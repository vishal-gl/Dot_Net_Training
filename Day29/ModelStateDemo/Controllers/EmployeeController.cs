using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelStateDemo.Models;

namespace ModelStateDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeLinqEntities1 dbcontext = new EmployeeLinqEntities1();
            List<Employee> emplist = dbcontext.Employees.ToList();

            return View(emplist);
        }
        public ActionResult Details(string ID)
        {
            
            
            EmployeeLinqEntities1 dbcontext = new EmployeeLinqEntities1();
            var emplist = dbcontext.Employees.FirstOrDefault(x => x.Id == ID);
            return View(emplist);

        }
    }
}