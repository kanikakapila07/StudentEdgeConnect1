using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentEdgeConnect1
{
    public partial class viewcertifications : System.Web.UI.Page
    {
        string ConnectionString = "Data Source=DESKTOP-8DP7DQP\\SQLEXPRESS;Initial Catalog=studentEdgeConnect1DB;Integrated Security=True";
        string AnotherConnectionString = "Data Source=DESKTOP-8DP7DQP\\SQLEXPRESS;Initial Catalog=studentEdgeConnect1DB;Integrated Security=True;providerName=System.Data.SqlClient";

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            addLink();
        }
        void addLink()
        {
            try
            {

                //establish connection
                SqlConnection con = new SqlConnection(ConnectionString);

                //open connection
                con.Open();
                //prepare query
                string Link = TextBox6.Text.Trim();


                string Query = "INSERT INTO certifications(Link) VALUES('" + Link + "')";



                //execute query
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                //close connection
                con.Close();
                //MessageBox.Show("User registered successfully!");
                // Response.Write("<script>alert('Registered Successfully!');</script>");
                Response.Write("<script>alert('Added Successfully!');</script>");
                //clear();
                GridView1.DataBind();

            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }

        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}