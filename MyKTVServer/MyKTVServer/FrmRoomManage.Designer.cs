namespace MyKTVServer
{
    partial class FrmRoomManage
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
            this.btnAddRoomText = new System.Windows.Forms.Button();
            this.pnlAddRoom = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.txtRoomId = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblRoomId = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.timServerPnl = new System.Windows.Forms.Timer(this.components);
            this.timFoodServer = new System.Windows.Forms.Timer(this.components);
            this.timPayServer = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAddRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddRoomText
            // 
            this.btnAddRoomText.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAddRoomText.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddRoomText.Font = new System.Drawing.Font("宋体", 30F);
            this.btnAddRoomText.Location = new System.Drawing.Point(1279, 0);
            this.btnAddRoomText.Name = "btnAddRoomText";
            this.btnAddRoomText.Size = new System.Drawing.Size(75, 716);
            this.btnAddRoomText.TabIndex = 0;
            this.btnAddRoomText.Text = "添加包厢信息";
            this.btnAddRoomText.UseVisualStyleBackColor = false;
            this.btnAddRoomText.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // pnlAddRoom
            // 
            this.pnlAddRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAddRoom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlAddRoom.Controls.Add(this.btnExit);
            this.pnlAddRoom.Controls.Add(this.btnAddRoom);
            this.pnlAddRoom.Controls.Add(this.cmbRoomType);
            this.pnlAddRoom.Controls.Add(this.txtRoomId);
            this.pnlAddRoom.Controls.Add(this.lblType);
            this.pnlAddRoom.Controls.Add(this.lblRoomId);
            this.pnlAddRoom.Controls.Add(this.lblAdd);
            this.pnlAddRoom.Location = new System.Drawing.Point(389, 184);
            this.pnlAddRoom.Name = "pnlAddRoom";
            this.pnlAddRoom.Size = new System.Drawing.Size(549, 328);
            this.pnlAddRoom.TabIndex = 1;
            this.pnlAddRoom.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(325, 236);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "取消";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(244, 236);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(75, 23);
            this.btnAddRoom.TabIndex = 5;
            this.btnAddRoom.Text = "新增";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click_1);
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Items.AddRange(new object[] {
            "小包",
            "中包",
            "大包"});
            this.cmbRoomType.Location = new System.Drawing.Point(178, 164);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(218, 20);
            this.cmbRoomType.TabIndex = 4;
            // 
            // txtRoomId
            // 
            this.txtRoomId.Location = new System.Drawing.Point(178, 99);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.Size = new System.Drawing.Size(218, 21);
            this.txtRoomId.TabIndex = 3;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(94, 167);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(65, 12);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "包厢类型：";
            // 
            // lblRoomId
            // 
            this.lblRoomId.AutoSize = true;
            this.lblRoomId.Location = new System.Drawing.Point(94, 102);
            this.lblRoomId.Name = "lblRoomId";
            this.lblRoomId.Size = new System.Drawing.Size(65, 12);
            this.lblRoomId.TabIndex = 1;
            this.lblRoomId.Text = "包厢编号：";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("宋体", 15F);
            this.lblAdd.Location = new System.Drawing.Point(206, 18);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(129, 20);
            this.lblAdd.TabIndex = 0;
            this.lblAdd.Text = "添加包厢信息";
            // 
            // timServerPnl
            // 
            this.timServerPnl.Enabled = true;
            this.timServerPnl.Tick += new System.EventHandler(this.timServerPnl_Tick);
            // 
            // timFoodServer
            // 
            this.timFoodServer.Enabled = true;
            this.timFoodServer.Tick += new System.EventHandler(this.timFoodServer_Tick);
            // 
            // timPayServer
            // 
            this.timPayServer.Enabled = true;
            this.timPayServer.Tick += new System.EventHandler(this.timPayServer_Tick);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 522);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Tag = "print";
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // FrmRoomManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 716);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlAddRoom);
            this.Controls.Add(this.btnAddRoomText);
            this.Name = "FrmRoomManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "包厢管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRoomManage_Load);
            this.pnlAddRoom.ResumeLayout(false);
            this.pnlAddRoom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddRoomText;
        private System.Windows.Forms.Panel pnlAddRoom;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblRoomId;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.TextBox txtRoomId;
        private System.Windows.Forms.Timer timServerPnl;
        private System.Windows.Forms.Timer timFoodServer;
        private System.Windows.Forms.Timer timPayServer;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label1;

    }
}