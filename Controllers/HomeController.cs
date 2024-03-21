using BooksMission11Hammond.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BooksMission11Hammond.Controllers
{
    public class HomeController : Controller
    {
        

        public HomeController(ILogger<HomeController> logger)
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }

        
    }
}
