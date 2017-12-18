using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyKTVServer.BLL;
using MyKTVServer.Model;

namespace MyKTVServer
{
    public partial class FrmToolManage : Form
    {
        AdminManage adminmanage = new AdminManage();
        RoomManage roomManage = new RoomManage();
        public FrmToolManage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 修改按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            this.txtPassWord.ReadOnly = false;
            this.txtUserName.ReadOnly = false;
            this.btnSure.Visible = true;
        }
        /// <summary>
        /// 查找管理员信息
        /// </summary>
        public void SearchAdmin()
        {
            Admin admin = adminmanage.SearchAdmin();
            this.txtPassWord.Text = admin.A_AdminPassWord1;
            this.txtUserName.Text = admin.A_AdminUserName1;
        }
        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmToolManage_Load(object sender, EventArgs e)
        {
            SearchAdmin();
        }
        /// <summary>
        /// 修改管理员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSure_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.A_AdminPassWord1 = this.txtPassWord.Text.Trim();
            admin.A_AdminUserName1 = this.txtUserName.Text.Trim();
            bool result = adminmanage.UpdateAdmin(admin);
            if (result)
            {
                MessageBox.Show("修改成功", "修改", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SearchAdmin();
                this.txtPassWord.ReadOnly = true;
                this.txtUserName.ReadOnly = true;
                this.btnSure.Visible = false;
                return;
            }
            MessageBox.Show("修改失败", "修改", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
