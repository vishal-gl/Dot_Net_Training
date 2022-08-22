using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ListBox_Task
{
    public partial class ListBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {
            var distinct = from p in ListBox1.Items.OfType<ListItem>()
                .Concat(ListBox2.Items.OfType<ListItem>())
                .Where(o => o.Selected)
                .Distinct()
                           select new
                           {
                               Text = p.Text
                           };
            Response.Write(" Selected Unique Input Merge List :" + "<br/>");
            foreach (var item in distinct)
            {
                Response.Write(item.Text + "<br/>");
            }


        }
    }
}