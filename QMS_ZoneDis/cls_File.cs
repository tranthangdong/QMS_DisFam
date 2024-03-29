using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Configuration;
using System.Web;
using System.IO;

namespace WirelessOrder
{
    public class cls_File
    {
        

        public cls_File() { }

        public void CreateFile(string fileName, string strSTR)
        {
            try
            {
                StreamWriter write;
                StreamReader s;
                if (System.IO.File.Exists(fileName) == false)
                {
                    write = new StreamWriter(fileName);
                    write.WriteLine(strSTR);
                    write.Close();
                }
                else
                {
                    s = File.OpenText(fileName);
                    string line = null;
                    while ((line = s.ReadLine()) != null)
                    {
                        strSTR += line;
                    }
                    s.Close();
                    write = new StreamWriter(fileName);
                    write.WriteLine(strSTR);
                    write.Close();
                }
            }
            catch (Exception e) { e.Message.ToString(); }
        }

        // Doc noi dung cua mot file da ton tai, neu khong co the tra ve "" 
        public string ReadFile(string fileName)
        {
            string Content = "";
            StreamReader s;
            if (System.IO.File.Exists(fileName) == false)
            {
                return "";
            }
            else
            {
                s = File.OpenText(fileName);
                string line = null;
                while ((line = s.ReadLine()) != null)
                {
                    Content += line;
                }
                s.Close();
                return Content;
            }
        }

        public string ReadFileUTF8(string fileName)
        {
            string Content = "";
            if (System.IO.File.Exists(fileName) == false)
            {
                return "";
            }
            else
            {
                Content = File.ReadAllText(fileName, Encoding.UTF8);
                return Content;
            }
        }

        /// Cap nhat noi dung cua file  
        public void UpDateFile(string fileName, string newConTent)
        {
            try
            {
                StreamWriter write;
                if (System.IO.File.Exists(fileName) == false)
                {
                    System.Console.WriteLine("No Have fileName");
                }
                else
                {
                    write = new StreamWriter(fileName);
                    write.WriteLine(newConTent);
                    write.Close();
                }
            }
            catch (Exception ex) { ex.Message.ToString(); }
        }

        /// Cap nhat noi dung cua file  
        public void UpDateFileUTF8(string fileName, string newConTent)
        {
            try
            {
                StreamWriter write;
                if (System.IO.File.Exists(fileName) == false)
                {
                    System.Console.WriteLine("No Have fileName");
                }
                else
                {
                    write = new StreamWriter(fileName, false, Encoding.UTF8);
                    write.WriteLine(newConTent);
                    write.Close();
                }
            }
            catch (Exception ex) { ex.Message.ToString(); }
        }

        /// Cap nhat noi dung cua file  
        public void AppendFile(string fileName, string newConTent)
        {
            try
            {
                StreamWriter write = File.AppendText(fileName);
                if (System.IO.File.Exists(fileName) == false)
                {
                    System.Console.WriteLine("No Have fileName");
                }
                else
                {
                    write.WriteLine(newConTent);
                    write.Close();
                }
            }
            catch (Exception ex) { ex.Message.ToString(); }
        }

        public void DeleteFile(string fileName)
        {
            try
            {
                FileInfo fi;
                if (System.IO.File.Exists(fileName) == true)
                {
                    fi = new FileInfo(fileName);
                    fi.Delete();
                }
            }
            catch (Exception ex) { ex.Message.ToString(); }
        }

    }

}
