using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MyKTVServer.BLL;
using MyKTVServer.Model;

namespace MyKTVServer
{
    public partial class FrmFilePath : Form
    {
        public string FilePathType = "歌曲文件";
        PathManage pathmanage = new PathManage();
        public FrmFilePath()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 浏览文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScan_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if(result == DialogResult.OK)
            {
                this.txtNewPath.Text = fbd.SelectedPath;
            }
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 获得旧路径
        /// </summary>
        public void GetOldPath()
        {
            string oldPath = pathmanage.GetOldPath(FilePathType);
            this.txtOldPath.Text = oldPath;
        }
        /// <summary>
        /// 歌曲文件rdo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoSong_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rdoSong.Checked == true)
            {
                this.FilePathType = "歌曲文件";
                GetOldPath();
            }
        }
        /// <summary>
        /// 歌手照片rdo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdoSinger_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rdoSinger.Checked == true)
            {
                this.FilePathType = "歌手照片";
                GetOldPath();
            }
        }
        /// <summary>
        /// 食物照片rdo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rboFood_CheckedChanged(object sender, EventArgs e)
        {
            if(this.rdoFood.Checked == true)
            {
                this.FilePathType = "食物照片";
                GetOldPath();
            }
        }
        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmFilePath_Load(object sender, EventArgs e)
        {
            GetOldPath();
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(CopyFileToNew())
            {
                bool result = pathmanage.UpdatePath(FilePathType, this.txtNewPath.Text.Trim());
                if (result)
                {
                    MessageBox.Show("更新目录成功", "更新", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
                MessageBox.Show("更新目录失败", "更新", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 复制源目录下的文件到新目录
        /// </summary>
        public bool CopyFileToNew()
        {
            try
            {
                string newPath = this.txtNewPath.Text.Trim();
                string[] files = Directory.GetFiles(pathmanage.GetOldPath(FilePathType));//获取源目录下的所有文件的地址
                foreach (string fl in files)
                {
                    string photoName = Path.GetFileName(fl);//获取每个文件的名字
                    string destPath = this.txtNewPath.Text + "\\" + photoName;
                    File.Copy(fl, destPath, true);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
