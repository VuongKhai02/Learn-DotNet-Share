using WorkWithDatabase_b3.Models;

namespace WorkWithDatabase_b3.ViewModel
{
    public class ProducttViewModel
    {
        public List<Product> Data { get; set; }
        public List<Category> Categories { get; set; }  
        public Product Product { get; set; }    
        //Tổng số bản ghi
        public int TotalCount { get; set; }
        //Số bản ghi / 1 trang
        public int PageSize { get; set; }
        //Số trang hiện tại
        public int PageNumber { get; set; }
        //Tổng số trang
        public int PageCount { get; set; }
    }
}
