using SpiderJ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiderJ.Data
{
    public interface IRepository
    {
        void Add(Product product);

        IEnumerable<Product> GetAll();
    }
}
