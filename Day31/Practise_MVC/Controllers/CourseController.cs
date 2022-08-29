using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practise_MVC.Models;
using Practise_MVC.Filter;

using Practise_MVC.ValidCheck;

namespace Practise_MVC.Controllers
{
    public class CourseController : Controller
    {
        School db = new School();

       //Create
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Course c)
        {
            db.Courses.Add(c);
            db.SaveChanges();
            return RedirectToAction("ViewCourses");

           
        }

        //To Print Recordes from Courses
        [MyException]
        public ActionResult ViewCourses(Course c)
        {
           
            var res = db.Database.SqlQuery<Course>("exec SelectCourses").ToList();
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
            Course c = db.Courses.Find(id);
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
            Course c = db.Courses.Find(id);
            if (ModelState.IsValid)
            {
                db.Database.ExecuteSqlCommand("exec DeleteCourse @cid='" + c.CourseId + "'");
                db.SaveChanges();
                return RedirectToAction("ViewCourses");
            }
            else
            {
                throw new CustomException("Model State is Invalid");
            }
           
            
        }

        //Details of Course
        [MyException]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                throw new CustomException("Id is not Found");
            }
            Course c = db.Courses.Find(id);
            if (c == null)
            {
               throw new CustomException("Id is not found in DataBase");
            }
            return View(c);
        }

        [MyException]
        public ActionResult Update(int? id)
        {
            if (id == null)
            {
                throw new CustomException("Input is Not Getting Properly");
            }
            Course c = db.Courses.Find(id);
            if (c == null)
            {
                throw new CustomException("Id is not availabale in DataBase to Update");
            }
            return View(c);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [MyException]
        
        public ActionResult Update(Course c)
        {
            
            if (ModelState.IsValid)
            {
                db.Database.ExecuteSqlCommand("exec UpdateCourse @cid='" + c.CourseId + "', @Cname='" + c.CourseName + "', @Tname='" + c.TutorName + "', @Cduration='" + c.Duration + "'");
                
                db.SaveChanges();
                return RedirectToAction("ViewCourses");
            }
            else
            {
                throw new CustomException("Update is not Done");
            }
            
            
           
        }




    }
}