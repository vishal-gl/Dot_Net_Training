using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace Student_Database
{
    public partial class SDetails : System.Web.UI.Page
    {
        SqlConnection conn;
        public SDetails()
        {
            // Instantiate the connection
            conn = new SqlConnection("Data Source=NAG1-LHP_N76275;Initial Catalog=newStudent;Integrated Security=SSPI");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                GetEmployeeList();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            // Open the connection
            conn.Open();


            // prepare command string

            string insertString = $"Insert into Student values('{TextBox3.Text}','{TextBox1.Text}','{int.Parse(TextBox4.Text)}','{int.Parse(TextBox5.Text)}','{TextBox2.Text}','{TextBox6.Text}')";


            // 1. Instantiate a new command with a query and connection
            SqlCommand cmd = new SqlCommand(insertString, conn);

            // 2. Call ExecuteNonQuery to send command
            cmd.ExecuteNonQuery();

            conn.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully saved');", true);
            GetEmployeeList();


        }

        protected void Button2_Click(object sender, EventArgs e)
        {



            SqlDataReader rdr = null;
            conn.Open();

            // 1. Instantiate a new command with a query and connection
            SqlCommand cmd = new SqlCommand("select * from Student ", conn);

            // 2. Call Execute reader to get query results
            rdr = cmd.ExecuteReader();
            GridView1.DataSource = rdr;
            GridView1.DataBind();
            conn.Close();

        }
        void GetEmployeeList()
        {
            SqlCommand command = new SqlCommand("Select * from Student", conn);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }



        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.Open();

            string DeleteString = $"delete from Student where Id = '{TextBox3.Text}'";

            SqlCommand cmd = new SqlCommand(DeleteString, conn);


            cmd.ExecuteNonQuery();

            conn.Close();

        }
        
        

        protected void Button3_Click(object sender, EventArgs e)
        {


            // Open the connection
            conn.Open();


            // prepare command string

            string String = $"Update Student set Id='{TextBox3.Text}',Name='{TextBox1.Text}',Age='{int.Parse(TextBox4.Text)}',Standard='{int.Parse(TextBox5.Text)}',City='{TextBox2.Text}',CId='{TextBox6.Text}' where Id='{TextBox3.Text}'";


            // 1. Instantiate a new command with a query and connection
            SqlCommand cmd = new SqlCommand(String, conn);

            // 2. Call ExecuteNonQuery to send command
            cmd.ExecuteNonQuery();

            conn.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
            GetEmployeeList();
        }
        protected void Button4_Click(object sender, EventArgs e)
        {


            // Open the connection
            conn.Open();


            // prepare command string

            string String = $"Delete from Student where Id='{TextBox3.Text}'";


            // 1. Instantiate a new command with a query and connection
            SqlCommand cmd = new SqlCommand(String, conn);

            // 2. Call ExecuteNonQuery to send command
            cmd.ExecuteNonQuery();

            conn.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Deleted';", true);
            GetEmployeeList();


        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            string String = $"Select * from Student where Id='{TextBox3.Text}'";
            SqlCommand command = new SqlCommand(String, conn);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            conn.Close();


        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            conn.Open();


            SqlCommand cmd = new SqlCommand("spDelete", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empId", id);
            GetEmployeeList();


            cmd.ExecuteNonQuery();

            conn.Close();
            GetEmployeeList();

        }
    }
}