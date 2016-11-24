using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SpiderJ.Model;

namespace SpiderJ.Data
{
    public class SpiderJDB : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
