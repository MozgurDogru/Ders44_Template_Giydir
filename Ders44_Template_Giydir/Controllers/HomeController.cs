using Ders44_Template_Giydir.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ders44_Template_Giydir.Controllers
{
    public class HomeController : Controller
    {
        NorthwindContext context = new NorthwindContext();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cart() 
        {
            return View();
        }

        public IActionResult Index2()
        {
            List<Product> products = context.Products.ToList();
            return View(products);

        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}