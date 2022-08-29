using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Employee_Department.Models
{
    public class DeptContext:DbContext
    {
        public DeptContext() : base("Default")
        {

        }


        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }
}