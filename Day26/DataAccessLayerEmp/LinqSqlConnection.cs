using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration.Assemblies;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerEmp
{
    class LinqSqlConnection
    {
        SqlConnection con;
        public LinqSqlConnection()
        {
            con = new SqlConnection("Data Source=NAG1-LHP_N76275;Initial Catalog=Student;Integrated Security=SSPI");
        }






        DataLinqDataContext dt = new DataLinqDataContext();
        public bool InsertData(string id,string name,float salary,string DId)
        {
            Employee newEmployee = new Employee();
            newEmployee.Id = id;
            newEmployee.Name = name;
            newEmployee.Salary = salary;
            newEmployee.Dept_Id = DId;
          

                
            dt.Employees.InsertOnSubmit(newEmployee);
            dt.SubmitChanges();
           

           
            return true;

        }

        public DataTable ReadData()
        {
            DataTable dt1 = new DataTable();
                

            var res = (from emp in dt.Employees
                       select emp);
            
            
            foreach (var item in res)
            {
                Employee newEmployee = new Employee();
                newEmployee.Id = item.Id;
                newEmployee.Name = item.Name;
                newEmployee.Salary = item.Salary;
                newEmployee.Dept_Id = item.Dept_Id;
               
                   
            }
            return dt1;
            
           
            
           

        }
    }
}
