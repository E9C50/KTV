using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MyKTVServer.Model;

namespace MyKTVServer.DAL
{
    public class RoomService
    {
        DBHandle db = new DBHandle();
        /// <summary>
        /// 获得房间集合
        /// </summary>
        /// <returns></returns>
        public List<Room> GetRoomList()
        {
            try
            {
                string sql = "select * from Room";
                SqlDataReader reader = db.GetManyResult(sql);
                List<Room> roomList = new List<Room>();
                while (reader.Read())
                {
                    Room room = new Room();
                    room.R_RoomId1 = Convert.ToInt32(reader["R_RoomId"]);
                    room.R_RoomState1 = Convert.ToInt32(reader["R_RoomState"]);
                    room.R_RoomType1 = reader["R_RoomType"].ToString();
                    roomList.Add(room);
                }

                db.Reader.Close();
                return roomList;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        /// <summary>
        /// 添加房间信息
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public bool AddRoom(Room room)
        {
            try
            {
                string sql = string.Format("insert Room values ({0},'{1}',{2},0,4,null,0,0,0)", room.R_RoomId1, room.R_RoomType1, room.R_RoomState1);
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
        /// 更新包厢状态
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="roomState"></param>
        /// <returns></returns>
        public bool UpdataState(int roomId, string roomState)
        {
            try
            {
                string sql = "";
                if (roomState == "空闲")
                {
                    sql = string.Format("update Room set R_RoomState = 1 where R_RoomId = {0}", roomId);
                }
                else if (roomState == "有人")
                {
                    sql = string.Format("update Room set R_RoomState = 0,R_RoomFoodedList = '',R_RoomFoodedMoney = 0 where R_RoomId = {0}", roomId);
                }
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
        /// 修改包厢使用时长
        /// </summary>
        /// <param name="RoomTime"></param>
        /// <returns></returns>
        public bool UpdateRoomTime(string RoomTime)
        {
            try 
	        {	        
		        string sql = string.Format("update Room set R_RoomUseTime = {0}",RoomTime);
                if(db.GetReviseResult(sql) > 0)
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
        /// 获取请求服务的房间
        /// </summary>
        public int GetServerRoom()
        {
            try
            {
                string sql = "select R_RoomId from Room where R_RoomServer = 1";
                return Convert.ToInt32(db.GetOneResult(sql));
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// 关闭服务
        /// </summary>
        /// <param name="ServerroomId"></param>
        public void CloseServer(int ServerroomId)
        {
            try
            {
                string sql = string.Format("update Room set R_RoomServer = 0 where R_RoomId = {0}", ServerroomId);
                db.GetReviseResult(sql);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        /// <summary>
        /// 获得食物集合
        /// </summary>
        /// <returns></returns>
        public Room GetFoodList()
        {
            try
            {
                
                string sql = "select R_RoomFoodedList,R_RoomId from Room where R_RoomFoodedServer = 1";
                SqlDataReader reader = db.GetManyResult(sql);
                Room room = new Room();
                while (reader.Read())
                {
                    room.R_RoomId1 = Convert.ToInt32(reader["R_RoomId"]);
                    room.R_RoomFoodedList1 = reader["R_RoomFoodedList"].ToString();
                }

                db.Reader.Close();
                
                return room;
              
            }
            catch (Exception)
            {
                
                throw;
          
            
        }
    
        }
        /// <summary>
        /// 获得请求结账的包厢
        /// </summary>
        /// <returns></returns>
        public Room GetPayServerRoom()
        {
            string sql = "select R_RoomId,R_RoomFoodedList,R_RoomFoodedMoney from Room where R_RoomPayMoneyServer = 1";
            SqlDataReader reader = db.GetManyResult(sql);
            Room room = new Room();
            while(reader.Read())
            {
                room.R_RoomId1 = Convert.ToInt32(reader["R_RoomId"]);
                room.R_RoomFoodedList1 = reader["R_RoomFoodedList"].ToString();
                room.R_RoomFoodedMoney1 = Convert.ToInt32(reader["R_RoomFoodedMoney"]);

                db.Reader.Close();
                return room;
            }
            return null;
        }
        /// <summary>
        /// 关闭食物提交请求
        /// </summary>
        /// <param name="roomId"></param>
        public void CloseFoodSubmitServer(int roomId)
        {
            try
            {
                string sql = string.Format("update Room set R_RoomFoodedServer = 0 where R_RoomId = {0}", roomId);
                db.GetReviseResult(sql);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        /// <summary>
        /// 关闭结账服务请求
        /// </summary>
        /// <param name="roomId"></param>
        public void ClosePayServer(int roomId)
        {
            try
            {
                string sql = string.Format("update Room set R_RoomPayMoneyServer = 0 where R_RoomId = {0}", roomId);
                db.GetReviseResult(sql);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
