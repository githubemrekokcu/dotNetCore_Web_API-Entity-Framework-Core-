using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetCore_Web_API.Entity
{
    public class Teacher
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("teacher_id")]
        public int teacherID { get; set; }
        [Required]
        [Column("teacher_frst_name")]
        [StringLength(50)]
        public string teacherFirstName { get; set; }
        [Required]
        [Column("teacher_last_name")]
        [StringLength(50)]
        public string teacherLastName { get; set; }
        [Required]
        [Column("teacher_birth_of_date")]
        public DateTime teacherBirthOfDate { get; set; }
        [Required]
        [Column("teacher_tel")]
        [StringLength(10)]
        public string teacherTel { get; set; }
        [Required]
        [Column("teacher_email")]
        [StringLength(100)]
        public string teacherEmail { get; set; }



        public int courseID { get; set; }
        public Course course { get; set; }

    }
}
