using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BSbook;

public partial class Forms_UpdateUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string username = TextBox1.Text;

            if (!string.IsNullOrEmpty(username))
            {
                DataAccess userDA = new DataAccess();
                DataSet ds = userDA.SearchUsers(username);

                gvUsers.DataSource = ds.Tables[0];
                gvUsers.DataBind();
            }
            else
            {
                lblMessage.Text = "please enter value";
            }
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message;
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        try
        {
            string id = TextBox2.Text;
            string username = TextBox4.Text;

            if (!string.IsNullOrEmpty(username))
            {
                DataAccess userDA = new DataAccess();
                int rowsUpdated = userDA.UpdateUser(id ,username);

                if (rowsUpdated > 0)
                {
                    lblMessage.Text = "name has been updated";
                }
                else
                {
                    lblMessage.Text = "user could not be updated";
                }
            }
            else
            {
                lblMessage.Text = "please enter value";
            }
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message;
        }
    }
}