using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BSbook;

public partial class Forms_ViewUser : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            DataAccess userDA = new DataAccess();
            DataSet ds = userDA.GetUsers();

            gvUsers.DataSource = ds.Tables[0];
            gvUsers.DataBind();
        }
        catch (Exception ex)
        {
            lblMessage.Text = ex.Message;
        }

    }
}