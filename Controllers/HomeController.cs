using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project.Models;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ShopContext _context;

        public HomeController(ILogger<HomeController> logger,ShopContext context)
        {
            _logger = logger;
            _context=context;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Home";
            ViewBag.Home = "class = active";
            return View();
        }

        public IActionResult About()
        {
            
            return View();
        }

        public IActionResult Shop()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
         public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        /*SIGN UP ---------------------------------------------*/
         public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
         public IActionResult SignUp(SignUp acc)
        {
            if(!checkName(acc.AccountName))
            {
                int Userid=registerDB(acc);
                return RedirectToAction("index", new{id=Userid.ToString()});
            }
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public Boolean checkName(String un){
    
            var checker=_context.Accounts.Where(x=>x.AccountName.ToLower()==un.ToLower()).FirstOrDefault<Account>();

            if(checker!=null){
                return true;
            }
            return false;
        }


        public int registerDB(SignUp firstTime)
        {
           Account ac=new Account();
           ac.AccountName=firstTime.AccountName;
           ac.Password=firstTime.Password;
           ac.Phonenumber=firstTime.Phonenumber;
            _context.Add(ac);
            _context.SaveChanges();
            return ac.AccountID;
        }
    

    /*LOGIN---------------------------------------------------------------------*/

    [HttpPost]
    public IActionResult Login(Login log)
    {
        int uid=checkLog(log.Name,log.Password);


        if(uid==1)
        {
            // return RedirectToAction("Areas/Admin/home/index", new{id=uid.ToString()});
            return RedirectToAction("List","Product",new { area = "Admin" });
            
        }
        else if(uid==0)
        {
            return RedirectToAction("index");
           
        }
        
        return View();
    }

    public int checkLog(String uni,String ps)
    {
    
        var validCred=_context.Accounts.Where(x=>x.AccountName.ToLower()==uni.ToLower() && x.Password.ToLower()==ps.ToLower() ).FirstOrDefault<Account>();
        if(validCred!=null)
        {
            return validCred.isAdmin;
        }
        return -1;

    }
  }
        
}

