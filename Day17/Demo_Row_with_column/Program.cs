using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Demo_Row_with_column
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Data Source=NAG1-LHP_N76275;Initial Catalog=NorthWind;Integrated Security=SSPI");
            string sql = "Select ProductName,UnitPrice,SupplierID from Products where UnitPrice<20";
            string sql1 = "select EmployeeID, FirstName,City from Employees where City = 'London'";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Products");
                SqlDataAdapter da1 = new SqlDataAdapter(sql1, conn);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "Employee_Result");
                ds.Merge(ds1);
                DataTable dt = ds.Tables["Products"];
                DataTable dt2 = ds.Tables["Employee_Result"];

                foreach (DataRow row in dt.Rows)
                {
                    foreach(DataColumn col in dt.Columns)
                    {
                        Console.WriteLine(row[col]);
                        
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("=============Employee Result using Merging Database====================");
                Console.WriteLine();


                foreach (DataRow row in dt2.Rows)
                {
                    foreach (DataColumn col in dt2.Columns)
                    {
                        Console.WriteLine(row[col]);

                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("=============Employee Result====================");
                Console.WriteLine();
                DataTable dt1 = ds1.Tables["Employee_Result"];
                foreach (DataRow row in dt1.Rows)
                {
                    foreach (DataColumn col in dt1.Columns)
                    {
                        Console.WriteLine(row[col]);

                    }
                    Console.WriteLine();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            Console.ReadLine();
        }
    }
}
