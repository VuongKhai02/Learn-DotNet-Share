using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkWithDatabase_b3.Entities;
using WorkWithDatabase_b3.Models;
using WorkWithDatabase_b3.ViewModel;
using System.Diagnostics;

namespace WorkWithDatabase_b3.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _dbContext;

        public ProductController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _dbContext = new AppDbContext();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddProduct()
        {
            var query = from c in _dbContext.CategoryEntities
                        where c.IsDeleted == false
                        select new Category()
                        {
                            Id = c.Id,
                            Name = c.Name,
                        };

            return View(query.ToList());
        }
        [HttpPost]
        public IActionResult AddProduct(Product model)
        {
            var entity = new ProductEntity()
            {
                CategoryId = model.CategoryId,
                Name = model.Name,
                Price = model.Price,
                Unit = model.Unit,
                CreateDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };

            _dbContext.ProductEntities.Add(entity);
            var status = _dbContext.SaveChanges();
            return Redirect("/product/listproduct");
        }
        public IActionResult EditProduct(int id)
        {
            var productGetted = _dbContext.ProductEntities.Find(id);
            var queryToGetCategory = from c in _dbContext.CategoryEntities select new Category()
            {
                Id = c.Id,
                Name = c.Name,
            };
            var vm = new ProducttViewModel()
            {
                Product = new Product()
                {
                    id = productGetted.id,
                    Name = productGetted.Name,
                    CategoryId = productGetted.CategoryId,
                    Price = productGetted.Price,
                    Unit = productGetted.Unit,
                    Image = productGetted.Image,
                },
                Categories = queryToGetCategory.ToList(),
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult EditProduct(Product model)
        {
            //Lấy ra sp cần sửa
            var entity = _dbContext.ProductEntities.Find(model.id);
            entity.Name = model.Name;
            entity.CategoryId = model.CategoryId;       
            entity.Price = model.Price;
            entity.Image = model.Image;
            entity.Unit = model.Unit;
            entity.UpdatedDate = DateTime.Now;

            _dbContext.ProductEntities.Attach(entity);
            _dbContext.SaveChanges();
            return Redirect("/");
        }

        public IActionResult Delete(int id)
        {
            var produceGetted = _dbContext.ProductEntities.Find(id);
            produceGetted.IsDeleted = true;
            produceGetted.UpdatedDate = DateTime.Now;

            _dbContext.ProductEntities.Update(produceGetted);
            _dbContext.SaveChanges();
            return Redirect("/");
        }
        public IActionResult ListProduct(int pageSize, int pageNumber)
        {
            //equal chỉ dùng join
            var query = from p in _dbContext.ProductEntities
                        join c in _dbContext.CategoryEntities
                        on p.CategoryId equals c.Id
                        where p.IsDeleted == false
                        //Tạo 1 Product như mình đã định nghĩa ở class Product
                        select new Product()
                        {
                            id = p.id,
                            Name = p.Name,
                            Price = p.Price,
                            CategoryName = c.Name,
                            CategoryId = p.CategoryId,
                            Image = p.Image,
                            Unit = p.Unit,
                            CreateDate = p.CreateDate,
                            CreatBy = p.CreatBy
                        };

            var query2 = from p in _dbContext.ProductEntities
                         where p.Name.Contains("R")
                         select new Product()
                         {
                             id = p.id,
                             Name = p.Name,
                             Price = p.Price,
                             //CategoryName = c.Name,
                             //CategoryId = p.CategoryId,
                             Image = p.Image,
                             Unit = p.Unit,
                             CreateDate = p.CreateDate,
                             CreatBy = p.CreatBy
                         };
            if (pageSize == 0)
            {
                pageSize = 10;
            }
            if (pageNumber == 0)
            {
                pageNumber = 1;
            }
            var skip = pageNumber * pageSize - pageSize;
            var totalCount = query.Count();
            var pageCount = (int)Math.Ceiling((double)totalCount/pageSize);

            var vm = new ProducttViewModel()
            {
                TotalCount = totalCount,
                Data = query.OrderBy(x => x.Name).Skip(skip).Take(pageSize).ToList(),
                //Data = query2.ToList(),
                PageCount = pageCount,
                PageNumber=pageNumber,
                PageSize=pageSize,
            };

            vm.Categories = _dbContext.CategoryEntities
                .Select(x => new Category()
                {
                    Name = x.Name,
                    Id = x.Id,
                }).ToList();

            //List<ProductEntity> data;
            //using (var db = new AppDbContext())
            //{
            //    data = db.ProductEntities.ToList();
            //    //var data1 = db.CategoryEntities.ToList();
            //}
            //return View(data);

            return View(vm);
        }
    }
}
