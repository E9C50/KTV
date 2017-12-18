using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyKTVClient.BLL;
using MyKTVClient.Model;

namespace MyKTVClient
{
    public partial class FrmSpell : Form
    {

        SongManage songmanage = new SongManage();
        public static PhoneConnTool phone = null;
        public static FrmPlaySong play = null;
        public string SearchType = "拼音";
        public string SearchText = "";
        public FrmSpell()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSongList_Load(object sender, EventArgs e)
        {
            this.txtSpell.Text = "";
            Search();
        }
        /// <summary>
        /// 获得已点歌曲
        /// </summary>
        public void GetSongedList()
        {
            for (int i = 0; i < PlayList.Songgroup.Count; i++)
            {
                if (PlayList.Songgroup[i] == null)
                {
                    break;
                }
                ListViewItem item = new ListViewItem();
                item.Text = PlayList.Songgroup[i].SGI_SongName1;
                item.Tag = PlayList.Songgroup[i].SGI_SongURL1;
                this.lvSongList.Items.Add(item);
            }
        }
        /// <summary>
        /// 拼音查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.SearchText = this.txtSpell.Text.Trim();
            this.lvSongList.Items.Clear();
            Search();
        }
        /// <summary>
        /// 获取歌曲集合
        /// </summary>
        public void Search()
        {
            this.lvSongList.Items.Clear();
            List<SongInfo> songList = songmanage.GetSongList(this.SearchType,this.SearchText);
            for (int i = 0; i < songList.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = songList[i].SGI_SongName1;
                item.Tag = songList[i].SGI_SongId1;
                item.SubItems.Add(songList[i].SGI_SongSinger1);
                this.lvSongList.Items.Add(item);
            }
        }
        /// <summary>
        /// Lv单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvSongList_Click(object sender, EventArgs e)
        {
            if(this.SearchType != "已点")
            {
                List<SongInfo> songList = songmanage.GetSongList("歌名", this.lvSongList.SelectedItems[0].Text);
                SongInfo song = new SongInfo();
                song = songList[0];
                PlayList.Songgroup.Add(song);
                songmanage.CountAdd(song.SGI_SongId1);
            }
        }
        #region 通用功能栏
        /// <summary>
        /// 点餐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlFood_Click(object sender, EventArgs e)
        {
            FrmFood food = new FrmFood();
            food.Show();
        }
        /// <summary>
        /// 主页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlShowMain_Click(object sender, EventArgs e)
        {
            FrmMain frmmain = new FrmMain();
            this.Close();
            frmmain.Show();
        }
        /// <summary>
        /// 已点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlSongList_Click(object sender, EventArgs e)
        {
            FrmSongedList frmsonglist = new FrmSongedList();
            FrmSongedList.play = FrmSpell.play;
            FrmSongedList.phone = FrmSpell.phone;
            frmsonglist.SearchType = "已点";
            frmsonglist.Show();
        }
        /// <summary>
        /// 服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlServer_Click(object sender, EventArgs e)
        {
            RoomManage roommanage = new RoomManage();
            bool result = roommanage.Server(FrmMain.roomId);
            if (result)
            {
                MessageBox.Show("服务发送成功", "服务", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("服务发送失败", "服务", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblLastPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 重唱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlLastSong_Click(object sender, EventArgs e)
        {
            PlayList.PlayAgain();
        }
        /// <summary>
        /// 切歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlNextSong_Click(object sender, EventArgs e)
        {
            bool result = PlayList.CutSong();
            if (!result)
            {
                MessageBox.Show("播放列表已播放完，请再点歌", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 退出结账
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlExit_Click(object sender, EventArgs e)
        {
            DialogResult sure = MessageBox.Show("确定要呼叫服务员结账吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sure == DialogResult.OK)
            {
                RoomManage roommanage = new RoomManage();
                string foodList = roommanage.GetFoodList(FrmMain.roomId);
                int payMoney = roommanage.GetFoodMoney(FrmMain.roomId);
                roommanage.OpenPayServer(FrmMain.roomId);
                DialogResult result = MessageBox.Show("您的餐单如下：\n" + foodList + "消费金额为：" + payMoney + "元。\n欢迎下次光临！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }
        /// <summary>
        /// 刷新当前播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblNowPlay.Text = PlayList.GetPlayingSongName();
            this.lblNextPlay.Text = PlayList.GetNextSongName();
        }
        /// <summary>
        /// 原唱伴唱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlsinger_Click(object sender, EventArgs e)
        {
            if (FrmPlaySong.truck == 0)
            {
                play.wmp.SetConfig(403, "1");
                this.label3.Text = "伴唱";
                FrmPlaySong.truck = 1;
            }
            else if (FrmPlaySong.truck == 1)
            {
                play.wmp.SetConfig(403, "0");
                this.label3.Text = "原唱";
                FrmPlaySong.truck = 0;
            }
        }
        /// <summary>
        /// 玫瑰表情单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmSingerSearch singer = new FrmSingerSearch();
            play.SetFace(singer.GetAllURL() + @"\玫瑰.swf");
        }
        /// <summary>
        /// 好棒表情单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmSingerSearch singer = new FrmSingerSearch();
            play.SetFace(singer.GetAllURL() + @"\你好棒.swf");
        }
        /// <summary>
        /// 气氛单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Click(object sender, EventArgs e)
        {
            if (this.panel2.Visible == true)
            {
                this.panel2.Visible = false;
            }
            else
            {
                this.panel2.Visible = true;
            }
        }
        /// <summary>
        /// 音量加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlAdd_Click(object sender, EventArgs e)
        {
            play.AddVolume();
        }
        /// <summary>
        /// 音量减
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlDel_Click(object sender, EventArgs e)
        {
            play.DelVolume();
        }
        #endregion

        StringBuilder sb = new StringBuilder();
        private void pnlA_Click(object sender, EventArgs e)
        {
            sb.Append("A");
            this.txtSpell.Text = sb.ToString();
        }

        private void pnlB_Click(object sender, EventArgs e)
        {
            sb.Append("B");
            this.txtSpell.Text = sb.ToString();
        }

        private void pnlC_Click(object sender, EventArgs e)
        {
            sb.Append("C");
            this.txtSpell.Text = sb.ToString();
        }

        private void pnlD_Click(object sender, EventArgs e)
        {
            sb.Append("D");
            this.txtSpell.Text = sb.ToString();
        }

        private void pnlE_Click(object sender, EventArgs e)
        {
            sb.Append("E");
            this.txtSpell.Text = sb.ToString();
        }

        private void pnlF_Click(object sender, EventArgs e)
        {
            sb.Append("F");
            this.txtSpell.Text = sb.ToString();
        }

        private void pnlG_Click(object sender, EventArgs e)
        {
            sb.Append("G");
            this.txtSpell.Text = sb.ToString();
        }

        private void pnlH_Click(object sender, EventArgs e)
        {
            sb.Append("H");
            this.txtSpell.Text = sb.ToString();
        }

        private void pnlI_Click(object sender, EventArgs e)
        {
            sb.Append("I");
            this.txtSpell.Text = sb.ToString();
        }

        private void pnlJ_Click(object sender, EventArgs e)
        {
            sb.Append("G");
            this.txtSpell.Text = sb.ToString();
        }

        private void pnlK_Click(object sender, EventArgs e)
        {
            sb.Append("K");
            this.txtSpell.Text = sb.ToString();
        }

        private void pnlL_Click(object sender, EventArgs e)
        {
            sb.Append("L");
            this.txtSpell.Text = sb.ToString();
        }

        private void pnlM_Click(object sender, EventArgs e)
        {
            sb.Append("M");
            this.txtSpell.Text = sb.ToString();
        }

        private void pnlN_Click(object sender, EventArgs e)
        {
            sb.Append("N");
            this.txtSpell.Text = sb.ToString();
        }

        private void pnlO_Click(object sender, EventArgs e)
        {
            sb.Append("O");
            this.txtSpell.Text = sb.ToString();
        }

        private void pnlP_Click(object sender, EventArgs e)
        {
            sb.Append("P");
            this.txtSpell.Text = sb.ToString();
        }

        private void pnlQ_Click(object sender, EventArgs e)
        {
            sb.Append("Q");
            this.txtSpell.Text = sb.ToString();
        }

        private void pnlR_Click(object sender, EventArgs e)
        {
            sb.Append("R");
            this.txtSpell.Text = sb.ToString();
        }

        private void pnlS_Click(object sender, EventArgs e)
        {
            sb.Append("S");
            this.txtSpell.Text = sb.ToString();
        }

        private void pnlT_Click(object sender, EventArgs e)
        {
            sb.Append("T");
            this.txtSpell.Text = sb.ToString();
        }

        private void pnlU_Click(object sender, EventArgs e)
        {
            sb.Append("U");
            this.txtSpell.Text = sb.ToString();
        }

        private void pnlV_Click(object sender, EventArgs e)
        {
            sb.Append("V");
            this.txtSpell.Text = sb.ToString();
        }

        private void pnlW_Click(object sender, EventArgs e)
        {
            sb.Append("W");
            this.txtSpell.Text = sb.ToString();
        }

        private void pnlX_Click(object sender, EventArgs e)
        {
            sb.Append("X");
            this.txtSpell.Text = sb.ToString();
        }

        private void pnlY_Click(object sender, EventArgs e)
        {
            sb.Append("Y");
            this.txtSpell.Text = sb.ToString();
        }

        private void pnlZ_Click(object sender, EventArgs e)
        {
            sb.Append("Z");
            this.txtSpell.Text = sb.ToString();
        }

        private void pnlDelete_Click(object sender, EventArgs e)
        {
            if(sb.Length==0)
            {
                return;
            }
            sb.Remove(sb.Length-1,1);
            this.txtSpell.Text = sb.ToString();
        }

        private void txtSpell_TextChanged(object sender, EventArgs e)
        {
            this.SearchText = this.txtSpell.Text.Trim(); ;
            Search();
        }
        /// <summary>
        /// 单击连接手事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlConnPhone_Click(object sender, EventArgs e)
        {
            if (this.qrIP.Visible == false)
            {
                this.qrIP.Visible = true;
                this.qrIP.Text = phone.GetIPAddress();
            }
            else if (this.qrIP.Visible == true)
            {
                this.qrIP.Visible = false;
            }
        }
        /// <summary>
        /// 暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlPause_Click(object sender, EventArgs e)
        {
            if (this.lblPause.Text.Trim() == "播放")
            {
                play.Pause(0);
                this.lblPause.Text = "暂停";
            }
            else if (this.lblPause.Text.Trim() == "暂停")
            {
                play.Pause(1);
                this.lblPause.Text = "播放";
            }
        }

        private void timBtnStatic_Tick(object sender, EventArgs e)
        {
            if (FrmPlaySong.truck == 0)
            {
                this.label3.Text = "原唱";
            }
            else
            {
                this.label3.Text = "伴唱";
            }
            if (FrmPlaySong.pause == 0)
            {
                this.lblPause.Text = "暂停";
            }
            else
            {
                this.lblPause.Text = "播放";
            }
        }


        
    }
}
