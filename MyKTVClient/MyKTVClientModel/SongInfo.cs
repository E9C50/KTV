using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKTVClient.Model
{
    public enum SongPlayState
    {
        unplayed, played, again, cut
    }
    public class SongInfo
    {
      
        private int SGI_SongId;

        public int SGI_SongId1
        {
            get { return SGI_SongId; }
            set { SGI_SongId = value; }
        }
        private string SGI_SongName;

        public string SGI_SongName1
        {
            get { return SGI_SongName; }
            set { SGI_SongName = value; }
        }
        private string SGI_SongType;

        public string SGI_SongType1
        {
            get { return SGI_SongType; }
            set { SGI_SongType = value; }
        }
        private int SGI_SongWordCount;

        public int SGI_SongWordCount1
        {
            get { return SGI_SongWordCount; }
            set { SGI_SongWordCount = value; }
        }
        private string SGI_SongSpell;

        public string SGI_SongSpell1
        {
            get { return SGI_SongSpell; }
            set { SGI_SongSpell = value; }
        }
        private string SGI_SongSinger;

        public string SGI_SongSinger1
        {
            get { return SGI_SongSinger; }
            set { SGI_SongSinger = value; }
        }
        private int SGI_SongClickRate;

        public int SGI_SongClickRate1
        {
            get { return SGI_SongClickRate; }
            set { SGI_SongClickRate = value; }
        }
        private string SGI_SongURL;

        public string SGI_SongURL1
        {
            get { return SGI_SongURL; }
            set { SGI_SongURL = value; }
        }
        private SongPlayState playState = SongPlayState.unplayed;//歌曲播放状态

        public SongPlayState PlayState
        {
            get { return playState; }
            set { playState = value; }
        }
    }
}
