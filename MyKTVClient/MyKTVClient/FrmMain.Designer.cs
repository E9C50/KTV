namespace MyKTVClient
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlTypeSearch = new System.Windows.Forms.Panel();
            this.pnlSpellSearch = new System.Windows.Forms.Panel();
            this.pnlCountSearch = new System.Windows.Forms.Panel();
            this.pnlSingerSearch = new System.Windows.Forms.Panel();
            this.pnlRanklist = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlFood = new System.Windows.Forms.Panel();
            this.pnlServer = new System.Windows.Forms.Panel();
            this.pnlLastSong = new System.Windows.Forms.Panel();
            this.pnlNextSong = new System.Windows.Forms.Panel();
            this.pnlSongList = new System.Windows.Forms.Panel();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.pnlShowMain = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlConnPhone = new System.Windows.Forms.Panel();
            this.lblNextPlay = new System.Windows.Forms.Label();
            this.lblNowPlay = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.pnlFace = new System.Windows.Forms.Panel();
            this.pnlsinger = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlDel = new System.Windows.Forms.Panel();
            this.pnlPause = new System.Windows.Forms.Panel();
            this.lblPause = new System.Windows.Forms.Label();
            this.qrIP = new Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl();
            this.timBtnStatic = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlsinger.SuspendLayout();
            this.pnlPause.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qrIP)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTypeSearch
            // 
            this.pnlTypeSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnlTypeSearch.Location = new System.Drawing.Point(83, 308);
            this.pnlTypeSearch.Name = "pnlTypeSearch";
            this.pnlTypeSearch.Size = new System.Drawing.Size(184, 201);
            this.pnlTypeSearch.TabIndex = 0;
            this.pnlTypeSearch.Click += new System.EventHandler(this.pnlTypeSearch_Click);
            // 
            // pnlSpellSearch
            // 
            this.pnlSpellSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnlSpellSearch.Location = new System.Drawing.Point(269, 308);
            this.pnlSpellSearch.Name = "pnlSpellSearch";
            this.pnlSpellSearch.Size = new System.Drawing.Size(183, 201);
            this.pnlSpellSearch.TabIndex = 1;
            this.pnlSpellSearch.Click += new System.EventHandler(this.pnlSpellSearch_Click);
            // 
            // pnlCountSearch
            // 
            this.pnlCountSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnlCountSearch.Location = new System.Drawing.Point(269, 104);
            this.pnlCountSearch.Name = "pnlCountSearch";
            this.pnlCountSearch.Size = new System.Drawing.Size(183, 200);
            this.pnlCountSearch.TabIndex = 2;
            this.pnlCountSearch.Click += new System.EventHandler(this.pnlCountSearch_Click);
            // 
            // pnlSingerSearch
            // 
            this.pnlSingerSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnlSingerSearch.Location = new System.Drawing.Point(456, 104);
            this.pnlSingerSearch.Name = "pnlSingerSearch";
            this.pnlSingerSearch.Size = new System.Drawing.Size(363, 405);
            this.pnlSingerSearch.TabIndex = 3;
            this.pnlSingerSearch.Click += new System.EventHandler(this.pnlSingerSearch_Click);
            // 
            // pnlRanklist
            // 
            this.pnlRanklist.BackColor = System.Drawing.Color.Transparent;
            this.pnlRanklist.Location = new System.Drawing.Point(83, 104);
            this.pnlRanklist.Name = "pnlRanklist";
            this.pnlRanklist.Size = new System.Drawing.Size(184, 200);
            this.pnlRanklist.TabIndex = 4;
            this.pnlRanklist.Click += new System.EventHandler(this.pnlRanklist_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(871, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 125);
            this.panel2.TabIndex = 10;
            this.panel2.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(115, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 119);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 119);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlFood
            // 
            this.pnlFood.BackColor = System.Drawing.Color.Transparent;
            this.pnlFood.Location = new System.Drawing.Point(822, 104);
            this.pnlFood.Name = "pnlFood";
            this.pnlFood.Size = new System.Drawing.Size(182, 405);
            this.pnlFood.TabIndex = 5;
            this.pnlFood.Click += new System.EventHandler(this.pnlFood_Click);
            // 
            // pnlServer
            // 
            this.pnlServer.BackColor = System.Drawing.Color.Transparent;
            this.pnlServer.Location = new System.Drawing.Point(114, 0);
            this.pnlServer.Name = "pnlServer";
            this.pnlServer.Size = new System.Drawing.Size(57, 94);
            this.pnlServer.TabIndex = 6;
            this.pnlServer.Click += new System.EventHandler(this.pnlServer_Click);
            // 
            // pnlLastSong
            // 
            this.pnlLastSong.BackColor = System.Drawing.Color.Transparent;
            this.pnlLastSong.Location = new System.Drawing.Point(832, 0);
            this.pnlLastSong.Name = "pnlLastSong";
            this.pnlLastSong.Size = new System.Drawing.Size(57, 91);
            this.pnlLastSong.TabIndex = 6;
            this.pnlLastSong.Click += new System.EventHandler(this.pnlLastSong_Click);
            // 
            // pnlNextSong
            // 
            this.pnlNextSong.BackColor = System.Drawing.Color.Transparent;
            this.pnlNextSong.Location = new System.Drawing.Point(200, 0);
            this.pnlNextSong.Name = "pnlNextSong";
            this.pnlNextSong.Size = new System.Drawing.Size(57, 91);
            this.pnlNextSong.TabIndex = 6;
            this.pnlNextSong.Click += new System.EventHandler(this.pnlNextSong_Click);
            // 
            // pnlSongList
            // 
            this.pnlSongList.BackColor = System.Drawing.Color.Transparent;
            this.pnlSongList.Location = new System.Drawing.Point(922, 0);
            this.pnlSongList.Name = "pnlSongList";
            this.pnlSongList.Size = new System.Drawing.Size(57, 91);
            this.pnlSongList.TabIndex = 6;
            this.pnlSongList.Click += new System.EventHandler(this.pnlSongList_Click);
            // 
            // pnlExit
            // 
            this.pnlExit.BackColor = System.Drawing.Color.Transparent;
            this.pnlExit.Location = new System.Drawing.Point(986, 0);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(94, 50);
            this.pnlExit.TabIndex = 6;
            this.pnlExit.Click += new System.EventHandler(this.pnlExit_Click);
            // 
            // pnlShowMain
            // 
            this.pnlShowMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlShowMain.Location = new System.Drawing.Point(28, 0);
            this.pnlShowMain.Name = "pnlShowMain";
            this.pnlShowMain.Size = new System.Drawing.Size(57, 91);
            this.pnlShowMain.TabIndex = 7;
            this.pnlShowMain.Click += new System.EventHandler(this.pnlShowMain_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.Controls.Add(this.pnlConnPhone);
            this.pnlTop.Controls.Add(this.lblNextPlay);
            this.pnlTop.Controls.Add(this.lblNowPlay);
            this.pnlTop.Controls.Add(this.pnlExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1092, 62);
            this.pnlTop.TabIndex = 8;
            // 
            // pnlConnPhone
            // 
            this.pnlConnPhone.BackColor = System.Drawing.Color.Transparent;
            this.pnlConnPhone.Location = new System.Drawing.Point(858, 1);
            this.pnlConnPhone.Name = "pnlConnPhone";
            this.pnlConnPhone.Size = new System.Drawing.Size(116, 50);
            this.pnlConnPhone.TabIndex = 7;
            this.pnlConnPhone.Click += new System.EventHandler(this.pnlConnPhone_Click);
            // 
            // lblNextPlay
            // 
            this.lblNextPlay.AutoSize = true;
            this.lblNextPlay.Font = new System.Drawing.Font("宋体", 16F);
            this.lblNextPlay.ForeColor = System.Drawing.Color.White;
            this.lblNextPlay.Location = new System.Drawing.Point(471, 15);
            this.lblNextPlay.Name = "lblNextPlay";
            this.lblNextPlay.Size = new System.Drawing.Size(142, 22);
            this.lblNextPlay.TabIndex = 1;
            this.lblNextPlay.Text = "您还没有点歌";
            // 
            // lblNowPlay
            // 
            this.lblNowPlay.AutoSize = true;
            this.lblNowPlay.Font = new System.Drawing.Font("宋体", 16F);
            this.lblNowPlay.ForeColor = System.Drawing.Color.White;
            this.lblNowPlay.Location = new System.Drawing.Point(147, 15);
            this.lblNowPlay.Name = "lblNowPlay";
            this.lblNowPlay.Size = new System.Drawing.Size(142, 22);
            this.lblNowPlay.TabIndex = 0;
            this.lblNowPlay.Text = "您还没有点歌";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnlBottom.Controls.Add(this.pnlAdd);
            this.pnlBottom.Controls.Add(this.pnlShowMain);
            this.pnlBottom.Controls.Add(this.pnlFace);
            this.pnlBottom.Controls.Add(this.pnlsinger);
            this.pnlBottom.Controls.Add(this.pnlSongList);
            this.pnlBottom.Controls.Add(this.label9);
            this.pnlBottom.Controls.Add(this.pnlLastSong);
            this.pnlBottom.Controls.Add(this.pnlNextSong);
            this.pnlBottom.Controls.Add(this.pnlServer);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 588);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1092, 91);
            this.pnlBottom.TabIndex = 9;
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.Transparent;
            this.pnlAdd.Location = new System.Drawing.Point(380, 0);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(57, 91);
            this.pnlAdd.TabIndex = 7;
            this.pnlAdd.Click += new System.EventHandler(this.pnlAdd_Click);
            // 
            // pnlFace
            // 
            this.pnlFace.BackColor = System.Drawing.Color.Transparent;
            this.pnlFace.Location = new System.Drawing.Point(1011, 0);
            this.pnlFace.Name = "pnlFace";
            this.pnlFace.Size = new System.Drawing.Size(57, 91);
            this.pnlFace.TabIndex = 7;
            this.pnlFace.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pnlsinger
            // 
            this.pnlsinger.BackColor = System.Drawing.Color.Transparent;
            this.pnlsinger.Controls.Add(this.label3);
            this.pnlsinger.Location = new System.Drawing.Point(743, 0);
            this.pnlsinger.Name = "pnlsinger";
            this.pnlsinger.Size = new System.Drawing.Size(57, 91);
            this.pnlsinger.TabIndex = 9;
            this.pnlsinger.Click += new System.EventHandler(this.pnlsinger_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "原唱";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(894, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "灯光";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlDel
            // 
            this.pnlDel.BackColor = System.Drawing.Color.Transparent;
            this.pnlDel.Location = new System.Drawing.Point(662, 585);
            this.pnlDel.Name = "pnlDel";
            this.pnlDel.Size = new System.Drawing.Size(57, 91);
            this.pnlDel.TabIndex = 7;
            this.pnlDel.Click += new System.EventHandler(this.pnlDel_Click);
            // 
            // pnlPause
            // 
            this.pnlPause.BackColor = System.Drawing.Color.Transparent;
            this.pnlPause.Controls.Add(this.lblPause);
            this.pnlPause.Location = new System.Drawing.Point(284, 588);
            this.pnlPause.Name = "pnlPause";
            this.pnlPause.Size = new System.Drawing.Size(57, 91);
            this.pnlPause.TabIndex = 7;
            this.pnlPause.Click += new System.EventHandler(this.pnlPause_Click);
            // 
            // lblPause
            // 
            this.lblPause.BackColor = System.Drawing.Color.Black;
            this.lblPause.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.lblPause.ForeColor = System.Drawing.Color.White;
            this.lblPause.Location = new System.Drawing.Point(6, 57);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(51, 24);
            this.lblPause.TabIndex = 0;
            this.lblPause.Text = "暂停";
            // 
            // qrIP
            // 
            this.qrIP.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M;
            this.qrIP.Image = ((System.Drawing.Image)(resources.GetObject("qrIP.Image")));
            this.qrIP.Location = new System.Drawing.Point(845, 54);
            this.qrIP.Name = "qrIP";
            this.qrIP.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two;
            this.qrIP.Size = new System.Drawing.Size(150, 150);
            this.qrIP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qrIP.TabIndex = 11;
            this.qrIP.TabStop = false;
            this.qrIP.Text = "192.168.124.1:8998";
            this.qrIP.Visible = false;
            // 
            // timBtnStatic
            // 
            this.timBtnStatic.Enabled = true;
            this.timBtnStatic.Tick += new System.EventHandler(this.timBtnStatic_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1092, 679);
            this.Controls.Add(this.qrIP);
            this.Controls.Add(this.pnlPause);
            this.Controls.Add(this.pnlDel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlFood);
            this.Controls.Add(this.pnlRanklist);
            this.Controls.Add(this.pnlSingerSearch);
            this.Controls.Add(this.pnlCountSearch);
            this.Controls.Add(this.pnlSpellSearch);
            this.Controls.Add(this.pnlTypeSearch);
            this.Controls.Add(this.pnlBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.lblNowPlay_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlsinger.ResumeLayout(false);
            this.pnlsinger.PerformLayout();
            this.pnlPause.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qrIP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTypeSearch;
        private System.Windows.Forms.Panel pnlSpellSearch;
        private System.Windows.Forms.Panel pnlCountSearch;
        private System.Windows.Forms.Panel pnlSingerSearch;
        private System.Windows.Forms.Panel pnlRanklist;
        private System.Windows.Forms.Panel pnlFood;
        private System.Windows.Forms.Panel pnlServer;
        private System.Windows.Forms.Panel pnlLastSong;
        private System.Windows.Forms.Panel pnlNextSong;
        private System.Windows.Forms.Panel pnlSongList;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.Panel pnlShowMain;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblNowPlay;
        private System.Windows.Forms.Label lblNextPlay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlsinger;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlFace;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Panel pnlDel;
        private System.Windows.Forms.Panel pnlPause;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Panel pnlConnPhone;
        private Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl qrIP;
        private System.Windows.Forms.Timer timBtnStatic;

    }
}

