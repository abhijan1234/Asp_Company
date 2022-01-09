using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Project.Models
{
    public class Dept
    {
        [Key]
        [Required]
        public int DeptNo { get; set; }
        [MaxLength(30)]
        public String DeptName { get; set; }
        [MaxLength(30)]
        public String Location { get; set; }
    }
    
}