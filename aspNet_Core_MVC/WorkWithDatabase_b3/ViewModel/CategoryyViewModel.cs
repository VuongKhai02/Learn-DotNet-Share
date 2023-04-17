using WorkWithDatabase_b3.Models;

namespace WorkWithDatabase_b3.ViewModel
{
    public class CategoryyViewModel
    {
        public List<Category> Data { get; set; }

        public int SizePage { get; set; }   
        public int PageCount { get; set; }  
        public int TotalCount { get; set; }
        public int CurrentPage { get; set; }    

    }
}
