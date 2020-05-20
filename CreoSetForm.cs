using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PLM系统工具集成
{
    public partial class CreoSetForm : Form
    {
        public CreoSetForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOpenCreo_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlgcreo = new OpenFileDialog();
            fdlgcreo.Title = "打开Creo软件";
            fdlgcreo.InitialDirectory = @"c:\";   //@是取消转义字符的意思
            fdlgcreo.Filter = "Creo4.0(*.exe)|*.exe|所有文件(*.*)|*.*";
            /*
             * FilterIndex 属性用于选择了何种文件类型,缺省设置为0,系统取Filter属性设置第一项
             * ,相当于FilterIndex 属性设置为1.如果你编了3个文件类型，当FilterIndex ＝2时是指第2个.
             */
            fdlgcreo.FilterIndex = 1;
            /*
             *如果值为false，那么下一次选择文件的初始目录是上一次你选择的那个目录，
             *不固定；如果值为true，每次打开这个对话框初始目录不随你的选择而改变，是固定的  
             */
            fdlgcreo.RestoreDirectory = true;
            if (fdlgcreo.ShowDialog() == DialogResult.OK)
            {
                PrintRichTextBox.Text += "\r\n\r\n" + DateTime.Now.ToString();

                PrintRichTextBox.Text += System.IO.Path.GetFullPath(fdlgcreo.FileName);
            }
        }

        private void PrintRichTextBox_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            PrintRichTextBox.SelectionStart = PrintRichTextBox.Text.Length;
            PrintRichTextBox.ScrollToCaret();
        }
    }
}
