using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_Prod_Catagory.Filter;
using Task_Prod_Catagory.Models;

namespace Task_Prod_Catagory.Controllers
{
    public class ProductController : Controller
    {
        ShopContext7 db = new ShopContext7();

        //Create

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [MyException]
        
        public ActionResult Register(Product p)
        {
            if (ModelState.IsValid==true)
            {
                var res = db.Products.Where(x => x.CId == p.CId);
                if (res == null)
                {
                    throw new CustomException("Your mentioned Category Id is not available in Category ");
                }
                else
                {
                    db.Database.ExecuteSqlCommand("exec InsertProduct1  @name='" + p.Name + "', @price='" + p.Price + "', @cid='" + p.CId + "'");

                    db.SaveChanges();
                    return RedirectToAction("ViewProduct");

                }

            }
            else
            {
                throw new CustomException("Insert is not Done");
            }





        }

        [MyException]

        public ActionResult ViewProduct(Product c)
        {

            var res = db.Database.SqlQuery<Product>("exec SelectProduct1").ToList();
            if (res == null)
            {
                throw new CustomException("Database has no Records");
            }
            else
            {
                return View(res);

            }




        }

        [MyException]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                throw new CustomException("Input Is not Getting");
            }
            Product c = db.Products.Find(id);
            if (c == null)
            {
                throw new CustomException("Id is not Available in DataBase ");
            }
            return View(c);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [MyException]
        public ActionResult Delete(int id)
        {
            Product c = db.Products.Find(id);
            if (ModelState.IsValid==true)
            {
                db.Database.ExecuteSqlCommand("exec DeleteProduct @id='" + c.PId + "'");
                db.SaveChanges();
                return RedirectToAction("ViewProuct");
            }
            else
            {
                throw new CustomException("Model State is Invalid");
            }


        }

        [MyException]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                throw new CustomException("Id is not Found");
            }
            Product c = db.Products.Find(id);
            if (c == null)
            {
                throw new CustomException("Id is not found in DataBase");
            }
            return View(c);
        }

        [MyException]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                throw new CustomException("Input is Not Getting Properly");
            }
            Product c = db.Products.Find(id);
            if (c == null)
            {
                throw new CustomException("Id is not availabale in DataBase to Update");
            }
            return View(c);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [MyException]

        public ActionResult Edit(Product c)
        {

            if (ModelState.IsValid==true)
            {
                db.Database.ExecuteSqlCommand("exec EditProduct @id='" + c.PId + "', @cid='" + c.CId + "', @name='" + c.Name + "', @price='" + c.Price + "'");

                db.SaveChanges();
                return RedirectToAction("ViewProduct");
            }
            else
            {
                throw new CustomException("Update is not Done");
            }



        }


    }
}