using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayerEmp;


namespace Business_Logic_Emp
{
    public class EmpManagementIo
    {
        public void Insert(string Id,string Name,float salary,string DId)
        {
            EmpService emp = new EmpService();
            emp.Insert(Id, Name, salary, DId);
        } 
        public void Read()
        {
            EmpService emp = new EmpService();
            emp.Read();
        }
    }
}
