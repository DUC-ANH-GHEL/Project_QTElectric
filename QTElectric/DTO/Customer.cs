using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTElectric.DTO
{
    public class Customer
    {
        public int cus_id { get; set; }
        public string fullName { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public Boolean gender { get; set; }
        public Boolean status { get; set; }
        public DateTime date_create { get; set; }
    }
}
