using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Assesment_7.Filter;
using MVC_Assesment_7.Models;

namespace MVC_Assesment_7.Controllers
{
    public class EmployeeController : Controller
    {
        DeptContext db = new DeptContext();
        // GET: Employee
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [MyException]
        public ActionResult Add(Employee e)
        {

            var res = db.Departments.FirstOrDefault(x => x.DId == e.DId);
            if (res == null)
            {
                throw new CustomException("You Insert Invalid Department Id");
            }
            else
            {
                db.Employees.Add(e);
                db.SaveChanges();
                return RedirectToAction("ViewEmployee");

            }
        }
    }
}