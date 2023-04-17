using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WorkWithDatabase_b3.Entities;
using WorkWithDatabase_b3.Models;
using WorkWithDatabase_b3.ViewModel;

namespace WorkWithDatabase_b3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _dbContext;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _dbContext = new AppDbContext();    
        }

        public IActionResult Index()
        {
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