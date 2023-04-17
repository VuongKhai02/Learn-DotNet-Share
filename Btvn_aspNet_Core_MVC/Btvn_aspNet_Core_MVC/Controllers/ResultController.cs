using Btvn_aspNet_Core_MVC.Entities;
using Btvn_aspNet_Core_MVC.Models;
using Btvn_aspNet_Core_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Btvn_aspNet_Core_MVC.Controllers
{
    public class ResultController : Controller
    {
        private readonly AppDbContext _dbContext;
        public ResultController()
        {
            _dbContext = new AppDbContext();
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListResult(string code)
        {
            var query = from r in _dbContext.ResultEntities
                        join stu in _dbContext.StudentEntities on r.StudentCode equals stu.Code
                        join sub in _dbContext.SubjectEntities on r.SubjectId equals sub.Id
                        where r.StudentCode == code
                        select new Result()
                        {
                            StudentCode = r.StudentCode,
                            StudentName = stu.Name,
                            SubjectName = sub.Name,
                            Score = r.Score,
                            CreateDate = r.CreateDate,
                            CreateBy=r.CreateBy,
                            UpdatedDate = r.UpdatedDate,
                        };
            var vm = new ResultViewModel()
            {
                Results = query.ToList(),
                StudentName = query.FirstOrDefault()?.StudentName,
                StudentCode = code,
        };
            return View(vm);
        }

        public IActionResult AddResult(string code)
        {

            //hỏi a dũng
            var query0 = from stu in _dbContext.StudentEntities
                         where stu.Code == code
                         select new { stu.Name, stu.Code };
            var query2 = from sub in _dbContext.SubjectEntities
                         where sub.IsDeleted == false
                         select new Subject()
                         {
                             Id = sub.Id,
                             Name = sub.Name,
                         };
            var vm = new ResultViewModel()
            {
                Subjects = query2.ToList(),
                StudentName = query0.FirstOrDefault().Name,
                StudentCode= query0.FirstOrDefault().Code,
            };
            return View(vm);
        }

        [HttpPost]
        public IActionResult AddResult(Result model)
        {
            var itemAdd = new ResultEntity()
            {
                StudentCode = model.StudentCode,
                SubjectId = model.SubjectId,
                Score = model.Score,
                CreateDate = DateTime.Now,
                CreateBy = "Khai",
            };

            _dbContext.ResultEntities.Add(itemAdd);
            _dbContext.SaveChanges();
            return Redirect("/Result/ListResult?code="+model.StudentCode);
        }

    }
}
