using QTElectric.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTElectric.DAO
{
    public class OrderDAO
    {
        private static OrderDAO instance;
        public static OrderDAO Instance
        {
            get { if (instance == null) instance = new OrderDAO(); return instance; }
            private set { instance = value; }
        }
        private OrderDAO() { }
        public DataTable Get()
        {
            string query = "GetByValues";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public object InsertOrder(Order o)
        {
            string query = "Insert_Order @cus_id , @or_name , @status , @date_create";
            object result = DataProvider.Instance.ExecuteScalarQuery(query, new object[] {o.cus_id, o.order_name, o.status, o.date_create });
            return result;
        }
        public DataTable Orders()
        {
            string query = "Get_Order";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public DataTable GetOrderByCus(int cus_id)
        {
            string query = "getOrderByCus @cus_id";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { cus_id});
            return result;
        }
        public int UpdateOrder(Order o)
        {
            string query = "Update_Order @id , @cus_id , @or_name , @status , @date_create";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { o.order_id, o.cus_id, o.order_name, o.status, o.date_create });
            return result;
        }
        public int DeleteOrder(int id)
        {
            string query = "Delete_Order @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result;
        }
    }
}
