using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MyKTVClient.Model;

namespace MyKTVClient.DAL
{
    public class FoodService
    {
        DBHandle db = new DBHandle();
        /// <summary>
        /// 获取食物集合
        /// </summary>
        /// <param name="foodTypeList"></param>
        /// <returns></returns>
        public List<Food> GetFoodList(string foodType, int foodId)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("select ft.FT_FoodTypeName,fi.FI_FoodId,fi.FI_FoodName,fi.FI_FoodPhotoURL,fi.FI_FoodPrice from FoodsInfo as fi,FoodType as ft where fi.FI_FoodTypeId = ft.FT_FoodTypeId");
                if (foodType != "" && foodType != "全部")
                {
                    sb.AppendFormat(" and ft.FT_FoodTypeName = '{0}'", foodType);
                }
                if (foodId != -1)
                {
                    sb.AppendFormat(" and fi.FI_FoodId = {0}", foodId);
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
                return foodList;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        /// <summary>
        /// 获得总路径
        /// </summary>
        /// <returns></returns>
        public string GetAllURL()
        {
            string sql = string.Format("select FP_FilePathURL from FilePath where FP_FilePathName = '食物照片'");
            return db.GetOneResult(sql).ToString();
        }
    }
}
