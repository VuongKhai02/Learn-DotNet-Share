using btvn_FruitManager_b2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace btvn_FruitManager_b2.Controllers
{
    public class HomeController : Controller
    {
        public List<Fruit> lstFruit = new List<Fruit>()
        {
            new Fruit(1,"Organic ","./images/Chan dung-khai.png",3200, 6500, 27, 2),
            new Fruit(2,"Chemical","./images/Chan dung-khai.png",3400, 1100, 47, 4),
            new Fruit(3,"Water Melon","./images/Chan dung-khai.png",4400, 2220, 22, 5),
            new Fruit(4,"Strawberry","./images/Chan dung-khai.png",1000, 3300, 11, 1),
            new Fruit(5,"Cococnut","./images/Chan dung-khai.png",5000, 6500, 44, 4),
        };

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var data = lstFruit;
            return View(data);
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