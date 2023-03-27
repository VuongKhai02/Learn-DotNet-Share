using StudentManager.Models;

namespace StudentManager.ViewModel
{
    public class StudentViewModel
    {
        public List<Student> Data { get; set; } 

        public int PageNumber { get; set; } 

        public int PageCount { get; set; }  

        public int PageSize { get; set; }

        public int TotalCount { get; set; }  


    }
}
