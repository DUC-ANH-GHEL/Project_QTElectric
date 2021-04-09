using QTElectric.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTElectric.DAO
{
    class TypeDAO
    {
        private static TypeDAO instance;
        public static TypeDAO Instance
        {
            get { if (instance == null) instance = new TypeDAO(); return instance; }
            private set { instance = value; }
        }
        private TypeDAO() { }
        public int Insert_Types(Types c)
        {
            string query = "Insert_Types @type_name , @cat_id , @status , @date_create";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { c.type_name, c.cat_id, c.status, c.date_create });
            return result;
        }

        public DataTable Types()
        {
            string query = "Get_Types";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public int Update_Types(Types c)
        {
            string query = "Update_Types @id , @type_name , @cat_id , @status , @date_create";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { c.type_id, c.type_name, c.cat_id, c.status, c.date_create });
            return result;
        }
        public int Delete_Types(int id)
        {
            string query = "Delete_Types @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result;
        }
        public DataTable GetbyCat(int cat_id)
        {
            string query = "GetByCat @cat_id ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { cat_id });
            return result;
        }
        public DataTable Search(string search)
        {
            string query = "GetTypeBySearch @search";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { search });
            return result;
        }
    }
}
