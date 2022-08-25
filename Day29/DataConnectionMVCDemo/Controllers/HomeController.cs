using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataConnectionMVCDemo.Models;

namespace DataConnectionMVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            NorthwindEntities db = new NorthwindEntities();
            List<Employee> emplist = db.Employees.ToList();

            return View(emplist);
            
        }

        public ActionResult About(int Id)
        {
            NorthwindEntities dbcontext = new NorthwindEntities();
           
         
            var emplist = dbcontext.Employees.FirstOrDefault(x=>x.EmployeeID==Id);
            
            return View(emplist);
          
        }

        public ActionResult Edit(int id)
        {
            NorthwindEntities dbcontext = new NorthwindEntities();
            var emplist = dbcontext.Employees.FirstOrDefault(x => x.EmployeeID == id);

            
            return View(emplist);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee emp)
        {

            NorthwindEntities dbcontext = new NorthwindEntities();
            if (ModelState.IsValid)
            {
                dbcontext.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                dbcontext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emp);
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}