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

        public ActionResult About()
        {
            NorthwindEntities dbcontext = new NorthwindEntities();
            var emplist = dbcontext.Employees.FirstOrDefault(x => x.FirstName=="Nancy");
            return View(emplist);







           
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}