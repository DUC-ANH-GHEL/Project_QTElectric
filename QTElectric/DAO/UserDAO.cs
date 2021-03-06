using QTElectric.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTElectric.DAO
{
    public class UserDAO
    {
        private static UserDAO instance;
        public static UserDAO Instance
        {
            get { if (instance == null) instance = new UserDAO(); return instance; }
            private set { instance = value; }
        }
        private UserDAO() { }
        public int Insert(User u)
        {
            string query = "Insert_User @user_name , @password , @mobile , @email , @gender , @full_name , @status , @date_create";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { u.user_name, u.password, u.mobile, u.email, u.gender, u.full_name, u.status, u.date_create });
            return result;
        }
        public DataTable Get()
        {
            string query = "Get_User";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public int Update(User u)
        {
            string query = "Update_User @id , @user_name , @password , @mobile , @email , @gender , @full_name , @status , @date_create ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { u.u_id, u.user_name, u.password, u.mobile, u.email, u.gender, u.full_name, u.status, u.date_create });
            return result;
        }
        public int Delete(int id)
        {
            string query = "Delete_User @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result;
        }
        public DataTable Search(string search)
        {
            string query = "GetUserBySearch @search";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { search });
            return result;
        }
    }
}
