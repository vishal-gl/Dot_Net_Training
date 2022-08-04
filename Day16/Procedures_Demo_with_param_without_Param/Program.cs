using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Procedures_Demo_with_param_without_Param
{
    class Program
    {
        static void Main(string[] args)
        {
            Program spd = new Program();
            //run a simple stored procedure
            spd.RunStoredProc();
        }
        public void RunStoredProc()
        {
            SqlConnection conn = null;
            SqlDataReader reader = null;
            Console.WriteLine("\n To get Employees Name");
            try
            {
                //craete and open a connection object
                
                conn = new SqlConnection("Data Source=NAG1-LHP_N76275;Initial Catalog=NorthWind;Integrated Security=SSPI");
                conn.Open();

                // careate  a command object identifying teh stored procedure
                SqlCommand cmd = new SqlCommand("spGEtEmployes", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //execute through results ,printing each to consolr
                reader = cmd.ExecuteReader();

                //iterate through results 
                while (reader.Read())
                {
                    Console.WriteLine("First Name :{0} Last Name :{1}",reader["FirstName"],reader["LastName"]);
                }
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();

                }
                if(reader != null)
                {
                    reader.Close();
                }

            }
            Console.ReadLine();
        }
    }
}
