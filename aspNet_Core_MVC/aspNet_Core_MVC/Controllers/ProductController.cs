using Microsoft.AspNetCore.Mvc;

namespace aspNet_Core_MVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
