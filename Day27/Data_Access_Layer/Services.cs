using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Book_Schema;
namespace Data_Access_Layer
{
    public class Services
    {
        SqlConnection con;
        public Services()
        {
            con = new SqlConnection("Data Source=NAG1-LHP_N76275;Initial Catalog=BookDatabase;Integrated Security=SSPI");
        }
        SqlCommand cmd;
        DataTable dt;

        public int InsertData(Book_Schema.Entity objSchema)
        {
            try
            {


                SqlCommand cmd = new SqlCommand("Insert_User_Data", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Para", "ADD");
                cmd.Parameters.AddWithValue("@Id", objSchema.Id);

                cmd.Parameters.AddWithValue("@Name", objSchema.Name);
                cmd.Parameters.AddWithValue("@Author", objSchema.Author);
                cmd.Parameters.AddWithValue("@Publisher", objSchema.Publisher);
                cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(objSchema.Price));
                if (con.State.Equals(ConnectionState.Closed)) con.Open();
                int result = cmd.ExecuteNonQuery();
                con.Close();
                return result;

            }
            catch (Exception ex)
            {
                throw ex;
                //Console.WriteLine("Please Enter All Details");
            }
            finally
            {
                con.Close();
            }
        }

        public int UpdateData(Book_Schema.Entity objSchema, int Id)
        {
            try
            {
                using (cmd = new SqlCommand("Insert_User_Data", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Para", "Update");
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.Parameters.AddWithValue("@Name", objSchema.Name);
                    cmd.Parameters.AddWithValue("@Author", objSchema.Author);
                    cmd.Parameters.AddWithValue("@Publisher", objSchema.Publisher);

                    cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(objSchema.Price));
                    if (con.State.Equals(ConnectionState.Closed)) con.Open();
                    int result = cmd.ExecuteNonQuery();
                    con.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public int DeleteData(int Id)
        {
            try
            {
                using (cmd = new SqlCommand("Insert_User_Data", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Para", "Delete");
                    cmd.Parameters.AddWithValue("@Id", Id);
                    if (con.State.Equals(ConnectionState.Closed)) con.Open();
                    int result = cmd.ExecuteNonQuery();
                    con.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable BindGrid()
        {
            using (cmd = new SqlCommand("Insert_User_Data", con))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Para", "Get_For_Grid");
                    if (con.State.Equals(ConnectionState.Closed)) con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public DataTable GetById(int Id)
        {
            using (cmd = new SqlCommand("Insert_User_Data", con))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Para", "Get_By_Id");
                    cmd.Parameters.AddWithValue("@Id", Id);
                    if (con.State.Equals(ConnectionState.Closed)) con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


        }

    }
}
