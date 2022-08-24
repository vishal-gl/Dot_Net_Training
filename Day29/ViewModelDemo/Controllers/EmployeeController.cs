using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModelDemo.Models;
using ViewModelDemo.ViewModel;

namespace ViewModelDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        
        public ViewResult Details()
        {
            Employee emp = new Employee()
            {
                EmployeeId = 101,
                Name = "harry",
                Gender = "male",
                Department = "IT",
                Salary = 10000,
                AddressId = 1001
            };
            Address address = new Address()
            {
                AddressId = 1001,
                City = "Vermont",
                State = "MP",
                Country = "Germany",
                Pincode = "12345678"
            };

            EmployeeDetailsViewModel employeeDetailsViewModel = new EmployeeDetailsViewModel()
            {
                Employee = emp,
                Address = address,
                PageTitle = "Employee Details Page",
                PageHeader = "Employee Details"

            };
            return View(employeeDetailsViewModel);

        }
        

    }
}