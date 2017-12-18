using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MyKTVClient.DAL
{
    public class DBHandle
    {
        #region 封装字段
        private string connStr = ConfigurationManager.ConnectionStrings["MyKTV"].ToString();

        public string ConnStr
        {
            get { return connStr; }
            set { connStr = value; }
        }

        private SqlConnection conn = null;

        public SqlConnection Conn
        {
            get { return conn; }
            set { conn = value; }
        }

        private SqlDataReader reader = null;

        public SqlDataReader Reader
        {
            get { return reader; }
            set { reader = value; }
        }
        #endregion
        #region 返回一个结果的方法
        /// <summary>
        /// 得到一个结果方法
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>一个结果</returns>
        public object GetOneResult(string sql)
        {
            Conn = new SqlConnection(ConnStr);
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand(sql, Conn);
                object result = comm.ExecuteScalar();
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("操作失败！");
                return -1;
                throw;
            }
            finally
            {
                Conn.Close();
            }
        }
        #endregion
        #region 返回多个结果方法
        /// <summary>
        /// 返回多个结果方法
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>返回多个结果</returns>
        public SqlDataReader GetManyResult(string sql)
        {
            try
            {
                Conn = new SqlConnection(ConnStr);
                Conn.Open();
                SqlCommand comm = new SqlCommand(sql, Conn);
                Reader = comm.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("操作失败！");
                throw;
            }
            return Reader;
        }
        #endregion
        #region 增、删、改方法
        /// <summary>
        /// 增加，删除，更改方法
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>返回值，判断处理是否成功</returns>
        public int GetReviseResult(string sql)
        {
            Conn = new SqlConnection(ConnStr);
            try
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand(sql, Conn);
                int result = comm.ExecuteNonQuery();
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("操作失败！");
                return -1;
                throw;
            }
            finally
            {
                Conn.Close();
            }
        }
        #endregion
        #region 得到SqlDataAdapter对象方法
        /// <summary>
        /// 得到SqlDataAdapter对象(即货车)
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns>SqlDataAdapter</returns>
        public SqlDataAdapter GetAdapter(string sql)
        {
            try
            {
                Conn = new SqlConnection(ConnStr);
                Conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(sql, Conn);
                return sda;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                Conn.Close();
            }
        }
        #endregion
        #region 形式参数更新方法
        /// <summary>
        /// SqlParameters参数集合(更新)
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        internal int ChangeResult(string sql, SqlParameter[] paras)
        {
            using (Conn = new SqlConnection(ConnStr))
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand(sql, Conn);
                comm.Parameters.AddRange(paras);
                int num = comm.ExecuteNonQuery();
                return num;
            }
        }
        #endregion
        #region 形式参数查询单个结果方法
        /// <summary>
        /// SqlParameters参数集合(查询单个结果)
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        internal object SelectResult(string sql, SqlParameter[] paras)
        {
            using (Conn = new SqlConnection(ConnStr))
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand(sql, Conn);
                comm.Parameters.AddRange(paras);
                object num = comm.ExecuteScalar();
                return num;
            }
        }
        #endregion
        #region 查询单个结果存储过程
        /// <summary>
        /// 调用查询单个结果类存储过程
        /// </summary>
        /// <param name="usp"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        internal object GetSelect(string usp, SqlParameter[] paras)
        {
            using (Conn = new SqlConnection(ConnStr))
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand(usp, Conn);
                comm.Parameters.AddRange(paras);
                comm.CommandType = CommandType.StoredProcedure;
                object num = comm.ExecuteScalar();
                return num;
            }
        }
        #endregion
        #region 更新存储过程
        /// <summary>
        /// 调用更新类存储过程
        /// </summary>
        /// <param name="usp"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        internal int GetProcedure(string usp, SqlParameter[] paras)
        {
            using (Conn = new SqlConnection(ConnStr))
            {
                Conn.Open();
                SqlCommand comm = new SqlCommand(usp, Conn);
                comm.Parameters.AddRange(paras);
                comm.CommandType = CommandType.StoredProcedure;
                int num = comm.ExecuteNonQuery();
                return num;
            }
        }
        #endregion
    }
}
