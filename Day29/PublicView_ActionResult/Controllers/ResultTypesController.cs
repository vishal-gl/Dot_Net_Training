using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PublicView_ActionResult.Models;

namespace PublicView_ActionResult.Controllers
{
    public class ResultTypesController : Controller
    {
        // GET: ResultTypes
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult ShowEmployee()
        {
            Employee Employee = new Employee()
            {
                Id = 1,
                Name = "Vishal",
                City = "Nagda"

            };
            return View(Employee);
            
               
        }

        public ContentResult ContentResultTest()
        {
            return Content("<b> Hello From GL<b>", "text/html", System.Text.Encoding.UTF8);
        }

        public RedirectResult RedirectResultTest()
        {
            return Redirect("https://google.com");
        }
        
        public HttpStatusCodeResult StatusCodeResult()
        {
            return new HttpStatusCodeResult(200);
        }

        public JsonResult Json()
        {
            return Json(new { Name = "Zain Ul Hassan", ID = 1 }, JsonRequestBehavior.AllowGet);
        }
        
    }
}