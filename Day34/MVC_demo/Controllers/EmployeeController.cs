using MVC_demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC_demo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index1()
        {
            string url = "https://localhost:44342/GetEmployee";
            WebClient webClient = new WebClient();

            webClient.Headers.Add(HttpRequestHeader.ContentType, "application/json");
            webClient.Headers.Add("Accept:application/json");

            var response = webClient.DownloadString(url);

            return View(response);
        }
        public ActionResult Index()
        {
            List<Employee> em = Employee.GetAllEmployess();
            
            return View(em);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            List<Employee> em = Employee.GetAllEmployess();
            


            return View(em.FirstOrDefault(x=>x.Id==id));
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {
                Employee.Add(emp);

                
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            Employee e = Employee.emp.FirstOrDefault(x => x.Id == id);
            return View(e);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(Employee e)
        {
            try
            {
                Employee e1 = Employee.emp.FirstOrDefault(x => x.Id == e.Id);
                string name = e.Name;
                string city = e.City;
                string country = e.Country;

                // TODO: Add update logic here
                Employee.Edit(e1,name,city,country);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            
            Employee e = Employee.emp.Find(x=>x.Id==id);
            return View(e);
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(Employee e)
        {
            try
            {
                

                Employee.Delete(Employee.emp.FirstOrDefault(x => x.Id == e.Id));

                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
