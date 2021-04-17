using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTElectric.DTO
{
    public class OrderDetailbyId
    {
        public int or_detail_id { get; set; }
        public string cat_name { get; set; }
        public string type_name { get; set; }
        public string diff_name { get; set; }
        public string val_name { get; set; }
        public int amount_in { get; set; }
        public int amount_out { get; set; }
        public int status { get; set; }
        public DateTime date_create { get; set; }
    }

    public class InfoOrderById
    {
        public int cus_id { get; set; }
        public string fullName { get; set; }
        public string or_name { get; set; }
        public DateTime date_order { get; set; }
    }
}
