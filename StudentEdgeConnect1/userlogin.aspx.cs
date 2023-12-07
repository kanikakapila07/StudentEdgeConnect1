using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentEdgeConnect1
{
    public partial class userlogin : System.Web.UI.Page
    {
        string ConnectionString = "Data Source=DESKTOP-8DP7DQP\\SQLEXPRESS;Initial Catalog=studentEdgeConnect1DB;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                //establish connection
                SqlConnection con = new SqlConnection(ConnectionString);
                //open connection
                con.Open();
                //prepare query
                string Username = TextBox1.Text.Trim();
                string Password = TextBox2.Text.Trim();
                string Query = "SELECT * FROM student WHERE S_username = @Username AND S_Password = @Password";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);
                SqlDataReader reader = cmd.ExecuteReader();
               
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        //Response.Write("<script>alert('" + reader.GetValue(18).ToString() + "');</script>");
                        //Response.Write("<script>alert('Success');</script>");
                       

                        Session["S_username"] = reader["S_username"].ToString();
                        Session["Fname"] = reader["Fname"].ToString();
                        Session["role"] = "Student";
                        Response.Redirect("studentprofile.aspx");
                    }
                    //Response.Redirect("homepage.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Invalid Credentials');</script>");

                }
            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }
        }
    }
}