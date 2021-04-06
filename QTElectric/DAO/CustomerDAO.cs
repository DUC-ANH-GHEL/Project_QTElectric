using QTElectric.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTElectric.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;
        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return instance; }
            private set { instance = value; }
        }
        private CustomerDAO() { }
        public int InsertCustomer(Customer cus)
        {
            string query = "Insert_Customer @fullname , @mobile , @email , @address , @gender , @status , @date_create";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { cus.fullName, cus.mobile, cus.email, cus.address, cus.gender, cus.status, cus.date_create });
            return result;
        }
        public DataTable Get()
        {
            string query = "Get_Customer";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public int Update(Customer cu)
        {
            string query = "Update_Customer @id , @fullname , @mobile , @email , @address , @gender , @status , @date_create";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { cu.cus_id, cu.fullName, cu.mobile, cu.email, cu.address, cu.gender, cu.status, cu.date_create });
            return result;
        }
        public int Delete(int id)
        {
            string query = "Delete_Customer @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result;
        }
        public DataTable Search(string search)
        {
            string query = "GetCusBySearch @search";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { search});
            return result;
        }
        
    }
}
