namespace MyKTVClient
{
    partial class FrmFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFood));
            this.lvFoodList = new System.Windows.Forms.ListView();
            this.imgFoodPhoto = new System.Windows.Forms.ImageList(this.components);
            this.lvFoodedList = new System.Windows.Forms.ListView();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblLastPage = new System.Windows.Forms.Panel();
            this.lblNextPlay = new System.Windows.Forms.Label();
            this.lblNowPlay = new System.Windows.Forms.Label();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlsinger = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlShowMain = new System.Windows.Forms.Panel();
            this.pnlNextSong = new System.Windows.Forms.Panel();
            this.pnlSongList = new System.Windows.Forms.Panel();
            this.pnlServer = new System.Windows.Forms.Panel();
            this.pnlLastSong = new System.Windows.Forms.Panel();
            this.pnlFace = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.pnlDel = new System.Windows.Forms.Panel();
            this.pnlAll = new System.Windows.Forms.Panel();
            this.pelDrinks = new System.Windows.Forms.Panel();
            this.pnlBarbecue = new System.Windows.Forms.Panel();
            this.pelSnack = new System.Windows.Forms.Panel();
            this.pelHotdishes = new System.Windows.Forms.Panel();
            this.pelColddish = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.qrIP = new Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl();
            this.pnlConnPhone = new System.Windows.Forms.Panel();
            this.pnlPause = new System.Windows.Forms.Panel();
            this.lblPause = new System.Windows.Forms.Label();
            this.timBtnStatic = new System.Windows.Forms.Timer(this.components);
            this.pnlExit.SuspendLayout();
            this.pnlsinger.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrIP)).BeginInit();
            this.pnlPause.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvFoodList
            // 
            this.lvFoodList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvFoodList.BackColor = System.Drawing.SystemColors.Control;
            this.lvFoodList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvFoodList.BackgroundImage")));
            this.lvFoodList.BackgroundImageTiled = true;
            this.lvFoodList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvFoodList.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvFoodList.ForeColor = System.Drawing.Color.White;
            this.lvFoodList.Location = new System.Drawing.Point(0, 97);
            this.lvFoodList.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.lvFoodList.Name = "lvFoodList";
            this.lvFoodList.Size = new System.Drawing.Size(724, 490);
            this.lvFoodList.TabIndex = 0;
            this.lvFoodList.UseCompatibleStateImageBehavior = false;
            this.lvFoodList.Click += new System.EventHandler(this.lvFoodList_Click);
            // 
            // imgFoodPhoto
            // 
            this.imgFoodPhoto.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgFoodPhoto.ImageSize = new System.Drawing.Size(200, 150);
            this.imgFoodPhoto.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lvFoodedList
            // 
            this.lvFoodedList.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lvFoodedList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvFoodedList.BackgroundImage")));
            this.lvFoodedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvFoodedList.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvFoodedList.ForeColor = System.Drawing.Color.White;
            this.lvFoodedList.Location = new System.Drawing.Point(726, 92);
            this.lvFoodedList.Name = "lvFoodedList";
            this.lvFoodedList.Size = new System.Drawing.Size(354, 419);
            this.lvFoodedList.TabIndex = 3;
            this.lvFoodedList.UseCompatibleStateImageBehavior = false;
            this.lvFoodedList.View = System.Windows.Forms.View.List;
            this.lvFoodedList.Click += new System.EventHandler(this.lvFoodedList_Click);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblMoney.Font = new System.Drawing.Font("宋体", 22F);
            this.lblMoney.ForeColor = System.Drawing.Color.White;
            this.lblMoney.Location = new System.Drawing.Point(854, 536);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(28, 30);
            this.lblMoney.TabIndex = 5;
            this.lblMoney.Text = "0";
            // 
            // lblLastPage
            // 
            this.lblLastPage.BackColor = System.Drawing.Color.Transparent;
            this.lblLastPage.Location = new System.Drawing.Point(988, 0);
            this.lblLastPage.Name = "lblLastPage";
            this.lblLastPage.Size = new System.Drawing.Size(92, 48);
            this.lblLastPage.TabIndex = 16;
            this.lblLastPage.Click += new System.EventHandler(this.lblLastPage_Click);
            // 
            // lblNextPlay
            // 
            this.lblNextPlay.AutoSize = true;
            this.lblNextPlay.BackColor = System.Drawing.Color.Black;
            this.lblNextPlay.Font = new System.Drawing.Font("宋体", 16F);
            this.lblNextPlay.ForeColor = System.Drawing.Color.White;
            this.lblNextPlay.Location = new System.Drawing.Point(477, 14);
            this.lblNextPlay.Name = "lblNextPlay";
            this.lblNextPlay.Size = new System.Drawing.Size(142, 22);
            this.lblNextPlay.TabIndex = 14;
            this.lblNextPlay.Text = "您还没有点歌";
            // 
            // lblNowPlay
            // 
            this.lblNowPlay.AutoSize = true;
            this.lblNowPlay.BackColor = System.Drawing.Color.Black;
            this.lblNowPlay.Font = new System.Drawing.Font("宋体", 16F);
            this.lblNowPlay.ForeColor = System.Drawing.Color.White;
            this.lblNowPlay.Location = new System.Drawing.Point(153, 14);
            this.lblNowPlay.Name = "lblNowPlay";
            this.lblNowPlay.Size = new System.Drawing.Size(142, 22);
            this.lblNowPlay.TabIndex = 13;
            this.lblNowPlay.Text = "您还没有点歌";
            // 
            // pnlExit
            // 
            this.pnlExit.BackColor = System.Drawing.Color.Transparent;
            this.pnlExit.Controls.Add(this.label8);
            this.pnlExit.Location = new System.Drawing.Point(880, 0);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(92, 48);
            this.pnlExit.TabIndex = 15;
            this.pnlExit.Click += new System.EventHandler(this.pnlExit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(8, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "结账";
            // 
            // pnlsinger
            // 
            this.pnlsinger.BackColor = System.Drawing.Color.Transparent;
            this.pnlsinger.Controls.Add(this.label3);
            this.pnlsinger.Location = new System.Drawing.Point(744, 587);
            this.pnlsinger.Name = "pnlsinger";
            this.pnlsinger.Size = new System.Drawing.Size(57, 92);
            this.pnlsinger.TabIndex = 37;
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
            this.pnlShowMain.Location = new System.Drawing.Point(29, 587);
            this.pnlShowMain.Name = "pnlShowMain";
            this.pnlShowMain.Size = new System.Drawing.Size(57, 93);
            this.pnlShowMain.TabIndex = 36;
            this.pnlShowMain.Click += new System.EventHandler(this.pnlShowMain_Click);
            // 
            // pnlNextSong
            // 
            this.pnlNextSong.BackColor = System.Drawing.Color.Transparent;
            this.pnlNextSong.Location = new System.Drawing.Point(200, 587);
            this.pnlNextSong.Name = "pnlNextSong";
            this.pnlNextSong.Size = new System.Drawing.Size(57, 92);
            this.pnlNextSong.TabIndex = 33;
            this.pnlNextSong.Click += new System.EventHandler(this.pnlNextSong_Click);
            // 
            // pnlSongList
            // 
            this.pnlSongList.BackColor = System.Drawing.Color.Transparent;
            this.pnlSongList.Location = new System.Drawing.Point(920, 587);
            this.pnlSongList.Name = "pnlSongList";
            this.pnlSongList.Size = new System.Drawing.Size(57, 92);
            this.pnlSongList.TabIndex = 32;
            this.pnlSongList.Click += new System.EventHandler(this.pnlSongList_Click);
            // 
            // pnlServer
            // 
            this.pnlServer.BackColor = System.Drawing.Color.Transparent;
            this.pnlServer.Location = new System.Drawing.Point(115, 587);
            this.pnlServer.Name = "pnlServer";
            this.pnlServer.Size = new System.Drawing.Size(57, 92);
            this.pnlServer.TabIndex = 35;
            this.pnlServer.Click += new System.EventHandler(this.pnlServer_Click);
            // 
            // pnlLastSong
            // 
            this.pnlLastSong.BackColor = System.Drawing.Color.Transparent;
            this.pnlLastSong.Location = new System.Drawing.Point(832, 587);
            this.pnlLastSong.Name = "pnlLastSong";
            this.pnlLastSong.Size = new System.Drawing.Size(57, 92);
            this.pnlLastSong.TabIndex = 34;
            this.pnlLastSong.Click += new System.EventHandler(this.pnlLastSong_Click);
            // 
            // pnlFace
            // 
            this.pnlFace.BackColor = System.Drawing.Color.Transparent;
            this.pnlFace.Location = new System.Drawing.Point(1008, 587);
            this.pnlFace.Name = "pnlFace";
            this.pnlFace.Size = new System.Drawing.Size(57, 92);
            this.pnlFace.TabIndex = 38;
            this.pnlFace.Click += new System.EventHandler(this.pnlFace_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(859, 456);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 125);
            this.panel2.TabIndex = 39;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(977, 536);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(78, 33);
            this.panel1.TabIndex = 40;
            this.panel1.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.Transparent;
            this.pnlAdd.Location = new System.Drawing.Point(380, 588);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(57, 92);
            this.pnlAdd.TabIndex = 34;
            this.pnlAdd.Click += new System.EventHandler(this.pnlAdd_Click);
            // 
            // pnlDel
            // 
            this.pnlDel.BackColor = System.Drawing.Color.Transparent;
            this.pnlDel.Location = new System.Drawing.Point(661, 587);
            this.pnlDel.Name = "pnlDel";
            this.pnlDel.Size = new System.Drawing.Size(57, 92);
            this.pnlDel.TabIndex = 34;
            this.pnlDel.Click += new System.EventHandler(this.pnlDel_Click);
            // 
            // pnlAll
            // 
            this.pnlAll.BackColor = System.Drawing.Color.Transparent;
            this.pnlAll.Location = new System.Drawing.Point(14, 45);
            this.pnlAll.Name = "pnlAll";
            this.pnlAll.Size = new System.Drawing.Size(114, 51);
            this.pnlAll.TabIndex = 41;
            this.pnlAll.Click += new System.EventHandler(this.pnlAll_Click);
            // 
            // pelDrinks
            // 
            this.pelDrinks.BackColor = System.Drawing.Color.Transparent;
            this.pelDrinks.Location = new System.Drawing.Point(131, 45);
            this.pelDrinks.Name = "pelDrinks";
            this.pelDrinks.Size = new System.Drawing.Size(114, 51);
            this.pelDrinks.TabIndex = 42;
            this.pelDrinks.Click += new System.EventHandler(this.pelDrinks_Click);
            // 
            // pnlBarbecue
            // 
            this.pnlBarbecue.BackColor = System.Drawing.Color.Transparent;
            this.pnlBarbecue.Location = new System.Drawing.Point(248, 45);
            this.pnlBarbecue.Name = "pnlBarbecue";
            this.pnlBarbecue.Size = new System.Drawing.Size(114, 51);
            this.pnlBarbecue.TabIndex = 43;
            this.pnlBarbecue.Click += new System.EventHandler(this.pnlBarbecue_Click);
            // 
            // pelSnack
            // 
            this.pelSnack.BackColor = System.Drawing.Color.Transparent;
            this.pelSnack.Location = new System.Drawing.Point(365, 45);
            this.pelSnack.Name = "pelSnack";
            this.pelSnack.Size = new System.Drawing.Size(114, 51);
            this.pelSnack.TabIndex = 44;
            this.pelSnack.Click += new System.EventHandler(this.pelSnack_Click);
            // 
            // pelHotdishes
            // 
            this.pelHotdishes.BackColor = System.Drawing.Color.Transparent;
            this.pelHotdishes.Location = new System.Drawing.Point(482, 45);
            this.pelHotdishes.Name = "pelHotdishes";
            this.pelHotdishes.Size = new System.Drawing.Size(114, 51);
            this.pelHotdishes.TabIndex = 45;
            this.pelHotdishes.Click += new System.EventHandler(this.pelHotdishes_Click);
            // 
            // pelColddish
            // 
            this.pelColddish.BackColor = System.Drawing.Color.Transparent;
            this.pelColddish.Location = new System.Drawing.Point(600, 45);
            this.pelColddish.Name = "pelColddish";
            this.pelColddish.Size = new System.Drawing.Size(114, 51);
            this.pelColddish.TabIndex = 46;
            this.pelColddish.Click += new System.EventHandler(this.pelColddish_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // qrIP
            // 
            this.qrIP.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M;
            this.qrIP.Image = ((System.Drawing.Image)(resources.GetObject("qrIP.Image")));
            this.qrIP.Location = new System.Drawing.Point(740, 50);
            this.qrIP.Name = "qrIP";
            this.qrIP.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two;
            this.qrIP.Size = new System.Drawing.Size(150, 150);
            this.qrIP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qrIP.TabIndex = 47;
            this.qrIP.TabStop = false;
            this.qrIP.Text = "192.168.124.1:8998";
            this.qrIP.Visible = false;
            // 
            // pnlConnPhone
            // 
            this.pnlConnPhone.BackColor = System.Drawing.Color.Transparent;
            this.pnlConnPhone.Location = new System.Drawing.Point(755, 0);
            this.pnlConnPhone.Name = "pnlConnPhone";
            this.pnlConnPhone.Size = new System.Drawing.Size(119, 48);
            this.pnlConnPhone.TabIndex = 48;
            this.pnlConnPhone.Click += new System.EventHandler(this.pnlConnPhone_Click);
            // 
            // pnlPause
            // 
            this.pnlPause.BackColor = System.Drawing.Color.Transparent;
            this.pnlPause.Controls.Add(this.lblPause);
            this.pnlPause.Location = new System.Drawing.Point(285, 587);
            this.pnlPause.Name = "pnlPause";
            this.pnlPause.Size = new System.Drawing.Size(57, 91);
            this.pnlPause.TabIndex = 49;
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
            // timBtnStatic
            // 
            this.timBtnStatic.Enabled = true;
            this.timBtnStatic.Tick += new System.EventHandler(this.timBtnStatic_Tick);
            // 
            // FrmFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1092, 679);
            this.Controls.Add(this.pnlPause);
            this.Controls.Add(this.pnlConnPhone);
            this.Controls.Add(this.qrIP);
            this.Controls.Add(this.pelColddish);
            this.Controls.Add(this.pelHotdishes);
            this.Controls.Add(this.pelSnack);
            this.Controls.Add(this.pnlBarbecue);
            this.Controls.Add(this.pelDrinks);
            this.Controls.Add(this.pnlAll);
            this.Controls.Add(this.pnlDel);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlsinger);
            this.Controls.Add(this.pnlShowMain);
            this.Controls.Add(this.pnlNextSong);
            this.Controls.Add(this.pnlSongList);
            this.Controls.Add(this.pnlServer);
            this.Controls.Add(this.pnlLastSong);
            this.Controls.Add(this.pnlFace);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblLastPage);
            this.Controls.Add(this.lblNextPlay);
            this.Controls.Add(this.lblNowPlay);
            this.Controls.Add(this.pnlExit);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lvFoodedList);
            this.Controls.Add(this.lvFoodList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFood";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmFoodManage_Load);
            this.pnlExit.ResumeLayout(false);
            this.pnlExit.PerformLayout();
            this.pnlsinger.ResumeLayout(false);
            this.pnlsinger.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrIP)).EndInit();
            this.pnlPause.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvFoodList;
        private System.Windows.Forms.ImageList imgFoodPhoto;
        private System.Windows.Forms.ListView lvFoodedList;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Panel lblLastPage;
        private System.Windows.Forms.Label lblNextPlay;
        private System.Windows.Forms.Label lblNowPlay;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlsinger;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlShowMain;
        private System.Windows.Forms.Panel pnlNextSong;
        private System.Windows.Forms.Panel pnlSongList;
        private System.Windows.Forms.Panel pnlServer;
        private System.Windows.Forms.Panel pnlLastSong;
        private System.Windows.Forms.Panel pnlFace;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Panel pnlDel;
        private System.Windows.Forms.Panel pnlAll;
        private System.Windows.Forms.Panel pelDrinks;
        private System.Windows.Forms.Panel pnlBarbecue;
        private System.Windows.Forms.Panel pelSnack;
        private System.Windows.Forms.Panel pelHotdishes;
        private System.Windows.Forms.Panel pelColddish;
        private System.Windows.Forms.Timer timer1;
        private Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl qrIP;
        private System.Windows.Forms.Panel pnlConnPhone;
        private System.Windows.Forms.Panel pnlPause;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Timer timBtnStatic;
    }
}