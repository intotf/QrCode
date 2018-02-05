namespace QrCodeApp
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.plBorder = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tbBorder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.plBackground = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.plForeground = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLogo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTxt = new System.Windows.Forms.TextBox();
            this.btCreate = new System.Windows.Forms.Button();
            this.QrPicture = new System.Windows.Forms.PictureBox();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.pictureMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.保存二维码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QrPicture)).BeginInit();
            this.pictureMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.plBorder);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.tbBorder);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.plBackground);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.plForeground);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.tbLogo);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.cbSize);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.tbTxt);
            this.splitContainer1.Panel1.Controls.Add(this.btCreate);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.QrPicture);
            this.splitContainer1.Size = new System.Drawing.Size(617, 611);
            this.splitContainer1.SplitterDistance = 152;
            this.splitContainer1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(399, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 27;
            this.label9.Text = "像素";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(280, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 12);
            this.label8.TabIndex = 26;
            this.label8.Text = "(-1无边框,0 默认10%边框 )";
            // 
            // plBorder
            // 
            this.plBorder.BackColor = System.Drawing.Color.White;
            this.plBorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plBorder.Location = new System.Drawing.Point(512, 104);
            this.plBorder.Name = "plBorder";
            this.plBorder.Size = new System.Drawing.Size(25, 25);
            this.plBorder.TabIndex = 22;
            this.plBorder.Click += new System.EventHandler(this.plBorder_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 25;
            this.label7.Text = "边框颜色：";
            // 
            // tbBorder
            // 
            this.tbBorder.Location = new System.Drawing.Point(346, 106);
            this.tbBorder.Name = "tbBorder";
            this.tbBorder.Size = new System.Drawing.Size(47, 21);
            this.tbBorder.TabIndex = 24;
            this.tbBorder.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "边框大小：";
            // 
            // plBackground
            // 
            this.plBackground.BackColor = System.Drawing.Color.White;
            this.plBackground.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plBackground.Location = new System.Drawing.Point(232, 104);
            this.plBackground.Name = "plBackground";
            this.plBackground.Size = new System.Drawing.Size(25, 25);
            this.plBackground.TabIndex = 16;
            this.plBackground.Click += new System.EventHandler(this.plBackground_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "背景颜色：";
            // 
            // plForeground
            // 
            this.plForeground.BackColor = System.Drawing.Color.Black;
            this.plForeground.Cursor = System.Windows.Forms.Cursors.Hand;
            this.plForeground.Location = new System.Drawing.Point(104, 104);
            this.plForeground.Name = "plForeground";
            this.plForeground.Size = new System.Drawing.Size(25, 25);
            this.plForeground.TabIndex = 15;
            this.plForeground.Click += new System.EventHandler(this.plForeground_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "二维码颜色：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "选择 Logo：";
            // 
            // tbLogo
            // 
            this.tbLogo.Location = new System.Drawing.Point(263, 76);
            this.tbLogo.Name = "tbLogo";
            this.tbLogo.ReadOnly = true;
            this.tbLogo.Size = new System.Drawing.Size(252, 21);
            this.tbLogo.TabIndex = 12;
            this.tbLogo.Click += new System.EventHandler(this.tbLogo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "二维码大小：";
            // 
            // cbSize
            // 
            this.cbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(104, 77);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(73, 20);
            this.cbSize.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "待生成字符串：";
            // 
            // tbTxt
            // 
            this.tbTxt.Location = new System.Drawing.Point(104, 11);
            this.tbTxt.Multiline = true;
            this.tbTxt.Name = "tbTxt";
            this.tbTxt.Size = new System.Drawing.Size(492, 58);
            this.tbTxt.TabIndex = 7;
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(521, 75);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(75, 23);
            this.btCreate.TabIndex = 6;
            this.btCreate.Text = "生成";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // QrPicture
            // 
            this.QrPicture.ContextMenuStrip = this.pictureMenu;
            this.QrPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QrPicture.Location = new System.Drawing.Point(0, 0);
            this.QrPicture.Name = "QrPicture";
            this.QrPicture.Size = new System.Drawing.Size(615, 453);
            this.QrPicture.TabIndex = 4;
            this.QrPicture.TabStop = false;
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // pictureMenu
            // 
            this.pictureMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存二维码ToolStripMenuItem});
            this.pictureMenu.Name = "contextMenuStrip1";
            this.pictureMenu.Size = new System.Drawing.Size(137, 26);
            // 
            // 保存二维码ToolStripMenuItem
            // 
            this.保存二维码ToolStripMenuItem.Name = "保存二维码ToolStripMenuItem";
            this.保存二维码ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.保存二维码ToolStripMenuItem.Text = "保存二维码";
            this.保存二维码ToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 611);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Main";
            this.Text = "QRCode 二维码生成器";
            this.Load += new System.EventHandler(this.Main_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QrPicture)).EndInit();
            this.pictureMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel plBackground;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel plForeground;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTxt;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.PictureBox QrPicture;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel plBorder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbBorder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip pictureMenu;
        private System.Windows.Forms.ToolStripMenuItem 保存二维码ToolStripMenuItem;
    }
}

