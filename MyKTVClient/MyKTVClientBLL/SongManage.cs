using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyKTVClient.DAL;
using MyKTVClient.Model;

namespace MyKTVClient.BLL
{
    public class SongManage
    {
        SongService songService = new SongService();
        /// <summary>
        /// 获得歌曲集合
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public List<SongInfo> GetSongList(string SearchType,string SearchText)
        {
            return songService.GetSongList(SearchType,SearchText);
        }
        /// <summary>
        /// 更新播放次数
        /// </summary>
        /// <param name="p"></param>
        public void CountAdd(int songId)
        {
            songService.CountAdd(songId);
        }
        /// <summary>
        /// 获得总路径
        /// </summary>
        public string GetAllURL()
        {
            return songService.GetAllURL();
        }
    }
}
