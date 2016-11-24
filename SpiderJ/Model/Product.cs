using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiderJ.Model
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string ImageUri { get; set; }
        public string Price { get; set; }
    }
}
