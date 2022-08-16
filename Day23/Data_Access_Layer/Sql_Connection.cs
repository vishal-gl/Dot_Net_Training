using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Data_Access_Layer
{
    class Sql_Connection
    {
        SqlConnection conn;

        public Sql_Connection()
        {
            // Instantiate the connection
            conn = new SqlConnection("Data Source=NAG1-LHP_N76275;Initial Catalog=Product_Category;Integrated Security=SSPI");
        }

        public bool InsertPdata(string PId, string PName, float Pprice, string CId)
        {
            try
            {
                // Open the connection
                conn.Open();


                // prepare command string

                string insertString = $"Insert into Product values('{PId}','{PName}','{Pprice}','{CId}')";


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
                    Console.WriteLine("Please Insert Above Metioned Category Id");
                    Console.WriteLine();


                }
                if (e.Number == 2627)
                {
                    Console.WriteLine("This Product Id is Already Exist In DataBase");
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

        public void ReadData()
        {
            SqlDataReader rdr = null;

            try
            {
                // Open the connection
                conn.Open();

                // 1. Instantiate a new command with a query and connection
                SqlCommand cmd = new SqlCommand("select * from Product Inner Join Category on Product.CategoryId=Category.CategoryId", conn);

                // 2. Call Execute reader to get query results
                rdr = cmd.ExecuteReader();

                // print the CategoryName of each record
                while (rdr.Read())
                {

                    Console.WriteLine("Product Id : {0} || Product Name : {1} || Price :{2} || Category Id : {3} || Category Name : {4} ", rdr["PId"], rdr["PName"], rdr["Price"], rdr["CategoryId"], rdr["CategoryName"]);
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

        public void ReadCategory()
        {
            SqlDataReader rdr = null;

            try
            {
                // Open the connection
                conn.Open();

                // 1. Instantiate a new command with a query and connection
                SqlCommand cmd = new SqlCommand("select * from Category", conn);

                // 2. Call Execute reader to get query results
                rdr = cmd.ExecuteReader();

                // print the CategoryName of each record
                while (rdr.Read())
                {

                    Console.WriteLine("Category Id : {0} || Category Name : {1} ", rdr["CategoryId"], rdr["CategoryName"]);
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

        public int GetNumberOfRecords()
        {
            int count = -1;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select count(*) from Product", conn);

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
                SqlCommand cmd = new SqlCommand("select PId from Product", conn);

                // 2. Call Execute reader to get query results
                rdr = cmd.ExecuteReader();

                // print the id of each record
                while (rdr.Read())
                {
                    if (rdr["PId"].ToString() == Id)
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

        public bool InsertCategory(string CId, string CName)
        {
            try
            {
                // Open the connection
                conn.Open();


                // prepare command string

                string insertString = $"Insert into Category values('{CId}','{CName}')";


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
                    Console.WriteLine("Please Insert Above Metioned Category Id");
                    Console.WriteLine();


                }
                if (e.Number == 2627)
                {
                    Console.WriteLine("This Course Id is Already Exist In DataBase");
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

        public void ReadDataProduct(string pid)
        {

            SqlDataReader rdr = null;

            try
            {
                // Open the connection
                conn.Open();

                // 1. Instantiate a new command with a query and connection
                SqlCommand cmd = new SqlCommand("select * from Product where Product.PId='" + pid + "'", conn);

                // 2. Call Execute reader to get query results
                rdr = cmd.ExecuteReader();

                // print the CategoryName of each record
                while (rdr.Read())
                {
                    Console.WriteLine("PId ProductName Price CategoryId : ");
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        Console.Write(rdr[i] + " ");
                    }
                    Console.WriteLine("");
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

        public bool Update(byte n, string m, string s)
        {
            try
            {
                // Open the connection
                conn.Open();

                switch (n)
                {
                    case 1:

                        string UpdateString = $"Update Product set PId= '{s}' where PId = '{m}'";

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

                        string UpdateString1 = $"Update Product set PName= '{s}' where PId = '{m}'";

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
                        string UpdateString2 = $"Update Product set Price= '{s}' where PId = '{m}'";

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
                        string UpdateString3 = $"Update Product set CategoryId= '{s}' where PId = '{m}'";

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

                string DeleteString = $"delete from Product where PId = '{id}'";

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
    


