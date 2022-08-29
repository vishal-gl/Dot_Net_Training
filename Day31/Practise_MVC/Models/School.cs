using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Practise_MVC.Models
{
    public class School:DbContext
    {
        public School() : base("Default")
        {

        }
       

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }
    }
}