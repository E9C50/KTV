namespace MyKTVClient
{
    partial class FrmSongedList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSongedList));
            this.lblLastPage = new System.Windows.Forms.Panel();
            this.lblNextPlay = new System.Windows.Forms.Label();
            this.lblNowPlay = new System.Windows.Forms.Label();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlsinger = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlShowMain = new System.Windows.Forms.Panel();
            this.pnlSongList = new System.Windows.Forms.Panel();
            this.pnlServer = new System.Windows.Forms.Panel();
            this.pnlNextSong = new System.Windows.Forms.Panel();
            this.pnlLastSong = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlFace = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.pnlDel = new System.Windows.Forms.Panel();
            this.lvSongList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.qrIP = new Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl();
            this.pnlConnPhone = new System.Windows.Forms.Panel();
            this.pnlPause = new System.Windows.Forms.Panel();
            this.lblPause = new System.Windows.Forms.Label();
            this.timBtnStatic = new System.Windows.Forms.Timer(this.components);
            this.pnlExit.SuspendLayout();
            this.pnlsinger.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlFace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrIP)).BeginInit();
            this.pnlPause.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLastPage
            // 
            this.lblLastPage.BackColor = System.Drawing.Color.Transparent;
            this.lblLastPage.ForeColor = System.Drawing.Color.Black;
            this.lblLastPage.Location = new System.Drawing.Point(987, -1);
            this.lblLastPage.Name = "lblLastPage";
            this.lblLastPage.Size = new System.Drawing.Size(85, 47);
            this.lblLastPage.TabIndex = 41;
            this.lblLastPage.Click += new System.EventHandler(this.lblLastPage_Click);
            // 
            // lblNextPlay
            // 
            this.lblNextPlay.AutoSize = true;
            this.lblNextPlay.Font = new System.Drawing.Font("宋体", 16F);
            this.lblNextPlay.ForeColor = System.Drawing.Color.White;
            this.lblNextPlay.Location = new System.Drawing.Point(473, 13);
            this.lblNextPlay.Name = "lblNextPlay";
            this.lblNextPlay.Size = new System.Drawing.Size(142, 22);
            this.lblNextPlay.TabIndex = 39;
            this.lblNextPlay.Text = "您还没有点歌";
            // 
            // lblNowPlay
            // 
            this.lblNowPlay.AutoSize = true;
            this.lblNowPlay.Font = new System.Drawing.Font("宋体", 16F);
            this.lblNowPlay.ForeColor = System.Drawing.Color.White;
            this.lblNowPlay.Location = new System.Drawing.Point(151, 14);
            this.lblNowPlay.Name = "lblNowPlay";
            this.lblNowPlay.Size = new System.Drawing.Size(142, 22);
            this.lblNowPlay.TabIndex = 38;
            this.lblNowPlay.Text = "您还没有点歌";
            // 
            // pnlExit
            // 
            this.pnlExit.BackColor = System.Drawing.Color.Transparent;
            this.pnlExit.Controls.Add(this.label8);
            this.pnlExit.Location = new System.Drawing.Point(880, -1);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(85, 47);
            this.pnlExit.TabIndex = 40;
            this.pnlExit.Click += new System.EventHandler(this.pnlExit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(10, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "结账";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(1012, 587);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(57, 92);
            this.panel1.TabIndex = 50;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pnlsinger
            // 
            this.pnlsinger.BackColor = System.Drawing.Color.Transparent;
            this.pnlsinger.Controls.Add(this.label3);
            this.pnlsinger.Location = new System.Drawing.Point(748, 587);
            this.pnlsinger.Name = "pnlsinger";
            this.pnlsinger.Size = new System.Drawing.Size(57, 93);
            this.pnlsinger.TabIndex = 49;
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
            // pnlShowMain
            // 
            this.pnlShowMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlShowMain.Location = new System.Drawing.Point(31, 587);
            this.pnlShowMain.Name = "pnlShowMain";
            this.pnlShowMain.Size = new System.Drawing.Size(57, 92);
            this.pnlShowMain.TabIndex = 48;
            this.pnlShowMain.Click += new System.EventHandler(this.pnlShowMain_Click);
            // 
            // pnlSongList
            // 
            this.pnlSongList.BackColor = System.Drawing.Color.Transparent;
            this.pnlSongList.Location = new System.Drawing.Point(924, 587);
            this.pnlSongList.Name = "pnlSongList";
            this.pnlSongList.Size = new System.Drawing.Size(57, 92);
            this.pnlSongList.TabIndex = 44;
            this.pnlSongList.Click += new System.EventHandler(this.pnlSongList_Click);
            // 
            // pnlServer
            // 
            this.pnlServer.BackColor = System.Drawing.Color.Transparent;
            this.pnlServer.Location = new System.Drawing.Point(118, 587);
            this.pnlServer.Name = "pnlServer";
            this.pnlServer.Size = new System.Drawing.Size(57, 93);
            this.pnlServer.TabIndex = 47;
            this.pnlServer.Click += new System.EventHandler(this.pnlServer_Click);
            // 
            // pnlNextSong
            // 
            this.pnlNextSong.BackColor = System.Drawing.Color.Transparent;
            this.pnlNextSong.Location = new System.Drawing.Point(202, 587);
            this.pnlNextSong.Name = "pnlNextSong";
            this.pnlNextSong.Size = new System.Drawing.Size(57, 92);
            this.pnlNextSong.TabIndex = 45;
            this.pnlNextSong.Click += new System.EventHandler(this.pnlNextSong_Click);
            // 
            // pnlLastSong
            // 
            this.pnlLastSong.BackColor = System.Drawing.Color.Transparent;
            this.pnlLastSong.Location = new System.Drawing.Point(832, 587);
            this.pnlLastSong.Name = "pnlLastSong";
            this.pnlLastSong.Size = new System.Drawing.Size(57, 92);
            this.pnlLastSong.TabIndex = 46;
            this.pnlLastSong.Click += new System.EventHandler(this.pnlLastSong_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.pnlFace);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Location = new System.Drawing.Point(864, 456);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 125);
            this.panel2.TabIndex = 51;
            this.panel2.Visible = false;
            // 
            // pnlFace
            // 
            this.pnlFace.BackColor = System.Drawing.Color.Transparent;
            this.pnlFace.Controls.Add(this.label13);
            this.pnlFace.Location = new System.Drawing.Point(85, 124);
            this.pnlFace.Name = "pnlFace";
            this.pnlFace.Size = new System.Drawing.Size(57, 82);
            this.pnlFace.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(9, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "气氛";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(115, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(106, 119);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(0, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(113, 119);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.Transparent;
            this.pnlAdd.Location = new System.Drawing.Point(380, 587);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(57, 92);
            this.pnlAdd.TabIndex = 46;
            this.pnlAdd.Click += new System.EventHandler(this.pnlAdd_Click);
            // 
            // pnlDel
            // 
            this.pnlDel.BackColor = System.Drawing.Color.Transparent;
            this.pnlDel.Location = new System.Drawing.Point(662, 587);
            this.pnlDel.Name = "pnlDel";
            this.pnlDel.Size = new System.Drawing.Size(57, 92);
            this.pnlDel.TabIndex = 47;
            this.pnlDel.Click += new System.EventHandler(this.pnlDel_Click);
            // 
            // lvSongList
            // 
            this.lvSongList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvSongList.BackgroundImage")));
            this.lvSongList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSongList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvSongList.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvSongList.ForeColor = System.Drawing.Color.White;
            this.lvSongList.FullRowSelect = true;
            this.lvSongList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvSongList.Location = new System.Drawing.Point(0, 64);
            this.lvSongList.Name = "lvSongList";
            this.lvSongList.Size = new System.Drawing.Size(1092, 521);
            this.lvSongList.TabIndex = 52;
            this.lvSongList.UseCompatibleStateImageBehavior = false;
            this.lvSongList.View = System.Windows.Forms.View.Details;
            this.lvSongList.Click += new System.EventHandler(this.lvSongList_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 400;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 400;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // qrIP
            // 
            this.qrIP.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M;
            this.qrIP.Image = ((System.Drawing.Image)(resources.GetObject("qrIP.Image")));
            this.qrIP.Location = new System.Drawing.Point(731, 48);
            this.qrIP.Name = "qrIP";
            this.qrIP.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two;
            this.qrIP.Size = new System.Drawing.Size(150, 150);
            this.qrIP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qrIP.TabIndex = 53;
            this.qrIP.TabStop = false;
            this.qrIP.Text = "192.168.124.1:8998";
            this.qrIP.Visible = false;
            // 
            // pnlConnPhone
            // 
            this.pnlConnPhone.BackColor = System.Drawing.Color.Transparent;
            this.pnlConnPhone.Location = new System.Drawing.Point(755, -1);
            this.pnlConnPhone.Name = "pnlConnPhone";
            this.pnlConnPhone.Size = new System.Drawing.Size(119, 47);
            this.pnlConnPhone.TabIndex = 54;
            this.pnlConnPhone.Click += new System.EventHandler(this.pnlConnPhone_Click);
            // 
            // pnlPause
            // 
            this.pnlPause.BackColor = System.Drawing.Color.Transparent;
            this.pnlPause.Controls.Add(this.lblPause);
            this.pnlPause.Location = new System.Drawing.Point(284, 587);
            this.pnlPause.Name = "pnlPause";
            this.pnlPause.Size = new System.Drawing.Size(57, 91);
            this.pnlPause.TabIndex = 55;
            this.pnlPause.Click += new System.EventHandler(this.pnlPause_Click);
            // 
            // lblPause
            // 
            this.lblPause.BackColor = System.Drawing.Color.Black;
            this.lblPause.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.lblPause.ForeColor = System.Drawing.Color.White;
            this.lblPause.Location = new System.Drawing.Point(4, 57);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(51, 24);
            this.lblPause.TabIndex = 0;
            this.lblPause.Text = "暂停";
            // 
            // timBtnStatic
            // 
            this.timBtnStatic.Enabled = true;
            this.timBtnStatic.Tick += new System.EventHandler(this.timBtnStatic_Tick);
            // 
            // FrmSongedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1092, 679);
            this.Controls.Add(this.pnlPause);
            this.Controls.Add(this.pnlConnPhone);
            this.Controls.Add(this.qrIP);
            this.Controls.Add(this.lvSongList);
            this.Controls.Add(this.pnlDel);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlsinger);
            this.Controls.Add(this.pnlShowMain);
            this.Controls.Add(this.pnlSongList);
            this.Controls.Add(this.pnlServer);
            this.Controls.Add(this.pnlNextSong);
            this.Controls.Add(this.pnlLastSong);
            this.Controls.Add(this.lblLastPage);
            this.Controls.Add(this.lblNextPlay);
            this.Controls.Add(this.lblNowPlay);
            this.Controls.Add(this.pnlExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSongedList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSongedList";
            this.Load += new System.EventHandler(this.FrmSongedList_Load);
            this.pnlExit.ResumeLayout(false);
            this.pnlExit.PerformLayout();
            this.pnlsinger.ResumeLayout(false);
            this.pnlsinger.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlFace.ResumeLayout(false);
            this.pnlFace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrIP)).EndInit();
            this.pnlPause.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel lblLastPage;
        private System.Windows.Forms.Label lblNextPlay;
        private System.Windows.Forms.Label lblNowPlay;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlsinger;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlShowMain;
        private System.Windows.Forms.Panel pnlSongList;
        private System.Windows.Forms.Panel pnlServer;
        private System.Windows.Forms.Panel pnlNextSong;
        private System.Windows.Forms.Panel pnlLastSong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlFace;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Panel pnlDel;
        private System.Windows.Forms.ListView lvSongList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Timer timer1;
        private Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl qrIP;
        private System.Windows.Forms.Panel pnlConnPhone;
        private System.Windows.Forms.Panel pnlPause;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Timer timBtnStatic;
    }
}