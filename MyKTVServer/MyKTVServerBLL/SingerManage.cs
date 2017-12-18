using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyKTVServer.DAL;
using MyKTVServer.Model;

namespace MyKTVServer.BLL
{
    public class SingerManage
    {
        SingerService singerservice = new SingerService();
        /// <summary>
        /// 查询歌手信息
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public List<Singer> GetSingerList(string SingerName, string SingerType)
        {
            return singerservice.GetSingerList(SingerName,SingerType);
        }
        /// <summary>
        /// 删除歌手信息
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool DeleteSinger(int singerId)
        {
            return singerservice.DeleteSinger(singerId);
        }
        /// <summary>
        /// 新增歌手信息
        /// </summary>
        /// <param name="singer"></param>
        /// <returns></returns>
        public bool UpdataSinger(Singer singer)
        {
            return singerservice.UpdataSinger(singer);
        }
    }
}
