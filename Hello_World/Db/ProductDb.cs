using Hello_World.Models;
using System.Collections.Generic;
using System.Linq;

namespace Hello_World.Db
{
    public class ProductDb : IProductDb
    {
        private readonly IList<Product> _products;

        public ProductDb()
        {
            _products = new List<Product>()
            {
                new Product() { Id = 1, Title = "Laptop", Price = 50000 },
                new Product() { Id = 2, Title = "Mobile", Price = 6000 },
                new Product() { Id = 3, Title = "Mouse", Price = 3500 },
                new Product() { Id = 4, Title = "Speaker", Price = 100 },
                new Product() { Id = 5, Title = "Keyboard", Price = 1500 }
            };
        }

        public Product GetDetail(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            return product;
        }

        public IEnumerable<Product> GetProducts() => _products;
    }
}
