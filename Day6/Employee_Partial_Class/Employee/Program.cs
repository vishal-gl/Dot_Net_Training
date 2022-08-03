using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee1 emp = new Employee1();
            emp.FirstName = "Vishal";
            emp.LastName = "rathore";
            emp.Salary = 100000;
            emp.Gender = "Male";
            emp.DisplayName();
            emp.DisplayEmployeeDetails();
            Console.WriteLine("Press any key to EXIT");
            Console.ReadKey();
        }
    }
}
