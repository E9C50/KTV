using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyKTVClient.Model;
using MyKTVClient.DAL;

namespace MyKTVClient.BLL
{
    public class PlayList
    {
        private static List<SongInfo> songgroup = new List<SongInfo>();

        public static List<SongInfo> Songgroup
        {
            get { return PlayList.songgroup; }
            set { PlayList.songgroup = value; }
        }



        private static int index = 0;                          //当前播放歌曲在数组中的索引

        public static int Index
        {
            get { return PlayList.index; }
            set { PlayList.index = value; }
        }

        #region 获取当前播放的歌曲
        /// <summary>
        /// 获取当前播放的歌曲
        /// </summary>
        /// <returns>当前播放的歌曲</returns>
        public static SongInfo GetPlayingSong()
        {
            if (songgroup.Count == 0)
            {
                return null;
            }
            if (songgroup[index] != null)
            {
                return songgroup[index];
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region 当前播放的歌曲名称
        /// <summary>
        /// 获取当前播放的歌曲名称
        /// </summary>
        /// <returns>当前播放的歌曲名称</returns>
        public static string GetPlayingSongName()
        {
            string songname = string.Empty;
            if(songgroup.Count == 0 || songgroup.Count == index)
            {
                return "歌曲已播放完";
            }
            if (songgroup[index] != null)
            {
                songname = songgroup[index].SGI_SongName1;
            }
            return songname;
        }
        #endregion

        #region 获取下一首要播放的歌曲名称
        /// <summary>
        /// 获取下一首要播放的歌曲名称
        /// </summary>
        /// <returns>下一首要播放的歌曲名称</returns>
        public static string GetNextSongName()
        {
            string songname = string.Empty;
            if (songgroup.Count == 0 || songgroup.Count == index)
            {
                return "歌曲已播放完";
            }
            if (index+1 != songgroup.Count)
            {
                if (songgroup[index + 1] == null)
                {
                    return "歌曲已播放完";
                }
                songname = songgroup[index + 1].SGI_SongName1;
            }
            return songname;
        }
        #endregion

        #region  获取已点歌曲数量
        /// <summary>
        /// 获取已点歌曲数量
        /// </summary>
        /// <returns>已点歌曲数量</returns>
        public static int GetSongCounts()
        {
            int counts = 0;
            for (int i = 0; i < songgroup.Count; i++)
            {
                if (songgroup[i] != null)
                {
                    counts++;
                }
            }
            return counts;
        }
        #endregion

        #region 切歌
        /// <summary>
        /// 切歌
        /// </summary>
        public static bool CutSong()
        {
            try
            {
                int i = index;
                if (songgroup.Count == 1 || songgroup.Count == 0 || songgroup[i + 1] == null)
                {
                    return false;
                }
                songgroup[i].PlayState = SongPlayState.cut;
                while (songgroup[i] != null)
                {
                    if (i == songgroup.Count - 1)
                    {
                        songgroup.RemoveAt(songgroup.Count - 2);
                        return true;
                    }
                    songgroup[i] = songgroup[i + 1];
                    i++;
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion

        #region 重放
        /// <summary>
        /// 重放
        /// </summary>
        public static void PlayAgain()
        {
            if (songgroup.Count == 0)
            {
                return;
            }
            if (songgroup[index] != null)
            {
                songgroup[index].PlayState = SongPlayState.again;
            }
        }
        #endregion

        #region 下一曲
        /// <summary>
        /// 下一曲
        /// </summary>
        public static bool MoveOn()
        {
            int i = index;
            if(songgroup.Count == i+1 || songgroup.Count == 0)
            {
                return false;
            }
            songgroup.RemoveAt(0);
            return true;
        }
        #endregion
    }
}
