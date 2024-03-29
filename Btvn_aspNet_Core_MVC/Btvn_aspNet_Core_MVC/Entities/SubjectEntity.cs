﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Btvn_aspNet_Core_MVC.Entities
{
        [Table(name: "Subject")]
    public class SubjectEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
