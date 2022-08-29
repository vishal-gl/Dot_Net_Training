using Employee_Department.Filter;
using Employee_Department.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee_Department.Controllers
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
        public ActionResult ViewDepartment(Department e)
        {

            var res = db.Departments.ToList();
            if (res == null)
            {
                throw new CustomException("Database has no Records");
            }
            else
            {
                return View(res);

            }




        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                throw new CustomException("Input Is not Getting");
            }
            Department c = db.Departments.Find(id);
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
            Department c = db.Departments.Find(id);
            if (ModelState.IsValid)
            {
                db.Departments.Remove(c);
                db.SaveChanges();
                return RedirectToAction("ViewDepartment");
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
            Department c = db.Departments.Find(id);
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
            Department c = db.Departments.Find(id);
            if (c == null)
            {
                throw new CustomException("Id is not availabale in DataBase to Update");
            }
            return View(c);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [MyException]

        public ActionResult Edit(Department c)
        {
            if (ModelState.IsValid)
            {
                db.Entry(c).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ViewDepartment");
            }
            return View(c);
        }
    }
}