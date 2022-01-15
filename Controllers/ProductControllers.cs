using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class ProductController : Controller
    {
        private ShopContext context;

        public ProductController(ShopContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return RedirectToAction("List", "Product");
        }

        [Route("[controller]s")]

        public IActionResult List()
        {

            List<Product> products;
            products = context.Products.OrderBy(p => p.ProductID).ToList();
                    
            // products to view
            return View(products);
        }


        public IActionResult Laptop(string type = "Laptop")
        {

            List<Product> lapproducts;
                lapproducts = context.Products
                    .Where(p => p.Category == type)
                    .OrderBy(p => p.ProductID).ToList();

            // products to view
            return View(lapproducts);
        }

         public IActionResult PC(string type = "PC")
        {

            List<Product> PCproducts;
                PCproducts = context.Products
                    .Where(p => p.Category == type)
                    .OrderBy(p => p.ProductID).ToList();

            // products to view
            return View(PCproducts);
        }

         public IActionResult Accessory(string type = "Accessory")
        {

            List<Product> accproducts;
                accproducts = context.Products
                    .Where(p => p.Category == type)
                    .OrderBy(p => p.ProductID).ToList();

            // products to view
            return View(accproducts);
        }



        public IActionResult Details(int id)
        {
            Product product = context.Products.Find(id);

            ViewBag.imgurl = product.imageURL;

            return View(product);
        }
    }
}