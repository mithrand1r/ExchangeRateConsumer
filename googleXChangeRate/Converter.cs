using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockHelper
{
    
    public class Converter
    {
        public bool success { get; set; }
        public string source { get; set; }
        public string target { get; set; }
        public float rate { get; set; }
        public float amount { get; set; }
        public string message { get; set; }
    }
}
