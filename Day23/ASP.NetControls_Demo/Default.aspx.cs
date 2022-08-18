using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NetControls_Demo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            //Loop through all the control present on the web page / form
            foreach (Control ctrl in form1.Controls)
            {
                //check for all TextBox controls on the page and clear them
                if (ctrl is TextBox)// or if (ctrl.GetType().Equals(typeof(TextBox)))
                {
                    ((TextBox)(ctrl)).Text = string.Empty;
                }
                //check for all Label controls on the page and clear them
                else if (ctrl is Label) // or else if (ctrl.GetType().Equals(typeof(Label)))
                {
                    ((Label)(ctrl)).Text = string.Empty;
                }
                //check for all DropDownList controls on the page and reset them
                else if (ctrl is DropDownList)// or else if (ctrl.GetType().Equals(typeof(DropDownList)))
                {
                    ((DropDownList)(ctrl)).ClearSelection();
                }
                //check for all CheckBox controls on the page and unchecked the selection
                else if (ctrl is CheckBox) // or else if (ctrl.GetType().Equals(typeof(CheckBox)))
                {
                    ((CheckBox)(ctrl)).Checked = false;
                }
                //check for all CheckBoxList controls on the page and unchecked all the selections
                else if (ctrl is CheckBoxList) // or else if (ctrl.GetType().Equals(typeof(CheckBoxList)))
                {
                    ((CheckBoxList)(ctrl)).ClearSelection();
                }
                //check for all RadioButton controls on the page and unchecked the selection
                else if (ctrl is RadioButton) // or else if (ctrl.GetType().Equals(typeof(RadioButton)))
                {
                    ((RadioButton)(ctrl)).Checked = false;
                }
                //check for all RadioButtonList controls on the page and unchecked the selection
                else if (ctrl is RadioButtonList) // or else if (ctrl.GetType().Equals(typeof(RadioButtonList)))
                {
                    ((RadioButtonList)(ctrl)).ClearSelection();
                }
                //check for all hiddenfield controls on the page and clear them
                else if (ctrl is HiddenField) //or else if (ctrl.GetType().Equals(typeof(HiddenField)))
                {
                    ((HiddenField)(ctrl)).Value = string.Empty;
                }

            }
        }
    }
}