using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyKTVServer.DAL;
using MyKTVServer.Model;

namespace MyKTVServer.BLL
{
    public class AdminManage
    {
        AdminService adminservice = new AdminService();
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public bool Login(Admin admin)
        {
            return adminservice.Login(admin);
        }
        /// <summary>
        /// 获得管理员信息
        /// </summary>
        /// <returns></returns>
        public Admin SearchAdmin()
        {
            return adminservice.SearchAdmin();
        }
        /// <summary>
        /// 修改管理员信息
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public bool UpdateAdmin(Admin admin)
        {
            return adminservice.UpdateAdmin(admin);
        }
    }
}
