using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using DempApi;

namespace DempApi.Controllers
{
    public class EmployeesController : ApiController
    {
        private EmployeeLinqEntities db = new EmployeeLinqEntities();

        // GET: api/Employees
        [HttpGet]
        [Route("GetEmployee")]
      
        public IQueryable<Employee> GetEmployees()
        {
            return db.Employees;
        }

        // GET: api/Employees/5
        [ResponseType(typeof(Employee))]
        [Route("GetEmployee")]
        public IHttpActionResult GetEmployee(string id)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }

        // PUT: api/Employees/5
        [ResponseType(typeof(void))]
        [HttpPut]
        public IHttpActionResult PutEmployee(string id, Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != employee.Id)
            {
                return BadRequest();
            }

            db.Entry(employee).State = EntityState.Modified;

            
            db.SaveChanges();
            
            return Ok();
        }

        // POST: api/Employees
        
        
        [HttpPost]
        [Route("PostInsertEmployee")]
        public IHttpActionResult PostInsertEmployee(Employee employee)
        {
            Employee emp = new Employee()
            {
                Id = employee.Id,
                Name =employee.Name,
                Salary = employee.Salary,
                Dept_Id = employee.Dept_Id
            };
            
            
            

              db.Employees.Add(emp);

            
            
              db.SaveChanges();
            return Ok();
                

            //return CreatedAtRoute("DefaultApi", new { id = employee.Id }, employee);
        }

        // DELETE: api/Employees/5
        

        
        [HttpDelete]
        public IHttpActionResult Delete(string id)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }

            db.Employees.Remove(employee);
            db.SaveChanges();

            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EmployeeExists(string id)
        {
            return db.Employees.Count(e => e.Id == id) > 0;
        }
    }
}