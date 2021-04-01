using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTElectric.DTO
{
    public class User
    {
        public int u_id { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
        public String mobile { get; set; }
        public string email { get; set; }
        public bool gender { get; set; }
        public string full_name { get; set; }
        public bool status { get; set; }
        public DateTime date_create { get; set; }
    }
}
