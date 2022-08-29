using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exception_Filter_Demo.Filter;

namespace Exception_Filter_Demo.Controllers
{
    public class HomeController : Controller
    {
        [CustomException]
        public ActionResult Index()
        {
            int i = 0;
            if (i == 0)
            {
                throw new NotImplementedException();

            }
            else
            {
                return View();

            }
           
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}