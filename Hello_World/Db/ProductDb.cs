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
                new Product() { Id = 1, Title = "Laptop", Email = "l@mail.com", Website="https://lbc.com", Price = 50000, Description="This is a best product" },
                new Product() { Id = 2, Title = "Mobile",Email = "m@mail.com", Website="https://mbc.com", Price = 1200, Description="This is a best product" },
                new Product() { Id = 3, Title = "Mouse", Email = "n@mail.com", Website="https://nbc.com", Price = 8500, Description="This is a best product" },
                new Product() { Id = 4, Title = "Speaker", Email = "s@mail.com", Website="https://sbc.com", Price = 3600, Description="This is a best product" },
                new Product() { Id = 5, Title = "Keyboard", Email = "k@mail.com", Website="https://kbc.com", Price = 44000, Description="This is a best product" }
            };
        }

        public Product GetDetail(int? id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            return product;
        }

        public IEnumerable<Product> GetProducts() => _products;
    }
}
