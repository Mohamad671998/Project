using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Areas.Admin.Controllers

{
 [Area("Admin")]
 public class HomeController : Controller
 {
    public IActionResult Index()
    {
    return View(); 
    }
 }
}