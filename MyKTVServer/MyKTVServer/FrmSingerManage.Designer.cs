namespace MyKTVServer
{
    partial class FrmSingerManage
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
            this.dgvSingerList = new System.Windows.Forms.DataGridView();
            this.SRI_SingeId1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRI_SingerName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRT_SingerTypeName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SRI_SingePhotoURL1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsManage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpAddSong = new System.Windows.Forms.GroupBox();
            this.cmbSingerType = new System.Windows.Forms.ComboBox();
            this.btnCleanAdd = new System.Windows.Forms.Button();
            this.txtSingerName = new System.Windows.Forms.TextBox();
            this.btnUpData = new System.Windows.Forms.Button();
            this.lblSingerType = new System.Windows.Forms.Label();
            this.lblSingerName = new System.Windows.Forms.Label();
            this.btnFindFilePath = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblSongPath = new System.Windows.Forms.Label();
            this.grpSelect = new System.Windows.Forms.GroupBox();
            this.cmbSingerTypeSearch = new System.Windows.Forms.ComboBox();
            this.txtSingerNameSearch = new System.Windows.Forms.TextBox();
            this.lblSingerTypeSearch = new System.Windows.Forms.Label();
            this.lblSingerNameSearch = new System.Windows.Forms.Label();
            this.btnCleanSearch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSingerList)).BeginInit();
            this.cmsManage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpAddSong.SuspendLayout();
            this.grpSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSingerList
            // 
            this.dgvSingerList.AllowUserToAddRows = false;
            this.dgvSingerList.AllowUserToDeleteRows = false;
            this.dgvSingerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSingerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSingerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SRI_SingeId1,
            this.SRI_SingerName1,
            this.SRT_SingerTypeName1,
            this.SRI_SingePhotoURL1});
            this.dgvSingerList.ContextMenuStrip = this.cmsManage;
            this.dgvSingerList.Location = new System.Drawing.Point(300, 12);
            this.dgvSingerList.Name = "dgvSingerList";
            this.dgvSingerList.ReadOnly = true;
            this.dgvSingerList.RowTemplate.Height = 23;
            this.dgvSingerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSingerList.Size = new System.Drawing.Size(1050, 692);
            this.dgvSingerList.TabIndex = 0;
            // 
            // SRI_SingeId1
            // 
            this.SRI_SingeId1.DataPropertyName = "SRI_SingeId1";
            this.SRI_SingeId1.HeaderText = "歌手编号";
            this.SRI_SingeId1.Name = "SRI_SingeId1";
            this.SRI_SingeId1.ReadOnly = true;
            // 
            // SRI_SingerName1
            // 
            this.SRI_SingerName1.DataPropertyName = "SRI_SingerName1";
            this.SRI_SingerName1.HeaderText = "歌手姓名";
            this.SRI_SingerName1.Name = "SRI_SingerName1";
            this.SRI_SingerName1.ReadOnly = true;
            this.SRI_SingerName1.Width = 200;
            // 
            // SRT_SingerTypeName1
            // 
            this.SRT_SingerTypeName1.DataPropertyName = "SRT_SingerTypeName1";
            this.SRT_SingerTypeName1.HeaderText = "歌手类型";
            this.SRT_SingerTypeName1.Name = "SRT_SingerTypeName1";
            this.SRT_SingerTypeName1.ReadOnly = true;
            this.SRT_SingerTypeName1.Width = 200;
            // 
            // SRI_SingePhotoURL1
            // 
            this.SRI_SingePhotoURL1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SRI_SingePhotoURL1.DataPropertyName = "SRI_SingePhotoURL1";
            this.SRI_SingePhotoURL1.HeaderText = "歌手照片路径";
            this.SRI_SingePhotoURL1.Name = "SRI_SingePhotoURL1";
            this.SRI_SingePhotoURL1.ReadOnly = true;
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
            this.panel1.TabIndex = 2;
            // 
            // grpAddSong
            // 
            this.grpAddSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grpAddSong.Controls.Add(this.cmbSingerType);
            this.grpAddSong.Controls.Add(this.btnCleanAdd);
            this.grpAddSong.Controls.Add(this.txtSingerName);
            this.grpAddSong.Controls.Add(this.btnUpData);
            this.grpAddSong.Controls.Add(this.lblSingerType);
            this.grpAddSong.Controls.Add(this.lblSingerName);
            this.grpAddSong.Controls.Add(this.btnFindFilePath);
            this.grpAddSong.Controls.Add(this.txtFilePath);
            this.grpAddSong.Controls.Add(this.lblSongPath);
            this.grpAddSong.Location = new System.Drawing.Point(12, 202);
            this.grpAddSong.Name = "grpAddSong";
            this.grpAddSong.Size = new System.Drawing.Size(282, 502);
            this.grpAddSong.TabIndex = 1;
            this.grpAddSong.TabStop = false;
            this.grpAddSong.Text = "添加";
            // 
            // cmbSingerType
            // 
            this.cmbSingerType.FormattingEnabled = true;
            this.cmbSingerType.Items.AddRange(new object[] {
            "华语男歌手",
            "华语女歌手",
            "港台男歌手",
            "港台女歌手",
            "欧美男歌手",
            "欧美女歌手",
            "中国组合",
            "国外组合"});
            this.cmbSingerType.Location = new System.Drawing.Point(91, 93);
            this.cmbSingerType.Name = "cmbSingerType";
            this.cmbSingerType.Size = new System.Drawing.Size(161, 20);
            this.cmbSingerType.TabIndex = 15;
            // 
            // btnCleanAdd
            // 
            this.btnCleanAdd.Location = new System.Drawing.Point(172, 199);
            this.btnCleanAdd.Name = "btnCleanAdd";
            this.btnCleanAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCleanAdd.TabIndex = 8;
            this.btnCleanAdd.Text = "清空";
            this.btnCleanAdd.UseVisualStyleBackColor = true;
            this.btnCleanAdd.Click += new System.EventHandler(this.btnCleanAdd_Click);
            // 
            // txtSingerName
            // 
            this.txtSingerName.Location = new System.Drawing.Point(91, 50);
            this.txtSingerName.Name = "txtSingerName";
            this.txtSingerName.Size = new System.Drawing.Size(161, 21);
            this.txtSingerName.TabIndex = 14;
            // 
            // btnUpData
            // 
            this.btnUpData.Location = new System.Drawing.Point(91, 199);
            this.btnUpData.Name = "btnUpData";
            this.btnUpData.Size = new System.Drawing.Size(75, 23);
            this.btnUpData.TabIndex = 17;
            this.btnUpData.Text = "添加";
            this.btnUpData.UseVisualStyleBackColor = true;
            this.btnUpData.Click += new System.EventHandler(this.btnUpData_Click);
            // 
            // lblSingerType
            // 
            this.lblSingerType.AutoSize = true;
            this.lblSingerType.Location = new System.Drawing.Point(20, 96);
            this.lblSingerType.Name = "lblSingerType";
            this.lblSingerType.Size = new System.Drawing.Size(65, 12);
            this.lblSingerType.TabIndex = 13;
            this.lblSingerType.Text = "歌手类型：";
            // 
            // lblSingerName
            // 
            this.lblSingerName.AutoSize = true;
            this.lblSingerName.Location = new System.Drawing.Point(20, 53);
            this.lblSingerName.Name = "lblSingerName";
            this.lblSingerName.Size = new System.Drawing.Size(65, 12);
            this.lblSingerName.TabIndex = 12;
            this.lblSingerName.Text = "歌手姓名：";
            // 
            // btnFindFilePath
            // 
            this.btnFindFilePath.Location = new System.Drawing.Point(218, 133);
            this.btnFindFilePath.Name = "btnFindFilePath";
            this.btnFindFilePath.Size = new System.Drawing.Size(34, 23);
            this.btnFindFilePath.TabIndex = 16;
            this.btnFindFilePath.Text = "...";
            this.btnFindFilePath.UseVisualStyleBackColor = true;
            this.btnFindFilePath.Click += new System.EventHandler(this.btnFindFilePath_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(91, 135);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(121, 21);
            this.txtFilePath.TabIndex = 15;
            // 
            // lblSongPath
            // 
            this.lblSongPath.AutoSize = true;
            this.lblSongPath.Location = new System.Drawing.Point(20, 138);
            this.lblSongPath.Name = "lblSongPath";
            this.lblSongPath.Size = new System.Drawing.Size(65, 12);
            this.lblSongPath.TabIndex = 14;
            this.lblSongPath.Text = "选择照片：";
            // 
            // grpSelect
            // 
            this.grpSelect.Controls.Add(this.cmbSingerTypeSearch);
            this.grpSelect.Controls.Add(this.txtSingerNameSearch);
            this.grpSelect.Controls.Add(this.lblSingerTypeSearch);
            this.grpSelect.Controls.Add(this.lblSingerNameSearch);
            this.grpSelect.Controls.Add(this.btnCleanSearch);
            this.grpSelect.Controls.Add(this.btnSearch);
            this.grpSelect.Location = new System.Drawing.Point(12, 12);
            this.grpSelect.Name = "grpSelect";
            this.grpSelect.Size = new System.Drawing.Size(282, 184);
            this.grpSelect.TabIndex = 0;
            this.grpSelect.TabStop = false;
            this.grpSelect.Text = "查询";
            // 
            // cmbSingerTypeSearch
            // 
            this.cmbSingerTypeSearch.FormattingEnabled = true;
            this.cmbSingerTypeSearch.Items.AddRange(new object[] {
            "华语男歌手",
            "华语女歌手",
            "港台男歌手",
            "港台女歌手",
            "欧美男歌手",
            "欧美女歌手",
            "中国组合",
            "国外组合"});
            this.cmbSingerTypeSearch.Location = new System.Drawing.Point(91, 84);
            this.cmbSingerTypeSearch.Name = "cmbSingerTypeSearch";
            this.cmbSingerTypeSearch.Size = new System.Drawing.Size(161, 20);
            this.cmbSingerTypeSearch.TabIndex = 11;
            // 
            // txtSingerNameSearch
            // 
            this.txtSingerNameSearch.Location = new System.Drawing.Point(91, 41);
            this.txtSingerNameSearch.Name = "txtSingerNameSearch";
            this.txtSingerNameSearch.Size = new System.Drawing.Size(161, 21);
            this.txtSingerNameSearch.TabIndex = 10;
            // 
            // lblSingerTypeSearch
            // 
            this.lblSingerTypeSearch.AutoSize = true;
            this.lblSingerTypeSearch.Location = new System.Drawing.Point(20, 87);
            this.lblSingerTypeSearch.Name = "lblSingerTypeSearch";
            this.lblSingerTypeSearch.Size = new System.Drawing.Size(65, 12);
            this.lblSingerTypeSearch.TabIndex = 9;
            this.lblSingerTypeSearch.Text = "歌手类型：";
            // 
            // lblSingerNameSearch
            // 
            this.lblSingerNameSearch.AutoSize = true;
            this.lblSingerNameSearch.Location = new System.Drawing.Point(20, 44);
            this.lblSingerNameSearch.Name = "lblSingerNameSearch";
            this.lblSingerNameSearch.Size = new System.Drawing.Size(65, 12);
            this.lblSingerNameSearch.TabIndex = 8;
            this.lblSingerNameSearch.Text = "歌手姓名：";
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
            // FrmSingerManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 716);
            this.Controls.Add(this.dgvSingerList);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSingerManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "歌手管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSingerManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSingerList)).EndInit();
            this.cmsManage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.grpAddSong.ResumeLayout(false);
            this.grpAddSong.PerformLayout();
            this.grpSelect.ResumeLayout(false);
            this.grpSelect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSingerList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpAddSong;
        private System.Windows.Forms.Button btnCleanAdd;
        private System.Windows.Forms.Button btnUpData;
        private System.Windows.Forms.Button btnFindFilePath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblSongPath;
        private System.Windows.Forms.GroupBox grpSelect;
        private System.Windows.Forms.Button btnCleanSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSingerTypeSearch;
        private System.Windows.Forms.Label lblSingerNameSearch;
        private System.Windows.Forms.ComboBox cmbSingerTypeSearch;
        private System.Windows.Forms.TextBox txtSingerNameSearch;
        private System.Windows.Forms.ComboBox cmbSingerType;
        private System.Windows.Forms.TextBox txtSingerName;
        private System.Windows.Forms.Label lblSingerType;
        private System.Windows.Forms.Label lblSingerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRI_SingeId1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRI_SingerName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRT_SingerTypeName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SRI_SingePhotoURL1;
        private System.Windows.Forms.ContextMenuStrip cmsManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
    }
}