using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTElectric.DAO
{
    public class OrderDetailbyIdDAO
    {
        private static OrderDetailbyIdDAO instance;
        public static OrderDetailbyIdDAO Instance
        {
            get { if (instance == null) instance = new OrderDetailbyIdDAO(); return instance; }
            set { instance = value; }
        }
        private OrderDetailbyIdDAO() { }
        public DataTable getOrderDetailbyId(int id)
        {
            string query = "GetOrderDetailbyorid @or_id";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            return result;
        }
    }
}
