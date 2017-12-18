using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyKTVServer.DAL;
using MyKTVServer.Model;

namespace MyKTVServer.BLL
{
    public class PathManage
    {
        PathService pathservice = new PathService();
        /// <summary>
        /// 获得旧地址
        /// </summary>
        /// <param name="FilePathType"></param>
        /// <returns></returns>
        public string GetOldPath(string FilePathType)
        {
            return pathservice.GetOldPath(FilePathType);
        }
        /// <summary>
        /// 更新地址
        /// </summary>
        /// <param name="FilePathType"></param>
        /// <returns></returns>
        public bool UpdatePath(string FilePathType, string NewFilePath)
        {
            return pathservice.UpdatePath(FilePathType,NewFilePath);
        }
    }
}
