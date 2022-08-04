using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Demo_DataSet
{
    class Program
    {
        static void Main(string[] args) { 
    
           
            
                SqlConnection conn = new SqlConnection("Data Source=NAG1-LHP_N76275;Initial Catalog=NorthWind;Integrated Security=SSPI");
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from Customers", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    Console.WriteLine("{0} ", row["CustomerID"]);

                }
                DataSet ds = new DataSet();
                da.Fill(ds, "CompanyName");
                Console.WriteLine();
                Console.WriteLine("====================================");
                Console.WriteLine();
                Console.WriteLine(ds.Tables.Count);
                Console.WriteLine();
                Console.WriteLine("====================================");
                Console.WriteLine();
                Console.WriteLine(ds.Tables[0].TableName);
                Console.WriteLine();
                Console.WriteLine("====================================");
                Console.WriteLine();
                foreach (DataRow row in ds.Tables["CompanyName"].Rows)
                {
                    Console.WriteLine("{0}", row["CompanyName"]);
                }
            }

            catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }
            Console.ReadLine();
        }
    }
}
