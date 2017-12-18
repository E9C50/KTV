using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MyKTVClient.Model;

namespace MyKTVClient.DAL
{
    public class SongService
    {
        DBHandle db = new DBHandle();
        /// <summary>
        /// 获取歌曲集合
        /// </summary>
        /// <param name="SingerName"></param>
        /// <returns></returns>
        public List<SongInfo> GetSongList(string SearchType, string SearchText)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"select SGI_SongClickRate,SGI_SongId,SGI_SongName,SGI_SongSpell,SGI_SongURL,
                        SGI_SongWordCount,SRI_SingerName,SGT_SongTypeName from SongInfo as so,
                        SingerInfo as si,SongType as st where so.SGI_SongSingerId = si.SRI_SingeId 
                        and so.SGI_SongTypeId = st.SGT_SongTypeId");
            if(SearchType == "歌手")
            {
                sb.AppendFormat(" and si.SRI_SingerName = '{0}'", SearchText);
            }
            if(SearchType == "歌名")
            {
                sb.AppendFormat(" and SGI_SongName = '{0}'", SearchText);
            }
            if(SearchType == "字数")
            {
                if(SearchText != "")
                {
                    sb.AppendFormat(" and SGI_SongWordCount = {0}", SearchText);
                }
            }
            if(SearchType == "类型")
            {
                if(SearchText != "")
                {
                    sb.AppendFormat(" and st.SGT_SongTypeName = '{0}'", SearchText);
                }
            }
            if(SearchType == "拼音")
            {
                sb.AppendFormat(" and SGI_SongSpell like '{0}%'", SearchText);
            }
            if(SearchType == "排行")
            {
                sb.Append(" order by SGI_SongClickRate desc");
            }
            if(SearchType == "歌名s")
            {
                sb.AppendFormat(" and SGI_SongName like '%{0}%'", SearchText);
            }
            SqlDataReader reader = db.GetManyResult(sb.ToString());
            List<SongInfo> songList = new List<SongInfo>();
            while(reader.Read())
            {
                SongInfo song = new SongInfo();
                song.SGI_SongClickRate1 = Convert.ToInt32(reader["SGI_SongClickRate"]);
                song.SGI_SongId1 = Convert.ToInt32(reader["SGI_SongId"]);
                song.SGI_SongName1 = reader["SGI_SongName"].ToString();
                song.SGI_SongSinger1 = reader["SRI_SingerName"].ToString();
                song.SGI_SongSpell1 = reader["SGI_SongSpell"].ToString();
                song.SGI_SongType1 = reader["SGT_SongTypeName"].ToString();
                song.SGI_SongURL1 = reader["SGI_SongURL"].ToString();
                song.SGI_SongWordCount1 = Convert.ToInt32(reader["SGI_SongWordCount"]);
                songList.Add(song);
            }
            return songList;
        }
        /// <summary>
        /// 更新播放次数
        /// </summary>
        /// <param name="Count"></param>
        public void CountAdd(int songId)
        {
            string sql = string.Format("update SongInfo set SGI_SongClickRate = SGI_SongClickRate + 1 where SGI_SongId = {0}",songId);
            db.GetReviseResult(sql);
        }
        /// <summary>
        /// 获得总路径
        /// </summary>
        /// <returns></returns>
        public string GetAllURL()
        {
            string sql = string.Format("select FP_FilePathURL from FilePath where FP_FilePathName = '歌曲文件'");
            return db.GetOneResult(sql).ToString();
        }
    }
}
