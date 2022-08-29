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
    public class StudentController : Controller
    {
        School db = new School();

        //Create
        
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [MyException]
        public ActionResult Register(Student s)
        {
            
            var res = db.Courses.FirstOrDefault(x => x.CourseId == s.CourseId);
            if (res == null)
            {
                throw new CustomException("Your mentioned Course Id is not available in Courses ");
            }
            else
            {
                db.Students.Add(s);
                db.SaveChanges();
                return RedirectToAction("ViewStudent");

            }
           


        }
        [MyException]
        public ActionResult ViewStudent(Student s)
        {

            var res = db.Database.SqlQuery<Student>("exec SelectStudent").ToList();
            if (res == null)
            {
                throw new CustomException("DataBase Has No Records");
            }
            else
            {
                return View(res);

            }
            



        }
        [MyException]
        
        public ActionResult SDelete(int? id)
        {
            if (id == null)
            {
                throw new CustomException("It cant receive any input Id to delete a record");
                
            }
            Student s = db.Students.Find(id);
            if (s == null)
            {
                throw new CustomException("Id is not Found");
            }
            return View(s);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SDelete(int id)
        {
            Student s = db.Students.Find(id);
            if (ModelState.IsValid)
            {
                db.Database.ExecuteSqlCommand("exec DeleteStudent @id='" + s.SId + "'");
            }


            db.SaveChanges();
            return RedirectToAction("ViewStudent");
        }

        [MyException]

        public ActionResult SDetails(int? id)
        {
            if (id == null)
            {
                throw new CustomException("Input is Empty,please Give Id as Input");
            }
            Student s = db.Students.Find(id);
            if (s == null)
            {
                throw new CustomException("Required Id is not Found to show Details in Database");
            }
            return View(s);



        }
        [MyException]

        public ActionResult SEdit(int? id)
        {
            if (id == null)
            {
                throw new CustomException("Id is not found in DataBase");
            }
            Student s = db.Students.Find(id);
            if (s== null)
            {
                throw new CustomException("Record Not Found");
            }
            return View(s);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [MyException]
        public ActionResult SEdit(Student s)
        {

            if (ModelState.IsValid)
            {
                db.Database.ExecuteSqlCommand("exec UpdateStudent @id='" + s.SId + "', @name='" + s.Name + "', @address='" + s.Address + "', @dob='" + s.DOB + "',@age='" + s.Age + "',@cid='" + s.CourseId + "',@email='" + s.Email + "',@password='" + s.Password + "',@cpassword='" + s.CPassword + "'");

                db.SaveChanges();
                return RedirectToAction("ViewStudent");
            }
            else
            {
                throw new CustomException("Update is not Done");
            }


            
        }
    }
}