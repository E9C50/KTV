namespace MyKTVClient
{
    partial class FrmSingerType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSingerType));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlConnPhone = new System.Windows.Forms.Panel();
            this.pnlClose = new System.Windows.Forms.Panel();
            this.lblNextPlay = new System.Windows.Forms.Label();
            this.lblNowPlay = new System.Windows.Forms.Label();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlShowMain = new System.Windows.Forms.Panel();
            this.pnlSongList = new System.Windows.Forms.Panel();
            this.pnlNextSong = new System.Windows.Forms.Panel();
            this.pnlLastSong = new System.Windows.Forms.Panel();
            this.pnlServer = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlPause = new System.Windows.Forms.Panel();
            this.lblPause = new System.Windows.Forms.Label();
            this.pnlDel = new System.Windows.Forms.Panel();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.pnlsinger = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlFace = new System.Windows.Forms.Panel();
            this.liSingerImage = new System.Windows.Forms.ImageList(this.components);
            this.pnlCHMan = new System.Windows.Forms.Panel();
            this.pnlCHWomen = new System.Windows.Forms.Panel();
            this.pnlHKMen = new System.Windows.Forms.Panel();
            this.pnlHKWomen = new System.Windows.Forms.Panel();
            this.pnlAUMen = new System.Windows.Forms.Panel();
            this.pnlAUWomen = new System.Windows.Forms.Panel();
            this.pnlCHTeam = new System.Windows.Forms.Panel();
            this.pnlAUTeam = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.qrIP = new Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl();
            this.timBtnStatic = new System.Windows.Forms.Timer(this.components);
            this.pnlTop.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlPause.SuspendLayout();
            this.pnlsinger.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrIP)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.Controls.Add(this.pnlConnPhone);
            this.pnlTop.Controls.Add(this.pnlClose);
            this.pnlTop.Controls.Add(this.lblNextPlay);
            this.pnlTop.Controls.Add(this.lblNowPlay);
            this.pnlTop.Controls.Add(this.pnlExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1092, 55);
            this.pnlTop.TabIndex = 9;
            // 
            // pnlConnPhone
            // 
            this.pnlConnPhone.Location = new System.Drawing.Point(757, 0);
            this.pnlConnPhone.Name = "pnlConnPhone";
            this.pnlConnPhone.Size = new System.Drawing.Size(119, 43);
            this.pnlConnPhone.TabIndex = 31;
            this.pnlConnPhone.Click += new System.EventHandler(this.pnlConnPhone_Click);
            // 
            // pnlClose
            // 
            this.pnlClose.Location = new System.Drawing.Point(990, 0);
            this.pnlClose.Name = "pnlClose";
            this.pnlClose.Size = new System.Drawing.Size(77, 43);
            this.pnlClose.TabIndex = 30;
            this.pnlClose.Click += new System.EventHandler(this.lblLastPage_Click);
            // 
            // lblNextPlay
            // 
            this.lblNextPlay.AutoSize = true;
            this.lblNextPlay.Font = new System.Drawing.Font("宋体", 16F);
            this.lblNextPlay.ForeColor = System.Drawing.Color.White;
            this.lblNextPlay.Location = new System.Drawing.Point(476, 14);
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
            this.lblNowPlay.Location = new System.Drawing.Point(146, 14);
            this.lblNowPlay.Name = "lblNowPlay";
            this.lblNowPlay.Size = new System.Drawing.Size(142, 22);
            this.lblNowPlay.TabIndex = 0;
            this.lblNowPlay.Text = "您还没有点歌";
            // 
            // pnlExit
            // 
            this.pnlExit.BackColor = System.Drawing.Color.Transparent;
            this.pnlExit.Controls.Add(this.label8);
            this.pnlExit.Location = new System.Drawing.Point(882, 0);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(77, 43);
            this.pnlExit.TabIndex = 11;
            this.pnlExit.Click += new System.EventHandler(this.pnlExit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(9, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "结账";
            // 
            // pnlShowMain
            // 
            this.pnlShowMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlShowMain.Location = new System.Drawing.Point(29, 0);
            this.pnlShowMain.Name = "pnlShowMain";
            this.pnlShowMain.Size = new System.Drawing.Size(57, 92);
            this.pnlShowMain.TabIndex = 16;
            this.pnlShowMain.Click += new System.EventHandler(this.pnlShowMain_Click);
            // 
            // pnlSongList
            // 
            this.pnlSongList.BackColor = System.Drawing.Color.Transparent;
            this.pnlSongList.Location = new System.Drawing.Point(921, 0);
            this.pnlSongList.Name = "pnlSongList";
            this.pnlSongList.Size = new System.Drawing.Size(57, 92);
            this.pnlSongList.TabIndex = 12;
            this.pnlSongList.Click += new System.EventHandler(this.pnlSongList_Click);
            // 
            // pnlNextSong
            // 
            this.pnlNextSong.BackColor = System.Drawing.Color.Transparent;
            this.pnlNextSong.Location = new System.Drawing.Point(199, 1);
            this.pnlNextSong.Name = "pnlNextSong";
            this.pnlNextSong.Size = new System.Drawing.Size(57, 91);
            this.pnlNextSong.TabIndex = 13;
            this.pnlNextSong.Click += new System.EventHandler(this.pnlNextSong_Click);
            // 
            // pnlLastSong
            // 
            this.pnlLastSong.BackColor = System.Drawing.Color.Transparent;
            this.pnlLastSong.Location = new System.Drawing.Point(831, 0);
            this.pnlLastSong.Name = "pnlLastSong";
            this.pnlLastSong.Size = new System.Drawing.Size(57, 92);
            this.pnlLastSong.TabIndex = 14;
            this.pnlLastSong.Click += new System.EventHandler(this.pnlLastSong_Click);
            // 
            // pnlServer
            // 
            this.pnlServer.BackColor = System.Drawing.Color.Transparent;
            this.pnlServer.Location = new System.Drawing.Point(114, 0);
            this.pnlServer.Name = "pnlServer";
            this.pnlServer.Size = new System.Drawing.Size(57, 92);
            this.pnlServer.TabIndex = 15;
            this.pnlServer.Click += new System.EventHandler(this.pnlServer_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnlBottom.Controls.Add(this.pnlPause);
            this.pnlBottom.Controls.Add(this.pnlDel);
            this.pnlBottom.Controls.Add(this.pnlAdd);
            this.pnlBottom.Controls.Add(this.pnlsinger);
            this.pnlBottom.Controls.Add(this.label10);
            this.pnlBottom.Controls.Add(this.label9);
            this.pnlBottom.Controls.Add(this.label2);
            this.pnlBottom.Controls.Add(this.pnlSongList);
            this.pnlBottom.Controls.Add(this.pnlNextSong);
            this.pnlBottom.Controls.Add(this.pnlServer);
            this.pnlBottom.Controls.Add(this.pnlLastSong);
            this.pnlBottom.Controls.Add(this.pnlShowMain);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 587);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1092, 92);
            this.pnlBottom.TabIndex = 17;
            // 
            // pnlPause
            // 
            this.pnlPause.BackColor = System.Drawing.Color.Transparent;
            this.pnlPause.Controls.Add(this.lblPause);
            this.pnlPause.Location = new System.Drawing.Point(288, 1);
            this.pnlPause.Name = "pnlPause";
            this.pnlPause.Size = new System.Drawing.Size(57, 91);
            this.pnlPause.TabIndex = 31;
            this.pnlPause.Click += new System.EventHandler(this.pnlPause_Click);
            // 
            // lblPause
            // 
            this.lblPause.BackColor = System.Drawing.Color.Black;
            this.lblPause.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.lblPause.ForeColor = System.Drawing.Color.White;
            this.lblPause.Location = new System.Drawing.Point(3, 60);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(51, 24);
            this.lblPause.TabIndex = 0;
            this.lblPause.Text = "暂停";
            // 
            // pnlDel
            // 
            this.pnlDel.BackColor = System.Drawing.Color.Transparent;
            this.pnlDel.Location = new System.Drawing.Point(662, 1);
            this.pnlDel.Name = "pnlDel";
            this.pnlDel.Size = new System.Drawing.Size(57, 91);
            this.pnlDel.TabIndex = 14;
            this.pnlDel.Click += new System.EventHandler(this.pnlDel_Click);
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.Transparent;
            this.pnlAdd.Location = new System.Drawing.Point(380, 1);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(57, 91);
            this.pnlAdd.TabIndex = 14;
            this.pnlAdd.Click += new System.EventHandler(this.pnlAdd_Click);
            // 
            // pnlsinger
            // 
            this.pnlsinger.BackColor = System.Drawing.Color.Transparent;
            this.pnlsinger.Controls.Add(this.label3);
            this.pnlsinger.Location = new System.Drawing.Point(747, 0);
            this.pnlsinger.Name = "pnlsinger";
            this.pnlsinger.Size = new System.Drawing.Size(57, 92);
            this.pnlsinger.TabIndex = 25;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(974, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "气氛";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(894, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "灯光";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(96, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "音量";
            // 
            // pnlFace
            // 
            this.pnlFace.BackColor = System.Drawing.Color.Transparent;
            this.pnlFace.Location = new System.Drawing.Point(1010, 586);
            this.pnlFace.Name = "pnlFace";
            this.pnlFace.Size = new System.Drawing.Size(57, 93);
            this.pnlFace.TabIndex = 29;
            this.pnlFace.Click += new System.EventHandler(this.pnlFace_Click);
            // 
            // liSingerImage
            // 
            this.liSingerImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("liSingerImage.ImageStream")));
            this.liSingerImage.TransparentColor = System.Drawing.Color.Transparent;
            this.liSingerImage.Images.SetKeyName(0, "Justin Bieber.jpg");
            this.liSingerImage.Images.SetKeyName(1, "Michael Jackson.jpg");
            this.liSingerImage.Images.SetKeyName(2, "Taylor Swift.jpg");
            this.liSingerImage.Images.SetKeyName(3, "邓紫棋.jpg");
            this.liSingerImage.Images.SetKeyName(4, "动力火车.jpg");
            this.liSingerImage.Images.SetKeyName(5, "梁静茹.jpg");
            this.liSingerImage.Images.SetKeyName(6, "林俊杰.jpg");
            this.liSingerImage.Images.SetKeyName(7, "七朵组合.jpg");
            this.liSingerImage.Images.SetKeyName(8, "五月天.jpg");
            this.liSingerImage.Images.SetKeyName(9, "姚贝娜.jpg");
            this.liSingerImage.Images.SetKeyName(10, "张杰.jpg");
            this.liSingerImage.Images.SetKeyName(11, "周杰伦.jpg");
            // 
            // pnlCHMan
            // 
            this.pnlCHMan.BackColor = System.Drawing.Color.Transparent;
            this.pnlCHMan.Location = new System.Drawing.Point(82, 118);
            this.pnlCHMan.Name = "pnlCHMan";
            this.pnlCHMan.Size = new System.Drawing.Size(168, 195);
            this.pnlCHMan.TabIndex = 18;
            this.pnlCHMan.Click += new System.EventHandler(this.pnlCHMan_Click);
            // 
            // pnlCHWomen
            // 
            this.pnlCHWomen.BackColor = System.Drawing.Color.Transparent;
            this.pnlCHWomen.Location = new System.Drawing.Point(338, 118);
            this.pnlCHWomen.Name = "pnlCHWomen";
            this.pnlCHWomen.Size = new System.Drawing.Size(168, 195);
            this.pnlCHWomen.TabIndex = 19;
            this.pnlCHWomen.Click += new System.EventHandler(this.pnlCHWomen_Click);
            // 
            // pnlHKMen
            // 
            this.pnlHKMen.BackColor = System.Drawing.Color.Transparent;
            this.pnlHKMen.Location = new System.Drawing.Point(622, 118);
            this.pnlHKMen.Name = "pnlHKMen";
            this.pnlHKMen.Size = new System.Drawing.Size(168, 195);
            this.pnlHKMen.TabIndex = 19;
            this.pnlHKMen.Click += new System.EventHandler(this.pnlHKMen_Click);
            // 
            // pnlHKWomen
            // 
            this.pnlHKWomen.BackColor = System.Drawing.Color.Transparent;
            this.pnlHKWomen.Location = new System.Drawing.Point(876, 118);
            this.pnlHKWomen.Name = "pnlHKWomen";
            this.pnlHKWomen.Size = new System.Drawing.Size(168, 195);
            this.pnlHKWomen.TabIndex = 20;
            this.pnlHKWomen.Click += new System.EventHandler(this.pnlHKWomen_Click);
            // 
            // pnlAUMen
            // 
            this.pnlAUMen.BackColor = System.Drawing.Color.Transparent;
            this.pnlAUMen.Location = new System.Drawing.Point(81, 319);
            this.pnlAUMen.Name = "pnlAUMen";
            this.pnlAUMen.Size = new System.Drawing.Size(168, 195);
            this.pnlAUMen.TabIndex = 21;
            this.pnlAUMen.Click += new System.EventHandler(this.pnlAUMen_Click);
            // 
            // pnlAUWomen
            // 
            this.pnlAUWomen.BackColor = System.Drawing.Color.Transparent;
            this.pnlAUWomen.Location = new System.Drawing.Point(338, 319);
            this.pnlAUWomen.Name = "pnlAUWomen";
            this.pnlAUWomen.Size = new System.Drawing.Size(168, 195);
            this.pnlAUWomen.TabIndex = 22;
            this.pnlAUWomen.Click += new System.EventHandler(this.pnlAUWomen_Click);
            // 
            // pnlCHTeam
            // 
            this.pnlCHTeam.BackColor = System.Drawing.Color.Transparent;
            this.pnlCHTeam.Location = new System.Drawing.Point(622, 319);
            this.pnlCHTeam.Name = "pnlCHTeam";
            this.pnlCHTeam.Size = new System.Drawing.Size(168, 195);
            this.pnlCHTeam.TabIndex = 23;
            this.pnlCHTeam.Click += new System.EventHandler(this.pnlCHTeam_Click);
            // 
            // pnlAUTeam
            // 
            this.pnlAUTeam.BackColor = System.Drawing.Color.Transparent;
            this.pnlAUTeam.Location = new System.Drawing.Point(876, 319);
            this.pnlAUTeam.Name = "pnlAUTeam";
            this.pnlAUTeam.Size = new System.Drawing.Size(168, 195);
            this.pnlAUTeam.TabIndex = 24;
            this.pnlAUTeam.Click += new System.EventHandler(this.pnlAUTeam_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(846, 456);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 125);
            this.panel2.TabIndex = 29;
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
            // qrIP
            // 
            this.qrIP.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M;
            this.qrIP.Image = ((System.Drawing.Image)(resources.GetObject("qrIP.Image")));
            this.qrIP.Location = new System.Drawing.Point(738, 46);
            this.qrIP.Name = "qrIP";
            this.qrIP.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two;
            this.qrIP.Size = new System.Drawing.Size(150, 150);
            this.qrIP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qrIP.TabIndex = 30;
            this.qrIP.TabStop = false;
            this.qrIP.Text = "192.168.124.1:8998";
            this.qrIP.Visible = false;
            // 
            // timBtnStatic
            // 
            this.timBtnStatic.Enabled = true;
            this.timBtnStatic.Tick += new System.EventHandler(this.timBtnStatic_Tick);
            // 
            // FrmSingerType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1092, 679);
            this.Controls.Add(this.qrIP);
            this.Controls.Add(this.pnlFace);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlAUTeam);
            this.Controls.Add(this.pnlCHTeam);
            this.Controls.Add(this.pnlAUWomen);
            this.Controls.Add(this.pnlAUMen);
            this.Controls.Add(this.pnlHKWomen);
            this.Controls.Add(this.pnlHKMen);
            this.Controls.Add(this.pnlCHWomen);
            this.Controls.Add(this.pnlCHMan);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSingerType";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SingerSearch";
            this.Load += new System.EventHandler(this.FrmSingerType_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlExit.ResumeLayout(false);
            this.pnlExit.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlPause.ResumeLayout(false);
            this.pnlsinger.ResumeLayout(false);
            this.pnlsinger.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrIP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblNextPlay;
        private System.Windows.Forms.Label lblNowPlay;
        private System.Windows.Forms.Panel pnlShowMain;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.Panel pnlSongList;
        private System.Windows.Forms.Panel pnlNextSong;
        private System.Windows.Forms.Panel pnlLastSong;
        private System.Windows.Forms.Panel pnlServer;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.ImageList liSingerImage;
        private System.Windows.Forms.Panel pnlCHMan;
        private System.Windows.Forms.Panel pnlCHWomen;
        private System.Windows.Forms.Panel pnlHKMen;
        private System.Windows.Forms.Panel pnlHKWomen;
        private System.Windows.Forms.Panel pnlAUMen;
        private System.Windows.Forms.Panel pnlAUWomen;
        private System.Windows.Forms.Panel pnlCHTeam;
        private System.Windows.Forms.Panel pnlAUTeam;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlsinger;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlFace;
        private System.Windows.Forms.Panel pnlClose;
        private System.Windows.Forms.Panel pnlDel;
        private System.Windows.Forms.Panel pnlAdd;
        private Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl qrIP;
        private System.Windows.Forms.Panel pnlConnPhone;
        private System.Windows.Forms.Panel pnlPause;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Timer timBtnStatic;
    }
}