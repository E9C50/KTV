using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyKTVServer.DAL;
using MyKTVServer.Model;

namespace MyKTVServer.BLL
{
    public class RoomManage
    {
        RoomService roomservice = new RoomService();
        /// <summary>
        /// 获得包厢集合
        /// </summary>
        /// <returns></returns>
        public List<Room> GetRoomList()
        {
            return roomservice.GetRoomList();
        }
        /// <summary>
        /// 添加包厢信息
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public bool AddRoom(Room room)
        {
            return roomservice.AddRoom(room);
        }
        /// <summary>
        /// 更新包厢状态
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public bool UpdataState(int roomId, string roomState)
        {
            return roomservice.UpdataState(roomId,roomState);
        }
        /// <summary>
        /// 修改包厢使用时长
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool UpdateRoomTime(string RoomTime)
        {
            return roomservice.UpdateRoomTime(RoomTime);
        }
        /// <summary>
        /// 获取请求服务的房间
        /// </summary>
        /// <returns></returns>
        public int GetServerRoom()
        {
            return roomservice.GetServerRoom();
        }
        /// <summary>
        /// 关闭服务
        /// </summary>
        /// <param name="ServerroomId"></param>
        public void CloseServer(int ServerroomId)
        {
            roomservice.CloseServer(ServerroomId);
        }
        /// <summary>
        /// 获得食物列表
        /// </summary>
        /// <returns></returns>
        public Room GetFoodList()
        {
            return roomservice.GetFoodList();
        }
        /// <summary>
        /// 获得请求结账的包厢
        /// </summary>
        /// <returns></returns>
        public Room GetPayServerRoom()
        {
            return roomservice.GetPayServerRoom();
        }
        /// <summary>
        /// 关闭点餐请求
        /// </summary>
        /// <param name="p"></param>
        public void CloseFoodSubmit(int roomId)
        {
            roomservice.CloseFoodSubmitServer(roomId);
        }
        /// <summary>
        /// 关闭结账服务请求
        /// </summary>
        /// <param name="p"></param>
        public void ClosePayServer(int roomId)
        {
            roomservice.ClosePayServer(roomId);
        }
    }
}
