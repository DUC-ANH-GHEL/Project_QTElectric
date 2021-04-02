using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTElectric.DTO
{
    public class Differenced
    {
        public int diff_id { get; set; }
        public string diff_name { get; set; }
        public int val_id { get; set; }
        public DateTime date_create { get; set; }
        public bool status { get; set; }
    }
}
