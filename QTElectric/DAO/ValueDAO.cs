using QTElectric.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTElectric.DAO
{
    class ValueDAO
    {
        private static ValueDAO instance;
        public static ValueDAO Instance
        {
            get { if (instance == null) instance = new ValueDAO(); return instance; }
            private set { instance = value; }
        }
        private ValueDAO() { }
        public int InsertValue(Value c)
        {
            string query = "Insert_Values @val_name , @type_id , @status , @date_create";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { c.val_name, c.type_id, c.status, c.date_ceate });
            return result;
        }

        public DataTable Value()
        {
            string query = "Get_Values";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public int UpdateValue(Value c)
        {
            string query = "Update_Values @id , @val_name , @type_id , @status , @date_create";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { c.val_id, c.val_name, c.type_id, c.status, c.date_ceate });
            return result;
        }
        public int DeleteValue(int id)
        {
            string query = "Delete_Values @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result;
        }
        public DataTable GetbyType(int type_id)
        {
            string query = "GetByType @type_id ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { type_id });
            return result;
        }
        public DataTable Search(string search)
        {
            string query = "GetValueBySearch @search";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { search });
            return result;
        }
    }
}
