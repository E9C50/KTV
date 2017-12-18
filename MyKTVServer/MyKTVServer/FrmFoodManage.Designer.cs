namespace MyKTVServer
{
    partial class FrmFoodManage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpAddSong = new System.Windows.Forms.GroupBox();
            this.txtFoodPrice = new System.Windows.Forms.TextBox();
            this.lblFoodPrice = new System.Windows.Forms.Label();
            this.cmbFoodType = new System.Windows.Forms.ComboBox();
            this.btnCleanAdd = new System.Windows.Forms.Button();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.btnUpData = new System.Windows.Forms.Button();
            this.lblFoodType = new System.Windows.Forms.Label();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.btnFindFilePath = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFoodPath = new System.Windows.Forms.Label();
            this.grpSelect = new System.Windows.Forms.GroupBox();
            this.cmbFoodTypeSearch = new System.Windows.Forms.ComboBox();
            this.txtFoodNameSearch = new System.Windows.Forms.TextBox();
            this.lblFoodTypeSearch = new System.Windows.Forms.Label();
            this.lblFoodNameSearch = new System.Windows.Forms.Label();
            this.btnCleanSearch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvFoodList = new System.Windows.Forms.DataGridView();
            this.FI_FoodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FI_FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FI_FoodPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FT_FoodTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FI_FoodPhotoURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsManage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.grpAddSong.SuspendLayout();
            this.grpSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
            this.cmsManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpAddSong);
            this.panel1.Controls.Add(this.grpSelect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 716);
            this.panel1.TabIndex = 3;
            // 
            // grpAddSong
            // 
            this.grpAddSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grpAddSong.Controls.Add(this.txtFoodPrice);
            this.grpAddSong.Controls.Add(this.lblFoodPrice);
            this.grpAddSong.Controls.Add(this.cmbFoodType);
            this.grpAddSong.Controls.Add(this.btnCleanAdd);
            this.grpAddSong.Controls.Add(this.txtFoodName);
            this.grpAddSong.Controls.Add(this.btnUpData);
            this.grpAddSong.Controls.Add(this.lblFoodType);
            this.grpAddSong.Controls.Add(this.lblFoodName);
            this.grpAddSong.Controls.Add(this.btnFindFilePath);
            this.grpAddSong.Controls.Add(this.txtFilePath);
            this.grpAddSong.Controls.Add(this.lblFoodPath);
            this.grpAddSong.Location = new System.Drawing.Point(12, 202);
            this.grpAddSong.Name = "grpAddSong";
            this.grpAddSong.Size = new System.Drawing.Size(282, 502);
            this.grpAddSong.TabIndex = 1;
            this.grpAddSong.TabStop = false;
            this.grpAddSong.Text = "添加";
            // 
            // txtFoodPrice
            // 
            this.txtFoodPrice.Location = new System.Drawing.Point(91, 133);
            this.txtFoodPrice.Name = "txtFoodPrice";
            this.txtFoodPrice.Size = new System.Drawing.Size(161, 21);
            this.txtFoodPrice.TabIndex = 19;
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.AutoSize = true;
            this.lblFoodPrice.Location = new System.Drawing.Point(20, 136);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(65, 12);
            this.lblFoodPrice.TabIndex = 18;
            this.lblFoodPrice.Text = "食品价格：";
            // 
            // cmbFoodType
            // 
            this.cmbFoodType.FormattingEnabled = true;
            this.cmbFoodType.Items.AddRange(new object[] {
            "酒水",
            "小吃",
            "烧烤",
            "热菜",
            "凉菜"});
            this.cmbFoodType.Location = new System.Drawing.Point(91, 93);
            this.cmbFoodType.Name = "cmbFoodType";
            this.cmbFoodType.Size = new System.Drawing.Size(161, 20);
            this.cmbFoodType.TabIndex = 15;
            // 
            // btnCleanAdd
            // 
            this.btnCleanAdd.Location = new System.Drawing.Point(172, 243);
            this.btnCleanAdd.Name = "btnCleanAdd";
            this.btnCleanAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCleanAdd.TabIndex = 8;
            this.btnCleanAdd.Text = "清空";
            this.btnCleanAdd.UseVisualStyleBackColor = true;
            this.btnCleanAdd.Click += new System.EventHandler(this.btnCleanAdd_Click);
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(91, 50);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(161, 21);
            this.txtFoodName.TabIndex = 14;
            // 
            // btnUpData
            // 
            this.btnUpData.Location = new System.Drawing.Point(91, 243);
            this.btnUpData.Name = "btnUpData";
            this.btnUpData.Size = new System.Drawing.Size(75, 23);
            this.btnUpData.TabIndex = 17;
            this.btnUpData.Text = "添加";
            this.btnUpData.UseVisualStyleBackColor = true;
            this.btnUpData.Click += new System.EventHandler(this.btnUpData_Click);
            // 
            // lblFoodType
            // 
            this.lblFoodType.AutoSize = true;
            this.lblFoodType.Location = new System.Drawing.Point(20, 96);
            this.lblFoodType.Name = "lblFoodType";
            this.lblFoodType.Size = new System.Drawing.Size(65, 12);
            this.lblFoodType.TabIndex = 13;
            this.lblFoodType.Text = "食品类型：";
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Location = new System.Drawing.Point(20, 53);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(65, 12);
            this.lblFoodName.TabIndex = 12;
            this.lblFoodName.Text = "食品名称：";
            // 
            // btnFindFilePath
            // 
            this.btnFindFilePath.Location = new System.Drawing.Point(218, 177);
            this.btnFindFilePath.Name = "btnFindFilePath";
            this.btnFindFilePath.Size = new System.Drawing.Size(34, 23);
            this.btnFindFilePath.TabIndex = 16;
            this.btnFindFilePath.Text = "...";
            this.btnFindFilePath.UseVisualStyleBackColor = true;
            this.btnFindFilePath.Click += new System.EventHandler(this.btnFindFilePath_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(91, 179);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(121, 21);
            this.txtFilePath.TabIndex = 15;
            // 
            // lblFoodPath
            // 
            this.lblFoodPath.AutoSize = true;
            this.lblFoodPath.Location = new System.Drawing.Point(20, 182);
            this.lblFoodPath.Name = "lblFoodPath";
            this.lblFoodPath.Size = new System.Drawing.Size(65, 12);
            this.lblFoodPath.TabIndex = 14;
            this.lblFoodPath.Text = "选择照片：";
            // 
            // grpSelect
            // 
            this.grpSelect.Controls.Add(this.cmbFoodTypeSearch);
            this.grpSelect.Controls.Add(this.txtFoodNameSearch);
            this.grpSelect.Controls.Add(this.lblFoodTypeSearch);
            this.grpSelect.Controls.Add(this.lblFoodNameSearch);
            this.grpSelect.Controls.Add(this.btnCleanSearch);
            this.grpSelect.Controls.Add(this.btnSearch);
            this.grpSelect.Location = new System.Drawing.Point(12, 12);
            this.grpSelect.Name = "grpSelect";
            this.grpSelect.Size = new System.Drawing.Size(282, 184);
            this.grpSelect.TabIndex = 0;
            this.grpSelect.TabStop = false;
            this.grpSelect.Text = "查询";
            // 
            // cmbFoodTypeSearch
            // 
            this.cmbFoodTypeSearch.FormattingEnabled = true;
            this.cmbFoodTypeSearch.Items.AddRange(new object[] {
            "酒水",
            "小吃",
            "烧烤",
            "热菜",
            "凉菜"});
            this.cmbFoodTypeSearch.Location = new System.Drawing.Point(91, 84);
            this.cmbFoodTypeSearch.Name = "cmbFoodTypeSearch";
            this.cmbFoodTypeSearch.Size = new System.Drawing.Size(161, 20);
            this.cmbFoodTypeSearch.TabIndex = 11;
            // 
            // txtFoodNameSearch
            // 
            this.txtFoodNameSearch.Location = new System.Drawing.Point(91, 41);
            this.txtFoodNameSearch.Name = "txtFoodNameSearch";
            this.txtFoodNameSearch.Size = new System.Drawing.Size(161, 21);
            this.txtFoodNameSearch.TabIndex = 10;
            // 
            // lblFoodTypeSearch
            // 
            this.lblFoodTypeSearch.AutoSize = true;
            this.lblFoodTypeSearch.Location = new System.Drawing.Point(20, 87);
            this.lblFoodTypeSearch.Name = "lblFoodTypeSearch";
            this.lblFoodTypeSearch.Size = new System.Drawing.Size(65, 12);
            this.lblFoodTypeSearch.TabIndex = 9;
            this.lblFoodTypeSearch.Text = "食品类型：";
            // 
            // lblFoodNameSearch
            // 
            this.lblFoodNameSearch.AutoSize = true;
            this.lblFoodNameSearch.Location = new System.Drawing.Point(20, 44);
            this.lblFoodNameSearch.Name = "lblFoodNameSearch";
            this.lblFoodNameSearch.Size = new System.Drawing.Size(65, 12);
            this.lblFoodNameSearch.TabIndex = 8;
            this.lblFoodNameSearch.Text = "食品名称：";
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
            // dgvFoodList
            // 
            this.dgvFoodList.AllowUserToAddRows = false;
            this.dgvFoodList.AllowUserToDeleteRows = false;
            this.dgvFoodList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FI_FoodId,
            this.FI_FoodName,
            this.FI_FoodPrice,
            this.FT_FoodTypeName,
            this.FI_FoodPhotoURL});
            this.dgvFoodList.ContextMenuStrip = this.cmsManage;
            this.dgvFoodList.Location = new System.Drawing.Point(314, 12);
            this.dgvFoodList.Name = "dgvFoodList";
            this.dgvFoodList.ReadOnly = true;
            this.dgvFoodList.RowTemplate.Height = 23;
            this.dgvFoodList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodList.Size = new System.Drawing.Size(1036, 692);
            this.dgvFoodList.TabIndex = 4;
            // 
            // FI_FoodId
            // 
            this.FI_FoodId.DataPropertyName = "FI_FoodId1";
            this.FI_FoodId.HeaderText = "食品编号";
            this.FI_FoodId.Name = "FI_FoodId";
            this.FI_FoodId.ReadOnly = true;
            // 
            // FI_FoodName
            // 
            this.FI_FoodName.DataPropertyName = "FI_FoodName1";
            this.FI_FoodName.HeaderText = "食品名称";
            this.FI_FoodName.Name = "FI_FoodName";
            this.FI_FoodName.ReadOnly = true;
            this.FI_FoodName.Width = 200;
            // 
            // FI_FoodPrice
            // 
            this.FI_FoodPrice.DataPropertyName = "FI_FoodPrice1";
            this.FI_FoodPrice.HeaderText = "食品价格";
            this.FI_FoodPrice.Name = "FI_FoodPrice";
            this.FI_FoodPrice.ReadOnly = true;
            this.FI_FoodPrice.Width = 200;
            // 
            // FT_FoodTypeName
            // 
            this.FT_FoodTypeName.DataPropertyName = "FT_FoodTypeName1";
            this.FT_FoodTypeName.HeaderText = "食品类型";
            this.FT_FoodTypeName.Name = "FT_FoodTypeName";
            this.FT_FoodTypeName.ReadOnly = true;
            this.FT_FoodTypeName.Width = 200;
            // 
            // FI_FoodPhotoURL
            // 
            this.FI_FoodPhotoURL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FI_FoodPhotoURL.DataPropertyName = "FI_FoodPhotoURL1";
            this.FI_FoodPhotoURL.HeaderText = "食品照片路径";
            this.FI_FoodPhotoURL.Name = "FI_FoodPhotoURL";
            this.FI_FoodPhotoURL.ReadOnly = true;
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
            // FrmFoodManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 716);
            this.Controls.Add(this.dgvFoodList);
            this.Controls.Add(this.panel1);
            this.Name = "FrmFoodManage";
            this.Text = "食品管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmFoodManage_Load);
            this.panel1.ResumeLayout(false);
            this.grpAddSong.ResumeLayout(false);
            this.grpAddSong.PerformLayout();
            this.grpSelect.ResumeLayout(false);
            this.grpSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
            this.cmsManage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpAddSong;
        private System.Windows.Forms.ComboBox cmbFoodType;
        private System.Windows.Forms.Button btnCleanAdd;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Button btnUpData;
        private System.Windows.Forms.Label lblFoodType;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.Button btnFindFilePath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblFoodPath;
        private System.Windows.Forms.GroupBox grpSelect;
        private System.Windows.Forms.ComboBox cmbFoodTypeSearch;
        private System.Windows.Forms.TextBox txtFoodNameSearch;
        private System.Windows.Forms.Label lblFoodTypeSearch;
        private System.Windows.Forms.Label lblFoodNameSearch;
        private System.Windows.Forms.Button btnCleanSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvFoodList;
        private System.Windows.Forms.TextBox txtFoodPrice;
        private System.Windows.Forms.Label lblFoodPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn FI_FoodId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FI_FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FI_FoodPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn FT_FoodTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FI_FoodPhotoURL;
        private System.Windows.Forms.ContextMenuStrip cmsManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
    }
}