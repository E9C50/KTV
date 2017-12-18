using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using MyKTVClient.BLL;
using MyKTVClient.Model;

namespace MyKTVClient
{
    public partial class FrmPlaySong : Form
    {
        PhoneConnTool phone = new PhoneConnTool();
        public static int pause = 0;
        public static int truck = 0;
        private int volume = 50;

        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }
        private SongInfo song;
        public FrmPlaySong()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPlaySong_Load(object sender, EventArgs e)
        {
            Thread connThread = new Thread(new ParameterizedThreadStart(StartServer));
            connThread.Start();
            this.wmp.SetVolume(50);
            FrmMain main = new FrmMain();
            FrmMain.phone = phone;
            FrmMain.play = this;
            main.Show();
        }
        /// <summary>
        /// 开启连接
        /// </summary>
        /// <param name="obj"></param>
        public void StartServer(Object obj)
        {
            phone.play = this;
            phone.Listen();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //当播放器没有歌曲时，获取歌曲并播放
            if (this.song == null)
            {
                this.PlaySong();
            }
            //重放(当播放器有歌曲并且歌曲状态为重放时)
            if (this.song != null && this.song.PlayState == SongPlayState.again)
            {
                this.PlaySong();
            }
            //当播放器停止时，点播下一首歌曲
            if (this.wmp.GetState() == 0)
            {
                bool result = PlayList.MoveOn();
                if(!result)
                {
                    this.wmp.Close();
                    return;
                }
                this.wmp.Open("");
                this.song = null;//将歌曲置空
            }
            //切歌
            if (this.song != null && this.song.PlayState == SongPlayState.cut)
            {
                this.wmp.Open("");
                this.song = null;
            }
            }
        /// <summary>
        /// 获得总路径
        /// </summary>
        /// <returns></returns>
        public string GetAllURL()
        {
            SongManage songmanage = new SongManage();
            return songmanage.GetAllURL();
        }
        /// <summary>
        /// 播放歌曲
        /// </summary>
        public void PlaySong()
        {
            song = PlayList.GetPlayingSong();   //获取当前播放列表里的歌曲
            if (song != null)
            {
                song.PlayState = SongPlayState.played;    //已播放
                this.wmp.Open(GetAllURL() + "\\" + song.SGI_SongURL1);
            }
        }
        /// <summary>
        /// 播放成功事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void wmp_OnOpenSucceeded(object sender, EventArgs e)
        {
            FrmMain.play = this;
            FrmCountType.play = this;
            FrmSingerSearch.play = this;
            FrmSingerType.play = this;
            FrmSpell.play = this;
            this.wmp.SetConfig(403, truck.ToString());
        }
        /// <summary>
        /// 气氛
        /// </summary>
        public void SetFace(string path)
        {
            this.wmp.SetConfig(602, "1");
            int num1 = this.Width / 2;
            int num2 = Convert.ToInt32(this.wmp.GetConfig(604)) / 2;
            this.wmp.SetConfig(606, (num1 - num2).ToString());
            this.wmp.SetConfig(618, path);
            int num3 = this.Width / 2;
            int num4 = Convert.ToInt32(this.wmp.GetConfig(604)) / 2;
            this.wmp.SetConfig(606, (num3 - num4).ToString());
            int num5 = this.Height / 2;
            int num6 = Convert.ToInt32(this.wmp.GetConfig(605)) / 2;
            this.wmp.SetConfig(607, (num5 - num6).ToString());
            int num7 = this.Height / 2;
            int num8 = Convert.ToInt32(this.wmp.GetConfig(605)) / 2;
            this.wmp.SetConfig(607, (num7 - num8).ToString());
            this.wmp.SetConfig(618, path);
            Thread thread = new Thread(NewThread);
            thread.Start();
        }

        public void NewThread()
        {
            Thread.Sleep(3000);
            this.wmp.SetConfig(602, "0");
           
        }
        public int AddVolume()
        {
            this.volume += 10;
            this.wmp.SetVolume(this.wmp.GetVolume() + 10);
            return volume;
        }
        public int DelVolume()
        {
            this.volume -= 10;
            this.wmp.SetVolume(this.wmp.GetVolume() - 10);
            return volume;
        }
        public void Pause(int num)
        {
            if(num == 0)
            {
                this.wmp.Play();
                FrmPlaySong.pause = 0;
            }
            else
            {
                this.wmp.Pause();
                FrmPlaySong.pause = 1;
            }
        }

    }
}
