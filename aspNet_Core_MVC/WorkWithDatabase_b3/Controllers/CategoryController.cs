using Microsoft.AspNetCore.Mvc;
using WorkWithDatabase_b3.Entities;
using WorkWithDatabase_b3.Models;
using WorkWithDatabase_b3.ViewModel;

namespace WorkWithDatabase_b3.Controllers
{
    public class CategoryController : Controller
        {
            public readonly AppDbContext _dbContext;

        public CategoryController()
        {
            _dbContext = new AppDbContext();
        }

        public IActionResult ListCategory()
        {
            var query = from c in _dbContext.CategoryEntities
                        select new Category()
                        {
                            Name = c.Name,  
                            Id = c.Id,
                            CreatBy = c.CreatBy,    
                        };

            var vm = new CategoryyViewModel()
            {
                Data = query.ToList(),
            };
            return View(vm);
        }


        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category model)
        {
            var data = new CategoryEntity()
            {
                Name = model.Name,  
                CreatBy = model.CreatBy,
                CreateDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };

            _dbContext.CategoryEntities.Add(data);
            _dbContext.SaveChanges();
            return Redirect("/Category/ListCategory");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
