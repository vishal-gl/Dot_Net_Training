using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerObjects_Demo
{
    public partial class FirstPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Page is loaded");

        }

        //
        protected void Button1_Click(object sender,EventArgs e)
        {
            Response.Redirect("SecondPage.aspx");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("SecondPage.aspx");
        }

        //Redirect to outside server
        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.google.com");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Server.Transfer("https://www.google.com");
        }

    }
}