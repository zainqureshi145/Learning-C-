using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string value = TextBox1.Text;

            ServiceReference1.Service1Client objService = new ServiceReference1.Service1Client();

            double strRetrunValue = objService.GetStudentCGPA(Convert.ToInt32(value));

            Label1.Text = strRetrunValue.ToString();
        }
    }
}
