using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api_Demo.Controllers
{
    public class EmployeeController : ApiController
    {
        EmployeeLinqEntities db = new EmployeeLinqEntities();


        [Route("GetEmployee")]
        public IQueryable<Employee> GetEmployees()
        {
            return db.Employees;
        }
        [Route("SingleEmployee/{id}")]
        [HttpGet]
        public Employee GetEmployee(string id)
        {
            Employee employee = db.Employees.Find(id);
            

            return employee;
        }

        [HttpPost]
        [Route("InsertEmployee")]
        public IHttpActionResult InsertEmployee(Employee employee)
        {
            //Employee emp = new Employee()
            //{
            //    Id = employee.Id,
            //    Name = employee.Name,
            //    Salary = employee.Salary,
            //    Dept_Id = employee.Dept_Id
            //};
            db.Employees.Add(employee);
            db.SaveChanges();
            return Ok();
        }
        [Route("UpdateEmployee")]
        [HttpPut]   
        public IHttpActionResult Update(Employee emp)
        {
            var res = db.Employees.FirstOrDefault(x => x.Id == emp.Id);
            res.Name = emp.Name;
            res.Salary = emp.Salary;
            res.Dept_Id = emp.Dept_Id;

            db.SaveChanges();
            return Ok();
            
        }
        [Route("Delete/{id}")]
        [HttpDelete]
       
        public IHttpActionResult Delete(string id)
        {
            Employee employee = db.Employees.Find(id);
            

            db.Employees.Remove(employee);
            db.SaveChanges();

            return Ok();
        }
    }
}
