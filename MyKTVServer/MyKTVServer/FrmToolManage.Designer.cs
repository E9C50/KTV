namespace MyKTVServer
{
    partial class FrmToolManage
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
            this.grpAdminManage = new System.Windows.Forms.GroupBox();
            this.btnSure = new System.Windows.Forms.Button();
            this.btnUpdateAdmin = new System.Windows.Forms.Button();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpAdminManage.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAdminManage
            // 
            this.grpAdminManage.Controls.Add(this.btnSure);
            this.grpAdminManage.Controls.Add(this.btnUpdateAdmin);
            this.grpAdminManage.Controls.Add(this.txtPassWord);
            this.grpAdminManage.Controls.Add(this.txtUserName);
            this.grpAdminManage.Controls.Add(this.lblPassWord);
            this.grpAdminManage.Controls.Add(this.lblUserName);
            this.grpAdminManage.Location = new System.Drawing.Point(12, 94);
            this.grpAdminManage.Name = "grpAdminManage";
            this.grpAdminManage.Size = new System.Drawing.Size(366, 99);
            this.grpAdminManage.TabIndex = 0;
            this.grpAdminManage.TabStop = false;
            this.grpAdminManage.Text = "管理员账户管理";
            // 
            // btnSure
            // 
            this.btnSure.Location = new System.Drawing.Point(270, 56);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(75, 23);
            this.btnSure.TabIndex = 5;
            this.btnSure.Text = "确定";
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Visible = false;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // btnUpdateAdmin
            // 
            this.btnUpdateAdmin.Location = new System.Drawing.Point(270, 26);
            this.btnUpdateAdmin.Name = "btnUpdateAdmin";
            this.btnUpdateAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateAdmin.TabIndex = 4;
            this.btnUpdateAdmin.Text = "修改";
            this.btnUpdateAdmin.UseVisualStyleBackColor = true;
            this.btnUpdateAdmin.Click += new System.EventHandler(this.btnUpdateAdmin_Click);
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(97, 56);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.ReadOnly = true;
            this.txtPassWord.Size = new System.Drawing.Size(167, 21);
            this.txtPassWord.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(97, 26);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(167, 21);
            this.txtUserName.TabIndex = 2;
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.Location = new System.Drawing.Point(38, 59);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(53, 12);
            this.lblPassWord.TabIndex = 1;
            this.lblPassWord.Text = "密  码：";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(38, 29);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(53, 12);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "用户名：";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTitle.Location = new System.Drawing.Point(112, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(175, 31);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "KTV自助系统";
            // 
            // FrmToolManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 222);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpAdminManage);
            this.Name = "FrmToolManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.FrmToolManage_Load);
            this.grpAdminManage.ResumeLayout(false);
            this.grpAdminManage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAdminManage;
        private System.Windows.Forms.Button btnUpdateAdmin;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.Label lblTitle;
    }
}