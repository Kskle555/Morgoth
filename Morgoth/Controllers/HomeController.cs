using Microsoft.AspNetCore.Mvc;
using Morgoth.Models;
using System.Diagnostics;

namespace Morgoth.Controllers
{
    public class HomeController : Controller
    {
       
         
        public IActionResult Index()
        {
            return View();
        }

       
    }
}