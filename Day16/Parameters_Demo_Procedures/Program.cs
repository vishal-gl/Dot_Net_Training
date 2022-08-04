using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Parameters_Demo_Procedures
{
    class Program
    {
        static void Main(string[] args)
        {
            //conn and raeder declared outside try
            //block for visibility in finally block

            SqlConnection conn = null;
            SqlDataReader reader = null;
            string inputCity = "London";
            try
            {
                //inststntiate
                conn = new SqlConnection("Data Source=NAG1-LHP_N76275;Initial Catalog=NorthWind;Integrated Security=SSPI");
                conn.Open();

                //SqlCommand cmd =new SqlCommand(
                //"Select * from Customers Where city='"+inputCity+"'",conn);
                //

                //1declare command object ...i.e..declare the sqlparameter in the 
                //sql command string
                SqlCommand cmd = new SqlCommand("Select * from Customers where City =@City",conn);

                //2.define parameters used in command object ..i.e. declare the sql parameter object with
                //applicable properties
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@City";
                param.Value = inputCity;

                //3. add n ew parameter to command object --assign the sql parameter objecty to the sqlcommand object

                cmd.Parameters.Add(param);

                //get data stream
                reader = cmd.ExecuteReader();

                //Write each record
                while (reader.Read())
                {
                    Console.WriteLine(reader["CompanyName"] + " --> is owned by --> " + reader["ContactName"]);
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
