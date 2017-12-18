using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKTVClient.DAL
{
    public class RoomService
    {
        DBHandle db = new DBHandle();
        /// <summary>
        /// 获取房间状态
        /// </summary>
        /// <param name="roomId"></param>
        /// <returns></returns>
        public bool GetRoomState(int roomId)
        {
            try
            {
                string sql = string.Format("select R_RoomState from Room where R_RoomId = {0}",roomId);
                int state = Convert.ToInt32(db.GetOneResult(sql));
                if (state == 1)
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
        /// 服务
        /// </summary>
        /// <param name="roomId"></param>
        /// <returns></returns>
        public bool Server(int roomId)
        {
            try
            {
                string sql = string.Format("update Room set R_RoomServer = 1 where R_RoomId = {0}", roomId);
                if(db.GetReviseResult(sql) == 1)
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
        /// 提交餐单
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public bool SubmitFoodList(string foodList, int money, int roomId)
        {
            try
            {
                string sql = string.Format("update Room set R_RoomFoodedList = '{0}',R_RoomFoodedMoney = {1},R_RoomFoodedServer = 1 where R_RoomId = {2}", foodList, money, roomId);
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
        /// <summary>
        /// 获得消费金额
        /// </summary>
        /// <param name="roomId"></param>
        /// <returns></returns>
        public int GetFoodMoney(int roomId)
        {
            try
            {
                string sql = string.Format("select R_RoomFoodedMoney from room where R_RoomId = {0}", roomId);
                return Convert.ToInt32(db.GetOneResult(sql));
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        /// <summary>
        /// 获得消费列表
        /// </summary>
        /// <param name="roomId"></param>
        /// <returns></returns>
        public string GetFoodList(int roomId)
        {
            try
            {
                string sql = string.Format("select R_RoomFoodedList from room where R_RoomId = {0}", roomId);
                return db.GetOneResult(sql).ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// 请求结账
        /// </summary>
        /// <param name="roomId"></param>
        public void OpenPayServer(int roomId)
        {
            try
            {
                string serverSql = string.Format("update Room set R_RoomPayMoneyServer = 1 where R_RoomId = {0}", roomId);
                db.GetReviseResult(serverSql);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
