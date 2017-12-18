using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyKTVServer.DAL;
using MyKTVServer.Model;

namespace MyKTVServer.BLL
{
    public class SongManage
    {
        SongService songservice = new SongService();
        /// <summary>
        /// 查询歌曲
        /// </summary>
        /// <param name="songName"></param>
        /// <param name="songType"></param>
        /// <param name="singer"></param>
        /// <returns></returns>
        public List<Song> SearchSong(string songName, string songType, string singer)
        {
            return songservice.SearchSong(songName,songType,singer);
        }
        /// <summary>
        /// 删除歌曲
        /// </summary>
        /// <param name="songId"></param>
        /// <returns></returns>
        public bool DeleteSong(int songId)
        {
            return songservice.DeleteSong(songId);
        }
        /// <summary>
        /// 新增歌曲
        /// </summary>
        /// <param name="song"></param>
        /// <returns></returns>
        public bool UpdataSong(Song song)
        {
            return songservice.UpdataSong(song);
        }
    }
}
