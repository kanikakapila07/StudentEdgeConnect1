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
    public partial class studentprofile : System.Web.UI.Page
    {
        string ConnectionString = "Data Source=DESKTOP-8DP7DQP\\SQLEXPRESS;Initial Catalog=studentEdgeConnect1DB;Integrated Security=True";
        string AnotherConnectionString = "Data Source=DESKTOP-8DP7DQP\\SQLEXPRESS;Initial Catalog=studentEdgeConnect1DB;Integrated Security=True;providerName=System.Data.SqlClient";

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                string S_username = Session["S_username"] as string;

                string currentTab = "edit-profile";
                if (currentTab == "edit-profile")
                {
                    LoadEditProfile();
                }

                else if (currentTab == "apply-jobs")
                {
                    LoadApplyJobs();
                }
                else if (currentTab == "view-application-status")
                {

                    LoadAppliedJobs();
                }
                else if (currentTab == "registered-events")
                {
                    LoadEvents();
                }
                else if (currentTab == "certifications")
                {
                    LoadCertifications();
                }
            }
        }
        protected void LoadEvents()
        {
            GridView2.DataBind();
        }
        protected void LoadCertifications()
        {
            GridView6.DataBind();
        }
        protected void LoadEditProfile()
        {
            try
            {
                string username = Session["S_username"] as string;

                // Connect to the database and fetch user details
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                string query = "SELECT SSN, S_password, Fname, Mname, Lname, BirthDate, EmailID, Phoneno, City, State, Country, ZipCode,EducationLevel, UniversityName,GraduationDate, S_username FROM student WHERE S_username = @Username";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", username);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        TextBox13.Text = reader["SSN"].ToString();
                        TextBox43.Text = reader["S_password"].ToString();
                        TextBox4.Text = reader["Fname"].ToString();
                        TextBox5.Text = reader["Mname"].ToString();
                        TextBox7.Text = reader["Lname"].ToString();
                        TextBox9.Text = reader["BirthDate"].ToString();
                        TextBox14.Text = reader["EmailID"].ToString();
                        TextBox15.Text = reader["Phoneno"].ToString();
                        TextBox16.Text = reader["City"].ToString();
                        TextBox17.Text = reader["State"].ToString();
                        TextBox18.Text = reader["Country"].ToString();
                        TextBox19.Text = reader["ZipCode"].ToString();
                        TextBox20.Text = reader["S_username"].ToString();
                        TextBox1.Text = reader["EducationLevel"].ToString();
                        TextBox2.Text = reader["UniversityName"].ToString();
                        TextBox3.Text = reader["GraduationDate"].ToString();
                    }
                }
                con.Close();

                Button8.Click += Button8_Click; // Attach the updateUserInfo method to the Button8 Click event
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
            }
        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                string ssn = TextBox13.Text.Trim(); // Fetching SSN from the TextBox
                string newpassword = TextBox43.Text.Trim(); // New password to update
                string fname = TextBox4.Text.Trim();
                string mname = TextBox5.Text.Trim();
                string lname = TextBox7.Text.Trim();
                string birthDate = TextBox9.Text.Trim();
                string Email = TextBox14.Text.Trim();
                string phone = TextBox15.Text.Trim();
                string city = TextBox16.Text.Trim();
                string state = TextBox17.Text.Trim();
                string country = TextBox18.Text.Trim();
                string zipCode = TextBox19.Text.Trim();
                string username = TextBox20.Text.Trim();
                string educationLevel = TextBox18.Text.Trim();
                string universityName = TextBox19.Text.Trim();
                string graduationDate = TextBox20.Text.Trim();




                // Connection establishment
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();

                // SQL Update Query
                string query = "UPDATE student SET S_password = @NewPassword, Fname = @Fname, Mname = @Mname, Lname = @Lname, BirthDate = @BirthDate, EmailID = @Email, Phone = @Phone, City = @City, State = @State, Country = @Country, ZipCode = @ZipCode, GraduationDate= @GraduationDate, EducationLevel=@EducationLevel, UniversityName=@UniversityName, S_username = @Username WHERE SSN = @SSN";


                // SQL Command creation
                SqlCommand cmd = new SqlCommand(query, con);

                // Adding parameters to prevent SQL Injection
                cmd.Parameters.AddWithValue("@NewPassword", newpassword);
                cmd.Parameters.AddWithValue("@Fname", fname);
                cmd.Parameters.AddWithValue("@Mname", mname);
                cmd.Parameters.AddWithValue("@Lname", lname);
                cmd.Parameters.AddWithValue("@BirthDate", birthDate);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@State", state);
                cmd.Parameters.AddWithValue("@Country", country);
                cmd.Parameters.AddWithValue("@ZipCode", zipCode);
                cmd.Parameters.AddWithValue("@GraduationDate", graduationDate);
                cmd.Parameters.AddWithValue("@EducationLevel", educationLevel);
                cmd.Parameters.AddWithValue("@UniversityName", universityName);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@SSN", ssn);
            

                // Executing the query
                int rowsAffected = cmd.ExecuteNonQuery();

                con.Close();

                if (rowsAffected > 0)
                {
                    // If the update was successful
                    Response.Write("<script>alert('Updated successfully!');</script>");
                }
                else
                {
                    // If no rows were affected (no matching SSN found)
                    Response.Write("<script>alert('No employer found with the provided SSN.');</script>");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions, if any
                Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
            }
        }
        protected void LoadAppliedJobs()

        {
            string S_username = Session["S_username"] as string;

            if (!string.IsNullOrEmpty(S_username))
            {
                
                ViewStatus(S_username);
            }
            
            GridView3.DataBind();
        }
        protected void LoadApplyJobs()
        {
            GridView1.DataBind();
        }
        
        //view application status
        private void ViewStatus(string S_username)
        {
            try
            {
                //establish connection
                SqlConnection con = new SqlConnection(ConnectionString);
                
                //open connection
                con.Open();
                
                //prepare query
                string query = "SELECT s.JobID, s.StudentID, s.ApplicationStatus " +
                                   "FROM Status s " +
                                   "INNER JOIN student u ON s.StudentID = u.StudentID " +
                                   "WHERE u.S_username = @S_username";

                //execute query
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@S_username", S_username);

                DataTable table = new DataTable();
                table.Load(cmd.ExecuteReader());
                GridView3.DataSource = table;
                GridView3.DataBind();

                //close connection
                con.Close();
            }
            catch (Exception exception)
            {
               
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            addLink();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void Button11_Click(object sender, EventArgs e)
        {
            Response.Redirect("applyjobs.aspx");
        }
        protected void GridView6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //register for events 
        protected void Button17_Click(object sender, EventArgs e)
        {
            Response.Redirect("registerevents.aspx");

        }

        //withdraw application
        protected void Button16_Click(object sender, EventArgs e)
        {
            try
            {
                LinkButton btn = (LinkButton)sender;
                GridViewRow row = (GridViewRow)btn.NamingContainer;
                string JobID = GridView3.DataKeys[row.RowIndex]["JobID"].ToString();

                //establish connection
                SqlConnection con = new SqlConnection(ConnectionString);

                //open connection
                con.Open();

                //prepare query
                string Query = "DELETE FROM appliedjobs_table WHERE JobID ='" + JobID + "'";

                //execute query
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();

                //close connection
                con.Close();
                Response.Write("<script>alert('Withdrawn!');</script>");



            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }

        }

        //add certification links 
        void addLink()
        {
            try
            {

                //establish connection
                SqlConnection con = new SqlConnection(ConnectionString);

                //open connection
                con.Open();

   
                string Link = TextBox6.Text.Trim();

                //prepare query
                string Query = "INSERT INTO certifications(Link) VALUES('" + Link + "')";

                //execute query
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();

                //close connection
                con.Close();
                Response.Write("<script>alert('Added Successfully!');</script>");
                GridView6.DataBind();

            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }

        }


    }
}
