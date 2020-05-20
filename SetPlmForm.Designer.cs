namespace PLM系统工具集成
{
    partial class SetPlmForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetPlmForm));
            this.button_chose_software = new System.Windows.Forms.Button();
            this.checkBox_Reset = new System.Windows.Forms.CheckBox();
            this.button_cancle = new System.Windows.Forms.Button();
            this.groupBoxCheck = new System.Windows.Forms.GroupBox();
            this.textBoxInstall = new System.Windows.Forms.TextBox();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.textBoxTemp = new System.Windows.Forms.TextBox();
            this.textBoxVairs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PrintRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBoxCheck.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_chose_software
            // 
            this.button_chose_software.BackColor = System.Drawing.SystemColors.Control;
            this.button_chose_software.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button_chose_software.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_chose_software.Location = new System.Drawing.Point(56, 356);
            this.button_chose_software.Margin = new System.Windows.Forms.Padding(4);
            this.button_chose_software.Name = "button_chose_software";
            this.button_chose_software.Size = new System.Drawing.Size(130, 45);
            this.button_chose_software.TabIndex = 0;
            this.button_chose_software.Text = "选择PLM安装包";
            this.button_chose_software.UseVisualStyleBackColor = false;
            this.button_chose_software.Click += new System.EventHandler(this.button_chose_software_Click);
            // 
            // checkBox_Reset
            // 
            this.checkBox_Reset.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_Reset.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox_Reset.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.checkBox_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_Reset.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBox_Reset.Image = ((System.Drawing.Image)(resources.GetObject("checkBox_Reset.Image")));
            this.checkBox_Reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBox_Reset.Location = new System.Drawing.Point(290, 356);
            this.checkBox_Reset.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_Reset.Name = "checkBox_Reset";
            this.checkBox_Reset.Size = new System.Drawing.Size(130, 45);
            this.checkBox_Reset.TabIndex = 1;
            this.checkBox_Reset.Text = "强制重装";
            this.checkBox_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_Reset.UseVisualStyleBackColor = false;
            this.checkBox_Reset.Visible = false;
            this.checkBox_Reset.CheckedChanged += new System.EventHandler(this.checkBox_Reset_CheckedChanged);
            // 
            // button_cancle
            // 
            this.button_cancle.BackColor = System.Drawing.SystemColors.Control;
            this.button_cancle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button_cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancle.Location = new System.Drawing.Point(530, 356);
            this.button_cancle.Name = "button_cancle";
            this.button_cancle.Size = new System.Drawing.Size(130, 45);
            this.button_cancle.TabIndex = 2;
            this.button_cancle.Text = "取消";
            this.button_cancle.UseVisualStyleBackColor = false;
            this.button_cancle.Click += new System.EventHandler(this.button_cancle_Click);
            // 
            // groupBoxCheck
            // 
            this.groupBoxCheck.Controls.Add(this.textBoxInstall);
            this.groupBoxCheck.Controls.Add(this.textBoxHost);
            this.groupBoxCheck.Controls.Add(this.textBoxTemp);
            this.groupBoxCheck.Controls.Add(this.textBoxVairs);
            this.groupBoxCheck.Controls.Add(this.label5);
            this.groupBoxCheck.Controls.Add(this.label4);
            this.groupBoxCheck.Controls.Add(this.label3);
            this.groupBoxCheck.Controls.Add(this.label2);
            this.groupBoxCheck.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCheck.Name = "groupBoxCheck";
            this.groupBoxCheck.Size = new System.Drawing.Size(698, 171);
            this.groupBoxCheck.TabIndex = 3;
            this.groupBoxCheck.TabStop = false;
            this.groupBoxCheck.Text = "检测安装环境";
            // 
            // textBoxInstall
            // 
            this.textBoxInstall.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxInstall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInstall.Location = new System.Drawing.Point(124, 137);
            this.textBoxInstall.Name = "textBoxInstall";
            this.textBoxInstall.ReadOnly = true;
            this.textBoxInstall.Size = new System.Drawing.Size(564, 25);
            this.textBoxInstall.TabIndex = 7;
            this.textBoxInstall.Text = "待检测";
            // 
            // textBoxHost
            // 
            this.textBoxHost.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHost.Location = new System.Drawing.Point(124, 99);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.ReadOnly = true;
            this.textBoxHost.Size = new System.Drawing.Size(564, 25);
            this.textBoxHost.TabIndex = 6;
            this.textBoxHost.Text = "待检测";
            // 
            // textBoxTemp
            // 
            this.textBoxTemp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTemp.Location = new System.Drawing.Point(124, 63);
            this.textBoxTemp.Name = "textBoxTemp";
            this.textBoxTemp.ReadOnly = true;
            this.textBoxTemp.Size = new System.Drawing.Size(564, 25);
            this.textBoxTemp.TabIndex = 5;
            this.textBoxTemp.Text = "待检测";
            // 
            // textBoxVairs
            // 
            this.textBoxVairs.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxVairs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxVairs.Location = new System.Drawing.Point(124, 28);
            this.textBoxVairs.Name = "textBoxVairs";
            this.textBoxVairs.ReadOnly = true;
            this.textBoxVairs.Size = new System.Drawing.Size(564, 25);
            this.textBoxVairs.TabIndex = 4;
            this.textBoxVairs.Text = "待检测";
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(18, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "   是否安装:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(18, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "   host地址:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(18, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "   缓存目录:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(18, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "   环境变量:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSet
            // 
            this.buttonSet.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSet.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSet.Location = new System.Drawing.Point(290, 356);
            this.buttonSet.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(130, 45);
            this.buttonSet.TabIndex = 4;
            this.buttonSet.Text = "安装";
            this.buttonSet.UseVisualStyleBackColor = false;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "安装包路径：";
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxUrl.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxUrl.Location = new System.Drawing.Point(115, 313);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.ReadOnly = true;
            this.textBoxUrl.Size = new System.Drawing.Size(595, 21);
            this.textBoxUrl.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PrintRichTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 109);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "信息显示";
            // 
            // PrintRichTextBox
            // 
            this.PrintRichTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.PrintRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrintRichTextBox.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PrintRichTextBox.Location = new System.Drawing.Point(11, 21);
            this.PrintRichTextBox.Name = "PrintRichTextBox";
            this.PrintRichTextBox.ReadOnly = true;
            this.PrintRichTextBox.Size = new System.Drawing.Size(681, 82);
            this.PrintRichTextBox.TabIndex = 10;
            this.PrintRichTextBox.Text = "若使用存在问题，请联系JOMOO PLM项目组运维人员，谢谢。";
            this.PrintRichTextBox.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.PrintRichTextBox_ContentsResized);
            // 
            // SetPlmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(725, 418);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.checkBox_Reset);
            this.Controls.Add(this.groupBoxCheck);
            this.Controls.Add(this.button_cancle);
            this.Controls.Add(this.button_chose_software);
            this.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetPlmForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "安装PLM客户端";
            this.TopMost = true;
            this.groupBoxCheck.ResumeLayout(false);
            this.groupBoxCheck.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_chose_software;
        private System.Windows.Forms.CheckBox checkBox_Reset;
        private System.Windows.Forms.Button button_cancle;
        private System.Windows.Forms.GroupBox groupBoxCheck;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox PrintRichTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxVairs;
        private System.Windows.Forms.TextBox textBoxInstall;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.TextBox textBoxTemp;
    }
}