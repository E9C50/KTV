using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyKTVClient.DAL;
using MyKTVClient.Model;

namespace MyKTVClient.BLL
{
    public class FoodManage
    {
        FoodService foodservice = new FoodService();
        /// <summary>
        /// 获得食品集合
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public List<Food> GetFoodList(string foodType,int foodId)
        {
            return foodservice.GetFoodList(foodType, foodId);
        }
        /// <summary>
        /// 获得总路径
        /// </summary>
        /// <returns></returns>
        public string GetAllURL()
        {
            return foodservice.GetAllURL();
        }
    }
}
