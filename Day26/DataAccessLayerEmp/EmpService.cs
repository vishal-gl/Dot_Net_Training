using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayerEmp
{
    public class EmpService
    {
        LinqSqlConnection std = new LinqSqlConnection();
        
        public void Insert(string Id,string name,float salary,string DId)
        {
            if (std.InsertData(Id, name, salary, DId))
            {
                Console.WriteLine("Data Added Successfully");

            }
            else
            {
                Console.WriteLine("Details Not Added ");
            }
        }
        public void Read()
        {
            std.ReadData();
        }

    }
}
