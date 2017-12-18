using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKTVClient.Model
{
    public class Food
    {
        private int FI_FoodId;

        public int FI_FoodId1
        {
            get { return FI_FoodId; }
            set { FI_FoodId = value; }
        }
        private string FI_FoodName;

        public string FI_FoodName1
        {
            get { return FI_FoodName; }
            set { FI_FoodName = value; }
        }
        private int FI_FoodPrice;

        public int FI_FoodPrice1
        {
            get { return FI_FoodPrice; }
            set { FI_FoodPrice = value; }
        }
        private string FT_FoodTypeName;

        public string FT_FoodTypeName1
        {
            get { return FT_FoodTypeName; }
            set { FT_FoodTypeName = value; }
        }
        private string FI_FoodPhotoURL;

        public string FI_FoodPhotoURL1
        {
            get { return FI_FoodPhotoURL; }
            set { FI_FoodPhotoURL = value; }
        }
    }
}
