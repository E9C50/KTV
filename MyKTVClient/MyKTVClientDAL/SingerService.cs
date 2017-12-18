using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MyKTVClient.Model;

namespace MyKTVClient.DAL
{
    public class SingerService
    {
        DBHandle db = new DBHandle();
        /// <summary>
        /// 获取歌手列表
        /// </summary>
        /// <param name="singerType"></param>
        /// <returns></returns>
        public List<SingerInfo> GetSingerList(string singerType)
        {
            string getSingerSql = "";
            if(singerType != "")
            {
                string getTypeSql = string.Format("select SRT_SingerTypeId from SingerType where SRT_SingerTypeName = '{0}'", singerType);
                int singerTypeId = Convert.ToInt32(db.GetOneResult(getTypeSql));
                getSingerSql = string.Format("select * from SingerInfo as i,SingerType as t where i.SRI_SingeTypeId = t.SRT_SingerTypeId and SRI_SingeTypeId = {0}", singerTypeId);
            }
            else
            {
                getSingerSql = "select * from SingerInfo as i,SingerType as t where i.SRI_SingeTypeId = t.SRT_SingerTypeId";
            }
            SqlDataReader reader = db.GetManyResult(getSingerSql);
            List<SingerInfo> singerList = new List<SingerInfo>();
            while(reader.Read())
            {
                SingerInfo singer = new SingerInfo();
                singer.SRI_SingeId1 = Convert.ToInt32(reader["SRI_SingeId"]);
                singer.SRI_SingePhotoURL1 = reader["SRI_SingePhotoURL"].ToString();
                singer.SRI_SingerName1 = reader["SRI_SingerName"].ToString();
                singer.SRI_SingeType1 = reader["SRT_SingerTypeName"].ToString();
                singerList.Add(singer);
            }
            return singerList;
        }
        /// <summary>
        /// 获得总路径
        /// </summary>
        /// <returns></returns>
        public string GetAllURL()
        {
            string sql = string.Format("select FP_FilePathURL from FilePath where FP_FilePathName = '歌手照片'");
            return db.GetOneResult(sql).ToString();
        }
    }
}
