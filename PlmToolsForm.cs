using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;

namespace PLM系统工具集成
{
    public partial class PlmToolsForm : Form
    {
        public PlmToolsForm()
        {
            InitializeComponent();
        }






            private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintRichTextBox.Text += "\r\n\r\n" + DateTime.Now.ToString();
            PrintRichTextBox.Text += "\r\n正在清除PLM系统缓存，请稍等...";

            ///////构建BAT文件
            string clearBatString = "tasklist|find /i \"TcFSCService.exe\"";
            clearBatString += "\r\ntaskkill /f /im TcFSCService.exe";
            clearBatString += "\r\ntasklist|find /i \"Teamcenter.exe\" ";
            clearBatString += "\r\ntaskkill /f /im Teamcenter.exe";
            clearBatString += "\r\nif exist \"C: \\Users\\Administrator\\AppData\\Local\\Temp\\V10000.1.0.20130604.00\"  rmdir /S /Q \"C: \\Users\\Administrator\\AppData\\Local\\Temp\\V10000.1.0.20130604.00\"";
            clearBatString += "\r\ntasklist|find /i \"java.exe\"||goto no_java_process";
            clearBatString += "\r\ntaskkill /f /im java.exe";
            clearBatString += "\r\n:no_java_process";
            clearBatString += "\r\nif exist \"%USERPROFILE%\\FCCCache\" rmdir /S /Q \"%USERPROFILE%\\FCCCache\"";
            clearBatString += "\r\nif exist \"%USERPROFILE%\\FSCCache\" rmdir /S /Q \"%USERPROFILE%\\FSCCache\"";
            clearBatString += "\r\nif exist \"%USERPROFILE%\\Teamcenter\" rmdir /S /Q \"%USERPROFILE%\\Teamcenter\"";
            clearBatString += "\r\nif exist \"%USERPROFILE%\\*.bmide\" del \"%USERPROFILE%\\*.bmide\"";
            clearBatString += "\r\nif exist \"%USERPROFILE%\\fcc*.log\" del \"%USERPROFILE%\\fcc*.log\"";
            clearBatString += "\r\nif exist \"%USERPROFILE%\\fcc*.log.lck\" del \"%USERPROFILE%\\fcc*.log.lck\"";
            //clearBatString += "\r\npause";

            //////////////////////////////////////////////////////////////////////////////////////////////判断是否存在路径
            string folderPath = @"C:\TEMP";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            System.IO.File.WriteAllText("C:\\TEMP\\clearTemp.bat", clearBatString);

            //执行BAT程序
            PrintRichTextBox.Text+=ExcuteBatFile("C:\\TEMP\\clearTemp.bat");


        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                PrintRichTextBox.Text += "\r\n\r\n" + DateTime.Now.ToString();
                PrintRichTextBox.Text += "\r\n正在打开切换程序，请稍等...";

                Process p1 = Process.Start(@"D:\JMPLMTest\TC11\OTW11\rac\Switch_PLM\Switch_PLM.bat");
                PrintRichTextBox.Text += "\r\n打开切换程序成功！";
                p1.WaitForExit();//关键，等待外部程序退出后才能往下执行
            }
            catch (Exception ex)
            {
                MessageBox.Show("打开切换客户端程序时,程序出现错误,详细信息如下\r\n" + ex.ToString(), "错误提示", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintRichTextBox.Text += "\r\n\r\n" + DateTime.Now.ToString();
            PrintRichTextBox.Text += "\r\n正在清缓存并打开PLM客户端，请稍等...";

            ////////////////////////////////////////////////////////////////////////////////////////////构建BAT代码
            string greenStart = "@echo off";
            greenStart += "\r\nrd /q /s \" % userprofile %\\Siemens\"";
            greenStart += "\r\nrd /q /s \" % userprofile %\\Teamcenter\"";
            greenStart += "\r\necho 打开tc客户端";
            greenStart += "\r\nstart /min cmd /c \"D:\\JMPLMTest\\TC11\\OTW11\\rac\\portal.bat\" %*";
            greenStart += "\r\nexit";
            //////////////////////////////////////////////////////////////////////////////////////////////判断是否存在路径
            string folderPath = @"C:\TEMP";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                //存在/不创建
            }

            System.IO.File.WriteAllText("C:\\TEMP\\greenStart.bat", greenStart);
            Process.Start(@"C:\TEMP\greenStart.bat");
            PrintRichTextBox.Text += "\r\n执行成功！";
        }

        /// <summary>
        /// 一键配置环境
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            //定义全局变量
            int Count = 0;

            PrintRichTextBox.Text +="\r\n\r\n"+ DateTime.Now.ToString();
            PrintRichTextBox.Text += "\r\n正在检测PLM系统变量，请稍等...";


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////配置系统环境变量
            try
            {
                string TempString = string.Empty;
                ///检测FMS_HOME环境变量
                try
                {
                    TempString = Environment.GetEnvironmentVariable("FMS_HOME", EnvironmentVariableTarget.User).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("获取FMS_HOME失败,详细信息如下\r\n" + ex.ToString(), "错误提示", MessageBoxButtons.OK);
                }




                if (TempString != "" && TempString != null)
                {
                    PrintRichTextBox.Text += "\r\n检测到“FMS_HOME”环境变量已存在！";
                    Count++;
                }
                else
                {
                    PrintRichTextBox.Text += "\r\n检测到“FMS_HOME”环境变量缺失，正在添加...";
                    Environment.SetEnvironmentVariable("FMS_HOME", @"D:\JMPLMTest\TC11\OTW11\tccs", EnvironmentVariableTarget.User);
                    PrintRichTextBox.Text += "\r\n“FMS_HOME”环境变量已添加！";
                    Count++;
                }
                TempString = string.Empty;

                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////检测JRE64_HOME环境变量
                TempString = Environment.GetEnvironmentVariable("JRE64_HOME", EnvironmentVariableTarget.User);
                if (TempString != "" && TempString != null)
                {
                    PrintRichTextBox.Text += "\r\n检测到“JRE64_HOME”环境变量已存在！";
                    Count++;
                }
                else
                {
                    PrintRichTextBox.Text += "\r\n检测到“JRE64_HOME”环境变量缺失，正在添加...";
                    Environment.SetEnvironmentVariable("JRE64_HOME", @"D:\JMPLMTest\TC11\jre", EnvironmentVariableTarget.User);
                    PrintRichTextBox.Text += "\r\n“JRE64_HOME”环境变量已添加！";
                    Count++;
                }
                if (Count == 2) { PrintRichTextBox.Text += "\r\n环境变量FMS_HOME、JRE64_HOME均已配置！"; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("配置环境变量时,程序出现错误,详细信息如下\r\n" + ex.ToString(), "错误提示", MessageBoxButtons.OK);
            }




            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////配置host文件
            try
            {
                ArrayList IpArray = new ArrayList();
                ArrayList AddressArray = new ArrayList();


                IpArray.Add("172.17.95.10"); AddressArray.Add("PLMDEV");
                IpArray.Add("172.17.95.191"); AddressArray.Add("PLMAPPTEST");
                IpArray.Add("172.17.95.160"); AddressArray.Add("PLMWEBTEST");
                IpArray.Add("172.17.95.4"); AddressArray.Add("PLMVOLTEST");
                IpArray.Add("172.17.95.222"); AddressArray.Add("PLMDISTEST");
                IpArray.Add("172.17.95.157"); AddressArray.Add("PLMDBTEST");
                IpArray.Add("172.17.95.151"); AddressArray.Add("PLMMASTERTEST");
                IpArray.Add("172.17.95.153"); AddressArray.Add("PLMLICENSE");
                IpArray.Add("172.17.95.50"); AddressArray.Add("PLMWEB1");
                IpArray.Add("172.17.95.51"); AddressArray.Add("PLMWEB2");
                IpArray.Add("172.17.95.52"); AddressArray.Add("PLMAPP1");
                IpArray.Add("172.17.95.53"); AddressArray.Add("PLMAPP2");
                IpArray.Add("172.17.95.54"); AddressArray.Add("PLMAPP3");
                IpArray.Add("172.17.95.55"); AddressArray.Add("PLMAPP4");
                IpArray.Add("172.17.95.56"); AddressArray.Add("PLMVOL1");
                IpArray.Add("172.17.95.57"); AddressArray.Add("PLMVOL2");
                IpArray.Add("172.17.95.58"); AddressArray.Add("PLMDB1");
                IpArray.Add("172.17.95.59"); AddressArray.Add("PLMDB2");
                IpArray.Add("172.20.91.24"); AddressArray.Add("PLMMaster");
                IpArray.Add("172.17.95.62"); AddressArray.Add("PLMNode1");
                IpArray.Add("172.17.95.64"); AddressArray.Add("PLMBackup");
                IpArray.Add("10.0.0.1"); AddressArray.Add("PLMCACHENA");
                IpArray.Add("172.20.91.100"); AddressArray.Add("PLMCACHEXM");
                IpArray.Add("172.20.91.24     "); AddressArray.Add("PLMCACHEKM");

                int arrayCount = 0;
                string addHost = string.Empty;

                PrintRichTextBox.Text += "\r\n正在配置host地址，请稍等...";

                string strFilePath = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, @"C:\Windows\System32\drivers\etc\hosts");
                if (File.Exists(strFilePath))
                {
                    string strContent = File.ReadAllText(strFilePath);
                    //循环添加host地址
                    foreach (string ipstring in IpArray)
                    {
                        //检测不存在当前IP执行操作
                        if (!strContent.Contains(ipstring))
                        {
                            addHost = "\r\n" + ipstring + "    " + AddressArray[arrayCount].ToString();
                            strContent += addHost;
                            File.WriteAllText(strFilePath, strContent);
                        }
                        arrayCount++;
                    }

                    Count++;

                    //if (!strContent.Contains("172.17.66.7"))
                    //{
                    //    MessageBox.Show("检测不到hosts缓存服务器IP配置，请联系运维人员处理！", "信息提示");
                    //}
                    //else
                    //{
                    //    strContent = Regex.Replace(strContent, "172.17.66.7", "172.20.91.24");
                    //    File.WriteAllText(strFilePath, strContent);
                    //    Count++;
                    //    PrintLabel.Text = "更新hosts文件成功！";
                    //}
                }
                else
                {
                    PrintRichTextBox.Text += "\r\nErrorMessage: 找不到hosts文件，请联系运维人员！";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("配置host时,程序出现错误,详细信息如下\r\n" + ex.ToString(), "错误提示", MessageBoxButtons.OK);
            }



            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////创建临时文件夹
            try
            {
                PrintRichTextBox.Text += "\r\n正在配置缓存文件夹，请稍等...";

               string folderPath = @"C:\TEMP";
                if (Directory.Exists(folderPath))
                {
                    //存在/不创建
                    Count++;
                }
                else
                {
                    //无则当前路径创建文件
                    Directory.CreateDirectory(folderPath);
                    Count++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("创建TEMP缓存文件夹时,程序出现错误,详细信息如下\r\n" + ex.ToString(), "错误提示", MessageBoxButtons.OK);
            }

            if (Count == 4)
            {
                PrintRichTextBox.Text += "\r\nhost文件以及缓存文件夹均已配置完成！";
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                PrintRichTextBox.Text += "\r\n\r\n" + DateTime.Now.ToString();
                Process p1 = Process.Start(@"D:\JMPLMTest\TC11\OTW11\rac\portal.bat");
                PrintRichTextBox.Text += "\r\n正在打开PLM客户端，请稍等...";
                p1.WaitForExit();//关键，等待外部程序退出后才能往下执行
                PrintRichTextBox.Text += "\r\nPLM客户端打开成功！";
            }
            catch (Exception ex)
            {
                MessageBox.Show("打开客户端时,程序出现错误,请检查是否安装客户端,错误详细信息如下\r\n" + ex.ToString(), "错误提示", MessageBoxButtons.OK);
            }
        }












        /// <summary>
        /// 执行BAT文件
        /// </summary>
        /// <param name="batPath">BAT路径</param>
        /// <param name="outstring">输出字符串</param>
        public static string ExcuteBatFile(string batPath)
        {
            //if (errMsg == null) throw new ArgumentNullException("errMsg");
            string output = string.Empty; ;
            using (Process process = new Process())
            {
                FileInfo file = new FileInfo(batPath);
                if (file.Directory != null)
                {
                    process.StartInfo.WorkingDirectory = file.Directory.FullName;
                }
                process.StartInfo.FileName = batPath;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                process.WaitForExit();
                output += "\r\nProcess Message : " + process.StandardOutput.ReadToEnd();
                output += "\r\nError Message : " + process.StandardError.ReadToEnd();
            }
            return output;
        }

        private void PrintRichTextBox_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            PrintRichTextBox.SelectionStart = PrintRichTextBox.Text.Length;                    
            PrintRichTextBox.ScrollToCaret();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form SetPlm = new SetPlmForm();
            SetPlm.Show();
        }

        private void button_SetCreo_Click(object sender, EventArgs e)
        {
             
        }
    }
}
