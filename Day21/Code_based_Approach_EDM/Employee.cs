using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Code_based_Approach_EDM
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }

        public int DepartmentId { get; set; }

        public virtual Department Departments { get; set; }
    }
}
