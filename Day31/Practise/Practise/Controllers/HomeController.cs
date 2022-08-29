using Practise.MyException;
using Practise.myValidcheck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practise.Controllers
{
    public class HomeController : Controller
    {
        [CustomException]
        public ActionResult Index()
        {
            throw new MyException1("this is that error");
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