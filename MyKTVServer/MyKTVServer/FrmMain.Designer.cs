namespace MyKTVServer
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
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiRoomManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFoodManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSongManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSingerManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFilePath = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTool = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMenu
            // 
            this.mnsMenu.BackColor = System.Drawing.SystemColors.Control;
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRoomManage,
            this.tsmiFoodManage,
            this.tsmiSongManage,
            this.tsmiSingerManage,
            this.tsmiFilePath,
            this.tsmiTool,
            this.tsmiExit});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(1354, 25);
            this.mnsMenu.TabIndex = 0;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // tsmiRoomManage
            // 
            this.tsmiRoomManage.Name = "tsmiRoomManage";
            this.tsmiRoomManage.Size = new System.Drawing.Size(68, 21);
            this.tsmiRoomManage.Text = "包厢管理";
            this.tsmiRoomManage.Click += new System.EventHandler(this.tsmiRoomManage_Click);
            // 
            // tsmiFoodManage
            // 
            this.tsmiFoodManage.Name = "tsmiFoodManage";
            this.tsmiFoodManage.Size = new System.Drawing.Size(68, 21);
            this.tsmiFoodManage.Text = "食物管理";
            this.tsmiFoodManage.Click += new System.EventHandler(this.tsmiFoodManage_Click);
            // 
            // tsmiSongManage
            // 
            this.tsmiSongManage.Name = "tsmiSongManage";
            this.tsmiSongManage.Size = new System.Drawing.Size(68, 21);
            this.tsmiSongManage.Text = "歌曲管理";
            this.tsmiSongManage.Click += new System.EventHandler(this.tsmiSongManage_Click);
            // 
            // tsmiSingerManage
            // 
            this.tsmiSingerManage.Name = "tsmiSingerManage";
            this.tsmiSingerManage.Size = new System.Drawing.Size(68, 21);
            this.tsmiSingerManage.Text = "歌手管理";
            this.tsmiSingerManage.Click += new System.EventHandler(this.tsmiSingerManage_Click);
            // 
            // tsmiFilePath
            // 
            this.tsmiFilePath.Name = "tsmiFilePath";
            this.tsmiFilePath.Size = new System.Drawing.Size(68, 21);
            this.tsmiFilePath.Text = "资源路径";
            this.tsmiFilePath.Click += new System.EventHandler(this.tsmiFilePath_Click);
            // 
            // tsmiTool
            // 
            this.tsmiTool.Name = "tsmiTool";
            this.tsmiTool.Size = new System.Drawing.Size(104, 21);
            this.tsmiTool.Text = "管理员账号设置";
            this.tsmiTool.Click += new System.EventHandler(this.tsmiTool_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(44, 21);
            this.tsmiExit.Text = "退出";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.mnsMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KTV自助系统后台管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiRoomManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiFoodManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiSongManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiSingerManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiFilePath;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiTool;
    }
}

