using QTElectric.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTElectric.DAO
{
    public class DifferencedDAO
    {
        private static DifferencedDAO instance;
        public static DifferencedDAO Instance
        {
            get { if (instance == null) instance = new DifferencedDAO(); return instance; }
            private set { instance = value; }
        }
        private DifferencedDAO() { }
        public int Insert(Differenced diff)
        {
            string query = "Insert_Differenced @diff_name , @val_id , @status , @date_create ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { diff.diff_name, diff.val_id, diff.status, diff.date_create });
            return result;
        }
        public DataTable Get()
        {
            string query = "Get_Differenced";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public int Update(Differenced diff)
        {
            string query = "Update_Differenced @id , @diff_name , @val_id , @status , @date_create ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { diff.id, diff.diff_name, diff.val_id, diff.status, diff.date_create });
            return result;
        }
        public int Delete(int id)
        {
            string query = "Delete_Differenced @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result;
        }
        public DataTable GetValues()
        {
            string query = "GetValues";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
    }
}
