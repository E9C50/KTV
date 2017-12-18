using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyKTVClient.DAL;
using MyKTVClient.Model;

namespace MyKTVClient.BLL
{
    public class SingerManage
    {
        SingerService singerservice = new SingerService();
        /// <summary>
        /// 获取歌手列表
        /// </summary>
        /// <param name="singerType"></param>
        /// <returns></returns>
        public List<SingerInfo> GetSingerList(string singerType)
        {
            return singerservice.GetSingerList(singerType);
        }
        /// <summary>
        /// 获得总路径
        /// </summary>
        /// <returns></returns>
        public string GetAllURL()
        {
            return singerservice.GetAllURL();
        }
    }
}
