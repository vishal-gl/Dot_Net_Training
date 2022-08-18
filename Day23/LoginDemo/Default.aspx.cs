using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace LoginDemo
{
    public partial class Default : System.Web.UI.Page
    {
        public SqlConnection con;
        public string query;
        public void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["emplogin"].ToString();
            con = new SqlConnection(constr);
            con.Open();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;

        }

        
        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            connection();
            query = "Emplogin";
            SqlCommand com = new SqlCommand(query, con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Usename", TextBox1.Text.ToString());
            com.Parameters.AddWithValue("@Password", TextBox2.Text.ToString());

            int usercount = (int)com.ExecuteScalar();
            if (usercount == 1)
            {
                Response.Redirect("Welcome.aspx");

            }
            else
            {
                con.Close();
                Label1.Visible = true;
                Label1.Text = "Invalid User Name or Password";


            }

        }
    }
}