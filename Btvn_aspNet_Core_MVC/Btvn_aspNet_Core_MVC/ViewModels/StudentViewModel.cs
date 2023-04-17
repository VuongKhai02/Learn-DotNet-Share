using Btvn_aspNet_Core_MVC.Models;

namespace Btvn_aspNet_Core_MVC.ViewModels
{
    public class StudentViewModel
    {
        public List<Student> Students { get; set; }
        public Student Student { get; set; }    
        //số lượng page
        public int PageCount { get; set; }  

        //kích cỡ 1 pagge
        public int PageSize { get; set; }   

        //số lượng phần tử
        public int TotalCount { get; set; } 

        //Page hiện tại
        public int PageNumber { get; set; }    
    }
}
