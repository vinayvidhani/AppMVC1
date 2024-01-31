using AppMVC1.Models;
using AppMVC1.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AppMVC1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public IProductReporsitory ProductReporsitory { get; }

        public HomeController(ILogger<HomeController> logger, IProductReporsitory productReporsitory)
        {
            _logger = logger;
            ProductReporsitory = productReporsitory;
        }

        public async Task<IActionResult> Index()
        {
            var products = await ProductReporsitory.GetProducts();
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