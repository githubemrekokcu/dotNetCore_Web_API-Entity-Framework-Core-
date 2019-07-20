using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetCore_Web_API.Entity
{
    [Table("student")]
    public class Student
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("student_id")]
        public int studentID { get; set; }
        [Required]
        [Column("student_frst_name")]
        [StringLength(50)]
        public string studentFirstName { get; set; }
        [Required]
        [Column("student_last_name")]
        [StringLength(50)]
        public string studentLastName { get; set; }
        [Required]
        [Column("student_birth_of_date")]
        public DateTime studentBirthOfDate { get; set; }
        [Required]
        [Column("student_tel")]
        [StringLength(10)]
        public string studentTel { get; set; }
        [Required]
        [Column("student_email")]
        [StringLength(100)]
        public string studentEmail { get; set; }


        public int courseID { get; set; }
        public Course course { get; set; }
    }
}
