using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Project.Areas.Admin.Controllers
{
 [Area("Admin")]
 public class ProductController : Controller
 {
     //public Product db= new Product();

     private ShopContext context;
     private IWebHostEnvironment enviroment;

        public ProductController(ShopContext ctx,IWebHostEnvironment env)
        {
            context = ctx;
            enviroment=env;
        }



        [Route("[area]/[controller]s/{id?}")]
        public IActionResult List()
        {
            List<Product> products;
            products = context.Products .OrderBy(p => p.ProductID).ToList();
                
            return View(products);
        }

     //Add Item**********************//
        public IActionResult AddItem()
        {
            return View();
        }

        [HttpPost]
         public async Task<IActionResult> AddItem(VProduct acc)
        {
            if(!checkName(acc.Name))
            {
                Product pro=registerDB(acc);
                string path = Path.Combine(enviroment.WebRootPath, "images"); 
                FileStream stream= new FileStream(Path.Combine(path,pro.ProductID + ".jpg"), FileMode.Create);
                acc.Image.CopyTo(stream);
                stream.Close();
                pro.imageURL = "~/images/" + pro.ProductID + ".jpg";
                context.Update(pro);
                await context.SaveChangesAsync();
                return RedirectToAction("List","Product",new { area = "Admin" });
            }
             
            return View();
        }

        public Boolean checkName(String un)
        {
            var checker=context.Products.Where(x=>x.Name.ToLower()==un.ToLower()).FirstOrDefault<Product>();

            if(checker!=null){
                return true;
            }
            return false;
        }

        public Product registerDB(VProduct firstTime)
        {
           Product ac=new Product();
           ac.Name=firstTime.Name;
           ac.Category=firstTime.Category;
           ac.Price=firstTime.Price;
            context.Add(ac);
            context.SaveChanges();
            return ac;
        }

        //Add Item************************


        //Remove Item**********************//
        
        public ActionResult Delete(int id )
        {
        
            var product = context.Products.Find(id);
            context.Remove(product);
            context.SaveChanges();
            
            return RedirectToAction("List","Product",new { area = "Admin" });
        }

        //Remove Item************************


        //Update Item**********************//
        
        public IActionResult Update(int id)
        {
            Product it=context.Products.FirstOrDefault(c => c.ProductID == id);
	        VProduct vp=new VProduct();
	        vp.Name=it.Name;
	        vp.Price=it.Price;
	        vp.Category =it.Category;
	        vp.ProductID=it.ProductID;
            return View(vp);
            }
             [HttpPost]
         public async Task<IActionResult> Update(VProduct item)
        {
		        Product p=new Product();
			    p.ProductID = item.ProductID;
                p.Category = item.Category;
                p.Price = item.Price;
                p.Name = item.Name;
				if(item.Image!=null)
                {
				string path = Path.Combine(enviroment.WebRootPath, "images");
                FileStream stream = new FileStream(Path.Combine(path, p.ProductID + ".jpg"), FileMode.Create);
                item.Image.CopyTo(stream);
                stream.Close();
				}
                    
                p.imageURL = "~/images/" + p.ProductID + ".jpg";
                await updateDB(p);
                return RedirectToAction("List","Product",new { area = "Admin" });
        }

        public async Task updateDB(Product pr)
        {
            context.Update(pr);
            await context.SaveChangesAsync();
        }

        //Update Item************************
    }




 
}