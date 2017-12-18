using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MyKTVServer.Model;

namespace MyKTVServer.DAL
{
    public class SingerService
    {
        DBHandle db = new DBHandle();
        /// <summary>
        /// 查询歌手信息
        /// </summary>
        /// <param name="SingerName"></param>
        /// <param name="SingerType"></param>
        /// <returns></returns>
        public List<Singer> GetSingerList(string SingerName, string SingerType)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat(@"select si.SRI_SingeId,si.SRI_SingePhotoURL,si.SRI_SingerName,
                            st.SRT_SingerTypeName from SingerInfo as si,SingerType as st where 
                            si.SRI_SingeTypeId = st.SRT_SingerTypeId and si.SRI_SingerName like 
                            '%{0}%'", SingerName);
                if (SingerType != "")
                {
                    sb.AppendFormat(" and st.SRT_SingerTypeName = '{0}'", SingerType);
                }
                SqlDataReader reader = db.GetManyResult(sb.ToString());
                List<Singer> singerList = new List<Singer>();
                while (reader.Read())
                {
                    Singer singer = new Singer();
                    singer.SRI_SingeId1 = Convert.ToInt32(reader["SRI_SingeId"]);
                    singer.SRI_SingePhotoURL1 = reader["SRI_SingePhotoURL"].ToString();
                    singer.SRI_SingerName1 = reader["SRI_SingerName"].ToString();
                    singer.SRT_SingerTypeName1 = reader["SRT_SingerTypeName"].ToString();
                    singerList.Add(singer);
                }

                db.Reader.Close();
                return singerList;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        /// <summary>
        /// 删除歌手
        /// </summary>
        /// <param name="singerId"></param>
        /// <returns></returns>
        public bool DeleteSinger(int singerId)
        {
            string sql = string.Format("delete SingerInfo where SRI_SingeId = {0}",singerId);
            if(db.GetReviseResult(sql) == 1)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 获得歌手类型ID
        /// </summary>
        public int GetSingerTypeId(string singerTypeName)
        {
            string sql = string.Format("select SRT_SingerTypeId from SingerType where SRT_SingerTypeName = '{0}'", singerTypeName);
            return Convert.ToInt32(db.GetOneResult(sql));
        }
        /// <summary>
        /// 新增歌手
        /// </summary>
        /// <param name="singer"></param>
        /// <returns></returns>
        public bool UpdataSinger(Singer singer)
        {
            string sql = string.Format("insert SingerInfo values('{0}',{1},'{2}')",singer.SRI_SingerName1
                                        , GetSingerTypeId(singer.SRT_SingerTypeName1),singer.SRI_SingePhotoURL1);
            if(db.GetReviseResult(sql) == 1)
            {
                return true;
            }
            return false;
        }
    }
}
