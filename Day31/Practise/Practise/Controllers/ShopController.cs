using Practise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practise.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop

        ComContext db = new ComContext();
        public ActionResult RegisterProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterProduct(Prod p)
        {
            db.Prods.Add(p);
            db.SaveChanges();
            return View();
        }

        public ActionResult ViewProduct(Prod p)
        {
            var res = db.Database.SqlQuery<Prod>("exec SelectAllProd").ToList();
            return View(res);
        }
        //enable-migrations
        //add-database filename
        //update-database

        public ActionResult RegisterCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterCustomer(Custom p)
        {
            if (ModelState.IsValid)
            {
                db.Database.ExecuteSqlCommand("exec InsertCustomer @n='" + p.Cname + "',@d='" + p.Caddress + "',@p='" + p.Prods_Pid + "'");
            }
            return View();

        }

        public ActionResult ViewCustomer()
        {
            var res = db.Database.SqlQuery<Custom>("exec SelectAllCust").ToList();
            return View(res);
        }
    }
}