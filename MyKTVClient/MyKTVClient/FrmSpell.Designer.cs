namespace MyKTVClient
{
    partial class FrmSpell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSpell));
            this.lblNowPlay = new System.Windows.Forms.Label();
            this.lblNextPlay = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlConnPhone = new System.Windows.Forms.Panel();
            this.lblLastPage = new System.Windows.Forms.Panel();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lvSongList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlLastSong = new System.Windows.Forms.Panel();
            this.pnlNextSong = new System.Windows.Forms.Panel();
            this.pnlServer = new System.Windows.Forms.Panel();
            this.pnlSongList = new System.Windows.Forms.Panel();
            this.pnlShowMain = new System.Windows.Forms.Panel();
            this.pnlsinger = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlPause = new System.Windows.Forms.Panel();
            this.lblPause = new System.Windows.Forms.Label();
            this.pnlDel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlFace = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSpell = new System.Windows.Forms.Label();
            this.pnlA = new System.Windows.Forms.Panel();
            this.pnlB = new System.Windows.Forms.Panel();
            this.pnlC = new System.Windows.Forms.Panel();
            this.pnlD = new System.Windows.Forms.Panel();
            this.pnlE = new System.Windows.Forms.Panel();
            this.pnlF = new System.Windows.Forms.Panel();
            this.pnlG = new System.Windows.Forms.Panel();
            this.pnlH = new System.Windows.Forms.Panel();
            this.pnlI = new System.Windows.Forms.Panel();
            this.pnlJ = new System.Windows.Forms.Panel();
            this.pnlK = new System.Windows.Forms.Panel();
            this.pnlL = new System.Windows.Forms.Panel();
            this.pnlM = new System.Windows.Forms.Panel();
            this.pnlN = new System.Windows.Forms.Panel();
            this.pnlO = new System.Windows.Forms.Panel();
            this.pnlP = new System.Windows.Forms.Panel();
            this.pnlQ = new System.Windows.Forms.Panel();
            this.pnlR = new System.Windows.Forms.Panel();
            this.pnlS = new System.Windows.Forms.Panel();
            this.pnlT = new System.Windows.Forms.Panel();
            this.pnlU = new System.Windows.Forms.Panel();
            this.pnlV = new System.Windows.Forms.Panel();
            this.pnlW = new System.Windows.Forms.Panel();
            this.pnlX = new System.Windows.Forms.Panel();
            this.pnlY = new System.Windows.Forms.Panel();
            this.pnlZ = new System.Windows.Forms.Panel();
            this.pnlDelete = new System.Windows.Forms.Panel();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.qrIP = new Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl();
            this.timBtnStatic = new System.Windows.Forms.Timer(this.components);
            this.pnlTop.SuspendLayout();
            this.pnlExit.SuspendLayout();
            this.pnlsinger.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlPause.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlFace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrIP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNowPlay
            // 
            this.lblNowPlay.AutoSize = true;
            this.lblNowPlay.Font = new System.Drawing.Font("宋体", 16F);
            this.lblNowPlay.ForeColor = System.Drawing.Color.White;
            this.lblNowPlay.Location = new System.Drawing.Point(151, 15);
            this.lblNowPlay.Name = "lblNowPlay";
            this.lblNowPlay.Size = new System.Drawing.Size(142, 22);
            this.lblNowPlay.TabIndex = 0;
            this.lblNowPlay.Text = "您还没有点歌";
            // 
            // lblNextPlay
            // 
            this.lblNextPlay.AutoSize = true;
            this.lblNextPlay.Font = new System.Drawing.Font("宋体", 16F);
            this.lblNextPlay.ForeColor = System.Drawing.Color.White;
            this.lblNextPlay.Location = new System.Drawing.Point(473, 14);
            this.lblNextPlay.Name = "lblNextPlay";
            this.lblNextPlay.Size = new System.Drawing.Size(142, 22);
            this.lblNextPlay.TabIndex = 1;
            this.lblNextPlay.Text = "您还没有点歌";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.Controls.Add(this.pnlConnPhone);
            this.pnlTop.Controls.Add(this.lblLastPage);
            this.pnlTop.Controls.Add(this.lblNextPlay);
            this.pnlTop.Controls.Add(this.lblNowPlay);
            this.pnlTop.Controls.Add(this.pnlExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1092, 65);
            this.pnlTop.TabIndex = 20;
            // 
            // pnlConnPhone
            // 
            this.pnlConnPhone.Location = new System.Drawing.Point(755, 0);
            this.pnlConnPhone.Name = "pnlConnPhone";
            this.pnlConnPhone.Size = new System.Drawing.Size(119, 49);
            this.pnlConnPhone.TabIndex = 43;
            this.pnlConnPhone.Click += new System.EventHandler(this.pnlConnPhone_Click);
            // 
            // lblLastPage
            // 
            this.lblLastPage.Location = new System.Drawing.Point(987, 0);
            this.lblLastPage.Name = "lblLastPage";
            this.lblLastPage.Size = new System.Drawing.Size(85, 47);
            this.lblLastPage.TabIndex = 37;
            this.lblLastPage.Click += new System.EventHandler(this.lblLastPage_Click);
            // 
            // pnlExit
            // 
            this.pnlExit.BackColor = System.Drawing.Color.Transparent;
            this.pnlExit.Controls.Add(this.label8);
            this.pnlExit.Location = new System.Drawing.Point(880, 0);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(85, 47);
            this.pnlExit.TabIndex = 11;
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
            // lvSongList
            // 
            this.lvSongList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvSongList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvSongList.BackgroundImage")));
            this.lvSongList.BackgroundImageTiled = true;
            this.lvSongList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSongList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvSongList.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvSongList.ForeColor = System.Drawing.Color.White;
            this.lvSongList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvSongList.Location = new System.Drawing.Point(0, 65);
            this.lvSongList.Name = "lvSongList";
            this.lvSongList.Size = new System.Drawing.Size(694, 520);
            this.lvSongList.TabIndex = 24;
            this.lvSongList.UseCompatibleStateImageBehavior = false;
            this.lvSongList.View = System.Windows.Forms.View.Details;
            this.lvSongList.Click += new System.EventHandler(this.lvSongList_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 449;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 214;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlLastSong
            // 
            this.pnlLastSong.BackColor = System.Drawing.Color.Transparent;
            this.pnlLastSong.Location = new System.Drawing.Point(829, 0);
            this.pnlLastSong.Name = "pnlLastSong";
            this.pnlLastSong.Size = new System.Drawing.Size(57, 92);
            this.pnlLastSong.TabIndex = 14;
            this.pnlLastSong.Click += new System.EventHandler(this.pnlLastSong_Click);
            // 
            // pnlNextSong
            // 
            this.pnlNextSong.BackColor = System.Drawing.Color.Transparent;
            this.pnlNextSong.Location = new System.Drawing.Point(199, 0);
            this.pnlNextSong.Name = "pnlNextSong";
            this.pnlNextSong.Size = new System.Drawing.Size(57, 92);
            this.pnlNextSong.TabIndex = 13;
            this.pnlNextSong.Click += new System.EventHandler(this.pnlNextSong_Click);
            // 
            // pnlServer
            // 
            this.pnlServer.BackColor = System.Drawing.Color.Transparent;
            this.pnlServer.Location = new System.Drawing.Point(115, 0);
            this.pnlServer.Name = "pnlServer";
            this.pnlServer.Size = new System.Drawing.Size(57, 93);
            this.pnlServer.TabIndex = 15;
            this.pnlServer.Click += new System.EventHandler(this.pnlServer_Click);
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
            // pnlShowMain
            // 
            this.pnlShowMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlShowMain.Location = new System.Drawing.Point(28, 0);
            this.pnlShowMain.Name = "pnlShowMain";
            this.pnlShowMain.Size = new System.Drawing.Size(57, 92);
            this.pnlShowMain.TabIndex = 16;
            this.pnlShowMain.Click += new System.EventHandler(this.pnlShowMain_Click);
            // 
            // pnlsinger
            // 
            this.pnlsinger.BackColor = System.Drawing.Color.Transparent;
            this.pnlsinger.Controls.Add(this.label3);
            this.pnlsinger.Location = new System.Drawing.Point(745, 0);
            this.pnlsinger.Name = "pnlsinger";
            this.pnlsinger.Size = new System.Drawing.Size(57, 93);
            this.pnlsinger.TabIndex = 35;
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
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnlBottom.Controls.Add(this.pnlPause);
            this.pnlBottom.Controls.Add(this.pnlDel);
            this.pnlBottom.Controls.Add(this.panel1);
            this.pnlBottom.Controls.Add(this.pnlsinger);
            this.pnlBottom.Controls.Add(this.pnlShowMain);
            this.pnlBottom.Controls.Add(this.pnlSongList);
            this.pnlBottom.Controls.Add(this.pnlServer);
            this.pnlBottom.Controls.Add(this.pnlNextSong);
            this.pnlBottom.Controls.Add(this.pnlLastSong);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 587);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1092, 92);
            this.pnlBottom.TabIndex = 21;
            // 
            // pnlPause
            // 
            this.pnlPause.BackColor = System.Drawing.Color.Transparent;
            this.pnlPause.Controls.Add(this.lblPause);
            this.pnlPause.Location = new System.Drawing.Point(285, 1);
            this.pnlPause.Name = "pnlPause";
            this.pnlPause.Size = new System.Drawing.Size(57, 91);
            this.pnlPause.TabIndex = 43;
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
            // pnlDel
            // 
            this.pnlDel.BackColor = System.Drawing.Color.Transparent;
            this.pnlDel.Location = new System.Drawing.Point(663, 0);
            this.pnlDel.Name = "pnlDel";
            this.pnlDel.Size = new System.Drawing.Size(57, 92);
            this.pnlDel.TabIndex = 15;
            this.pnlDel.Click += new System.EventHandler(this.pnlDel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(1009, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(57, 92);
            this.panel1.TabIndex = 36;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.pnlFace);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(871, 555);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 125);
            this.panel2.TabIndex = 36;
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
            // txtSpell
            // 
            this.txtSpell.AutoSize = true;
            this.txtSpell.BackColor = System.Drawing.Color.Transparent;
            this.txtSpell.Font = new System.Drawing.Font("宋体", 20F);
            this.txtSpell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtSpell.Location = new System.Drawing.Point(789, 143);
            this.txtSpell.Name = "txtSpell";
            this.txtSpell.Size = new System.Drawing.Size(96, 27);
            this.txtSpell.TabIndex = 37;
            this.txtSpell.Text = "label1";
            this.txtSpell.TextChanged += new System.EventHandler(this.txtSpell_TextChanged);
            // 
            // pnlA
            // 
            this.pnlA.BackColor = System.Drawing.Color.Transparent;
            this.pnlA.Location = new System.Drawing.Point(694, 190);
            this.pnlA.Name = "pnlA";
            this.pnlA.Size = new System.Drawing.Size(48, 70);
            this.pnlA.TabIndex = 38;
            this.pnlA.Click += new System.EventHandler(this.pnlA_Click);
            // 
            // pnlB
            // 
            this.pnlB.BackColor = System.Drawing.Color.Transparent;
            this.pnlB.Location = new System.Drawing.Point(745, 190);
            this.pnlB.Name = "pnlB";
            this.pnlB.Size = new System.Drawing.Size(48, 70);
            this.pnlB.TabIndex = 39;
            this.pnlB.Click += new System.EventHandler(this.pnlB_Click);
            // 
            // pnlC
            // 
            this.pnlC.BackColor = System.Drawing.Color.Transparent;
            this.pnlC.Location = new System.Drawing.Point(797, 190);
            this.pnlC.Name = "pnlC";
            this.pnlC.Size = new System.Drawing.Size(48, 70);
            this.pnlC.TabIndex = 39;
            this.pnlC.Click += new System.EventHandler(this.pnlC_Click);
            // 
            // pnlD
            // 
            this.pnlD.BackColor = System.Drawing.Color.Transparent;
            this.pnlD.Location = new System.Drawing.Point(848, 191);
            this.pnlD.Name = "pnlD";
            this.pnlD.Size = new System.Drawing.Size(48, 70);
            this.pnlD.TabIndex = 39;
            this.pnlD.Click += new System.EventHandler(this.pnlD_Click);
            // 
            // pnlE
            // 
            this.pnlE.BackColor = System.Drawing.Color.Transparent;
            this.pnlE.Location = new System.Drawing.Point(900, 191);
            this.pnlE.Name = "pnlE";
            this.pnlE.Size = new System.Drawing.Size(48, 70);
            this.pnlE.TabIndex = 40;
            this.pnlE.Click += new System.EventHandler(this.pnlE_Click);
            // 
            // pnlF
            // 
            this.pnlF.BackColor = System.Drawing.Color.Transparent;
            this.pnlF.Location = new System.Drawing.Point(952, 191);
            this.pnlF.Name = "pnlF";
            this.pnlF.Size = new System.Drawing.Size(48, 70);
            this.pnlF.TabIndex = 39;
            this.pnlF.Click += new System.EventHandler(this.pnlF_Click);
            // 
            // pnlG
            // 
            this.pnlG.BackColor = System.Drawing.Color.Transparent;
            this.pnlG.Location = new System.Drawing.Point(1006, 191);
            this.pnlG.Name = "pnlG";
            this.pnlG.Size = new System.Drawing.Size(48, 70);
            this.pnlG.TabIndex = 39;
            this.pnlG.Click += new System.EventHandler(this.pnlG_Click);
            // 
            // pnlH
            // 
            this.pnlH.BackColor = System.Drawing.Color.Transparent;
            this.pnlH.Location = new System.Drawing.Point(718, 267);
            this.pnlH.Name = "pnlH";
            this.pnlH.Size = new System.Drawing.Size(48, 70);
            this.pnlH.TabIndex = 40;
            this.pnlH.Click += new System.EventHandler(this.pnlH_Click);
            // 
            // pnlI
            // 
            this.pnlI.BackColor = System.Drawing.Color.Transparent;
            this.pnlI.Location = new System.Drawing.Point(769, 267);
            this.pnlI.Name = "pnlI";
            this.pnlI.Size = new System.Drawing.Size(48, 70);
            this.pnlI.TabIndex = 40;
            this.pnlI.Click += new System.EventHandler(this.pnlI_Click);
            // 
            // pnlJ
            // 
            this.pnlJ.BackColor = System.Drawing.Color.Transparent;
            this.pnlJ.Location = new System.Drawing.Point(821, 267);
            this.pnlJ.Name = "pnlJ";
            this.pnlJ.Size = new System.Drawing.Size(48, 70);
            this.pnlJ.TabIndex = 40;
            this.pnlJ.Click += new System.EventHandler(this.pnlJ_Click);
            // 
            // pnlK
            // 
            this.pnlK.BackColor = System.Drawing.Color.Transparent;
            this.pnlK.Location = new System.Drawing.Point(872, 267);
            this.pnlK.Name = "pnlK";
            this.pnlK.Size = new System.Drawing.Size(48, 70);
            this.pnlK.TabIndex = 40;
            this.pnlK.Click += new System.EventHandler(this.pnlK_Click);
            // 
            // pnlL
            // 
            this.pnlL.BackColor = System.Drawing.Color.Transparent;
            this.pnlL.Location = new System.Drawing.Point(925, 267);
            this.pnlL.Name = "pnlL";
            this.pnlL.Size = new System.Drawing.Size(48, 70);
            this.pnlL.TabIndex = 40;
            this.pnlL.Click += new System.EventHandler(this.pnlL_Click);
            // 
            // pnlM
            // 
            this.pnlM.BackColor = System.Drawing.Color.Transparent;
            this.pnlM.Location = new System.Drawing.Point(977, 267);
            this.pnlM.Name = "pnlM";
            this.pnlM.Size = new System.Drawing.Size(48, 70);
            this.pnlM.TabIndex = 40;
            this.pnlM.Click += new System.EventHandler(this.pnlM_Click);
            // 
            // pnlN
            // 
            this.pnlN.BackColor = System.Drawing.Color.Transparent;
            this.pnlN.Location = new System.Drawing.Point(694, 342);
            this.pnlN.Name = "pnlN";
            this.pnlN.Size = new System.Drawing.Size(48, 70);
            this.pnlN.TabIndex = 41;
            this.pnlN.Click += new System.EventHandler(this.pnlN_Click);
            // 
            // pnlO
            // 
            this.pnlO.BackColor = System.Drawing.Color.Transparent;
            this.pnlO.Location = new System.Drawing.Point(745, 342);
            this.pnlO.Name = "pnlO";
            this.pnlO.Size = new System.Drawing.Size(48, 70);
            this.pnlO.TabIndex = 40;
            this.pnlO.Click += new System.EventHandler(this.pnlO_Click);
            // 
            // pnlP
            // 
            this.pnlP.BackColor = System.Drawing.Color.Transparent;
            this.pnlP.Location = new System.Drawing.Point(797, 342);
            this.pnlP.Name = "pnlP";
            this.pnlP.Size = new System.Drawing.Size(48, 70);
            this.pnlP.TabIndex = 40;
            this.pnlP.Click += new System.EventHandler(this.pnlP_Click);
            // 
            // pnlQ
            // 
            this.pnlQ.BackColor = System.Drawing.Color.Transparent;
            this.pnlQ.Location = new System.Drawing.Point(848, 343);
            this.pnlQ.Name = "pnlQ";
            this.pnlQ.Size = new System.Drawing.Size(48, 70);
            this.pnlQ.TabIndex = 40;
            this.pnlQ.Click += new System.EventHandler(this.pnlQ_Click);
            // 
            // pnlR
            // 
            this.pnlR.BackColor = System.Drawing.Color.Transparent;
            this.pnlR.Location = new System.Drawing.Point(901, 342);
            this.pnlR.Name = "pnlR";
            this.pnlR.Size = new System.Drawing.Size(48, 70);
            this.pnlR.TabIndex = 40;
            this.pnlR.Click += new System.EventHandler(this.pnlR_Click);
            // 
            // pnlS
            // 
            this.pnlS.BackColor = System.Drawing.Color.Transparent;
            this.pnlS.Location = new System.Drawing.Point(952, 342);
            this.pnlS.Name = "pnlS";
            this.pnlS.Size = new System.Drawing.Size(48, 70);
            this.pnlS.TabIndex = 40;
            this.pnlS.Click += new System.EventHandler(this.pnlS_Click);
            // 
            // pnlT
            // 
            this.pnlT.BackColor = System.Drawing.Color.Transparent;
            this.pnlT.Location = new System.Drawing.Point(1006, 342);
            this.pnlT.Name = "pnlT";
            this.pnlT.Size = new System.Drawing.Size(48, 70);
            this.pnlT.TabIndex = 40;
            this.pnlT.Click += new System.EventHandler(this.pnlT_Click);
            // 
            // pnlU
            // 
            this.pnlU.BackColor = System.Drawing.Color.Transparent;
            this.pnlU.Location = new System.Drawing.Point(718, 417);
            this.pnlU.Name = "pnlU";
            this.pnlU.Size = new System.Drawing.Size(48, 70);
            this.pnlU.TabIndex = 40;
            this.pnlU.Click += new System.EventHandler(this.pnlU_Click);
            // 
            // pnlV
            // 
            this.pnlV.BackColor = System.Drawing.Color.Transparent;
            this.pnlV.Location = new System.Drawing.Point(769, 417);
            this.pnlV.Name = "pnlV";
            this.pnlV.Size = new System.Drawing.Size(48, 70);
            this.pnlV.TabIndex = 40;
            this.pnlV.Click += new System.EventHandler(this.pnlV_Click);
            // 
            // pnlW
            // 
            this.pnlW.BackColor = System.Drawing.Color.Transparent;
            this.pnlW.Location = new System.Drawing.Point(823, 417);
            this.pnlW.Name = "pnlW";
            this.pnlW.Size = new System.Drawing.Size(48, 70);
            this.pnlW.TabIndex = 40;
            this.pnlW.Click += new System.EventHandler(this.pnlW_Click);
            // 
            // pnlX
            // 
            this.pnlX.BackColor = System.Drawing.Color.Transparent;
            this.pnlX.Location = new System.Drawing.Point(875, 417);
            this.pnlX.Name = "pnlX";
            this.pnlX.Size = new System.Drawing.Size(48, 70);
            this.pnlX.TabIndex = 40;
            this.pnlX.Click += new System.EventHandler(this.pnlX_Click);
            // 
            // pnlY
            // 
            this.pnlY.BackColor = System.Drawing.Color.Transparent;
            this.pnlY.Location = new System.Drawing.Point(926, 417);
            this.pnlY.Name = "pnlY";
            this.pnlY.Size = new System.Drawing.Size(48, 70);
            this.pnlY.TabIndex = 40;
            this.pnlY.Click += new System.EventHandler(this.pnlY_Click);
            // 
            // pnlZ
            // 
            this.pnlZ.BackColor = System.Drawing.Color.Transparent;
            this.pnlZ.Location = new System.Drawing.Point(977, 417);
            this.pnlZ.Name = "pnlZ";
            this.pnlZ.Size = new System.Drawing.Size(48, 70);
            this.pnlZ.TabIndex = 40;
            this.pnlZ.Click += new System.EventHandler(this.pnlZ_Click);
            // 
            // pnlDelete
            // 
            this.pnlDelete.BackColor = System.Drawing.Color.Transparent;
            this.pnlDelete.Location = new System.Drawing.Point(996, 136);
            this.pnlDelete.Name = "pnlDelete";
            this.pnlDelete.Size = new System.Drawing.Size(48, 40);
            this.pnlDelete.TabIndex = 40;
            this.pnlDelete.Click += new System.EventHandler(this.pnlDelete_Click);
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.Transparent;
            this.pnlAdd.Location = new System.Drawing.Point(379, 587);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(57, 92);
            this.pnlAdd.TabIndex = 14;
            this.pnlAdd.Click += new System.EventHandler(this.pnlAdd_Click);
            // 
            // qrIP
            // 
            this.qrIP.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M;
            this.qrIP.Image = ((System.Drawing.Image)(resources.GetObject("qrIP.Image")));
            this.qrIP.Location = new System.Drawing.Point(734, 49);
            this.qrIP.Name = "qrIP";
            this.qrIP.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two;
            this.qrIP.Size = new System.Drawing.Size(150, 150);
            this.qrIP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qrIP.TabIndex = 42;
            this.qrIP.TabStop = false;
            this.qrIP.Text = "192.168.124.1:8998";
            this.qrIP.Visible = false;
            // 
            // timBtnStatic
            // 
            this.timBtnStatic.Enabled = true;
            this.timBtnStatic.Tick += new System.EventHandler(this.timBtnStatic_Tick);
            // 
            // FrmSpell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1092, 679);
            this.Controls.Add(this.qrIP);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.pnlDelete);
            this.Controls.Add(this.pnlZ);
            this.Controls.Add(this.pnlY);
            this.Controls.Add(this.pnlX);
            this.Controls.Add(this.pnlW);
            this.Controls.Add(this.pnlV);
            this.Controls.Add(this.pnlU);
            this.Controls.Add(this.pnlT);
            this.Controls.Add(this.pnlS);
            this.Controls.Add(this.pnlR);
            this.Controls.Add(this.pnlQ);
            this.Controls.Add(this.pnlP);
            this.Controls.Add(this.pnlO);
            this.Controls.Add(this.pnlN);
            this.Controls.Add(this.pnlM);
            this.Controls.Add(this.pnlL);
            this.Controls.Add(this.pnlK);
            this.Controls.Add(this.pnlJ);
            this.Controls.Add(this.pnlI);
            this.Controls.Add(this.pnlH);
            this.Controls.Add(this.pnlG);
            this.Controls.Add(this.pnlF);
            this.Controls.Add(this.pnlE);
            this.Controls.Add(this.pnlD);
            this.Controls.Add(this.pnlC);
            this.Controls.Add(this.pnlB);
            this.Controls.Add(this.pnlA);
            this.Controls.Add(this.txtSpell);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lvSongList);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSpell";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSongList";
            this.Load += new System.EventHandler(this.FrmSongList_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlExit.ResumeLayout(false);
            this.pnlExit.PerformLayout();
            this.pnlsinger.ResumeLayout(false);
            this.pnlsinger.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlPause.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlFace.ResumeLayout(false);
            this.pnlFace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrIP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNowPlay;
        private System.Windows.Forms.Label lblNextPlay;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.ListView lvSongList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlLastSong;
        private System.Windows.Forms.Panel pnlNextSong;
        private System.Windows.Forms.Panel pnlServer;
        private System.Windows.Forms.Panel pnlSongList;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlShowMain;
        private System.Windows.Forms.Panel pnlsinger;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlFace;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel lblLastPage;
        private System.Windows.Forms.Label txtSpell;
        private System.Windows.Forms.Panel pnlA;
        private System.Windows.Forms.Panel pnlB;
        private System.Windows.Forms.Panel pnlC;
        private System.Windows.Forms.Panel pnlD;
        private System.Windows.Forms.Panel pnlE;
        private System.Windows.Forms.Panel pnlF;
        private System.Windows.Forms.Panel pnlG;
        private System.Windows.Forms.Panel pnlH;
        private System.Windows.Forms.Panel pnlI;
        private System.Windows.Forms.Panel pnlJ;
        private System.Windows.Forms.Panel pnlK;
        private System.Windows.Forms.Panel pnlL;
        private System.Windows.Forms.Panel pnlM;
        private System.Windows.Forms.Panel pnlN;
        private System.Windows.Forms.Panel pnlO;
        private System.Windows.Forms.Panel pnlP;
        private System.Windows.Forms.Panel pnlQ;
        private System.Windows.Forms.Panel pnlR;
        private System.Windows.Forms.Panel pnlS;
        private System.Windows.Forms.Panel pnlT;
        private System.Windows.Forms.Panel pnlU;
        private System.Windows.Forms.Panel pnlV;
        private System.Windows.Forms.Panel pnlW;
        private System.Windows.Forms.Panel pnlX;
        private System.Windows.Forms.Panel pnlY;
        private System.Windows.Forms.Panel pnlZ;
        private System.Windows.Forms.Panel pnlDelete;
        private System.Windows.Forms.Panel pnlDel;
        private System.Windows.Forms.Panel pnlAdd;
        private Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl qrIP;
        private System.Windows.Forms.Panel pnlConnPhone;
        private System.Windows.Forms.Panel pnlPause;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Timer timBtnStatic;

    }
}