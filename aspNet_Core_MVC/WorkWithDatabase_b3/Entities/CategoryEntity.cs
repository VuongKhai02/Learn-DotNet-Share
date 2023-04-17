    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    namespace WorkWithDatabase_b3.Entities
    {
        [Table(name:"Category")]
        public class CategoryEntity
        {
            [Key]
            public int Id { get; set; } 
            public string Name { get; set; }
            public string CreatBy { get; set; }
            public string UpdateBy { get; set; }
            public DateTime CreateDate { get; set; }
            public DateTime UpdatedDate { get; set; }
            public bool IsDeleted { get; set; }
        }
    }
