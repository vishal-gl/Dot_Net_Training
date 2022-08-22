using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business_Logic;
using Book_Schema;
using System.Data;

namespace Book_3_Layered_Ado_DotNet_Task
{
    public partial class Presentation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSubmit.Text == "Submit")
                {
                    InsertData();
                }
                else if (btnSubmit.Text == "Update")
                {
                    int Id = int.Parse(gvDisplay.Rows[gvDisplay.SelectedIndex].Cells[0].Text);
                    UpdateData(Id);
                }
            }
            catch (Exception ex)
            {
                Response.Write("Enter Data First Then Click On Submit" + "<br>");

            }
        }
        public void UpdateData(int Id)
        {
            Book_Schema.Entity objSchema = new Book_Schema.Entity();
            objSchema.Id = Convert.ToInt32(txtId.Text);
            objSchema.Name = txtName.Text;
            objSchema.Author = txtAuthor.Text;
            objSchema.Publisher = txtPublisher.Text;

            objSchema.Price = Convert.ToDecimal(txtPrice.Text);
            Business_Logic.BookManagementIO objBAL = new Business_Logic.BookManagementIO();
            int result = objBAL.Update(objSchema, Id);
            if (result > 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Data Updated Successfully')", true);
            }
            btnSubmit.Text = "Submit";
            BindGrid();
            Clear();
        }
        public void InsertData()
        {
            Book_Schema.Entity objSchema = new Book_Schema.Entity();
            objSchema.Id = Convert.ToInt32(txtId.Text);

            objSchema.Name = txtName.Text;
            objSchema.Author = txtAuthor.Text;
            objSchema.Publisher = txtPublisher.Text;

            objSchema.Price = Convert.ToDecimal(txtPrice.Text);
            Business_Logic.BookManagementIO objBAL = new Business_Logic.BookManagementIO();

            int result = objBAL.Insert(objSchema);
            if (result > 0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Data Saved Successfully')", true);
            }
            BindGrid();
            Clear();
        }
        private void Clear()
        {
            txtName.Text = "";
            txtAuthor.Text = "";
            txtPublisher.Text = "";
            txtPrice.Text = "";
            txtId.Text = "";
        }
        private void BindGrid()
        {
            try
            {
                Business_Logic.BookManagementIO objBal = new Business_Logic.BookManagementIO();


                gvDisplay.Columns[0].Visible = true;
                gvDisplay.DataSource = objBal.BindGrid();
                gvDisplay.DataBind();

                gvDisplay.Visible = true;
            }
            catch (Exception ex)
            {

                Response.Write(ex.Message);
            }
        }

        protected void gvDisplay_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            try
            {
                Business_Logic.BookManagementIO objBAL = new Business_Logic.BookManagementIO();

                int Id = int.Parse(gvDisplay.Rows[e.NewSelectedIndex].Cells[0].Text);
                DataTable dt = new DataTable();
                dt = objBAL.GetById(Id);
                if (dt.Rows.Count > 0)
                {
                    

                    txtName.Text = dt.Rows[0]["Name"].ToString();
                    txtAuthor.Text = dt.Rows[0]["Author"].ToString();
                    txtPublisher.Text = dt.Rows[0]["Publisher"].ToString();
                    txtPrice.Text = dt.Rows[0]["Price"].ToString();

                    btnSubmit.Text = "Update";
                    Button1.Text = "Cancel";

                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        protected void gvDisplay_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Delete"))
            {
                int Id = int.Parse(e.CommandArgument.ToString());
                DeleteRecord(Id);
            }
        }
        private void DeleteRecord(int Id)
        {
            try
            {
                Business_Logic.BookManagementIO objBAL = new Business_Logic.BookManagementIO();

                int Result = objBAL.Delete(Id);
                if (Result > 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Data Deleted Successfully')", true);
                }
                BindGrid();
                Clear();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
        protected void gvDisplay_RowDeleting(object sender, GridViewDeleteEventArgs e) { }



        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Button1.Text == "Display")
                {
                    BindGrid();
                }
                else if (Button1.Text == "Cancel")
                {
                    gvDisplay.EditIndex = -1;
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Cancel Successfully')", true);

                    Button1.Text = "Display";
                    btnSubmit.Text = "Submit";
                    BindGrid();
                    Clear();

                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }


        }
    }


}