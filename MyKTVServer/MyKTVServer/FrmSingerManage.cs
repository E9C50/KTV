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
    public partial class FrmSingerManage : Form
    {
        #region 加载
        SingerManage singermanage = new SingerManage();
        public FrmSingerManage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSingerManage_Load(object sender, EventArgs e)
        {
            SearchSinger();
        }
        #endregion
        #region 查询
        /// <summary>
        /// 查询按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchSinger();
        }
        /// <summary>
        /// 查询歌手信息
        /// </summary>
        public void SearchSinger()
        {
            List<Singer> singerList = singermanage.GetSingerList(this.txtSingerNameSearch.Text.Trim(),
                                                this.cmbSingerTypeSearch.Text.Trim());
            if(singerList.Count == 0)
            {
                MessageBox.Show("没有查到数据", "查询", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.dgvSingerList.DataSource = singerList;
        }
        #endregion
        #region 清空
        /// <summary>
        /// 查询清空按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCleanSearch_Click(object sender, EventArgs e)
        {
            CleanSearch();
        }
        /// <summary>
        /// 清空查询
        /// </summary>
        public void CleanSearch()
        {
            this.txtSingerNameSearch.Text = "";
            this.cmbSingerTypeSearch.Text = "";
        }
        /// <summary>
        /// 新增清空按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCleanAdd_Click(object sender, EventArgs e)
        {
            CleanAdd();
        }
        /// <summary>
        /// 清空新增
        /// </summary>
        public void CleanAdd()
        {
            this.txtSingerName.Text = "";
            this.txtFilePath.Text = "";
            this.cmbSingerType.Text = "";
        }
        #endregion
        #region 删除
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            bool result = singermanage.DeleteSinger(Convert.ToInt32(this.dgvSingerList.SelectedRows[0].Cells[0].Value));
            if (result)
            {
                MessageBox.Show(this.dgvSingerList.SelectedRows[0].Cells[1].Value + "已被删除", "删除", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CleanSearch();
                SearchSinger();
                return;
            }
            MessageBox.Show("删除失败", "删除", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
        #region 上传
        /// <summary>
        /// 浏览按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFindFilePath_Click(object sender, EventArgs e)
        {
             FindFilePath();
        }
        /// <summary>
        /// 浏览文件
        /// </summary>
        public void FindFilePath()
        {
            OpenFileDialog openfile = new OpenFileDialog();
            DialogResult result = openfile.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.txtFilePath.Text = openfile.SafeFileName;
            }
        }
        /// <summary>
        /// 上传按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpData_Click(object sender, EventArgs e)
        {
            if(CheckInput())
            {
                UpdataSinger();
            }
        }
        /// <summary>
        /// 非空验证
        /// </summary>
        /// <returns></returns>
        public bool CheckInput()
        {
            if(this.txtSingerName.Text.Trim() == "")
            {
                MessageBox.Show("歌手姓名不能为空","新增",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.txtSingerName.Focus();
                return false;
            }
            if (this.cmbSingerType.Text.Trim() == "")
            {
                MessageBox.Show("歌手类型不能为空", "新增", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cmbSingerType.Focus();
                return false;
            }
            if (this.txtFilePath.Text.Trim() == "")
            {
                MessageBox.Show("歌手照片不能为空", "新增", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtFilePath.Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// 新增歌手
        /// </summary>
        public void UpdataSinger()
        {
            if(singermanage.GetSingerList(this.txtSingerName.Text.Trim(),this.cmbSingerType.Text.Trim()).Count == 0)
            {
                Singer singer = new Singer();
                singer.SRI_SingerName1 = this.txtSingerName.Text.Trim();
                singer.SRT_SingerTypeName1 = this.cmbSingerType.Text.Trim();
                singer.SRI_SingePhotoURL1 = this.txtFilePath.Text.Trim();
                bool result = singermanage.UpdataSinger(singer);
                if (result)
                {
                    MessageBox.Show("新增成功", "新增", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CleanAdd();
                    CleanSearch();
                    SearchSinger();
                    return;
                }
                MessageBox.Show("新增失败", "新增", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("该歌手已存在，无需添加","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        #endregion
    }
}
