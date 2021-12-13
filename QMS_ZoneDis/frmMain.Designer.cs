namespace WirelessOrder
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            threadExit();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelExit = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_stt = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_soluong = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelP5 = new System.Windows.Forms.Label();
            this.labelP3 = new System.Windows.Forms.Label();
            this.labelP2 = new System.Windows.Forms.Label();
            this.labelP1 = new System.Windows.Forms.Label();
            this.labelRunTest = new System.Windows.Forms.Label();
            this.listBoxSound = new System.Windows.Forms.ListBox();
            this.timerSound = new System.Windows.Forms.Timer(this.components);
            this.timeChaychu = new System.Windows.Forms.Timer(this.components);
            this.labelBN55 = new System.Windows.Forms.Label();
            this.labelBN11 = new System.Windows.Forms.Label();
            this.labelBN22 = new System.Windows.Forms.Label();
            this.labelBN33 = new System.Windows.Forms.Label();
            this.labelBN44 = new System.Windows.Forms.Label();
            this.labelP4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTime_ = new System.Windows.Forms.Label();
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.timerNhapnhay = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTenBenhNhan = new System.Windows.Forms.Label();
            this.labelBN00 = new System.Windows.Forms.Label();
            this.labelP0 = new System.Windows.Forms.Label();
            this.axWMPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxGo5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBoxGo4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxGo3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxGo2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxGo1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxGo0 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWMPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGo5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGo0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.Red;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(8, 8);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelExit,
            this.lb_stt,
            this.lb_soluong});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1068);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1920, 12);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelExit
            // 
            this.toolStripStatusLabelExit.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabelExit.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripStatusLabelExit.Name = "toolStripStatusLabelExit";
            this.toolStripStatusLabelExit.Size = new System.Drawing.Size(11, 12);
            this.toolStripStatusLabelExit.Text = "X";
            this.toolStripStatusLabelExit.Click += new System.EventHandler(this.toolStripStatusLabelExit_Click);
            // 
            // lb_stt
            // 
            this.lb_stt.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lb_stt.ForeColor = System.Drawing.Color.DarkGray;
            this.lb_stt.Margin = new System.Windows.Forms.Padding(0);
            this.lb_stt.Name = "lb_stt";
            this.lb_stt.Size = new System.Drawing.Size(0, 0);
            // 
            // lb_soluong
            // 
            this.lb_soluong.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lb_soluong.ForeColor = System.Drawing.Color.DarkGray;
            this.lb_soluong.Margin = new System.Windows.Forms.Padding(0);
            this.lb_soluong.Name = "lb_soluong";
            this.lb_soluong.Size = new System.Drawing.Size(0, 0);
            // 
            // labelP5
            // 
            this.labelP5.BackColor = System.Drawing.Color.Transparent;
            this.labelP5.Font = new System.Drawing.Font("Microsoft Sans Serif", 110.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP5.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelP5.Location = new System.Drawing.Point(401, 109);
            this.labelP5.Name = "labelP5";
            this.labelP5.Size = new System.Drawing.Size(422, 138);
            this.labelP5.TabIndex = 38;
            this.labelP5.Text = "401C";
            this.labelP5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelP3
            // 
            this.labelP3.BackColor = System.Drawing.Color.Transparent;
            this.labelP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 110.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP3.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelP3.Location = new System.Drawing.Point(401, 401);
            this.labelP3.Name = "labelP3";
            this.labelP3.Size = new System.Drawing.Size(422, 138);
            this.labelP3.TabIndex = 40;
            this.labelP3.Text = "207G";
            this.labelP3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelP2
            // 
            this.labelP2.BackColor = System.Drawing.Color.Transparent;
            this.labelP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 110.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP2.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelP2.Location = new System.Drawing.Point(401, 547);
            this.labelP2.Name = "labelP2";
            this.labelP2.Size = new System.Drawing.Size(422, 138);
            this.labelP2.TabIndex = 41;
            this.labelP2.Text = "208";
            this.labelP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelP1
            // 
            this.labelP1.BackColor = System.Drawing.Color.Transparent;
            this.labelP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 110.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP1.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelP1.Location = new System.Drawing.Point(401, 693);
            this.labelP1.Name = "labelP1";
            this.labelP1.Size = new System.Drawing.Size(422, 138);
            this.labelP1.TabIndex = 42;
            this.labelP1.Text = "333";
            this.labelP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRunTest
            // 
            this.labelRunTest.AutoSize = true;
            this.labelRunTest.BackColor = System.Drawing.Color.Transparent;
            this.labelRunTest.Font = new System.Drawing.Font("Arial", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRunTest.ForeColor = System.Drawing.Color.Teal;
            this.labelRunTest.Location = new System.Drawing.Point(0, 1015);
            this.labelRunTest.Name = "labelRunTest";
            this.labelRunTest.Size = new System.Drawing.Size(923, 53);
            this.labelRunTest.TabIndex = 74;
            this.labelRunTest.Text = "Bệnh viện Gia Đình Kính Chào Quý Khách.";
            this.labelRunTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxSound
            // 
            this.listBoxSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSound.FormattingEnabled = true;
            this.listBoxSound.HorizontalScrollbar = true;
            this.listBoxSound.ItemHeight = 12;
            this.listBoxSound.Location = new System.Drawing.Point(1262, 214);
            this.listBoxSound.Name = "listBoxSound";
            this.listBoxSound.ScrollAlwaysVisible = true;
            this.listBoxSound.Size = new System.Drawing.Size(431, 136);
            this.listBoxSound.TabIndex = 75;
            this.listBoxSound.Visible = false;
            // 
            // timerSound
            // 
            this.timerSound.Enabled = true;
            this.timerSound.Interval = 150;
            this.timerSound.Tick += new System.EventHandler(this.timerSound_Tick);
            // 
            // timeChaychu
            // 
            this.timeChaychu.Enabled = true;
            this.timeChaychu.Interval = 1;
            this.timeChaychu.Tick += new System.EventHandler(this.timeChaychu_Tick);
            // 
            // labelBN55
            // 
            this.labelBN55.BackColor = System.Drawing.Color.Transparent;
            this.labelBN55.Font = new System.Drawing.Font("Microsoft Sans Serif", 110.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBN55.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelBN55.Location = new System.Drawing.Point(-15, 109);
            this.labelBN55.Name = "labelBN55";
            this.labelBN55.Size = new System.Drawing.Size(430, 138);
            this.labelBN55.TabIndex = 77;
            this.labelBN55.Text = "0000";
            this.labelBN55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBN11
            // 
            this.labelBN11.BackColor = System.Drawing.Color.Transparent;
            this.labelBN11.Font = new System.Drawing.Font("Microsoft Sans Serif", 110.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBN11.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelBN11.Location = new System.Drawing.Point(-15, 693);
            this.labelBN11.Name = "labelBN11";
            this.labelBN11.Size = new System.Drawing.Size(430, 138);
            this.labelBN11.TabIndex = 83;
            this.labelBN11.Text = "0000";
            this.labelBN11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBN22
            // 
            this.labelBN22.BackColor = System.Drawing.Color.Transparent;
            this.labelBN22.Font = new System.Drawing.Font("Microsoft Sans Serif", 110.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBN22.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelBN22.Location = new System.Drawing.Point(-15, 547);
            this.labelBN22.Name = "labelBN22";
            this.labelBN22.Size = new System.Drawing.Size(430, 138);
            this.labelBN22.TabIndex = 85;
            this.labelBN22.Text = "0000";
            this.labelBN22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBN33
            // 
            this.labelBN33.BackColor = System.Drawing.Color.Transparent;
            this.labelBN33.Font = new System.Drawing.Font("Microsoft Sans Serif", 110.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBN33.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelBN33.Location = new System.Drawing.Point(-15, 401);
            this.labelBN33.Name = "labelBN33";
            this.labelBN33.Size = new System.Drawing.Size(430, 138);
            this.labelBN33.TabIndex = 86;
            this.labelBN33.Text = "0000";
            this.labelBN33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBN44
            // 
            this.labelBN44.BackColor = System.Drawing.Color.Transparent;
            this.labelBN44.Font = new System.Drawing.Font("Microsoft Sans Serif", 110.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBN44.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelBN44.Location = new System.Drawing.Point(-15, 255);
            this.labelBN44.Name = "labelBN44";
            this.labelBN44.Size = new System.Drawing.Size(430, 138);
            this.labelBN44.TabIndex = 87;
            this.labelBN44.Text = "0000";
            this.labelBN44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelP4
            // 
            this.labelP4.BackColor = System.Drawing.Color.Transparent;
            this.labelP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 110.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP4.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelP4.Location = new System.Drawing.Point(401, 255);
            this.labelP4.Name = "labelP4";
            this.labelP4.Size = new System.Drawing.Size(422, 138);
            this.labelP4.TabIndex = 88;
            this.labelP4.Text = "206";
            this.labelP4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.labelTime_);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(802, 755);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 99);
            this.panel1.TabIndex = 91;
            // 
            // labelTime_
            // 
            this.labelTime_.BackColor = System.Drawing.Color.Transparent;
            this.labelTime_.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime_.ForeColor = System.Drawing.Color.White;
            this.labelTime_.Location = new System.Drawing.Point(154, 0);
            this.labelTime_.Name = "labelTime_";
            this.labelTime_.Size = new System.Drawing.Size(882, 88);
            this.labelTime_.TabIndex = 93;
            this.labelTime_.Text = "00:00";
            this.labelTime_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.HorizontalScrollbar = true;
            this.listBoxDisplay.ItemHeight = 12;
            this.listBoxDisplay.Location = new System.Drawing.Point(1046, 214);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.ScrollAlwaysVisible = true;
            this.listBoxDisplay.Size = new System.Drawing.Size(210, 136);
            this.listBoxDisplay.TabIndex = 93;
            this.listBoxDisplay.Visible = false;
            // 
            // timerNhapnhay
            // 
            this.timerNhapnhay.Interval = 500;
            this.timerNhapnhay.Tick += new System.EventHandler(this.timerNhapnhay_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.labelTenBenhNhan);
            this.panel2.Controls.Add(this.pictureBoxGo5);
            this.panel2.Controls.Add(this.labelBN00);
            this.panel2.Controls.Add(this.labelP0);
            this.panel2.Location = new System.Drawing.Point(-13, 851);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1933, 161);
            this.panel2.TabIndex = 94;
            // 
            // labelTenBenhNhan
            // 
            this.labelTenBenhNhan.BackColor = System.Drawing.Color.Transparent;
            this.labelTenBenhNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 65.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenBenhNhan.ForeColor = System.Drawing.Color.White;
            this.labelTenBenhNhan.Location = new System.Drawing.Point(815, 6);
            this.labelTenBenhNhan.Name = "labelTenBenhNhan";
            this.labelTenBenhNhan.Size = new System.Drawing.Size(1115, 142);
            this.labelTenBenhNhan.TabIndex = 96;
            this.labelTenBenhNhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBN00
            // 
            this.labelBN00.BackColor = System.Drawing.Color.Transparent;
            this.labelBN00.Font = new System.Drawing.Font("Microsoft Sans Serif", 129.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBN00.ForeColor = System.Drawing.Color.White;
            this.labelBN00.Location = new System.Drawing.Point(0, -15);
            this.labelBN00.Name = "labelBN00";
            this.labelBN00.Size = new System.Drawing.Size(495, 163);
            this.labelBN00.TabIndex = 87;
            this.labelBN00.Text = "4444";
            this.labelBN00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelP0
            // 
            this.labelP0.BackColor = System.Drawing.Color.Transparent;
            this.labelP0.Font = new System.Drawing.Font("Microsoft Sans Serif", 129.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP0.ForeColor = System.Drawing.Color.White;
            this.labelP0.Location = new System.Drawing.Point(473, -15);
            this.labelP0.Name = "labelP0";
            this.labelP0.Size = new System.Drawing.Size(391, 176);
            this.labelP0.TabIndex = 85;
            this.labelP0.Text = "000";
            this.labelP0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // axWMPlayer
            // 
            this.axWMPlayer.Enabled = true;
            this.axWMPlayer.Location = new System.Drawing.Point(1699, 214);
            this.axWMPlayer.Name = "axWMPlayer";
            this.axWMPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMPlayer.OcxState")));
            this.axWMPlayer.Size = new System.Drawing.Size(210, 47);
            this.axWMPlayer.TabIndex = 76;
            this.axWMPlayer.Visible = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(802, 122);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1125, 633);
            this.axWindowsMediaPlayer1.TabIndex = 73;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::QMS_ZoneDis.Properties.Resources.TopLine2;
            this.pictureBox8.Location = new System.Drawing.Point(802, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(1124, 125);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 90;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.pictureBox1.Location = new System.Drawing.Point(0, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1920, 4);
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxGo5
            // 
            this.pictureBoxGo5.Image = global::QMS_ZoneDis.Properties.Resources.go_icon;
            this.pictureBoxGo5.Location = new System.Drawing.Point(440, 62);
            this.pictureBoxGo5.Name = "pictureBoxGo5";
            this.pictureBoxGo5.Size = new System.Drawing.Size(64, 46);
            this.pictureBoxGo5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxGo5.TabIndex = 86;
            this.pictureBoxGo5.TabStop = false;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxExit.Image = global::QMS_ZoneDis.Properties.Resources.go_icon;
            this.pictureBoxExit.Location = new System.Drawing.Point(369, 48);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(64, 46);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxExit.TabIndex = 92;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // pictureBoxGo4
            // 
            this.pictureBoxGo4.Image = global::QMS_ZoneDis.Properties.Resources.go_icon;
            this.pictureBoxGo4.Location = new System.Drawing.Point(369, 752);
            this.pictureBoxGo4.Name = "pictureBoxGo4";
            this.pictureBoxGo4.Size = new System.Drawing.Size(64, 46);
            this.pictureBoxGo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxGo4.TabIndex = 63;
            this.pictureBoxGo4.TabStop = false;
            // 
            // pictureBoxGo3
            // 
            this.pictureBoxGo3.Image = global::QMS_ZoneDis.Properties.Resources.go_icon;
            this.pictureBoxGo3.Location = new System.Drawing.Point(369, 607);
            this.pictureBoxGo3.Name = "pictureBoxGo3";
            this.pictureBoxGo3.Size = new System.Drawing.Size(64, 46);
            this.pictureBoxGo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxGo3.TabIndex = 62;
            this.pictureBoxGo3.TabStop = false;
            // 
            // pictureBoxGo2
            // 
            this.pictureBoxGo2.Image = global::QMS_ZoneDis.Properties.Resources.go_icon;
            this.pictureBoxGo2.Location = new System.Drawing.Point(369, 462);
            this.pictureBoxGo2.Name = "pictureBoxGo2";
            this.pictureBoxGo2.Size = new System.Drawing.Size(64, 46);
            this.pictureBoxGo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxGo2.TabIndex = 61;
            this.pictureBoxGo2.TabStop = false;
            // 
            // pictureBoxGo1
            // 
            this.pictureBoxGo1.Image = global::QMS_ZoneDis.Properties.Resources.go_icon;
            this.pictureBoxGo1.Location = new System.Drawing.Point(369, 317);
            this.pictureBoxGo1.Name = "pictureBoxGo1";
            this.pictureBoxGo1.Size = new System.Drawing.Size(64, 46);
            this.pictureBoxGo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxGo1.TabIndex = 60;
            this.pictureBoxGo1.TabStop = false;
            // 
            // pictureBoxGo0
            // 
            this.pictureBoxGo0.Image = global::QMS_ZoneDis.Properties.Resources.go_icon;
            this.pictureBoxGo0.Location = new System.Drawing.Point(369, 172);
            this.pictureBoxGo0.Name = "pictureBoxGo0";
            this.pictureBoxGo0.Size = new System.Drawing.Size(64, 46);
            this.pictureBoxGo0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxGo0.TabIndex = 59;
            this.pictureBoxGo0.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::QMS_ZoneDis.Properties.Resources.TopLine1;
            this.pictureBox4.Location = new System.Drawing.Point(-11, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(787, 120);
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listBoxDisplay);
            this.Controls.Add(this.listBoxSound);
            this.Controls.Add(this.pictureBoxExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxGo4);
            this.Controls.Add(this.pictureBoxGo3);
            this.Controls.Add(this.pictureBoxGo2);
            this.Controls.Add(this.pictureBoxGo1);
            this.Controls.Add(this.labelBN44);
            this.Controls.Add(this.labelBN33);
            this.Controls.Add(this.labelBN22);
            this.Controls.Add(this.labelBN11);
            this.Controls.Add(this.pictureBoxGo0);
            this.Controls.Add(this.labelBN55);
            this.Controls.Add(this.axWMPlayer);
            this.Controls.Add(this.labelRunTest);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.labelP5);
            this.Controls.Add(this.labelP4);
            this.Controls.Add(this.labelP3);
            this.Controls.Add(this.labelP2);
            this.Controls.Add(this.labelP1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWMPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGo5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGo0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelExit;
        private System.Windows.Forms.ToolStripStatusLabel lb_stt;
        private System.Windows.Forms.ToolStripStatusLabel lb_soluong;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelP5;
        private System.Windows.Forms.Label labelP3;
        private System.Windows.Forms.Label labelP2;
        private System.Windows.Forms.Label labelP1;
        private System.Windows.Forms.PictureBox pictureBoxGo0;
        private System.Windows.Forms.PictureBox pictureBoxGo1;
        private System.Windows.Forms.PictureBox pictureBoxGo2;
        private System.Windows.Forms.PictureBox pictureBoxGo3;
        private System.Windows.Forms.PictureBox pictureBoxGo4;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label labelRunTest;
        private System.Windows.Forms.ListBox listBoxSound;
        private System.Windows.Forms.Timer timerSound;
        private AxWMPLib.AxWindowsMediaPlayer axWMPlayer;
        private System.Windows.Forms.Timer timeChaychu;
        private System.Windows.Forms.Label labelBN55;
        private System.Windows.Forms.Label labelBN11;
        private System.Windows.Forms.Label labelBN22;
        private System.Windows.Forms.Label labelBN33;
        private System.Windows.Forms.Label labelBN44;
        private System.Windows.Forms.Label labelP4;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Label labelTime_;
        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.Timer timerNhapnhay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxGo5;
        private System.Windows.Forms.Label labelBN00;
        private System.Windows.Forms.Label labelP0;
        private System.Windows.Forms.Label labelTenBenhNhan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

