using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageEventDemo
{
    public partial class PageEvent : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Log("<<Page_Load>>");

        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Log("<<Page_PreRender>>");
        }

        protected void CtrlChanged(object sender, EventArgs e)
        {
            //find the control id of the server
            //this requires converting the object type into a control class

            string ctrlname = ((Control)sender).ID;
            Log(ctrlname + "Changed");

        }

        private void Log(string entry)
        {
            ListBox1.Items.Add(entry);
            ListBox1.SelectedIndex = ListBox1.Items.Count - 1;
        }

    }
}