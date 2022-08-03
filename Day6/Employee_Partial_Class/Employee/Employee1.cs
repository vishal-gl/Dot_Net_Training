using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    partial class Employee1
    {
        public void DisplayName()
        {
            Console.WriteLine("@Full Name is {0} {1}", _firstName, _lastName);

        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Deatails :");
            Console.WriteLine("@First Name is : {0} ", _firstName);
            Console.WriteLine("@Last Name is : {0}", _lastName);

            Console.WriteLine("@Gender is : {0}", _gender);
            Console.WriteLine("@Salary is : {0}", _salary);

        }
    }
}
