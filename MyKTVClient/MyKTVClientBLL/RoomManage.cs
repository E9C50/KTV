using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyKTVClient.DAL;
using MyKTVClient.Model;

namespace MyKTVClient.BLL
{
    public class RoomManage
    {
        RoomService roomservice = new RoomService();
        /// <summary>
        /// 获取房间状态
        /// </summary>
        /// <param name="roomId"></param>
        /// <returns></returns>
        public bool GetRoomState(int roomId)
        {
            return roomservice.GetRoomState(roomId);
        }
        /// <summary>
        /// 服务
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool Server(int roomId)
        {
            return roomservice.Server(roomId);
        }
        /// <summary>
        /// 提交餐单
        /// </summary>
        /// <returns></returns>
        public bool SubmitFoodList(int roomId)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < FoodList.foodList.Count; i++)
            {
                sb.Append(FoodList.foodList[i].FI_FoodName1 + "\t\t" + FoodList.foodList[i].FI_FoodPrice1 +"\n");
            }
            Food food = new Food();
            food.FI_FoodName1 = "----------------------------";
            food.FI_FoodPrice1 = 0;
            FoodList.InsertFood(food);
            return roomservice.SubmitFoodList(sb.ToString(), FoodList.money, roomId);
        }
        /// <summary>
        /// 获得消费金额
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int GetFoodMoney(int roomId)
        {
            return roomservice.GetFoodMoney(roomId);
        }
        /// <summary>
        /// 获得消费列表
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public string GetFoodList(int roomId)
        {
            return roomservice.GetFoodList(roomId);
        }
        /// <summary>
        /// 请求结账
        /// </summary>
        /// <param name="p"></param>
        public void OpenPayServer(int roomId)
        {
            roomservice.OpenPayServer(roomId);
        }
    }
}
