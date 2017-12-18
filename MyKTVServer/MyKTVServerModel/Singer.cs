using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKTVServer.Model
{
    public class Singer
    {
        private int SRI_SingeId;//歌手编号

        public int SRI_SingeId1
        {
            get { return SRI_SingeId; }
            set { SRI_SingeId = value; }
        }
        private string SRI_SingerName;//歌手姓名

        public string SRI_SingerName1
        {
            get { return SRI_SingerName; }
            set { SRI_SingerName = value; }
        }
        private string SRT_SingerTypeName;//歌手类型

        public string SRT_SingerTypeName1
        {
            get { return SRT_SingerTypeName; }
            set { SRT_SingerTypeName = value; }
        }
        private string SRI_SingePhotoURL;//歌手照片路径

        public string SRI_SingePhotoURL1
        {
            get { return SRI_SingePhotoURL; }
            set { SRI_SingePhotoURL = value; }
        }
    }
}
