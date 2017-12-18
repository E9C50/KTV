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
    public partial class FrmSongManage : Form
    {
        #region 加载
        SongManage songmanage = new SongManage();
        SingerManage singermanage = new SingerManage();
        public FrmSongManage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSongManage_Load(object sender, EventArgs e)
        {
            SearchSongs();
            GetSingerNameList();
            this.cmbSinger.Text = "";
            this.cmbSingerSearch.Text = "";
        }
        #endregion
        #region 绑定
        /// <summary>
        /// 绑定歌手下拉框
        /// </summary>
        public void GetSingerNameList()
        {
            List<Singer> singerList = singermanage.GetSingerList("", "");
            List<string> singerNameList = new List<string>();
            for (int i = 0; i < singerList.Count;i++ )
            {
                singerNameList.Add(singerList[i].SRI_SingerName1);
            }
            this.cmbSinger.DataSource = singerNameList;
            this.cmbSingerSearch.DataSource = singerNameList;
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
        /// 查询清空
        /// </summary>
        public void CleanSearch()
        {
            this.txtSongSearch.Text = "";
            this.cmbSingerSearch.Text = "";
            this.cmbTypeSearch.Text = "";
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
        /// 新增清空
        /// </summary>
        public void CleanAdd()
        {
            this.txtFilePath.Text = "";
            this.txtSong.Text = "";
            this.txtSpell.Text = "";
            this.cmbSinger.Text = "";
            this.cmbType.Text = "";
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
            SearchSongs();
        }
        /// <summary>
        /// 查询歌曲
        /// </summary>
        public void SearchSongs()
        {
            List<Song> songList = songmanage.SearchSong(this.txtSongSearch.Text.Trim(),
                                                                this.cmbTypeSearch.Text.Trim(),
                                                                this.cmbSingerSearch.Text.Trim());
            if(songList.Count == 0)
            {
                MessageBox.Show("没有查到数据","查询",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            this.dgvSongList.DataSource = songList;
        }
        #endregion
        #region 删除
        /// <summary>
        /// 删除按钮单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            DialogResult sure = MessageBox.Show("确定要删除吗","删除",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(sure == DialogResult.OK)
            {
                bool result = songmanage.DeleteSong(Convert.ToInt32(this.dgvSongList.SelectedRows[0].Cells[0].Value));
                if (result)
                {
                    MessageBox.Show(this.dgvSongList.SelectedRows[0].Cells[1].Value + "已被删除", "删除", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CleanSearch();
                    SearchSongs();
                    return;
                }
                MessageBox.Show("删除失败", "删除", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region 添加
        /// <summary>
        /// 非空判断
        /// </summary>
        public bool CheckInput()
        {
            if (this.txtSong.Text.Trim() == "")
            {
                MessageBox.Show("歌名不能为空", "上传", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtSong.Focus();
                return false;
            }
            if (this.cmbSinger.Text.Trim() == "")
            {
                MessageBox.Show("歌手姓名不能为空", "上传", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cmbSinger.Focus();
                return false;
            }
            if (this.cmbType.Text.Trim() == "")
            {
                MessageBox.Show("歌曲类型不能为空", "上传", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cmbType.Focus();
                return false;
            }
            if (this.txtSpell.Text.Trim() == "")
            {
                MessageBox.Show("拼音简写不能为空", "上传", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtSpell.Focus();
                return false;
            }
            if(this.txtFilePath.Text.Trim() == "")
            {
                MessageBox.Show("请选择文件","上传",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.txtFilePath.Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// 浏览文件按钮
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
            if(result == DialogResult.OK)
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
            if (CheckInput())
            {
                UpdataSong();
            }
        }
        /// <summary>
        /// 新增歌曲
        /// </summary>
        public void UpdataSong()
        {
            if(songmanage.SearchSong(this.txtSong.Text.Trim(),this.cmbType.Text.Trim(),this.cmbSinger.Text.Trim()).Count == 0)
            {
                Song song = new Song();
                song.SGI_SongClickRate1 = 0;
                song.SGI_SongName1 = this.txtSong.Text.Trim();
                song.SGI_SongSpell1 = this.txtSpell.Text.Trim();
                song.SGI_SongURL1 = this.txtFilePath.Text.Trim();
                song.SGI_SongWordCount1 = this.txtSong.Text.Trim().Length;
                song.SGT_SongTypeName1 = this.cmbType.Text.Trim();
                song.SRI_SingerName1 = this.cmbSinger.Text.Trim();
                bool result = songmanage.UpdataSong(song);
                if (result)
                {
                    MessageBox.Show("新增成功", "新增", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CleanAdd();
                    CleanSearch();
                    SearchSongs();
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
