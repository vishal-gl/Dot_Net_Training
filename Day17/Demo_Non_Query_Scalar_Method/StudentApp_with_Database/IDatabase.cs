using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StudentApp_with_Database
{
    class IDatabase
    {
        SqlConnection conn;

        public IDatabase()
        {
            // Instantiate the connection
            conn = new SqlConnection("Data Source=NAG1-LHP_N76275;Initial Catalog=SampleDB;Integrated Security=SSPI");
        }
        public void ReadData()
        {
            SqlDataReader rdr = null;

            try
            {
                // Open the connection
                conn.Open();

                // 1. Instantiate a new command with a query and connection
                SqlCommand cmd = new SqlCommand("select * from Student", conn);

                // 2. Call Execute reader to get query results
                rdr = cmd.ExecuteReader();

                // print the CategoryName of each record
                while (rdr.Read())
                {

                    Console.WriteLine("Student Id : {0} Name : {1} Standard : {2} Address : {3}", rdr["Id"], rdr["Name"], rdr["Standard"], rdr["Address"]);
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

        /// <summary>
        /// use ExecuteNonQuery method for Insert
        /// </summary>
        public void Insertdata(int n, string s, string s1, string s2)
        {
            try
            {
                // Open the connection
                conn.Open();


                // prepare command string
                string insertString = @"
                 insert into Student(Id,Name,Standard,Address) values('"+n+"','"+s+"','"+s1+"','"+s2+"')";

                // 1. Instantiate a new command with a query and connection
                SqlCommand cmd = new SqlCommand(insertString, conn);

                // 2. Call ExecuteNonQuery to send command
                cmd.ExecuteNonQuery();
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

        /// <summary>
        /// use ExecuteNonQuery method for Update
        /// </summary>
        public void UpdateData(int n, int m, string s)
        {
            try
            {
                // Open the connection
                conn.Open();
                switch (n)
                {
                    case 1:
                        int p = Convert.ToInt32(s);
                        string updateString = @"
                        update Student
                        set Id=@Id
                        where Id= '" + m + "'";

                        SqlCommand cmd = new SqlCommand(updateString);
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = "@Id";
                        param.Value = p;
                        cmd.Parameters.Add(param);
                        cmd.Connection = conn;
                        cmd.ExecuteNonQuery();
                        break;



                    case 2:

                        string updateString1 = @"
                        update Student
                        set Name=@Name
                        where Id= '" + m + "'";

                        SqlCommand cmd1 = new SqlCommand(updateString1);
                        SqlParameter param1 = new SqlParameter();
                        param1.ParameterName = "@Name";
                        param1.Value = s;
                        cmd1.Parameters.Add(param1);
                        cmd1.Connection = conn;
                        cmd1.ExecuteNonQuery();
                        break;
                    case 3:
                        string updateString2 = @"
                        update Student
                        set Standard=@Standard
                        where Id= '" + m + "'";

                        SqlCommand cmd2 = new SqlCommand(updateString2);
                        SqlParameter param2 = new SqlParameter();
                        param2.ParameterName = "@Standard";
                        param2.Value = s;
                        cmd2.Parameters.Add(param2);
                        cmd2.Connection = conn;
                        cmd2.ExecuteNonQuery();
                        break;

                    case 4:
                        string updateString3 = @"
                        update Student
                        set Address=@Address
                        where Id= '" + m + "'";

                        SqlCommand cmd3 = new SqlCommand(updateString3);
                        SqlParameter param3 = new SqlParameter();
                        param3.ParameterName = "@Address";
                        param3.Value = s;
                        cmd3.Parameters.Add(param3);
                        cmd3.Connection = conn;
                        cmd3.ExecuteNonQuery();
                        break;
                    default:
                        break;

                }






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

        /// <summary>
        /// use ExecuteNonQuery method for Delete
        /// </summary>
        public void DeleteData(int n)
        {
            try
            {
                // Open the connection
                conn.Open();

                // prepare command string
                string deleteString = @"
                 delete from Student
                 where Id ='" + n + "'";

                // 1. Instantiate a new command
                SqlCommand cmd = new SqlCommand();

                // 2. Set the CommandText property
                cmd.CommandText = deleteString;

                // 3. Set the Connection property
                cmd.Connection = conn;

                // 4. Call ExecuteNonQuery to send command
                cmd.ExecuteNonQuery();
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

        /// <summary>
        /// use ExecuteScalar method
        /// </summary>
        /// <returns>number of records</returns>
        public int GetNumberOfRecords()
        {
            int count = -1;
            try
            {
                // Open the connection
                conn.Open();
                // 1. Instantiate a new command
                SqlCommand cmd = new SqlCommand("select count(*) from Categories", conn);

                // 2. Call ExecuteScalar to send command
                count = (int)cmd.ExecuteScalar();
            }
            finally
            {
                // Close the connection
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return count;
        }
    }
}
    

