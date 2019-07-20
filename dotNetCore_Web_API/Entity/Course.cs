using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetCore_Web_API.Entity
{
    [Table("course")]
    public class Course
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("course_id")]
        public int courseID { get; set; }
        [Required]
        [Column("course_name")]
        [StringLength(100)]
        public string courseName { get; set; }
        [Required]
        [Column("course_start_date")]
        public DateTime courseStartDate { get; set; }
        [Required]
        [Column("course_end_date")]
        public DateTime courseEndDate { get; set; }



        public ICollection<Student> students { get; set; }
        public Teacher teacher { get; set; }
    }
}
