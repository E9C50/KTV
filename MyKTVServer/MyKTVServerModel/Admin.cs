using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKTVServer.Model
{
    public class Admin
    {
        int A_AdminId;

        public int A_AdminId1
        {
            get { return A_AdminId; }
            set { A_AdminId = value; }
        }
        string A_AdminUserName;

        public string A_AdminUserName1
        {
            get { return A_AdminUserName; }
            set { A_AdminUserName = value; }
        }
        string A_AdminPassWord;

        public string A_AdminPassWord1
        {
            get { return A_AdminPassWord; }
            set { A_AdminPassWord = value; }
        }
    }
}
