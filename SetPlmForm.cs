using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PLM系统工具集成
{
    public partial class SetPlmForm : Form
    {
        public static int ReSetState = 0;
        public SetPlmForm()
        {
            InitializeComponent();
        }

        private void button_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            //安装包路径存在判断
            if (textBoxUrl.TextLength == 0)
            {
                PrintRichTextBox.Text += "\r\n\r\n" + DateTime.Now.ToString();
                PrintRichTextBox.Text += "\r\n请先选择PLM客户端安装包，再点击安装按钮，谢谢！";
            }
            else
            {
                //安装包合法性判断
                if (!textBoxUrl.Text.Contains("JMPLM") || !textBoxUrl.Text.Contains(".exe"))
                {
                    PrintRichTextBox.Text += "\r\n\r\n" + DateTime.Now.ToString();
                    PrintRichTextBox.Text += "\r\n安装包不合法，请重新选择！";
                }
                else
                {


                    Process p1 = Process.Start(textBoxUrl.Text);
                    PrintRichTextBox.Text += "\r\n正在执行安装，请稍等...";
                    buttonSet.Enabled = false;
                    this.Close();
                }
            }
        }

        private void checkBox_Reset_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Reset.CheckState == CheckState.Checked)
            {
                ReSetState = 1;
                PrintRichTextBox.Text += "\r\n\r\n" + DateTime.Now.ToString();
                PrintRichTextBox.Text += "\r\n已勾选强制重装，若已安装客户端，会自动进行重装！";
            }
            else
            {
                ReSetState = 0;
                PrintRichTextBox.Text += "\r\n\r\n" + DateTime.Now.ToString();
                PrintRichTextBox.Text += "\r\n已取消强制重装！";
            }
        }

        private void PrintRichTextBox_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            PrintRichTextBox.SelectionStart = PrintRichTextBox.Text.Length;
            PrintRichTextBox.ScrollToCaret();
        }

        private void button_chose_software_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "选择PLM系统安装包";
            fdlg.InitialDirectory = @"c:\";   //@是取消转义字符的意思
            fdlg.Filter = "PLM系统安装包(*.exe)|*.exe|所有文件(*.*)|*.*";
            /*
             * FilterIndex 属性用于选择了何种文件类型,缺省设置为0,系统取Filter属性设置第一项
             * ,相当于FilterIndex 属性设置为1.如果你编了3个文件类型，当FilterIndex ＝2时是指第2个.
             */
            fdlg.FilterIndex = 1;
            /*
             *如果值为false，那么下一次选择文件的初始目录是上一次你选择的那个目录，
             *不固定；如果值为true，每次打开这个对话框初始目录不随你的选择而改变，是固定的  
             */
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBoxUrl.Text = System.IO.Path.GetFullPath(fdlg.FileName);
                PrintRichTextBox.Text += "\r\n\r\n" + DateTime.Now.ToString();
                PrintRichTextBox.Text += "\r\n已获取PLM安装程序路径！";
                PrintRichTextBox.Text += "\r\n正在检测安装环境...";

                ///////////////////////////////////////////////////////////////////////////////////////////////////进行安装环境检测


                string TempString = string.Empty;
                ///检测FMS_HOME环境变量
                TempString = Environment.GetEnvironmentVariable("FMS_HOME", EnvironmentVariableTarget.User).ToString();
                int Vcount = 0;
                if (TempString != "" && TempString != null)
                {
                    PrintRichTextBox.Text += "\r\n检测到“FMS_HOME”环境变量已存在！";
                }
                else
                {
                    Environment.SetEnvironmentVariable("FMS_HOME", @"D:\JMPLMTest\TC11\OTW11\tccs", EnvironmentVariableTarget.User);
                    Vcount++;
                }
                TempString = string.Empty;

                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////检测JRE64_HOME环境变量
                TempString = Environment.GetEnvironmentVariable("JRE64_HOME", EnvironmentVariableTarget.User);
                if (TempString != "" && TempString != null)
                {
                    PrintRichTextBox.Text += "\r\n检测到“JRE64_HOME”环境变量已存在！";
                }
                else
                {
                    Environment.SetEnvironmentVariable("JRE64_HOME", @"D:\JMPLMTest\TC11\jre", EnvironmentVariableTarget.User);
                    Vcount++;
                }
                if (Vcount > 0) { textBoxVairs.Text = "环境变量均已配置！"; } else { textBoxVairs.Text = "环境变量已存在！"; }
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////检测环境变量结束


                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////检测缓存目录
                string folderPath = @"C:\TEMP";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                    textBoxTemp.Text = "缓存目录已配置！";
                }
                else
                {
                    textBoxTemp.Text = "缓存目录已存在！";
                }
                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////检测缓存目录结束




                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////配置HOST地址
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
                textBoxHost.Text = "hosts地址已配置！";
                //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////hosts地址配置结束


                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////检测是否已安装

                string StallfolderPath = @"D:\JMPLMTest";
                if (Directory.Exists(StallfolderPath))
                {
                    textBoxInstall.Text = "PLM客户端已安装！";
                    if (checkBox_Reset.CheckState == CheckState.Unchecked)
                    { buttonSet.Enabled = false; }
                    else
                    { buttonSet.Enabled = true; }
                }
                else
                {
                    textBoxInstall.Text = "PLM客户端未安装！";
                }



            }
        }
    }
}
