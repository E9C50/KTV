using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKTVServer.Model
{
    public class Room
    {
        private int R_RoomId;//房间编号

        public int R_RoomId1
        {
            get { return R_RoomId; }
            set { R_RoomId = value; }
        }
        private string R_RoomType;//包厢类型（小包，中包，大包）

        public string R_RoomType1
        {
            get { return R_RoomType; }
            set { R_RoomType = value; }
        }
        private int R_RoomState;//包厢状态（0空闲，1使用）

        public int R_RoomState1
        {
            get { return R_RoomState; }
            set { R_RoomState = value; }
        }
        private int useTime;//使用时间

        public int UseTime
        {
            get { return useTime; }
            set { useTime = value; }
        }
        private int R_RoomServer;//服务状态

        public int R_RoomServer1
        {
            get { return R_RoomServer; }
            set { R_RoomServer = value; }
        }
        private string R_RoomFoodedList;//食物列表

        public string R_RoomFoodedList1
        {
            get { return R_RoomFoodedList; }
            set { R_RoomFoodedList = value; }
        }
        private int R_RoomFoodedMoney;//消费金额

        public int R_RoomFoodedMoney1
        {
            get { return R_RoomFoodedMoney; }
            set { R_RoomFoodedMoney = value; }
        }
    }
}
