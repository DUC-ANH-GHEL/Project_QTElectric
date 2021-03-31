using QTElectric.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTElectric.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;
        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return instance; }
            private set { instance = value; }
        }
        private CategoryDAO() { }
        public int InsertCategory(Category c)
        {
            string query = "Insert_Category @cat_name , @status , @date_create";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { c.cat_name, c.status, c.date_ceate });
            return result;
        }

        public DataTable Categories()
        {
            string query = "Get_Category";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public int UpdateCategory(Category c)
        {
            string query = "Update_Category @id , @cat_name , @status , @date_create";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { c.cat_id, c.cat_name, c.status, c.date_ceate });
            return result;
        }
        public int DeleteCategory(int id)
        {
            string query = "Delete_Category @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result;
        }
    }
}
