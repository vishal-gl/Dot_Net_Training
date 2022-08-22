using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business_Logic_Emp;

namespace Practice_Linq_Sql_3TierArchitecture
{
    public partial class Presentation : System.Web.UI.Page
    {
        EmpManagementIo emp = new EmpManagementIo();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string id = TextBox1.Text;
            string name = TextBox2.Text;
            float salary = float.Parse(TextBox3.Text);
            string did = TextBox4.Text;
            emp.Insert(id, name, salary, did);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully saved');", true);

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";



        }
        public void Display()
        {
            emp.Read();
            GridView1.DataSource = 



        }
    }
}