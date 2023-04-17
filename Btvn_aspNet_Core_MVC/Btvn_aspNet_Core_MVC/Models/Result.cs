namespace Btvn_aspNet_Core_MVC.Models
{
    public class Result
    {
        public string StudentCode { get; set; } 
        public string StudentName { get; set; } 
        public string SubjectName { get; set; } 
        public int SubjectId { get; set; }
        public decimal Score { get; set; }

        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }

    }
}
