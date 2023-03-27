using Microsoft.AspNetCore.Mvc;
using StudentManager.Models;
using StudentManager.ViewModel;
using System.Diagnostics;

namespace StudentManager.Controllers
{
    public class HomeController : Controller
    {
        public List<Student> listStudent = new List<Student>()
        {
            //Truyền DL datetime : yyyy,MM,dd
            new Student("Dev01",new DateTime(2002,12,10),1,"khai@gmail.com","0909121239"),
            new Student("Face02",new DateTime(2000,2,3),0,"aaa@gmail.com","1233321239"),
            new Student("Nouse02",new DateTime(1999,11,30),2,"a222aa@gmail.com","3213321239")
        };

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var data = listStudent;
            //return View(data);

            var vm = new StudentViewModel();
            vm.Data = listStudent;

            vm.PageNumber = 1;
            //Số phần tử 1 trnag
            vm.PageSize = 5;
            //Tổng số phần tử
            vm.TotalCount = listStudent.Count();
            //Số trang
            vm.PageCount = (int)Math.Ceiling((decimal)vm.TotalCount / vm.PageSize);

            return View(vm);
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