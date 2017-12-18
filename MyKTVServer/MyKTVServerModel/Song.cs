using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKTVServer.Model
{
    public class Song
    {
        private int SGI_SongId;//歌曲编号

        public int SGI_SongId1
        {
            get { return SGI_SongId; }
            set { SGI_SongId = value; }
        }
        private string SGI_SongName;//歌曲名称

        public string SGI_SongName1
        {
            get { return SGI_SongName; }
            set { SGI_SongName = value; }
        }
        private string SGT_SongTypeName;//歌曲类型

        public string SGT_SongTypeName1
        {
            get { return SGT_SongTypeName; }
            set { SGT_SongTypeName = value; }
        }
        private int SGI_SongWordCount;//歌曲名称字数

        public int SGI_SongWordCount1
        {
            get { return SGI_SongWordCount; }
            set { SGI_SongWordCount = value; }
        }
        private string SGI_SongSpell;//歌曲名称拼音简写

        public string SGI_SongSpell1
        {
            get { return SGI_SongSpell; }
            set { SGI_SongSpell = value; }
        }
        private string SRI_SingerName;//歌曲歌手

        public string SRI_SingerName1
        {
            get { return SRI_SingerName; }
            set { SRI_SingerName = value; }
        }
        private int SGI_SongClickRate;//歌曲点击率

        public int SGI_SongClickRate1
        {
            get { return SGI_SongClickRate; }
            set { SGI_SongClickRate = value; }
        }
        private string SGI_SongURL;//歌曲路径

        public string SGI_SongURL1
        {
            get { return SGI_SongURL; }
            set { SGI_SongURL = value; }
        }
    }
}
