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
    }
}
