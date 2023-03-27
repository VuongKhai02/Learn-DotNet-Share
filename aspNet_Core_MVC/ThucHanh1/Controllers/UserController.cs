using Microsoft.AspNetCore.Mvc;

namespace ThucHanh1.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
