using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentEdgeConnect1
{
    public partial class initialsignup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignUpStudent_Click(object sender, EventArgs e)
        {
            Response.Redirect("studentsignup.aspx");
        }

        protected void btnSignUpEmployer_Click(object sender, EventArgs e)
        {
            Response.Redirect("signup.aspx");
        }
    }
}