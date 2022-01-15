using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;


namespace Project.Controllers
{
    public class CartController : Controller
    {
        private ShopContext context;

        public CartController(ShopContext ctx)
        {
            context = ctx;
        }

        public IActionResult Default()
        {
            return View();
        }

         public IActionResult AddItem(int id)
        {
            Product it=context.Products.FirstOrDefault(c => c.ProductID == id);
            return View(it);
        }
       
        [HttpPost]
         public async Task<IActionResult> AddItem(Product item)
        {
                await addDB(item);
                return RedirectToAction("List","Product",new { area = "Admin" });
        }

        public async Task addDB(Product pr)
        {
            context.Add(pr);
            await context.SaveChangesAsync();
        }
    

    }

    
}
