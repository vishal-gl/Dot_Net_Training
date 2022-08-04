using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Demo_Procedure_with_Parameter
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Program spd = new Program();
            string str = "Davolio";
            //run a simple stored procedure
            spd.RunStoredProc(str);
        }
        public void RunStoredProc(string str)
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
                SqlCommand cmd = new SqlCommand("spGetEmployeesBYGenderandDepartment", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@LastName",str));
                cmd.Parameters.Add(new SqlParameter("@PostalCode",98122));

                //execute through results ,printing each to consolr
                reader = cmd.ExecuteReader();

                //iterate through results 
                while (reader.Read())
                {
                    Console.WriteLine(reader["FirstName"]);
                }
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();

                }
                if (reader != null)
                {
                    reader.Close();
                }

            }
            Console.ReadLine();
        }
    }
}
