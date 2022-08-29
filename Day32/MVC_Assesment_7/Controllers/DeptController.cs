using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Assesment_7.Filter;
using MVC_Assesment_7.Models;

namespace MVC_Assesment_7.Controllers
{
    public class DeptController : Controller
    {
        // GET: Dept
        DeptContext db = new DeptContext();
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Department d)
        {
            db.Departments.Add(d);
            db.SaveChanges();
            return RedirectToAction("ViewDepartment");


        }
        [MyException]
        public ActionResult ViewDepartment(Department d)
        {

            var res = db.Database.SqlQuery<Department>("exec SelectDepartment").ToList();
            if (res == null)
            {
                throw new CustomException("Database has no Records");
            }
            else
            {
                return View(res);

            }




        }

    }
}