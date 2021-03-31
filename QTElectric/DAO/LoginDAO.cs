using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTElectric.DAO
{
    public class LoginDAO
    {
        private static LoginDAO instance;
        public static LoginDAO Instance
        {
            get { if (instance == null) instance = new LoginDAO(); return instance; }
            private set { instance = value; }
        }
        private LoginDAO() { }
        public Boolean checkLogin(string userName, string passWord)
        {
            string query = "CheckPass @user_name , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            if (result.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
