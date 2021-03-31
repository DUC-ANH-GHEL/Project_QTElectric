using QTElectric.DTO;
using System;
using System.Collections.Generic;
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
    }
}
