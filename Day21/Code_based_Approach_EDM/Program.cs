using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_based_Approach_EDM
{
    class Program
    {
        static void Main(string[] args)
        {
            DataaccessHelper dbHelper = new DataaccessHelper();
            Department dept = new Department()
            {
                DepartmentName = "IT Department",
                Employees = new List<Employee>
                {
                    new Employee() {EmployeeName="Ram" } ,
                    new Employee() {EmployeeName="Shyam" } ,
                    new Employee() {EmployeeName="Jamm" } ,
                    new Employee() {EmployeeName="Sita" }

                }
            };
            dbHelper.AddDept(dept);
            var AddedDeptValue = dbHelper.FetchDepartments().FirstOrDefault();
            if (AddedDeptValue != null)
            {
                Console.WriteLine(AddedDeptValue.DepartmentName);
                Console.WriteLine("List of Employees are : ");
                foreach(var AddedDeptEmp in AddedDeptValue.Employees)
                {
                    Console.WriteLine(AddedDeptEmp.EmployeeName);


                }

            }
            Console.ReadLine();
        }
    }
}
