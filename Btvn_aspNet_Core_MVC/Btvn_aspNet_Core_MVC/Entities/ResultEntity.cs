using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Btvn_aspNet_Core_MVC.Entities
{
    [Table(name: "Result")]

    public class ResultEntity
    {
        [Key]
        public int SubjectId { get; set; } 
        public string StudentCode { get; set; }
        public decimal Score { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
