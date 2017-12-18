using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyKTVServer.DAL;
using MyKTVServer.Model;

namespace MyKTVServer.BLL
{
    public class FoodManage
    {
        FoodService foodservice = new FoodService();
        /// <summary>
        /// 查询食品信息
        /// </summary>
        /// <param name="foodName"></param>
        /// <param name="foodType"></param>
        /// <returns></returns>
        public List<Food> GetFoodList(string foodName, string foodType)
        {
            return foodservice.GetFoodList(foodName,foodType);
        }
        /// <summary>
        /// 删除食品信息
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool DeleteFood(string foodId)
        {
            return foodservice.DeleteFood(foodId);
        }
        /// <summary>
        /// 添加新食品
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        public bool AddFood(Food food)
        {
            return foodservice.AddFood(food);
        }
    }
}
