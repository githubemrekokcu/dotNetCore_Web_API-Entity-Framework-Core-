using dotNetCore_Web_API.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetCore_Web_API.Db
{
    public class CourseDbContext:DbContext
    {
        public CourseDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses{ get; set; }
        public DbSet<Student> Students{ get; set; }


    }
}
