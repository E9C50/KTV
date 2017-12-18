using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MyKTVServer.Model;

namespace MyKTVServer.DAL
{
    public class FoodService
    {
        DBHandle db = new DBHandle();
        /// <summary>
        /// 查询食品信息
        /// </summary>
        /// <param name="foodName"></param>
        /// <param name="foodType"></param>
        /// <returns></returns>
        public List<Food> GetFoodList(string foodName, string foodType)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat(@"select fi.FI_FoodId,fi.FI_FoodName,fi.FI_FoodPhotoURL,fi.FI_FoodPrice,
                            ft.FT_FoodTypeName from FoodsInfo as fi,FoodType as ft where 
                            fi.FI_FoodTypeId = ft.FT_FoodTypeId and fi.FI_FoodName like '%{0}%'", foodName);
                if (foodType != "")
                {
                    sb.AppendFormat(" and ft.FT_FoodTypeName = '{0}'", foodType);
                }
                SqlDataReader reader = db.GetManyResult(sb.ToString());
                List<Food> foodList = new List<Food>();
                while (reader.Read())
                {
                    Food food = new Food();
                    food.FI_FoodId1 = Convert.ToInt32(reader["FI_FoodId"]);
                    food.FI_FoodName1 = reader["FI_FoodName"].ToString();
                    food.FI_FoodPhotoURL1 = reader["FI_FoodPhotoURL"].ToString();
                    food.FI_FoodPrice1 = Convert.ToInt32(reader["FI_FoodPrice"]);
                    food.FT_FoodTypeName1 = reader["FT_FoodTypeName"].ToString();
                    foodList.Add(food);
                }
               
                db.Reader.Close();
                return foodList;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        /// <summary>
        /// 删除食品信息
        /// </summary>
        /// <param name="foodId"></param>
        /// <returns></returns>
        public bool DeleteFood(string foodId)
        {
            try
            {
                string sql = string.Format("delete from FoodsInfo where FI_FoodId = {0}", foodId);
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
        /// 获得食物类型ID
        /// </summary>
        /// <returns></returns>
        public int GetTypeId(string foodTypeName)
        {
            string sql = string.Format("select FT_FoodTypeId from FoodType where FT_FoodTypeName = '{0}'",foodTypeName);
            return Convert.ToInt32(db.GetOneResult(sql));
        }
        /// <summary>
        /// 添加新食品
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        public bool AddFood(Food food)
        {
            string sql = string.Format("insert FoodsInfo values('{0}',{1},{2},'{3}')",food.FI_FoodName1,
                                        food.FI_FoodPrice1,GetTypeId(food.FT_FoodTypeName1),food.FI_FoodPhotoURL1);
            if(db.GetReviseResult(sql) == 1)
            {
                return true;
            }
            return false;
        }
    }
}
