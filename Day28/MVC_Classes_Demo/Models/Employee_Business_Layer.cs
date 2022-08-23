using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Classes_Demo.Models
{
    public class Employee_Business_Layer
    {
        public Employee GetEmployeeDetails(int Id)
        {
            Employee emp = new Employee()
            {
                Id = 1 ,
                Name="Arihant",
                Gender="Male",
                Address="Nagpur",
                Salary=90000 ,
                City="Maharashtra"



            };
            return emp;
        }
    }
}