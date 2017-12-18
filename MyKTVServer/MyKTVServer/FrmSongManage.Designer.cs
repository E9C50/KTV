namespace MyKTVServer
{
    partial class FrmSongManage
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
            this.dgvSongList = new System.Windows.Forms.DataGridView();
            this.SGI_SongId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGI_SongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGT_SongTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGI_SongWordCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGI_SongSpell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRI_SingerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGI_SongClickRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGI_SongURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsManage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpAddSong = new System.Windows.Forms.GroupBox();
            this.btnCleanAdd = new System.Windows.Forms.Button();
            this.btnUpData = new System.Windows.Forms.Button();
            this.btnFindFilePath = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblSongPath = new System.Windows.Forms.Label();
            this.txtSpell = new System.Windows.Forms.TextBox();
            this.lblSpell = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbSinger = new System.Windows.Forms.ComboBox();
            this.txtSong = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblSinger = new System.Windows.Forms.Label();
            this.lblSong = new System.Windows.Forms.Label();
            this.grpSelect = new System.Windows.Forms.GroupBox();
            this.btnCleanSearch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbTypeSearch = new System.Windows.Forms.ComboBox();
            this.cmbSingerSearch = new System.Windows.Forms.ComboBox();
            this.txtSongSearch = new System.Windows.Forms.TextBox();
            this.lblTypeSearch = new System.Windows.Forms.Label();
            this.lblSingerSearch = new System.Windows.Forms.Label();
            this.lblSongSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongList)).BeginInit();
            this.cmsManage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpAddSong.SuspendLayout();
            this.grpSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSongList
            // 
            this.dgvSongList.AllowUserToAddRows = false;
            this.dgvSongList.AllowUserToDeleteRows = false;
            this.dgvSongList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSongList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SGI_SongId,
            this.SGI_SongName,
            this.SGT_SongTypeName,
            this.SGI_SongWordCount,
            this.SGI_SongSpell,
            this.SRI_SingerName,
            this.SGI_SongClickRate,
            this.SGI_SongURL});
            this.dgvSongList.ContextMenuStrip = this.cmsManage;
            this.dgvSongList.Location = new System.Drawing.Point(300, 12);
            this.dgvSongList.Name = "dgvSongList";
            this.dgvSongList.ReadOnly = true;
            this.dgvSongList.RowTemplate.Height = 23;
            this.dgvSongList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSongList.Size = new System.Drawing.Size(1050, 692);
            this.dgvSongList.TabIndex = 0;
            // 
            // SGI_SongId
            // 
            this.SGI_SongId.DataPropertyName = "SGI_SongId1";
            this.SGI_SongId.HeaderText = "歌曲编号";
            this.SGI_SongId.Name = "SGI_SongId";
            this.SGI_SongId.ReadOnly = true;
            // 
            // SGI_SongName
            // 
            this.SGI_SongName.DataPropertyName = "SGI_SongName1";
            this.SGI_SongName.HeaderText = "歌曲名称";
            this.SGI_SongName.Name = "SGI_SongName";
            this.SGI_SongName.ReadOnly = true;
            // 
            // SGT_SongTypeName
            // 
            this.SGT_SongTypeName.DataPropertyName = "SGT_SongTypeName1";
            this.SGT_SongTypeName.HeaderText = "歌曲类型";
            this.SGT_SongTypeName.Name = "SGT_SongTypeName";
            this.SGT_SongTypeName.ReadOnly = true;
            // 
            // SGI_SongWordCount
            // 
            this.SGI_SongWordCount.DataPropertyName = "SGI_SongWordCount1";
            this.SGI_SongWordCount.HeaderText = "歌名字数";
            this.SGI_SongWordCount.Name = "SGI_SongWordCount";
            this.SGI_SongWordCount.ReadOnly = true;
            // 
            // SGI_SongSpell
            // 
            this.SGI_SongSpell.DataPropertyName = "SGI_SongSpell1";
            this.SGI_SongSpell.HeaderText = "歌名拼音简写";
            this.SGI_SongSpell.Name = "SGI_SongSpell";
            this.SGI_SongSpell.ReadOnly = true;
            // 
            // SRI_SingerName
            // 
            this.SRI_SingerName.DataPropertyName = "SRI_SingerName1";
            this.SRI_SingerName.HeaderText = "歌手姓名";
            this.SRI_SingerName.Name = "SRI_SingerName";
            this.SRI_SingerName.ReadOnly = true;
            // 
            // SGI_SongClickRate
            // 
            this.SGI_SongClickRate.DataPropertyName = "SGI_SongClickRate1";
            this.SGI_SongClickRate.HeaderText = "歌曲点击率";
            this.SGI_SongClickRate.Name = "SGI_SongClickRate";
            this.SGI_SongClickRate.ReadOnly = true;
            // 
            // SGI_SongURL
            // 
            this.SGI_SongURL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SGI_SongURL.DataPropertyName = "SGI_SongURL1";
            this.SGI_SongURL.HeaderText = "歌曲路径";
            this.SGI_SongURL.Name = "SGI_SongURL";
            this.SGI_SongURL.ReadOnly = true;
            // 
            // cmsManage
            // 
            this.cmsManage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete});
            this.cmsManage.Name = "cmsManage";
            this.cmsManage.Size = new System.Drawing.Size(101, 26);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(100, 22);
            this.tsmiDelete.Text = "删除";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpAddSong);
            this.panel1.Controls.Add(this.grpSelect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 716);
            this.panel1.TabIndex = 1;
            // 
            // grpAddSong
            // 
            this.grpAddSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grpAddSong.Controls.Add(this.btnCleanAdd);
            this.grpAddSong.Controls.Add(this.btnUpData);
            this.grpAddSong.Controls.Add(this.btnFindFilePath);
            this.grpAddSong.Controls.Add(this.txtFilePath);
            this.grpAddSong.Controls.Add(this.lblSongPath);
            this.grpAddSong.Controls.Add(this.txtSpell);
            this.grpAddSong.Controls.Add(this.lblSpell);
            this.grpAddSong.Controls.Add(this.cmbType);
            this.grpAddSong.Controls.Add(this.cmbSinger);
            this.grpAddSong.Controls.Add(this.txtSong);
            this.grpAddSong.Controls.Add(this.lblType);
            this.grpAddSong.Controls.Add(this.lblSinger);
            this.grpAddSong.Controls.Add(this.lblSong);
            this.grpAddSong.Location = new System.Drawing.Point(12, 202);
            this.grpAddSong.Name = "grpAddSong";
            this.grpAddSong.Size = new System.Drawing.Size(282, 502);
            this.grpAddSong.TabIndex = 1;
            this.grpAddSong.TabStop = false;
            this.grpAddSong.Text = "添加";
            // 
            // btnCleanAdd
            // 
            this.btnCleanAdd.Location = new System.Drawing.Point(177, 244);
            this.btnCleanAdd.Name = "btnCleanAdd";
            this.btnCleanAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCleanAdd.TabIndex = 8;
            this.btnCleanAdd.Text = "清空";
            this.btnCleanAdd.UseVisualStyleBackColor = true;
            this.btnCleanAdd.Click += new System.EventHandler(this.btnCleanAdd_Click);
            // 
            // btnUpData
            // 
            this.btnUpData.Location = new System.Drawing.Point(96, 244);
            this.btnUpData.Name = "btnUpData";
            this.btnUpData.Size = new System.Drawing.Size(75, 23);
            this.btnUpData.TabIndex = 17;
            this.btnUpData.Text = "添加";
            this.btnUpData.UseVisualStyleBackColor = true;
            this.btnUpData.Click += new System.EventHandler(this.btnUpData_Click);
            // 
            // btnFindFilePath
            // 
            this.btnFindFilePath.Location = new System.Drawing.Point(210, 198);
            this.btnFindFilePath.Name = "btnFindFilePath";
            this.btnFindFilePath.Size = new System.Drawing.Size(42, 23);
            this.btnFindFilePath.TabIndex = 16;
            this.btnFindFilePath.Text = "...";
            this.btnFindFilePath.UseVisualStyleBackColor = true;
            this.btnFindFilePath.Click += new System.EventHandler(this.btnFindFilePath_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(78, 198);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(126, 21);
            this.txtFilePath.TabIndex = 15;
            // 
            // lblSongPath
            // 
            this.lblSongPath.AutoSize = true;
            this.lblSongPath.Location = new System.Drawing.Point(6, 201);
            this.lblSongPath.Name = "lblSongPath";
            this.lblSongPath.Size = new System.Drawing.Size(65, 12);
            this.lblSongPath.TabIndex = 14;
            this.lblSongPath.Text = "选择文件：";
            // 
            // txtSpell
            // 
            this.txtSpell.Location = new System.Drawing.Point(78, 161);
            this.txtSpell.Name = "txtSpell";
            this.txtSpell.Size = new System.Drawing.Size(174, 21);
            this.txtSpell.TabIndex = 13;
            // 
            // lblSpell
            // 
            this.lblSpell.AutoSize = true;
            this.lblSpell.Location = new System.Drawing.Point(6, 164);
            this.lblSpell.Name = "lblSpell";
            this.lblSpell.Size = new System.Drawing.Size(65, 12);
            this.lblSpell.TabIndex = 12;
            this.lblSpell.Text = "拼音简写：";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "热门流行",
            "经典老歌",
            "游戏动漫",
            "军旅之歌",
            "影视金曲",
            "儿童歌谣"});
            this.cmbType.Location = new System.Drawing.Point(78, 123);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(174, 20);
            this.cmbType.TabIndex = 11;
            // 
            // cmbSinger
            // 
            this.cmbSinger.FormattingEnabled = true;
            this.cmbSinger.Location = new System.Drawing.Point(78, 86);
            this.cmbSinger.Name = "cmbSinger";
            this.cmbSinger.Size = new System.Drawing.Size(174, 20);
            this.cmbSinger.TabIndex = 10;
            // 
            // txtSong
            // 
            this.txtSong.Location = new System.Drawing.Point(78, 48);
            this.txtSong.Name = "txtSong";
            this.txtSong.Size = new System.Drawing.Size(174, 21);
            this.txtSong.TabIndex = 9;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 126);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(65, 12);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "歌曲类型：";
            // 
            // lblSinger
            // 
            this.lblSinger.AutoSize = true;
            this.lblSinger.Location = new System.Drawing.Point(7, 90);
            this.lblSinger.Name = "lblSinger";
            this.lblSinger.Size = new System.Drawing.Size(65, 12);
            this.lblSinger.TabIndex = 7;
            this.lblSinger.Text = "歌手姓名：";
            // 
            // lblSong
            // 
            this.lblSong.AutoSize = true;
            this.lblSong.Location = new System.Drawing.Point(7, 51);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(65, 12);
            this.lblSong.TabIndex = 6;
            this.lblSong.Text = "歌曲名称：";
            // 
            // grpSelect
            // 
            this.grpSelect.Controls.Add(this.btnCleanSearch);
            this.grpSelect.Controls.Add(this.btnSearch);
            this.grpSelect.Controls.Add(this.cmbTypeSearch);
            this.grpSelect.Controls.Add(this.cmbSingerSearch);
            this.grpSelect.Controls.Add(this.txtSongSearch);
            this.grpSelect.Controls.Add(this.lblTypeSearch);
            this.grpSelect.Controls.Add(this.lblSingerSearch);
            this.grpSelect.Controls.Add(this.lblSongSearch);
            this.grpSelect.Location = new System.Drawing.Point(12, 12);
            this.grpSelect.Name = "grpSelect";
            this.grpSelect.Size = new System.Drawing.Size(282, 184);
            this.grpSelect.TabIndex = 0;
            this.grpSelect.TabStop = false;
            this.grpSelect.Text = "查询";
            // 
            // btnCleanSearch
            // 
            this.btnCleanSearch.Location = new System.Drawing.Point(151, 142);
            this.btnCleanSearch.Name = "btnCleanSearch";
            this.btnCleanSearch.Size = new System.Drawing.Size(75, 23);
            this.btnCleanSearch.TabIndex = 7;
            this.btnCleanSearch.Text = "清空";
            this.btnCleanSearch.UseVisualStyleBackColor = true;
            this.btnCleanSearch.Click += new System.EventHandler(this.btnCleanSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(54, 142);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbTypeSearch
            // 
            this.cmbTypeSearch.FormattingEnabled = true;
            this.cmbTypeSearch.Items.AddRange(new object[] {
            "热门流行",
            "经典老歌",
            "游戏动漫",
            "军旅之歌",
            "影视金曲",
            "儿童歌谣"});
            this.cmbTypeSearch.Location = new System.Drawing.Point(54, 105);
            this.cmbTypeSearch.Name = "cmbTypeSearch";
            this.cmbTypeSearch.Size = new System.Drawing.Size(198, 20);
            this.cmbTypeSearch.TabIndex = 5;
            // 
            // cmbSingerSearch
            // 
            this.cmbSingerSearch.FormattingEnabled = true;
            this.cmbSingerSearch.Location = new System.Drawing.Point(54, 67);
            this.cmbSingerSearch.Name = "cmbSingerSearch";
            this.cmbSingerSearch.Size = new System.Drawing.Size(198, 20);
            this.cmbSingerSearch.TabIndex = 4;
            // 
            // txtSongSearch
            // 
            this.txtSongSearch.Location = new System.Drawing.Point(54, 29);
            this.txtSongSearch.Name = "txtSongSearch";
            this.txtSongSearch.Size = new System.Drawing.Size(198, 21);
            this.txtSongSearch.TabIndex = 3;
            // 
            // lblTypeSearch
            // 
            this.lblTypeSearch.AutoSize = true;
            this.lblTypeSearch.Location = new System.Drawing.Point(6, 108);
            this.lblTypeSearch.Name = "lblTypeSearch";
            this.lblTypeSearch.Size = new System.Drawing.Size(41, 12);
            this.lblTypeSearch.TabIndex = 2;
            this.lblTypeSearch.Text = "类型：";
            // 
            // lblSingerSearch
            // 
            this.lblSingerSearch.AutoSize = true;
            this.lblSingerSearch.Location = new System.Drawing.Point(7, 70);
            this.lblSingerSearch.Name = "lblSingerSearch";
            this.lblSingerSearch.Size = new System.Drawing.Size(41, 12);
            this.lblSingerSearch.TabIndex = 1;
            this.lblSingerSearch.Text = "歌手：";
            // 
            // lblSongSearch
            // 
            this.lblSongSearch.AutoSize = true;
            this.lblSongSearch.Location = new System.Drawing.Point(7, 32);
            this.lblSongSearch.Name = "lblSongSearch";
            this.lblSongSearch.Size = new System.Drawing.Size(41, 12);
            this.lblSongSearch.TabIndex = 0;
            this.lblSongSearch.Text = "歌名：";
            // 
            // FrmSongManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 716);
            this.Controls.Add(this.dgvSongList);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSongManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "歌曲管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSongManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongList)).EndInit();
            this.cmsManage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.grpAddSong.ResumeLayout(false);
            this.grpAddSong.PerformLayout();
            this.grpSelect.ResumeLayout(false);
            this.grpSelect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSongList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpAddSong;
        private System.Windows.Forms.Button btnCleanAdd;
        private System.Windows.Forms.Button btnUpData;
        private System.Windows.Forms.Button btnFindFilePath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblSongPath;
        private System.Windows.Forms.TextBox txtSpell;
        private System.Windows.Forms.Label lblSpell;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbSinger;
        private System.Windows.Forms.TextBox txtSong;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblSinger;
        private System.Windows.Forms.Label lblSong;
        private System.Windows.Forms.GroupBox grpSelect;
        private System.Windows.Forms.Button btnCleanSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbTypeSearch;
        private System.Windows.Forms.ComboBox cmbSingerSearch;
        private System.Windows.Forms.TextBox txtSongSearch;
        private System.Windows.Forms.Label lblTypeSearch;
        private System.Windows.Forms.Label lblSingerSearch;
        private System.Windows.Forms.Label lblSongSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGI_SongId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGI_SongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGT_SongTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGI_SongWordCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGI_SongSpell;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRI_SingerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGI_SongClickRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGI_SongURL;
        private System.Windows.Forms.ContextMenuStrip cmsManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
    }
}