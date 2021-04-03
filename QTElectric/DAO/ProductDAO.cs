﻿using QTElectric.DTO;
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
        public int Insert(Product p)
        {
            string query = "Insert_Product @cat_id , @type_id , @val_id , @diff_id , @qrname , @status , @date_create ";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { p.cat_id, p.type_id, p.val_id, p.diff_id, p.qrname, p.status, p.date_create });
            return result;
        }
        public DataTable Get()
        {
            string query = "Select_Product";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }
    }
}