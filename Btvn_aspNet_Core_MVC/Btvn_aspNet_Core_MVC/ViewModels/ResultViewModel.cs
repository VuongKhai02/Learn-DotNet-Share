using Btvn_aspNet_Core_MVC.Models;

namespace Btvn_aspNet_Core_MVC.ViewModels
{
    public class ResultViewModel
    {
        public List<Result> Results { get; set; }
        public List<Subject> Subjects { get; set; } 
        public string StudentName { get; set; } 
        public string StudentCode { get; set; }
    }
}
