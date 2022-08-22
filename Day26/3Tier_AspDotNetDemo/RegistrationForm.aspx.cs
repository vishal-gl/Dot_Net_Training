using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business_Logic;
using System.Data;
using System.Data.SqlClient;

namespace _3Tier_AspDotNetDemo
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        SqlConnection conn;
        public RegistrationForm()
        {
            // Instantiate the connection
            conn = new SqlConnection("Data Source=NAG1-LHP_N76275;Initial Catalog=Enemy;Integrated Security=SSPI");
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                GetEmployeeList();

            }
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
        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = TextBox2.Text;
            string name = TextBox1.Text;
            int age = int.Parse(TextBox3.Text);
            int standard = int.Parse(TextBox4.Text);
            string address = TextBox5.Text;
            string cid = RadioButtonList1.Text;


            StudentManagementIO student = new StudentManagementIO();
            student.AddStudent(id, name, age, standard, address, cid);
            GetEmployeeList();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

        }





        //protected void Button2_Click(object sender, EventArgs e)
        //{
        //    string id = TextBox2.Text;
        //    StudentManagementIO student = new StudentManagementIO();
        //    student.DeleteStudent(id);

        //}
    }
}