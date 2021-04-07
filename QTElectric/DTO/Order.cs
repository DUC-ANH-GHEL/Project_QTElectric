using QTElectric.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTElectric.DTO
{
    public class Order
    {
        public int or_detail_id { get; set; }
        public string order_id { get; set; }
        public int pro_id { get; set; }
        public int amount_in { get; set; }
        public int amount_out { get; set; }
        public Boolean status { get; set; }
        public DateTime date_create { get; set; }
        public string status2 { get; set; }
        public Order()
        {

        }
        public Order(int or_detail_id, string order_id, int pro_id, int amount_in, int amount_out, bool status, DateTime date_create)
        {
            this.or_detail_id = or_detail_id;
            this.order_id = order_id;
            this.pro_id = pro_id;
            this.amount_in = amount_in;
            this.amount_out = amount_out;
            this.status = status;
            this.date_create = date_create;
        }
    }

    public class ModelOrder
    {
        public string order_id { get; set; }
        public string cat_name { get; set; }
        public string type_name { get; set; }
        public string value_name { get; set; }
        public string diff_name { get; set; }
        public int amount_in { get; set; }
        public int amount_out { get; set; }
        public DateTime date_create { get; set; }
        public ModelOrder()
        {

        }
        public ModelOrder(string order_id, string cat_name, string type_name, string value_name, string diff_name, int amount_in, int amount_out, DateTime date_create)
        {
            this.order_id = order_id;
            this.cat_name = cat_name;
            this.type_name = type_name;
            this.value_name = value_name;
            this.diff_name = diff_name;
            this.amount_in = amount_in;
            this.amount_out = amount_out;
            this.date_create = date_create;
        }
    }
}
