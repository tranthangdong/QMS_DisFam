using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;  
using System.Configuration;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using WMPLib;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace WirelessOrder
{

    public partial class FormMain : Form
    {
        //Phần khai báo biến dành cho Socket
        private const int BUFFER_SIZE = 1024;
        private int SocketPORT = 0;
        //static ASCIIEncoding encoding = new ASCIIEncoding();
        static UTF8Encoding encoding = new UTF8Encoding();
        public static IPAddress IPaddressServer = IPAddress.Parse("0.0.0.0");
        public Thread threadServer, threatDisplay;
        public TcpClient client;
        public Stream stream;
        public string sDataReceived;        //Bộ đệm nhận dữ liệu
        private bool ReceivedfrServer;
        public Label[] labelTT, labelBN, labelP;
        public string _videoURL = @"C:\video\1.mp4";
        //Khai báo các biến phát âm thanh và chạy chữ
        public IWMPMedia sMedia, sVideo;
        public int iTocdo = 1;
        public bool onConnected_1, onConnected_2;
        public string sChaychu = "Bệnh viện Gia Đình kính chào Quý khách. FAMILY _ Thân thiết như người nhà.";
        public string sZone, sType, sFloor, sRepeat;
        cls_File fFile;
        System.IO.DirectoryInfo dirVideo = new System.IO.DirectoryInfo(@"C:\video");
        public int countVideo=0;
        public string sDisplayRange = "";
        public bool enableDisplay;
        public int SolanNhapnhay = 0;

        public FormMain()
        {
            InitializeComponent();
            this.Width = 1920;
            this.Height = 1080;
            this.Top = 0;
            this.Left = 0;
            SolanNhapnhay = 0;
            labelBN = new Label[] { labelBN00, labelBN11, labelBN22, labelBN33, labelBN44, labelBN55 };
            labelP = new Label[] { labelP0, labelP1, labelP2, labelP3, labelP4, labelP5 };
            
            sZone = ConfigurationManager.AppSettings["_zone"].ToString();
            sType = ConfigurationManager.AppSettings["_type"].ToString();
            sFloor = ConfigurationManager.AppSettings["_floor"].ToString();
            sRepeat = ConfigurationManager.AppSettings["_repeat"].ToString();
            sDisplayRange = ConfigurationManager.AppSettings["_displayRange"].ToString();
            fFile = new cls_File();

            //Đọc dữ liệu từ file config
            labelP5.Text = ConfigurationManager.AppSettings["_room6"].ToString();
            labelP4.Text = ConfigurationManager.AppSettings["_room5"].ToString();
            labelP3.Text = ConfigurationManager.AppSettings["_room4"].ToString();
            labelP2.Text = ConfigurationManager.AppSettings["_room3"].ToString();
            labelP1.Text = ConfigurationManager.AppSettings["_room2"].ToString();
            labelP0.Text = ConfigurationManager.AppSettings["_room1"].ToString();

            labelBN55.Text = ConfigurationManager.AppSettings["_serv6"].ToString();
            labelBN44.Text = ConfigurationManager.AppSettings["_serv5"].ToString();
            labelBN33.Text = ConfigurationManager.AppSettings["_serv4"].ToString();
            labelBN22.Text = ConfigurationManager.AppSettings["_serv3"].ToString();
            labelBN11.Text = ConfigurationManager.AppSettings["_serv2"].ToString();
            labelBN00.Text = ConfigurationManager.AppSettings["_serv1"].ToString();

            //Phần khởi tạo dành cho Socket
            client = new TcpClient();

            //Phần khởi tạo âm thanh và chạy chữ giao diện
            int iZoneType = int.Parse(ConfigurationManager.AppSettings["_zonetype"].ToString());
            if(iZoneType==1)
                pictureBox4.Image = new Bitmap(QMS_ZoneDis.Properties.Resources.TopLine1); 
            else if(iZoneType==2)
                pictureBox4.Image = new Bitmap(QMS_ZoneDis.Properties.Resources.TopLine1a);
            else
                pictureBox4.Image = new Bitmap(QMS_ZoneDis.Properties.Resources.TopLine1b);

            axWMPlayer.settings.volume = int.Parse(ConfigurationManager.AppSettings["_volume"].ToString());
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.settings.volume = 0;
            labelRunTest.Left = 1900;
            labelRunTest.Text = sChaychu;

        }

        public void ConfigSave(string skey, string content)
        {
            Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            _config.AppSettings.Settings[skey].Value = content;
            _config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void SetupClient()
        {
            lb_stt.Text = "Client: " + GetLocalIPAddress();
            ReceivedfrServer = false;
            onConnected_1 = true;
            onConnected_2 = false;

            //Set Server's IP Address
            IPaddressServer = IPAddress.Parse(ConfigurationManager.AppSettings["_ipServer"].ToString());
            SocketPORT = int.Parse(ConfigurationManager.AppSettings["_portServer"].ToString());
            sChaychu = ConfigurationManager.AppSettings["_advString"].ToString();
            Thread.Sleep(500);
            threadServer = new Thread(connectToServer);
            threadServer.Start();
            Thread.Sleep(500);
            threatDisplay = new Thread(processDisplay);
            threatDisplay.Start();
        }

        #region Loop to make connection to Server
        public void connectToServer()
        {
            while (true)
            {
                try
                {
                    if (client.Connected == false)
                    {
                        client = new TcpClient();
                        // 1. connect
                        client.Connect(IPaddressServer, SocketPORT);
                        stream = client.GetStream();
                        onConnected_2 = true;
                    }

                    // 3. receive
                    byte[] dataR = new byte[BUFFER_SIZE];
                    stream.Read(dataR, 0, BUFFER_SIZE);
                    //-http://stackoverflow.com/questions/34297216/c-sharp-socket-receive-byte-array-length
                    
                    string sDataTemp = encoding.GetString(dataR).TrimEnd('\0').TrimEnd('\n').TrimEnd('\r');
                    sDataReceived = "";
                    int vitri = 0, vitriN = 0, vitriE = 0;
                    if (sDataTemp.Contains("#") && sDataTemp.Contains("$") && sDataTemp.Length>27)
                    {
                        sDataTemp.Replace("$$", "$").Replace("##", "#");
                        vitri = sDataTemp.LastIndexOf("$");
                        vitriE = sDataTemp.LastIndexOf("#");
                        int vitriGachNgang = sDataTemp.LastIndexOf("-");
                        sDataReceived = sDataTemp.Substring(vitri, vitriE - vitri) + "#";
                        sDataTemp = "";
                        if (sDataReceived.Substring(int.Parse(sZone), 1).Equals("1") && vitriGachNgang==27)
                        {

                            if (listBoxSound.Items.Count == 0 && listBoxDisplay.Items.Count > 0)
                                ThreadHelperClass.ClearList(this, listBoxDisplay);

                            ThreadHelperClass.SetList(this, listBoxDisplay, sDataReceived); //Đọc lần 1
                            if (sRepeat.Equals("2"))
                                ThreadHelperClass.SetList(this, listBoxDisplay, sDataReceived); //Đọc lần 2
                            ReceivedfrServer = true;
                        }
                        onConnected_2 = true;
                    }
                    else if (sDataTemp.Contains("#") && sDataTemp.Contains("@"))
                    {
                        if (sDataTemp.Contains("ResetPC"))
                        {
                            //Khởi động lại máy tính
                            ProcessStartInfo proc = new ProcessStartInfo();
                            proc.WindowStyle = ProcessWindowStyle.Hidden;
                            proc.FileName = "cmd";
                            proc.Arguments = "/C shutdown -f -r -t 1";   //Restar
                            Process.Start(proc);
                            Application.Exit();
                        }
                        else if (sDataTemp.Contains("ShutdownPC"))
                        {
                            //Khởi động lại máy tính
                            ProcessStartInfo proc = new ProcessStartInfo();
                            proc.WindowStyle = ProcessWindowStyle.Hidden;
                            proc.FileName = "cmd";
                            proc.Arguments = "/C shutdown -f -s -t 1";   //Restar
                            Process.Start(proc);
                            Application.Exit();
                        }
                        else if (sDataTemp.Contains("StopV"))
                        {
                            //Tắt video quảng cáo
                            axWindowsMediaPlayer1.URL = "";
                            byte[] dataT = encoding.GetBytes(GetLocalIPAddress() + ": Video Stoped!");
                            stream.Write(dataT, 0, dataT.Length);
                            onConnected_2 = true;
                        }
                        else if (sDataTemp.Contains("StartV"))
                        {
                            //Khởi động video quảng cáo
                            makeVideoList();
                            byte[] dataT = encoding.GetBytes(GetLocalIPAddress() + ": Video Started!");
                            stream.Write(dataT, 0, dataT.Length);
                            onConnected_2 = true;
                        }
                        else if(sDataTemp.Contains("Vol"))
                        {
                            //Thay đổi âm lượng
                            vitri = sDataTemp.IndexOf("@");
                            string _vlu = sDataTemp.Substring(vitri + 4, 3);
                            ConfigSave("_volume", _vlu);
                            axWMPlayer.settings.volume = int.Parse(_vlu);
                            byte[] dataT = encoding.GetBytes(GetLocalIPAddress() + ": Volume = " + int.Parse(_vlu).ToString());
                            stream.Write(dataT, 0, dataT.Length);
                            onConnected_2 = true;
                        }
                        else if (sDataTemp.Contains("Rep"))
                        {
                            //Thay đổi số lần phát âm thanh và hiển thị @Rep1#
                            vitri = sDataTemp.IndexOf("@");
                            string _rep = sDataTemp.Substring(vitri + 4, 1);
                            ConfigSave("_repeat", _rep);
                            sRepeat = _rep;
                            byte[] dataT = encoding.GetBytes(GetLocalIPAddress() + ": Repeat = " + _rep);
                            stream.Write(dataT, 0, dataT.Length);
                            onConnected_2 = true;
                        }
                        else
                        {
                            //Thay chuỗi quảng cáo
                            vitri = sDataTemp.IndexOf("@");
                            sChaychu = sDataTemp.Substring(vitri + 1, sDataTemp.Length - vitri - 2);
                            ConfigSave("_advString", sChaychu);
                            byte[] dataT = encoding.GetBytes(GetLocalIPAddress() + ": Update Successful!");
                            stream.Write(dataT, 0, dataT.Length);
                            onConnected_2 = true;
                        }
                        sDataTemp = "";
                    }
                    else if (sDataTemp.Contains("#") && sDataTemp.Contains("*"))
                    {
                        //Có dữ liệu từ server để giữ kết nối
                        onConnected_2 = true;
                    }
                    sDataTemp = "";
                    
                }

                catch (Exception connectToServer)
                {

                }
                Thread.Sleep(100);
            }
        }
        #endregion

        #region Process Display Number on TIVI Screen
        public void processDisplay()
        {
            while (true)
            {
                try
                {
                    bool networkUp = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
                    if (client.Connected == true && networkUp)
                    {
                        lb_stt.Text = "Client " + GetLocalIPAddress() + " đã kết nối tới Server " + IPaddressServer.ToString() + ":" + SocketPORT.ToString();
                        statusStrip1.BackColor = System.Drawing.Color.White;
                        if (ReceivedfrServer == true && !sDataReceived.Equals(""))
                        {
                            if (listBoxDisplay.Items[0].ToString().Substring(int.Parse(sZone), 1).Equals("1"))
                            {
                                PHAT_AM(sDataReceived.Substring(19, 3), sDataReceived.Substring(22, 1), sDataReceived.Substring(23, 4), sDataReceived.Substring(18, 1), int.Parse(sDataReceived.Substring(17, 1)));
                                if (sRepeat.Equals("2"))
                                    PHAT_AM2(sDataReceived.Substring(19, 3), sDataReceived.Substring(22, 1), sDataReceived.Substring(23, 4), sDataReceived.Substring(18, 1), int.Parse(sDataReceived.Substring(17, 1)));
                            }

                            ReceivedfrServer = false;
                            sDataReceived = "";
                        }
                    }
                    else
                    {
                        lb_stt.Text = "Client " + GetLocalIPAddress() + " đang chờ Server " + IPaddressServer.ToString() + ":" + SocketPORT.ToString();
                        statusStrip1.BackColor = System.Drawing.Color.Red;
                    }
                }

                catch (Exception processDisplay)
                {

                }
                Thread.Sleep(100);
            }
        }
        #endregion

        private void Display(string room, string current, string floor, int type, string CustomeName)
        {
            int itemp=5;
            for (int i = 0; i < 6; i++)
            {
                if (labelP[i].Text.Equals(room))    //Nếu đã có dòng hiển thị của phòng trên màn hình
                {
                    itemp = i;
                    break;
                }
            }

            for (int _i = itemp; _i > 0; _i--)
            {
                ThreadHelperClass.SetText(this, labelBN[_i], labelBN[_i - 1].Text);
                ThreadHelperClass.SetText(this, labelP[_i], labelP[_i - 1].Text);
            }
            ThreadHelperClass.SetText(this, labelBN[0], current);
            ThreadHelperClass.SetText(this, labelP[0], room);
            ThreadHelperClass.SetText(this, labelTenBenhNhan, CustomeName);
            TextColorChange(0);
        }

        private void TextColorChange(int noOfLable)
        {
            for (int i = 0; i < 5; i++)
            {
                ThreadHelperClass.SetColor(this, labelBN[i], Color.DarkOrange);
                ThreadHelperClass.SetColor(this, labelP[i], Color.DarkOrange);
            }
            ThreadHelperClass.SetColor(this, labelP[noOfLable], Color.White);
            ThreadHelperClass.SetColor(this, labelBN[noOfLable], Color.White);
        }

        private void threadExit()
        {
            client.Close();
            threatDisplay.Abort();
            threadServer.Abort();
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Local IP Address Not Found!");
        }

        public void add_Order(string mamon, string tenMonAn, string sl, string table)
        {
            ListViewItem lmonan = new ListViewItem(mamon);
            ListViewItem.ListViewSubItem mamonan = new ListViewItem.ListViewSubItem(lmonan, tenMonAn);
            lmonan.SubItems.Add(tenMonAn);
            ListViewItem.ListViewSubItem soluong = new ListViewItem.ListViewSubItem(lmonan, sl);
            lmonan.SubItems.Add(soluong);
            ListViewItem.ListViewSubItem banSo = new ListViewItem.ListViewSubItem(lmonan, table);
            lmonan.SubItems.Add(banSo);

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            SetupClient();
            makeVideoList();
        }

        private void toolStripStatusLabelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /**********************************************************************************************/
        #region CÁC HÀM PHÁT ÂM THANH
        /**********************************************************************************************/
        public void PHAT_AM(string room, string roomC, string current, string floor, int type)
        {
            try
            {
                //Add file âm thanh vào danh sách phát âm thanh
                string n4 = (int.Parse(current) / 1000).ToString();
                string n3 = ((int.Parse(current) % 1000) / 100).ToString();
                string n2 = (((int.Parse(current) % 1000) % 100) / 10).ToString();
                string n1 = (int.Parse(current) % 10).ToString();
                //Add file âm thanh vào danh sách phát âm thanh
                string r3 = (int.Parse(room) / 100).ToString();
                string r2 = ((int.Parse(room) % 100) / 10).ToString();
                string r1 = (int.Parse(room) % 10).ToString();

                ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\moi.wav");
                ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\#" + n4 + ".wav");
                ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\#" + n3 + ".wav");
                ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\#" + n2 + ".wav");
                ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\#" + n1 + ".wav");
                switch (type)
                {
                    case 1:
                        ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\denquay.wav");
                        ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\#" + r1 + ".wav");
                        break;
                    case 2:
                        ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\denletan.wav");
                        ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\#" + r1 + ".wav");
                        break;
                    case 3:
                        ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\denphong.wav");
                        ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\#" + r3 + ".wav");
                        ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\#" + r2 + ".wav");
                        ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\#" + r1 + ".wav");
                        break;
                    default:
                        break;
                }

                if (File.Exists(Application.StartupPath + @"\Sounds\#" + roomC + ".wav") && !roomC.Equals("0"))
                {
                    ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\#" + roomC + ".wav");
                }

                ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\tang.wav");
                ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\#" + floor + ".wav");
            }
            catch (Exception)
            {
                ThreadHelperClass.ClearList(this, listBoxDisplay);
            }
        }

        public void PHAT_AM2(string room, string roomC, string current, string floor, int type)
        {
            //Add file âm thanh vào danh sách phát âm thanh
            string n4 = (int.Parse(current) / 1000).ToString();
            string n3 = ((int.Parse(current) % 1000) / 100).ToString();
            string n2 = (((int.Parse(current) % 1000) % 100) / 10).ToString();
            string n1 = (int.Parse(current) % 10).ToString();
            //Add file âm thanh vào danh sách phát âm thanh
            string r3 = (int.Parse(room) / 100).ToString();
            string r2 = ((int.Parse(room) % 100) / 10).ToString();
            string r1 = (int.Parse(room) % 10).ToString();

            ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\moi.wav");
            ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\#" + n4 + ".wav");
            ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\#" + n3 + ".wav");
            ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\#" + n2 + ".wav");
            ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\#" + n1 + ".wav");
            string _location = "";
            switch (type)
            {
                case 1:
                    ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\denquay.wav");
                    _location = "dequay.wav";
                    ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\#" + r1 + ".wav");
                    break;
                case 2:
                    ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\denletan.wav");
                    _location = "letan.wav";
                    ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\#" + r1 + ".wav");
                    break;
                case 3:
                    ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\denphong.wav");
                    _location = "denphong.wav";
                    ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\#" + r3 + ".wav");
                    ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\#" + r2 + ".wav");
                    ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\#" + r1 + ".wav");
                    break;
                default:
                    break;
            }

            ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\tang.wav");
            ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\#" + floor + ".wav");
            ThreadHelperClass.SetList(this, listBoxSound, Application.StartupPath + @"\Sounds\camon.wav");
        }

        //Quét đọc âm thanh 
        private void timerSound_Tick(object sender, EventArgs e)
        {
            makePlayList();
            labelTime_.Text = DateTime.Now.ToShortTimeString();
        }

        //Kiểm tra có dữ liệu phát âm thì add và playlist
        public void makePlayList()
        {
            try
            {
                if (listBoxSound.Items.Count > 0 && axWMPlayer.currentPlaylist.count == 0)
                {
                    sMedia = axWMPlayer.mediaCollection.add(listBoxSound.Items[0].ToString());
                    axWMPlayer.currentPlaylist.insertItem(axWMPlayer.currentPlaylist.count, sMedia);

                    if (listBoxSound.Items[0].ToString().Contains("moi.wav"))
                    {
                        string ssZone = listBoxDisplay.Items[0].ToString().Substring(int.Parse(sZone), 1);
                        //------------------------------------------------------------------------------------
                        //Kiểm tra điều kiện hiển thị lên Tivi -----------------------------------------------
                        //------------------------------------------------------------------------------------
                        if (listBoxDisplay.Items[0].ToString().Substring(18, 1).Equals(sFloor) && ssZone.Equals("1") && sDisplayRange.Contains(listBoxDisplay.Items[0].ToString().Substring(19, 3)))
                        {
                            SolanNhapnhay = 0;
                            timerNhapnhay.Enabled = true;

                            int vitriN = listBoxDisplay.Items[0].ToString().IndexOf("-");
                            int vitriE = listBoxDisplay.Items[0].ToString().IndexOf("#");
                            string sNameBN = "";
                            if (vitriN > 0)
                                sNameBN = listBoxDisplay.Items[0].ToString().Substring(vitriN + 1, vitriE - vitriN - 1);
                            else
                                sNameBN = "";

                            if (listBoxDisplay.Items[0].ToString().Substring(22, 1).Equals("0"))
                                Display(int.Parse(listBoxDisplay.Items[0].ToString().Substring(19, 3)).ToString(), listBoxDisplay.Items[0].ToString().Substring(23, 4), listBoxDisplay.Items[0].ToString().Substring(18, 1), int.Parse(listBoxDisplay.Items[0].ToString().Substring(17, 1)), sNameBN);
                            else
                                Display(listBoxDisplay.Items[0].ToString().Substring(19, 4), listBoxDisplay.Items[0].ToString().Substring(23, 4), listBoxDisplay.Items[0].ToString().Substring(18, 1), int.Parse(listBoxDisplay.Items[0].ToString().Substring(17, 1)), sNameBN);
                        }
                        ThreadHelperClass.ClearList(this, listBoxDisplay);
                    }

                    listBoxSound.Items.RemoveAt(0);
                }

                //Nếu chưa play thì bấm play phát âm
                if (axWMPlayer.playState == WMPPlayState.wmppsReady)
                    axWMPlayer.Ctlcontrols.play();

                //Nếu không play nữa thì clear list
                if (axWMPlayer.playState == WMPPlayState.wmppsStopped && axWMPlayer.currentPlaylist.count > 0)
                    axWMPlayer.currentPlaylist.clear();
            }
            catch (Exception mk)
            {
                axWMPlayer.currentPlaylist.clear();
                fFile.AppendFile(Application.StartupPath + @"\Errorlogs.ini", "\n" + DateFormatConvert(DateTime.Now.ToString("o").Substring(0, 10)) + "\tCode: [makePlayList]: \t\t\t" + mk.Message);
            }
        }

        public void makeVideoList()
        {
            if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsStopped && axWindowsMediaPlayer1.currentPlaylist.count > 0)
                axWindowsMediaPlayer1.currentPlaylist.clear();

            countVideo = dirVideo.GetFiles().Length;
            try
            {
                if (countVideo > 0)
                {
                    for (int i = 1; i <= countVideo; i++)
                    {
                        sVideo = axWindowsMediaPlayer1.mediaCollection.add(@"C:\video\" + i + ".mp4");
                        axWindowsMediaPlayer1.currentPlaylist.insertItem(axWindowsMediaPlayer1.currentPlaylist.count, sVideo);
                    }
                    if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsReady)
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
            catch (Exception mk)
            {
                axWindowsMediaPlayer1.currentPlaylist.clear();
            }
        }
        #endregion

        public string DateFormatConvert(string sinputDate)   //yyyy-mm-đd
        {
            return sinputDate.Substring(8, 2) + "-" + sinputDate.Substring(5, 2) + "-" + sinputDate.Substring(0, 4);
        }

        private void timeChaychu_Tick(object sender, EventArgs e)
        {
            labelRunTest.Text = sChaychu;
            labelRunTest.Left -= iTocdo;
            if (labelRunTest.Left < -(labelRunTest.Width + 100))
                labelRunTest.Left = 1900;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Kiểm tra còn kết nối tới server không
            if(onConnected_1== true && onConnected_2==true)
            {
                //Đang giữ kết nối
                onConnected_2 = false;
            }
            else if(onConnected_1 == true && onConnected_2 == false)
            {
                onConnected_1 = false;
            }
            else if (onConnected_1 == false && onConnected_2 == true)
            {
                onConnected_1 = true;
            }
            else if (onConnected_1 == false && onConnected_2 == false)
            {
                if (client.Connected == true)
                {
                    //Mở lại khi release
                    //threadExit();
                    //Application.Restart();
                    //Application.Exit();
                }
            }
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timerNhapnhay_Tick(object sender, EventArgs e)
        {
            SolanNhapnhay++;
            labelBN00.Visible = !labelBN00.Visible;
            labelP0.Visible = !labelP0.Visible;
            labelTenBenhNhan.Visible = !labelTenBenhNhan.Visible;
            if (SolanNhapnhay > 16)
            {
                labelBN00.Visible = true;
                labelP0.Visible = true;
                labelTenBenhNhan.Visible = true;
                SolanNhapnhay = 0;
                timerNhapnhay.Enabled = false;
            }
        }
    }

    public static class ThreadHelperClass
    {
        delegate void SetTextCallback(Form f, Control ctrl, string text);
        /// <summary>
        /// Set text property of various controls
        /// </summary>
        /// <param name="form">The calling form</param>
        /// <param name="ctrl"></param>
        /// <param name="text"></param>
        public static void SetText(Form form, Control ctrl, string text)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (ctrl.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                form.Invoke(d, new object[] { form, ctrl, text });
            }
            else
            {
                ctrl.Text = text;
            }
        }

        delegate void SetLeftCallback(Form f, Control ctrl, int value);
        /// <summary>
        /// Set location property of various controls
        /// </summary>
        /// <param name="form">The calling form</param>
        /// <param name="ctrl"></param>
        /// <param name="value"></param>
        public static void SetLocation(Form form, Control ctrl, int value)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (ctrl.InvokeRequired)
            {
                SetLeftCallback d = new SetLeftCallback(SetLocation);
                form.Invoke(d, new object[] { form, ctrl, value });
            }
            else
            {
                ctrl.Left = ctrl.Left - value;
            }
        }

        delegate void SetListCallback(Form f, ListBox ctrl, string value);
        /// <summary>
        /// Set location property of various Listbox
        /// </summary>
        /// <param name="form">The calling form</param>
        /// <param name="ctrl"></param>
        /// <param name="value"></param>
        public static void SetList(Form form, ListBox ctrl, string value)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (ctrl.InvokeRequired)
            {
                SetListCallback d = new SetListCallback(SetList);
                form.Invoke(d, new object[] { form, ctrl, value });
            }
            else
            {
                ctrl.Items.Add(value);
            }
        }

        delegate void ClearListCallback(Form f, ListBox ctrl);
        public static void ClearList(Form form, ListBox ctrl)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (ctrl.InvokeRequired)
            {
                ClearListCallback d = new ClearListCallback(ClearList);
                form.Invoke(d, new object[] { form, ctrl});
            }
            else
            {
                ctrl.Items.RemoveAt(0);
            }
        }

        delegate void SetColorCallback(Form f, Control ctrl, Color co);
        /// Set location property of various Listbox
        /// </summary>
        /// <param name="form">The calling form</param>
        /// <param name="ctrl"></param>
        /// <param name="value"></param>
        public static void SetColor(Form form, Control ctrl, Color co)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (ctrl.InvokeRequired)
            {
                SetColorCallback d = new SetColorCallback(SetColor);
                form.Invoke(d, new object[] { form, ctrl, co });
            }
            else
            {
                ctrl.ForeColor = co;
            }
        }
    }
    
}