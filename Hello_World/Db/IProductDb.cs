using System.Collections.Generic;
using Hello_World.Models;

namespace Hello_World.Db
{
    public interface IProductDb
    {
        // GetProducts() is used to iterate/get multiple records.
        IEnumerable<Product> GetProducts();

        // GetPeroduct(int id) is used to get/return only single product object.
        Product GetDetail(int id);
    }
}
