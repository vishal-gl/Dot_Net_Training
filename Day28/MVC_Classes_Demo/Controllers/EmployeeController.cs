using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Classes_Demo.Models;

namespace MVC_Classes_Demo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            int Id = 1;
            Employee_Business_Layer EmpBL = new Employee_Business_Layer();
            Employee employee = EmpBL.GetEmployeeDetails(Id);
            //ViewData["Employee"] = employee;
            //ViewData["Header"] = "Employee_Details";
            ViewBag.Emp = employee;
            ViewBag.Header = "Employee_Details";
            
            return View();
        }
    }
}