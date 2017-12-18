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
    public partial class FrmSingerType : Form
    {
        RoomManage roommanage = new RoomManage();
        public static PhoneConnTool phone = null;
        FrmMain frmmain = new FrmMain();
        public FrmSingerType()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// 华语男歌手
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlCHMan_Click(object sender, EventArgs e)
        {
            FrmSingerSearch singerSearch = new FrmSingerSearch();
            singerSearch.singerType = "华语男歌手";
            FrmSingerSearch.play = FrmSingerType.play;
            FrmSingerSearch.phone = FrmMain.phone;
            singerSearch.Show();
        }
        /// <summary>
        /// 华语女歌手
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlCHWomen_Click(object sender, EventArgs e)
        {
            FrmSingerSearch singerSearch = new FrmSingerSearch();
            singerSearch.singerType = "华语女歌手";
            FrmSingerSearch.play = FrmSingerType.play;
            FrmSingerSearch.phone = FrmMain.phone;
            singerSearch.Show();
        }
        /// <summary>
        /// 港台男歌手
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlHKMen_Click(object sender, EventArgs e)
        {
            FrmSingerSearch singerSearch = new FrmSingerSearch();
            singerSearch.singerType = "港台男歌手";
            FrmSingerSearch.play = FrmSingerType.play;
            FrmSingerSearch.phone = FrmMain.phone;
            singerSearch.Show();
        }
        /// <summary>
        /// 港台女歌手
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlHKWomen_Click(object sender, EventArgs e)
        {
            FrmSingerSearch singerSearch = new FrmSingerSearch();
            singerSearch.singerType = "港台女歌手";
            FrmSingerSearch.play = FrmSingerType.play;
            FrmSingerSearch.phone = FrmMain.phone;
            singerSearch.Show();
        }
        /// <summary>
        /// 欧美男歌手
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlAUMen_Click(object sender, EventArgs e)
        {
            FrmSingerSearch singerSearch = new FrmSingerSearch();
            singerSearch.singerType = "欧美男歌手";
            FrmSingerSearch.play = FrmSingerType.play;
            FrmSingerSearch.phone = FrmMain.phone;
            singerSearch.Show();
        }
        /// <summary>
        /// 欧美女歌手
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlAUWomen_Click(object sender, EventArgs e)
        {
            FrmSingerSearch singerSearch = new FrmSingerSearch();
            singerSearch.singerType = "欧美女歌手";
            FrmSingerSearch.play = FrmSingerType.play;
            FrmSingerSearch.phone = FrmMain.phone;
            singerSearch.Show();
        }
        /// <summary>
        /// 国内组合
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlCHTeam_Click(object sender, EventArgs e)
        {
            FrmSingerSearch singerSearch = new FrmSingerSearch();
            singerSearch.singerType = "中国组合";
            FrmSingerSearch.play = FrmSingerType.play;
            FrmSingerSearch.phone = FrmMain.phone;
            singerSearch.Show();
        }
        /// <summary>
        /// 国外组合
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlAUTeam_Click(object sender, EventArgs e)
        {
            FrmSingerSearch singerSearch = new FrmSingerSearch();
            singerSearch.singerType = "国外组合";
            FrmSingerSearch.play = FrmSingerType.play;
            FrmSingerSearch.phone = FrmMain.phone;
            singerSearch.Show();
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
            FrmSongedList.play = FrmSingerType.play;
            FrmSongedList.phone = FrmSingerType.phone;
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
        public static FrmPlaySong play = null;
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
        #endregion

        private void FrmSingerType_Load(object sender, EventArgs e)
        {
            if (FrmPlaySong.truck == 0)
            {
                this.label3.Text = "原唱";
            }
            else
            {
                this.label3.Text = "伴唱";
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
        /// 好棒情单击事件
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
        private void pnlFace_Click(object sender, EventArgs e)
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
        /// 单击连接手机事件
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
