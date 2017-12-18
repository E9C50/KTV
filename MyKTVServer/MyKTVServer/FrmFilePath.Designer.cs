namespace MyKTVServer
{
    partial class FrmFilePath
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.txtNewPath = new System.Windows.Forms.TextBox();
            this.lblNewPath = new System.Windows.Forms.Label();
            this.txtOldPath = new System.Windows.Forms.TextBox();
            this.lblOldPath = new System.Windows.Forms.Label();
            this.rdoSong = new System.Windows.Forms.RadioButton();
            this.rdoSinger = new System.Windows.Forms.RadioButton();
            this.rdoFood = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(302, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(204, 92);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(383, 65);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(31, 23);
            this.btnScan.TabIndex = 11;
            this.btnScan.Text = "...";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // txtNewPath
            // 
            this.txtNewPath.Location = new System.Drawing.Point(83, 65);
            this.txtNewPath.Name = "txtNewPath";
            this.txtNewPath.ReadOnly = true;
            this.txtNewPath.Size = new System.Drawing.Size(294, 21);
            this.txtNewPath.TabIndex = 10;
            // 
            // lblNewPath
            // 
            this.lblNewPath.AutoSize = true;
            this.lblNewPath.Location = new System.Drawing.Point(12, 70);
            this.lblNewPath.Name = "lblNewPath";
            this.lblNewPath.Size = new System.Drawing.Size(53, 12);
            this.lblNewPath.TabIndex = 9;
            this.lblNewPath.Text = "新路径：";
            // 
            // txtOldPath
            // 
            this.txtOldPath.Location = new System.Drawing.Point(83, 36);
            this.txtOldPath.Name = "txtOldPath";
            this.txtOldPath.ReadOnly = true;
            this.txtOldPath.Size = new System.Drawing.Size(294, 21);
            this.txtOldPath.TabIndex = 8;
            // 
            // lblOldPath
            // 
            this.lblOldPath.AutoSize = true;
            this.lblOldPath.Location = new System.Drawing.Point(12, 39);
            this.lblOldPath.Name = "lblOldPath";
            this.lblOldPath.Size = new System.Drawing.Size(65, 12);
            this.lblOldPath.TabIndex = 7;
            this.lblOldPath.Text = "当前路径：";
            // 
            // rdoSong
            // 
            this.rdoSong.AutoSize = true;
            this.rdoSong.Checked = true;
            this.rdoSong.Location = new System.Drawing.Point(107, 14);
            this.rdoSong.Name = "rdoSong";
            this.rdoSong.Size = new System.Drawing.Size(71, 16);
            this.rdoSong.TabIndex = 14;
            this.rdoSong.TabStop = true;
            this.rdoSong.Text = "歌曲文件";
            this.rdoSong.UseVisualStyleBackColor = true;
            this.rdoSong.CheckedChanged += new System.EventHandler(this.rdoSong_CheckedChanged);
            // 
            // rdoSinger
            // 
            this.rdoSinger.AutoSize = true;
            this.rdoSinger.Location = new System.Drawing.Point(184, 14);
            this.rdoSinger.Name = "rdoSinger";
            this.rdoSinger.Size = new System.Drawing.Size(71, 16);
            this.rdoSinger.TabIndex = 15;
            this.rdoSinger.Text = "歌手照片";
            this.rdoSinger.UseVisualStyleBackColor = true;
            this.rdoSinger.CheckedChanged += new System.EventHandler(this.rdoSinger_CheckedChanged);
            // 
            // rdoFood
            // 
            this.rdoFood.AutoSize = true;
            this.rdoFood.Location = new System.Drawing.Point(261, 14);
            this.rdoFood.Name = "rdoFood";
            this.rdoFood.Size = new System.Drawing.Size(71, 16);
            this.rdoFood.TabIndex = 16;
            this.rdoFood.Text = "食物照片";
            this.rdoFood.UseVisualStyleBackColor = true;
            this.rdoFood.CheckedChanged += new System.EventHandler(this.rboFood_CheckedChanged);
            // 
            // FrmFilePath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 144);
            this.Controls.Add(this.rdoFood);
            this.Controls.Add(this.rdoSinger);
            this.Controls.Add(this.rdoSong);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.txtNewPath);
            this.Controls.Add(this.lblNewPath);
            this.Controls.Add(this.txtOldPath);
            this.Controls.Add(this.lblOldPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmFilePath";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "资源路径设置";
            this.Load += new System.EventHandler(this.FrmFilePath_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.TextBox txtNewPath;
        private System.Windows.Forms.Label lblNewPath;
        private System.Windows.Forms.TextBox txtOldPath;
        private System.Windows.Forms.Label lblOldPath;
        private System.Windows.Forms.RadioButton rdoSong;
        private System.Windows.Forms.RadioButton rdoSinger;
        private System.Windows.Forms.RadioButton rdoFood;
    }
}