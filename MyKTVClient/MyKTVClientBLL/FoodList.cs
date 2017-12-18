using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyKTVClient.Model;

namespace MyKTVClient.BLL
{
    public class FoodList
    {
        public static List<Food> foodList = new List<Food>();
        public static int money = 0;
        public static int foodedMoney = 0;
        /// <summary>
        /// 点餐
        /// </summary>
        public static void InsertFood(Food food)
        {
            foodList.Add(food);
            money = money + food.FI_FoodPrice1;
        }
        /// <summary>
        /// 删除 
        /// </summary>
        public static void DeleteFood(Food food)
        {
            for(int i = 0;i < foodList.Count;i++)
            {
                if(foodList[i].FI_FoodId1 == food.FI_FoodId1)
                {
                    money = money - foodList[i].FI_FoodPrice1;
                    for(int j = i;j < foodList.Count;j++)
                    {
                        if(foodList.Count == j + 1)
                        {
                            foodList.Remove(foodList[j]);
                            return;
                        }
                        foodList[j] = foodList[j + 1];
                    }
                }
            }
        }
        /// <summary>
        /// 清空已点
        /// </summary>
        public static void CleanFoodList()
        {
            foodList.Clear();
            money = 0;
        }
    }
}
