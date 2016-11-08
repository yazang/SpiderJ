using SpiderJ.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiderJ.Data
{
    public class Repository
    {
        private List<Product> _products;

        public Repository()
        {
            _products = new List<Product>();
        }

        public void Add(Product product)
        {
            if (product != null)
            {
                _products.Add(product);
            }
        }

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }
    }
}
