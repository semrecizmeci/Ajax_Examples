using ajaxDeneme.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ajaxDeneme.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //public class datas
        //{
        //    public int id { get; set; }
        //    public string? name { get; set; }
        //}
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(int id, string name)
        {
            ViewBag.data = $"{name}"+$"{id}";
        
            return View();
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