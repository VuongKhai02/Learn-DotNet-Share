using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkWithDatabase_b3.Entities
{
    [Table(name:"Product")]
    public class ProductEntity
    {
        [Key] 
        public int id { get; set; } 
        public string Name { get; set; }    
        public decimal Price { get; set; }  
        public string Image { get; set; }
        public string Unit { get; set; }    
        public int CategoryId { get; set; } 
        public string CreatBy { get; set; }    
        public string UpdateBy { get; set; }    
        public DateTime CreateDate { get; set; }    
        public DateTime UpdatedDate { get; set; }    
        public bool IsDeleted { get; set; }  
    }
}
