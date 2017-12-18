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
    public partial class FrmMain : Form
    {
        DateTime startTime = DateTime.Now;
        public FrmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 包厢管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiRoomManage_Click(object sender, EventArgs e)
        {
            FrmRoomManage roomManage = new FrmRoomManage();
            this.tsmiRoomManage.ForeColor = Color.Black;
            roomManage.MdiParent = this;
            roomManage.tsmi = this.tsmiRoomManage;
            roomManage.Show();
        }
        /// <summary>
        /// 食物管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiFoodManage_Click(object sender, EventArgs e)
        {
            FrmFoodManage foodManage = new FrmFoodManage();
            foodManage.MdiParent = this;
            foodManage.Show();
        }
        /// <summary>
        /// 歌曲管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSongManage_Click(object sender, EventArgs e)
        {
            FrmSongManage songManage = new FrmSongManage();
            songManage.MdiParent = this;
            songManage.Show();
        }
        /// <summary>
        /// 歌手管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSingerManage_Click(object sender, EventArgs e)
        {
            FrmSingerManage singerManage = new FrmSingerManage();
            singerManage.MdiParent = this;
            singerManage.Show();
        }
        /// <summary>
        /// 资源路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiFilePath_Click(object sender, EventArgs e)
        {
            FrmFilePath filePath = new FrmFilePath();
            filePath.ShowDialog();
        }
        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定要退出系统吗","退出",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiTool_Click(object sender, EventArgs e)
        {
            FrmToolManage tool = new FrmToolManage();
            tool.ShowDialog();
        }

    }
}
