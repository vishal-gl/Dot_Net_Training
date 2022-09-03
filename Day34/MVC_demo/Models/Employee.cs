using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_demo.Models
{
    public class Employee
    {
        public int Id { get; set; }
       
        public string Name { get; set; }

        public string City{ get; set; }

        public string Country { get; set; }


        public static List<Employee> emp = new List<Employee>() {


                new Employee(){ Id = 1, Name = "Vishal", City = "Nagpur", Country = "India" },
                new Employee() { Id = 2, Name = "Aditya", City = "Nagore", Country = "India" },
                new Employee() {Id=3, Name = "Vishali", City = "Nagda", Country = "India" },
                new Employee() {Id=4, Name = "Vikruti", City = "Chennai", Country = "India" }
        };

        public static List<Employee> GetAllEmployess()
        {
            return emp;
        }
            
        public static void Add(Employee e){
            emp.Add(e);

        }

        public static void Delete(Employee e)
        {
            emp.Remove(e);
        }
        public static void Edit(Employee e, string name, string city,string country)
        {
            Employee e1 = Employee.emp.Find(x => x.Id == e.Id);
            e1.Name = name;
            e1.Country = country;
            e1.City = city;
            
        }



    }
}