using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentEdgeConnect1
{   //shows lists of jobs posted
    public partial class applyjobs_enterinfo : System.Web.UI.Page
    {


        string ConnectionString = "Data Source=DESKTOP-8DP7DQP\\SQLEXPRESS;Initial Catalog=studentEdgeConnect1DB;Integrated Security=True";
        string AnotherConnectionString = "Data Source=DESKTOP-8DP7DQP\\SQLEXPRESS;Initial Catalog=studentEdgeConnect1DB;Integrated Security=True;providerName=System.Data.SqlClient";

        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }
        protected void Button11_Click(object sender, EventArgs e)
        {
            Response.Redirect("applyjobs.aspx");
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}