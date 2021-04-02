using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTElectric.DTO
{
    public class Product
    {
        public int pro_id { get; set; }
        public int type_id { get; set; }
        public int cat_id { get; set; }
        public int val_id { get; set; }
        public int diff_id { get; set; }
        public string qrname { get; set; }
        public bool status { get; set; }
        public DateTime date_create { get; set; }
    }
}
