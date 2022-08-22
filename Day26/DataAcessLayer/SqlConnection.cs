using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAcessLayer
{
    public class Sql_Connection
    {
        SqlConnection conn;
        
        public Sql_Connection()
        {
            conn = new SqlConnection("Data Source=NAG1-LHP_N76275;Initial Catalog=Enemy;Integrated Security=SSPI");
        }
        public bool Insertdata(string Id, string Name, int Age, int Standard, string City, string CId)
        {
            try
            {
                // Open the connection
                conn.Open();


                // prepare command string

                string insertString = $"Insert into Student values('{Id}','{Name}','{Age}','{Standard}','{City}','{CId}')";


                // 1. Instantiate a new command with a query and connection
                SqlCommand cmd = new SqlCommand(insertString, conn);

                // 2. Call ExecuteNonQuery to send command

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException e)
            {
                if (e.Number == 547)
                {
                    Console.WriteLine("Please Insert Above Metioned Course Id");
                    Console.WriteLine();


                }
                if (e.Number == 2627)
                {
                    Console.WriteLine("This Student Id is Already Exist In DataBase");
                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine(e.Message);
                }

                return false;

            }

            finally
            {
                // Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }


        }

        public bool DeleteData(string id)
        {
            try
            {
                conn.Open();

                string DeleteString = $"delete from Student where Id = '{id}'";

                SqlCommand cmd = new SqlCommand(DeleteString, conn);

                int n = cmd.ExecuteNonQuery();
                if (n > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
    }
}
