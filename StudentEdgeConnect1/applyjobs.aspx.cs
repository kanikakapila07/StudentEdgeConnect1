using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentEdgeConnect1
{
    public partial class applyjobs : System.Web.UI.Page
    {

        string ConnectionString = "Data Source=DESKTOP-8DP7DQP\\SQLEXPRESS;Initial Catalog=studentEdgeConnect1DB;Integrated Security=True";
        string AnotherConnectionString = "Data Source=DESKTOP-8DP7DQP\\SQLEXPRESS;Initial Catalog=studentEdgeConnect1DB;Integrated Security=True;providerName=System.Data.SqlClient";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                if (Session["S_username"] != null)
                {
                   
                    getStudentID();
                    GridView1.DataBind(); 
                }
              
            }
        }



        void getStudentID()
        {
            try
            {
                if (Session["S_username"] != null)
                {
                    string loggedInUsername = Session["S_username"].ToString();

                   
                    Response.Write("<script>alert('Logged In Username: " + loggedInUsername + "');</script>");

                    using (SqlConnection con = new SqlConnection(ConnectionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT StudentID FROM student WHERE S_username = @S_username", con);
                        cmd.Parameters.AddWithValue("@S_username", loggedInUsername);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            TextBox1.Text = reader["StudentID"].ToString();
                        }
                        else
                        {
                           
                            Response.Write("<script>alert('No data found ');</script>");
                        }

                        reader.Close();
                        con.Close();
                    }
                }
                else
                {
                  
                    Response.Write("<script>alert('Session variable S_username is null or not set');</script>");
                   
                }
            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }
        }



        protected void Button2_Click(object sender, EventArgs e)
        {
            applyJob();
             

        }















        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void applyJob()
        {
            try
            {
                // Retrieve user input
                string JobID = TextBox51.Text.Trim();
                string JobPosition = TextBox52.Text.Trim();
                string Company = TextBox2.Text.Trim();
                string CompanyLocation = TextBox3.Text.Trim();
                string EducationLevel = DropDownList53.SelectedItem.Value;
                string UniversityName = TextBox54.Text.Trim();
                string GraduationDate = TextBox55.Text.Trim();
                string StudentID = TextBox1.Text.Trim();

                SqlConnection con = new SqlConnection(ConnectionString);
                    
                        con.Open();
                        // Query to insert job application details
                        string query = "INSERT INTO appliedjobs_table(JobID, JobPosition, Company, CompanyLocation, EducationLevel, UniversityName, GraduationDate, StudentID) VALUES(@JobID, @JobPosition, @Company, @CompanyLocation, @EducationLevel, @UniversityName, @GraduationDate, @StudentID)";

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@JobID", JobID);
                        cmd.Parameters.AddWithValue("@JobPosition", JobPosition);
                        cmd.Parameters.AddWithValue("@Company", Company);
                        cmd.Parameters.AddWithValue("@CompanyLocation", CompanyLocation);
                        cmd.Parameters.AddWithValue("@EducationLevel", EducationLevel);
                        cmd.Parameters.AddWithValue("@UniversityName", UniversityName);
                        cmd.Parameters.AddWithValue("@GraduationDate", GraduationDate);
                        cmd.Parameters.AddWithValue("@StudentID", StudentID);

                        cmd.ExecuteNonQuery();

                        con.Close();

                        Response.Write("<script>alert('Added Successfully!');</script>");
                        GridView1.DataBind();
                    }
                
               
            
            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }
        }

    }
}