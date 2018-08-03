using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Models
{
    public class Activation_C
    {
        public int id { get; set; }
        public string activation_code { get; set; }
        public string username { get; set; }
        public bool status { get; set; }
    }
}
