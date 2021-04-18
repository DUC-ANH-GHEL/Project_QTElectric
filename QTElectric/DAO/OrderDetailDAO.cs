using QTElectric.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTElectric.DAO
{
    class OrderDetailDAO
    {
        private static OrderDetailDAO instance;
        public static OrderDetailDAO Instance
        {
            get { if (instance == null) instance = new OrderDetailDAO(); return instance; }
            private set { instance = value; }
        }
        private OrderDetailDAO() { }
        public int InsertOrderDetail(OrderDetail o)
        {
            string query = "Insert_OrderDetail @order_id , @pro_id , @amount_in , @amount_out , @status , @date_create";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { o.order_id, o.pro_id, o.amount_in, o.amount_out, o.status, o.date_create });
            return result;
        }
        public DataTable OrderDetail()
        {
            string query = "Get_OrderDetail";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public int UpdateOrderDetail(OrderDetail o)
        {
            string query = "Update_OrderDetail @id , @pro_id ,   @amount_in , @amount_out , @status , @date_create";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { o.or_detail_id, o.pro_id, o.amount_in, o.amount_out, o.status, o.date_create });
            return result;
        }
        public int DeleteOrderDetail(int id)
        {
            string query = "Delete_OrderDetail @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result;
        }
    }
}
