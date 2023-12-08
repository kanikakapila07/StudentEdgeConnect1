using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentEdgeConnect1
{
    public partial class registerevents : System.Web.UI.Page
    {

        string ConnectionString = "Data Source=DESKTOP-8DP7DQP\\SQLEXPRESS;Initial Catalog=studentEdgeConnect1DB;Integrated Security=True";
        string AnotherConnectionString = "Data Source=DESKTOP-8DP7DQP\\SQLEXPRESS;Initial Catalog=studentEdgeConnect1DB;Integrated Security=True;providerName=System.Data.SqlClient";

        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            register();
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void register()
        {
            try
            {

                //establish connection
                SqlConnection con = new SqlConnection(ConnectionString);

                //open connection
                con.Open();

                
                string EventID = TextBox51.Text.Trim();
                string EventName= TextBox52.Text.Trim();
                string Description = TextBox2.Text.Trim();
                string Date = TextBox3.Text.Trim();
                string Time = TextBox4.Text.Trim();
                string BuildingNo = TextBox54.Text.Trim();
                string BuildingName = TextBox55.Text.Trim();
                string StreetName = TextBox1.Text.Trim();
                string City = TextBox5.Text.Trim();
                string ZipCode = TextBox6.Text.Trim();
                string StudentID = TextBox7.Text.Trim();

                //prepare query
                string Query = "INSERT INTO registeredevents_table(EventID,EventName,Description,Date,Time,BuildingNo,BuildingName,StreetName,City,ZipCode,StudentID) VALUES('" + EventID + "', '" + EventName + "', '" + Description + "', '" + Date + "', '" + Time + "', '" + BuildingNo + "', '" + BuildingName + "', '" + StreetName + "','" +City + "','"+ZipCode+ "','" + StudentID + "')";

                //execute query
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();

                //close connection
                con.Close();
                Response.Write("<script>alert('Registered successfully!');</script>");

                GridView1.DataBind();

            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }

        }


        //go button for searching event 
        protected void LinkButton8_Click(object sender, EventArgs e)
        {

            try
            {

                //establish connection
                SqlConnection con = new SqlConnection(ConnectionString);

                //open connection
                con.Open();

                //prepare query
                string Query = "SELECT * from registeredevents_table";

                //execute query
                SqlCommand cmd = new SqlCommand(Query, con);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        TextBox51.Text = reader["EventID"].ToString();
                        TextBox52.Text = reader["EventName"].ToString();
                        TextBox2.Text = reader["Description"].ToString();
                        TextBox3.Text = reader["Date"].ToString();
                        TextBox4.Text = reader["Time"].ToString();
                        TextBox54.Text = reader["BuildingNo"].ToString();
                        TextBox55.Text = reader["BuildingName"].ToString();
                        TextBox1.Text = reader["StreetName"].ToString();
                        TextBox5.Text = reader["City"].ToString();
                        TextBox6.Text = reader["ZipCode"].ToString();
                        TextBox7.Text = reader["StudentID"].ToString();

                    }

                }
                else
                {
                    Response.Write("<script>alert('Invalid credentials');</script>");
                }

                //close connection
                con.Close();
            }


            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }


        }
    }
}