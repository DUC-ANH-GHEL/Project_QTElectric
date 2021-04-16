using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTElectric.DTO
{
    public class Orderbycus
    {
        public int or_id { get; set; }
        public string or_name { get; set; }
        public int cus_id { get; set; }
        public bool status { get; set; }
        public DateTime date_create { get; set; }

    }
}
