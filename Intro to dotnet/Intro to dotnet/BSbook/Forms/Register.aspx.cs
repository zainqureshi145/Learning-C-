using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BSbook;

public partial class Forms_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        try
        {
            // Get Data from form

            ZabUser objUser = new ZabUser();

            objUser.Name = txtName.Text;
            objUser.Email = txtEmail.Text;
            objUser.Password = txtPassword.Text;

            DataAccess da = new DataAccess();

           int rows =  da.AddUser(objUser);

           if (rows > 0)
           {
               lblMessage.Text = "User has been added successfully";
           }
            
            // Save Object to Database
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message;
        }
    }
}