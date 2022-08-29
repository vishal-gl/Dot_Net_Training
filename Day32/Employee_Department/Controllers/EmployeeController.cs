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
    public class EmployeeController : Controller
    {
        // GET: Employee
        DeptContext db = new DeptContext();
        // GET: Employee
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [MyException]
        public ActionResult Add(Employee e)
        {

            var res = db.Departments.FirstOrDefault(x => x.DId == e.DId);
            if (res == null)
            {
                throw new CustomException("You Insert Invalid Department Id");
            }
            else
            {
                db.Employees.Add(e);
                db.SaveChanges();
                return RedirectToAction("ViewEmployee");

            }
        }
        //To Print Recordes from Employees
        [MyException]
        public ActionResult ViewEmployee(Employee e)
        {

            var res = db.Employees.ToList();
            if (res == null)
            {
                throw new CustomException("Database has no Records");
            }
            else
            {
                return View(res);

            }




        }


        //To Delete The Courses
        [MyException]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                throw new CustomException("Input Is not Getting");
            }
            Employee c = db.Employees.Find(id);
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
            Employee c = db.Employees.Find(id);
            if (ModelState.IsValid)
            {
                db.Employees.Remove(c);
                db.SaveChanges();
                return RedirectToAction("ViewEmployee");
            }
            else
            {
                throw new CustomException("Model State is Invalid");
            }


        }

        //Details of Employee
        [MyException]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                throw new CustomException("Id is not Found");
            }
            Employee c = db.Employees.Find(id);
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
            Employee c = db.Employees.Find(id);
            if (c == null)
            {
                throw new CustomException("Id is not availabale in DataBase to Update");
            }
            return View(c);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [MyException]

        public ActionResult Edit(Employee c)
        {
            if (ModelState.IsValid)
            {
                db.Entry(c).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ViewEmployee");
            }
            return View(c);
        }

    }
}