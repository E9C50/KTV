using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MyKTVServer.Model;

namespace MyKTVServer.DAL
{
    public class AdminService
    {
        DBHandle db = new DBHandle();
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public bool Login(Admin admin)
        {
            try
            {
                string sql = string.Format("select COUNT(*) from Admin where A_AdminUserName = '{0}' and A_AdminPassWord = '{1}'", admin.A_AdminUserName1, admin.A_AdminPassWord1);
                if (Convert.ToInt32(db.GetOneResult(sql)) == 1)
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
        /// <summary>
        /// 获得管理员信息
        /// </summary>
        /// <returns></returns>
        public Admin SearchAdmin()
        {
            string sql = "select * from Admin";
            SqlDataReader reader = db.GetManyResult(sql);
            Admin admin = new Admin();
            while(reader.Read())
            {
                admin.A_AdminPassWord1 = reader["A_AdminPassWord"].ToString();
                admin.A_AdminUserName1 = reader["A_AdminUserName"].ToString();
            }
            db.Reader.Close();
           
            return admin;
        }
        /// <summary>
        /// 修改管理员信息
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public bool UpdateAdmin(Admin admin)
        {
            string sql = string.Format("update Admin set A_AdminPassWord = '{0}',A_AdminUserName = '{1}'",admin.A_AdminPassWord1,admin.A_AdminUserName1);
            if(db.GetReviseResult(sql) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
