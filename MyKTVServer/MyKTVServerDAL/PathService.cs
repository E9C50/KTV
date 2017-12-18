using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyKTVServer.Model;

namespace MyKTVServer.DAL
{
    public class PathService
    {
        DBHandle db = new DBHandle();
        /// <summary>
        /// 获得旧地址
        /// </summary>
        /// <param name="filePathType"></param>
        /// <returns></returns>
        public string GetOldPath(string filePathType)
        {
            try
            {
                string sql = string.Format("select FP_FilePathURL from FilePath where FP_FilePathName = '{0}'", filePathType);
                return db.GetOneResult(sql).ToString();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        /// <summary>
        /// 更新地址
        /// </summary>
        /// <param name="FilePathType"></param>
        /// <returns></returns>
        public bool UpdatePath(string FilePathType, string NewFilePath)
        {
            string sql = string.Format("update FilePath set FP_FilePathURL = '{0}' where FP_FilePathName = '{1}'",NewFilePath,FilePathType);
            if(db.GetReviseResult(sql) == 1)
            {
                return true;
            }
            return false;
        }
    }
}
