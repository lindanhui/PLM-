namespace PLM系统工具集成
{
    partial class CreoSetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreoSetForm));
            this.button7 = new System.Windows.Forms.Button();
            this.buttonOpenCreo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PrintRichTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.Enabled = false;
            this.button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.Location = new System.Drawing.Point(230, 16);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(125, 125);
            this.button7.TabIndex = 9;
            this.button7.Text = "安装CREO集成";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // buttonOpenCreo
            // 
            this.buttonOpenCreo.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOpenCreo.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonOpenCreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenCreo.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOpenCreo.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenCreo.Image")));
            this.buttonOpenCreo.Location = new System.Drawing.Point(46, 16);
            this.buttonOpenCreo.Name = "buttonOpenCreo";
            this.buttonOpenCreo.Size = new System.Drawing.Size(125, 125);
            this.buttonOpenCreo.TabIndex = 10;
            this.buttonOpenCreo.Text = "打开CREO软件";
            this.buttonOpenCreo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOpenCreo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonOpenCreo.UseVisualStyleBackColor = false;
            this.buttonOpenCreo.Click += new System.EventHandler(this.buttonOpenCreo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PrintRichTextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 109);
            this.groupBox1.TabIndex = 11;
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
            this.PrintRichTextBox.Size = new System.Drawing.Size(543, 82);
            this.PrintRichTextBox.TabIndex = 10;
            this.PrintRichTextBox.Text = "若使用存在问题，请联系JOMOO PLM项目组运维人员，谢谢。";
            this.PrintRichTextBox.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.PrintRichTextBox_ContentsResized);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(416, 16);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(125, 125);
            this.buttonClose.TabIndex = 13;
            this.buttonClose.Text = "退出";
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // CreoSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 277);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonOpenCreo);
            this.Controls.Add(this.button7);
            this.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreoSetForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creo集成安装配置";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonOpenCreo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox PrintRichTextBox;
        private System.Windows.Forms.Button buttonClose;
    }
}