using QTElectric.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTElectric.DAO
{
    public class ProductDAO
    {
        private static ProductDAO instance;
        public static ProductDAO Instance
        {
            get { if (instance == null) instance = new ProductDAO(); return instance; }
            private set { instance = value; }
        }
        private ProductDAO() { }
        public object Insert(Product p)
        {
            string query = "Insert_Product @cat_id , @type_id , @val_id , @diff_id , @status , @date_create ";
            object result = DataProvider.Instance.ExecuteScalarQuery(query, new object[] { p.cat_id, p.type_id, p.val_id, p.diff_id, p.status, p.date_create });
            return result;
        }
        public DataTable Get()
        {
            string query = "Select_Product";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
        public object CheckProduct(int cat_id, int type_id, int val_id, int diff_id)
        {
            string query = "CheckProduct @cat_id , @type_id , @value_id , @diff_id ";
            object p = DataProvider.Instance.ExecuteScalarQuery(query, new object[] { cat_id, type_id, val_id, diff_id });
            return p;
        }
        public int Update(Product p)
        {
            string query = "Update_Product @id , @cat_id , @type_id , @val_id , @diff_id , @status , @date_create ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { p.pro_id, p.cat_id, p.type_id, p.val_id, p.diff_id, p.status, p.date_create });
            return result;
        }
        public int Delete(int id)
        {
            string query = "Delete_Product @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result;
        }
    }
}
