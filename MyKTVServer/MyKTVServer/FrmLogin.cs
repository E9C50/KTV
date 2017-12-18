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
    public partial class FrmLogin : Form
    {
        AdminManage adminmanage = new AdminManage();
        public FrmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.A_AdminPassWord1 = this.txtPassWord.Text.Trim();
            admin.A_AdminUserName1 = this.txtUserName.Text.Trim();
            bool result = adminmanage.Login(admin);
            if(result)
            {
                FrmMain main = new FrmMain();
                main.Show();
                this.Hide();
                return;
            }
            MessageBox.Show("用户名或密码错误","登录",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
