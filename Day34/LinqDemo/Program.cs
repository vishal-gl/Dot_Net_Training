using MVC_demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Manager> manager = new List<Manager>() {


                new Manager(){ Id = 1, Name = "DotNet"},
                new Manager() { Id = 2, Name = "Java"},
                
            };
            List<Employee> em = Employee.GetAllEmployess();
            //var result = em.GroupBy(x => x.City);
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item.Key + "  " + item.Count());
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            var res = from e in em
                      join p in manager on e.Id equals p.Id
                      select new
                      {
                          id = e.Id,
                          name = e.Name,
                          project = p.Name


                      };
            foreach(var item in res)
            {
                Console.WriteLine(item.id + "  " + item.name+"  "+item.project);
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
