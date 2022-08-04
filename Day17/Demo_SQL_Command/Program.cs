using System;

using System.Data.SqlClient;


namespace USe_4_adding
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.instantiate the connection
            SqlConnection conn = new SqlConnection("Data Source=NAG1-LHP_N76275;Initial Catalog=NorthWind;Integrated Security=SSPI");
            SqlDataReader rdr = null;
            try
            {
                //2. Open the connection
                conn.Open();
                //3.pass the connection to a command object
                SqlCommand cmd = new SqlCommand("select * from Customers", conn);

                //4 use the connection

                //5 get qurey results
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0]);
                }
            }
            finally
            {
                //close the reader
                if(rdr != null)
                {
                    rdr.Close();
                }
                //close the connection
                if(conn != null)
                {
                    conn.Close();
                }
            }
            Console.ReadLine();




        }
    }
}
