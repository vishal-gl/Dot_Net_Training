using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task_Prod_Catagory.Filter;
using Task_Prod_Catagory.Models;

namespace Task_Prod_Catagory.Controllers
{
    public class CategoryController : Controller
    {
        ShopContext7 db = new ShopContext7();

        //Create
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Category c)
        {
            if (ModelState.IsValid == true)
            {
                db.Categories.Add(c);
                db.SaveChanges();
            }
            
            return RedirectToAction("ViewCategory");


        }
        [MyException]

        public ActionResult ViewCategory(Category c)
        {

            var res = db.Database.SqlQuery<Category>("exec SelectCategory").ToList();
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
                Category c = db.Categories.Find(id);
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
                Category c = db.Categories.Find(id);
                if (ModelState.IsValid==true)
                {
                    db.Database.ExecuteSqlCommand("exec DeleteCourse @cid='" + c.CId + "'");
                    db.SaveChanges();
                    return RedirectToAction("ViewCategory");
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
            Category c = db.Categories.Find(id);
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
            Category c = db.Categories.Find(id);
            if (c == null)
            {
                throw new CustomException("Id is not availabale in DataBase to Update");
            }
            return View(c);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [MyException]

        public ActionResult Edit(Category c)
        {

            if (ModelState.IsValid==true)
            {
                db.Database.ExecuteSqlCommand("exec EditCategory @cid='" + c.CId + "', @name='" + c.CategoryName + "'");

                db.SaveChanges();
                return RedirectToAction("ViewCategory");
            }
            else
            {
                throw new CustomException("Update is not Done");
            }



        }

    }
}