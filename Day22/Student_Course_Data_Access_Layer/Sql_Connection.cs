using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Student_Course_Data_Access_Layer
{
    public class Sql_Connection
    {
        SqlConnection conn;

        public Sql_Connection()
        {
            // Instantiate the connection
            conn = new SqlConnection("Data Source=NAG1-LHP_N76275;Initial Catalog=Enemy;Integrated Security=SSPI");
        }

        public void ReadData()
        {
            SqlDataReader rdr = null;

            try
            {
                // Open the connection
                conn.Open();

                // 1. Instantiate a new command with a query and connection
                SqlCommand cmd = new SqlCommand("select * from Student Inner Join Course on Student.CId=Course.CId", conn);

                // 2. Call Execute reader to get query results
                rdr = cmd.ExecuteReader();

                // print the CategoryName of each record
                while (rdr.Read())
                {

                    Console.WriteLine("Student Id : {0} || Name : {1} || Age :{2} || Standard : {3} || Address : {4} || CID : {5} || CName : {6} || Tutor : {7} || CDuration : {8} ", rdr["Id"], rdr["Name"], rdr["Age"], rdr["Standard"], rdr["City"], rdr["CId"], rdr["CName"], rdr["CTutor"],rdr["CDuration"]);
                    Console.WriteLine();
                }

            }
            finally
            {
                // close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public bool Insertdata(string Id, string Name, int Age, string Standard, string City, string CId)
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

        public int GetNumberOfRecords()
        {
            int count = -1;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select count(*) from Student", conn);

                count = (int)cmd.ExecuteScalar();
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return count;
        }

        public bool CheckId(string Id)
        {
            SqlDataReader rdr = null;

            try
            {
                // Open the connection
                conn.Open();

                // 1. Instantiate a new command with a query and connection
                SqlCommand cmd = new SqlCommand("select Id from Student", conn);

                // 2. Call Execute reader to get query results
                rdr = cmd.ExecuteReader();

                // print the id of each record
                while (rdr.Read())
                {
                    if (rdr["Id"].ToString() == Id)
                    {
                        return true;
                    }

                }
                return false;

            }
            finally
            {
                // close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }


        }

        public bool Update(byte n, string m, string s)
        {
            try
            {
                // Open the connection
                conn.Open();

                switch (n)
                {
                    case 1:

                        string UpdateString = $"Update Student set Id= '{s}' where Id = '{m}'";

                        SqlCommand cmd = new SqlCommand(UpdateString, conn);

                        int p = cmd.ExecuteNonQuery();
                        if (p > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }




                    case 2:

                        string UpdateString1 = $"Update Student set Name= '{s}' where Id = '{m}'";

                        SqlCommand cmd1 = new SqlCommand(UpdateString1, conn);

                        int p1 = cmd1.ExecuteNonQuery();
                        if (p1 > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    case 3:
                        string UpdateString2 = $"Update Student set Age= '{s}' where Id = '{m}'";

                        SqlCommand cmd2 = new SqlCommand(UpdateString2, conn);

                        int p2 = cmd2.ExecuteNonQuery();
                        if (p2 > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }



                    case 4:
                        string UpdateString3 = $"Update Student set Standard= '{s}' where Id = '{m}'";

                        SqlCommand cmd3 = new SqlCommand(UpdateString3, conn);

                        int p3 = cmd3.ExecuteNonQuery();
                        if (p3 > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    case 5:
                        string UpdateString4 = $"Update Student set City= '{s}' where Id = '{m}'";

                        SqlCommand cmd4 = new SqlCommand(UpdateString4, conn);

                        int p4 = cmd4.ExecuteNonQuery();
                        if (p4 > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    default:
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

        public void ReadCourse()
        {
            SqlDataReader rdr = null;

            try
            {
                // Open the connection
                conn.Open();

                // 1. Instantiate a new command with a query and connection
                SqlCommand cmd = new SqlCommand("select * from Course", conn);

                // 2. Call Execute reader to get query results
                rdr = cmd.ExecuteReader();

                // print the CategoryName of each record
                while (rdr.Read())
                {

                    Console.WriteLine("Course Id : {0} || Course Name : {1} || Tutor's Name :{2} || Course Duration in Hrs :{3}", rdr["CId"], rdr["CName"], rdr["CTutor"], rdr["CDuration"]);
                    Console.WriteLine();
                }

            }
            finally
            {
                // close the reader
                if (rdr != null)
                {
                    rdr.Close();
                }

                // Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }


        }

    }
}
