using Microsoft.AspNetCore.Mvc;
using Hello_World.Models;
using Hello_World.Db;

namespace Hello_World.Controllers
{
    public class ProductsController : Controller
    {

        private readonly IProductDb _productDb;

        public ProductsController(IProductDb productDb)
        {
           _productDb = productDb;
        }

        public ViewResult Detail(int? id, string pname) 
        {
            var product = _productDb.GetDetail(id);
            // ViewData["Product"] = product;
            // ViewBag.Product = product;

            return View(product);
        }

        public ViewResult Products()
        {
            //ViewData["Title"] = "My Web | Products";

            ViewBag.Title = "My Web | Products";

            var products = _productDb.GetProducts();
            return View(products);
        }

        public ViewResult AddNew()
        {
            ViewBag.Title = "Add New Product";
            return View();
        }

        [HttpPost]
        public ViewResult Save(Product product)
        {
            if (!ModelState.IsValid)
            {
                return View("AddNew");
            }
            // This -> Save(Product product) called automatic model binding.
            ViewBag.Title = "Product Saved";
            return View(product);

            //return RedirectToAction("Products");
        }
    }
}
