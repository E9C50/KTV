using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MyKTVServer.Model;

namespace MyKTVServer.DAL
{
    public class SongService
    {
        DBHandle db = new DBHandle();
        #region 通过名称查ID
        /// <summary>
        /// 获取歌曲类型ID
        /// </summary>
        /// <returns></returns>
        public int GetTypeId(string songTypeName)
        {
            string sql = string.Format("select SGT_SongTypeId from SongType where SGT_SongTypeName = '{0}'", songTypeName);
            return Convert.ToInt32(db.GetOneResult(sql));
        }
        /// <summary>
        /// 获取歌手ID
        /// </summary>
        /// <param name="singerName"></param>
        /// <returns></returns>
        public int GetSingerId(string singerName)
        {
            string sql = string.Format("select SRI_SingeId from SingerInfo where SRI_SingerName = '{0}'", singerName);
            return Convert.ToInt32(db.GetOneResult(sql));
        }
        #endregion
        #region 查询
        /// <summary>
        /// 查询歌曲
        /// </summary>
        /// <param name="songName"></param>
        /// <param name="songType"></param>
        /// <param name="singer"></param>
        /// <returns></returns>
        public List<Song> SearchSong(string songName, string songType, string singer)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat(@"select si.*,st.SGT_SongTypeName,se.SRI_SingerName from SongInfo as si,
                            SongType as st,SingerInfo as se where si.SGI_SongSingerId = se.SRI_SingeId 
                            and si.SGI_SongTypeId = st.SGT_SongTypeId and si.SGI_SongName like '%{0}%'"
                                                                                                , songName);
                if (singer != "")
                {
                    sb.AppendFormat(" and se.SRI_SingerName = '{0}'", singer);
                }
                if (songType != "")
                {
                    sb.AppendFormat(" and st.SGT_SongTypeName = '{0}'", songType);
                }
                SqlDataReader reader = db.GetManyResult(sb.ToString());
                List<Song> songList = new List<Song>();
                while (reader.Read())
                {
                    Song song = new Song();
                    song.SGI_SongClickRate1 = Convert.ToInt32(reader["SGI_SongClickRate"]);
                    song.SGI_SongId1 = Convert.ToInt32(reader["SGI_SongId"]);
                    song.SGI_SongName1 = reader["SGI_SongName"].ToString();
                    song.SGI_SongSpell1 = reader["SGI_SongSpell"].ToString();
                    song.SGI_SongURL1 = reader["SGI_SongURL"].ToString();
                    song.SGI_SongWordCount1 = Convert.ToInt32(reader["SGI_SongWordCount"]);
                    song.SGT_SongTypeName1 = reader["SGT_SongTypeName"].ToString();
                    song.SRI_SingerName1 = reader["SRI_SingerName"].ToString();
                    songList.Add(song);
                }

                db.Reader.Close();
                return songList;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        #endregion
        #region 删除
        /// <summary>
        /// 删除歌曲
        /// </summary>
        /// <param name="songId"></param>
        /// <returns></returns>
        public bool DeleteSong(int songId)
        {
            try
            {
                string sql = string.Format("delete SongInfo where SGI_SongId = {0}", songId);
                if (db.GetReviseResult(sql) == 1)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        #endregion
        #region 新增
        /// <summary>
        /// 新增歌曲
        /// </summary>
        /// <param name="song"></param>
        /// <returns></returns>
        public bool UpdataSong(Song song)
        {
            try
            {
                string sql = string.Format("insert SongInfo values('{0}',{1},{2},'{3}',{4},{5},'{6}')",
                        song.SGI_SongName1, GetTypeId(song.SGT_SongTypeName1), song.SGI_SongWordCount1,
                        song.SGI_SongSpell1, GetSingerId(song.SRI_SingerName1), song.SGI_SongClickRate1,
                        song.SGI_SongURL1);
                if (db.GetReviseResult(sql) == 1)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        #endregion
    }
}
