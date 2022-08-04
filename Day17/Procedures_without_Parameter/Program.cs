using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Procedure_without_Parameter
{
    class Program
    {

        static void Main(string[] args)
        {
            Program spd = new Program();

            //run a simple stored Procedure
            spd.RunStoredProc();

            //run a stored procedure that takes a prameter
            //sp.RunStoredProcParams();

        }
        public void RunStoredProc()
        {
            SqlConnection conn = null;
            SqlDataReader rdr = null;
            Console.WriteLine("\n Top 10 Most Expensive ProductsL\n");

            try
            {
                conn = new SqlConnection(
                "Server=NAG1-LHP_N76275;Initial Catalog =Northwind;Integrated Security =SSPI"
                );
                conn.Open();
                //1.create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("Ten Most Expensive Products", conn);

                //2.set the command object so it knows to execute a stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //exxecute the command
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine("Products:{0,25} Price : ${1,6:####.00}", rdr["TenMostExpensiveProducts"], rdr["UnitPrice"]);

                }
            }
            finally
            {
                //close the reader
                if (rdr != null)
                    rdr.Close();

                if (conn != null)
                    conn.Close();
            }
            Console.ReadLine();
        }
        
        
    }
}
