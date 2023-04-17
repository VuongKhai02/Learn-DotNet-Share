using Btvn_aspNet_Core_MVC.Entities;
using Btvn_aspNet_Core_MVC.Models;
using Btvn_aspNet_Core_MVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Btvn_aspNet_Core_MVC.Controllers
{
    public class StudentController : Controller
    {

        public readonly AppDbContext _dbContext;

        public StudentController()
        {
            _dbContext = new AppDbContext();
        }

        public IActionResult ListStudent(int pageSize, int pageNumber, string codeSearch, string nameSearch, string phoneSearch)
        {
            var query = from s in _dbContext.StudentEntities.Where(x => x.IsDeleted == false &&
                        (string.IsNullOrEmpty(nameSearch) || x.Name.ToLower().Contains(nameSearch)) &&
                        (string.IsNullOrEmpty(phoneSearch) || x.Phone.Contains(phoneSearch)) &&
                        (string.IsNullOrEmpty(codeSearch) || x.Code == codeSearch))
                        select new Student()
                        {
                            Id = s.Id,
                            Name = s.Name,
                            Code = s.Code,
                            Addr = s.Addr,
                            Phone = s.Phone,
                            Email = s.Email,
                            CreateBy = s.CreateBy,
                            CreateDate = s.CreateDate,
                            UpdatedDate = s.UpdatedDate,
                        };

            if (pageSize == 0)
            {
                pageSize = 2;
            }
            if (pageNumber == 0)
            {
                pageNumber = 1;
            }

            var totalCount = query.Count();
            var pageCount = (int)Math.Ceiling((decimal)totalCount / pageSize);
            var take = pageSize;
            var skip = pageNumber * pageSize - pageSize;
            var vm = new StudentViewModel()
            {
                Students = query.Skip(skip).Take(pageSize).ToList(),
                PageCount = pageCount,
                PageSize = pageSize,
                PageNumber = pageNumber,
                TotalCount = totalCount,
            };

            return View(vm);
        }

        public IActionResult AddStudent()
        {
            return View();
        }

        public IActionResult EditStudent(string code)
        {
            //var studentGetted = _dbContext.StudentEntities.Find(code);
            var studentGetted = from s in _dbContext.StudentEntities
                                where s.Code == code
                                select new Student()
                                {
                                    Id  = s.Id,
                                    Code = s.Code,
                                    Name = s.Name,
                                    Addr = s.Addr,
                                    Email = s.Email,
                                    Phone = s.Phone,
                                };
            var vm = new StudentViewModel()
            {
                Student = studentGetted.FirstOrDefault(),
        };
            return View(vm);
        }
        public IActionResult DeleteStudent(int id)
        {
            var studentGetted = _dbContext.StudentEntities.Find(id);
            studentGetted.IsDeleted = true;
            studentGetted.UpdatedDate = DateTime.Now;

            _dbContext.StudentEntities.Update(studentGetted);
            _dbContext.SaveChanges();
            return Redirect("/Student/ListStudent");
        }

        [HttpPost]
        public IActionResult AddStudent(Student model)
        {
            var itemAdd = new StudentEntity()
            {
                Code = model.Code,
                Name = model.Name,
                Addr = model.Addr,
                Email = model.Email,
                Phone = model.Phone,
                CreateDate = DateTime.Now,
                CreateBy = "Khai",
            };

            _dbContext.StudentEntities.Add(itemAdd);
            _dbContext.SaveChanges();
            return Redirect("/Student/ListStudent");
        }

        [HttpPost]
        public IActionResult EditStudent(Student model)
        {
            //var entity = from s in _dbContext.StudentEntities
            //             where s.Code == model.Code
            //             select new Student()
            //             {
            //                 Code = model.Code,
            //                 Name = model.Name,
            //                 Addr = model.Addr,                            
            //                 Email = model.Email,
            //                 Phone = model.Phone,
            //             };
            //_dbContext.StudentEntities.Attach(entity);
            //_dbContext.SaveChanges();
            var entity = _dbContext.StudentEntities.Find(model.Id);
            entity.Name = model.Name;
            entity.Addr = model.Addr;
            entity.Email = model.Email;
            entity.Phone = model.Phone;
            entity.UpdatedDate = DateTime.Now;
            _dbContext.StudentEntities.Attach(entity);
            _dbContext.SaveChanges();
            return Redirect("/Student/ListStudent");
        }
    }
}
