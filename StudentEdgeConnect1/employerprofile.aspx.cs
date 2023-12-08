using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace StudentEdgeConnect1
{
    public partial class employerprofile : System.Web.UI.Page
    {
        string ConnectionString = "Data Source=DESKTOP-8DP7DQP\\SQLEXPRESS;Initial Catalog=studentEdgeConnect1DB;Integrated Security=True";
        string AnotherConnectionString = "Data Source=DESKTOP-8DP7DQP\\SQLEXPRESS;Initial Catalog=studentEdgeConnect1DB;Integrated Security=True;providerName=System.Data.SqlClient";


        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack)
            {
                string username = Session["E_username"] as string;
            }
            string currentTab = "edit-profile";
            if (currentTab == "edit-profile")
            {
                LoadEditProfile();
            }
            else if (currentTab == "posts-events")
            {
                LoadPostsEvents();
            }
            else if (currentTab == "view-applications")
            {
                LoadApplicationStatus();
            }
            else if (currentTab == "posts-jobs")
            {
                LoadPostsJobs();
            }
        }

        protected void LoadEditProfile()
        {

        }

        protected void LoadPostsEvents()
        {
            GridView2.DataBind();
        }
        protected void LoadApplicationStatus()
        {
            GridView3.DataBind();
        }
        protected void LoadPostsJobs()
        {
            GridView1.DataBind();
        }

        //update Job info
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (checkExists())
            {
                updateJobInfo();


            }
            else
            {

                Response.Write("<script>alert('Job with this ID doesn't exist!');</script>");
            }
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            if (checkEventExists())
            {
                updateEventInfo();


            }
            else
            {

                Response.Write("<script>alert('Job with this ID doesn't exist!');</script>");
            }
        }



        //add
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (checkExists())
            {
                Response.Write("<script>alert('Job with this ID already exists! Cannot add job with same ID.');</script>");
            }
            else
            {
                addNewJob();

            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (checkEventExists())
            {
                Response.Write("<script>alert('Job with this ID already exists! Cannot add job with same ID.');</script>");
            }
            else
            {
                addNewEvent();

            }

        }

        //accepts job application
        protected void Button7_Click(object sender, EventArgs e)
        {

            try
            {
                //establish connection
                SqlConnection con = new SqlConnection(ConnectionString);

                //open connection
                con.Open();
                //prepare query
                string JobID = TextBox39.Text.Trim();
                string StudentID = TextBox34.Text.Trim();
                string Query = "INSERT INTO Status(JobID, StudentID, ApplicationStatus) VALUES('" + JobID + "', '" + StudentID + "','Accepted')";


                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Accepted!');</script>");

            }
            catch (Exception exception)
            {

                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");

            }

        }

        //rejects job application
        protected void Button9_Click(object sender, EventArgs e)
        {

            try
            {
                //establish connection
                SqlConnection con = new SqlConnection(ConnectionString);

                //open connection
                con.Open();
                //prepare query
                string JobID = TextBox39.Text.Trim();
                string StudentID = TextBox34.Text.Trim();
                string Query = "INSERT INTO Status(JobID, StudentID, ApplicationStatus) VALUES('" + JobID + "', '" + StudentID + "','Rejected')";


                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Rejected!');</script>");
            }
            catch (Exception exception)
            {

                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");

            }

        }

        //go button for searching student id
        protected void LinkButton8_Click(object sender, EventArgs e)
        {

            try
            {

                //establish connection
                SqlConnection con = new SqlConnection(ConnectionString);

                //open connection
                con.Open();
                //prepare query

                string JobID = TextBox39.Text.Trim();
                string StudentID = TextBox34.Text.Trim();

                string Query = "SELECT s.fname, s.mname, s.lname, s.StudentID, s.EmailID, " +
                    "a.EducationLevel, a.UniversityName, a.GraduationDate, a.JobID, a.JobPosition, a.Company " +
                    "FROM student s " +
                    "INNER JOIN appliedjobs_table a ON s.StudentID = a.StudentID WHERE a.JobID = @JobID AND s.StudentID = @StudentID";



                //execute query
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@JobID", JobID);
                cmd.Parameters.AddWithValue("@StudentID", StudentID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        TextBox31.Text = reader["fname"].ToString();
                        TextBox32.Text = reader["lname"].ToString();
                        TextBox33.Text = reader["mname"].ToString();
                        TextBox34.Text = reader["StudentID"].ToString();
                        TextBox35.Text = reader["EmailID"].ToString();
                        TextBox36.Text = reader["EducationLevel"].ToString();
                        TextBox37.Text = reader["UniversityName"].ToString();
                        TextBox38.Text = reader["GraduationDate"].ToString();
                        TextBox39.Text = reader["JobID"].ToString();
                        TextBox40.Text = reader["JobPosition"].ToString();
                        TextBox41.Text = reader["Company"].ToString();

                    }

                }
                else
                {
                    Response.Write("<script>alert('Invalid credentials');</script>");
                }

                con.Close();
                //MessageBox.Show("User registered successfully!");
                // Response.Write("<script>alert('Registered Successfully!');</script>");
                //Response.Write("<script>alert('Success!');</script>");


            }


            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }


        }
        //delete
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (checkExists())
            {
                deleteJob();

            }
            else
            {
                Response.Write("<script>alert('Job with this ID doesn't exist!');</script>");
            }

        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            if (checkEventExists())
            {
                deleteEvent();

            }
            else
            {
                Response.Write("<script>alert('Job with this ID doesn't exist!');</script>");
            }

        }

        bool checkExists()
        {
            try
            {

                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();

                string JobID = TextBox1.Text.Trim();
                string Query = "(SELECT COUNT(*) FROM jobs_table WHERE JobID ='" + JobID + "')";

                SqlCommand cmd = new SqlCommand(Query, con);

                cmd.Parameters.AddWithValue("@JobID", JobID);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {

                    con.Close();
                    return true;

                }
                else
                {
                    con.Close();
                    return false;

                }
            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message.Replace("'", "\\'") + "');</script>");
            }
            return false;
        }

        bool checkEventExists()
        {
            try
            {

                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();

                string EventID = TextBox25.Text.Trim();
                string Query = "(SELECT COUNT(*) FROM events_table WHERE EventID ='" + EventID + "')";

                SqlCommand cmd = new SqlCommand(Query, con);

                cmd.Parameters.AddWithValue("@EventID", EventID);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {

                    con.Close();
                    return true;

                }
                else
                {
                    con.Close();
                    return false;

                }
            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message.Replace("'", "\\'") + "');</script>");
            }
            return false;
        }

        //new job 
        void addNewJob()
        {
            try
            {

                //establish connection
                SqlConnection con = new SqlConnection(ConnectionString);

                //open connection
                con.Open();
                //prepare query
                string JobID = TextBox1.Text.Trim();
                string JobPosition = TextBox2.Text.Trim();
                string Requirements = DropDownList2.SelectedItem.Value;
                string Description = TextBox3.Text.Trim();
                string Pay = DropDownList3.SelectedItem.Value;
                string ApplicationDeadline = TextBox6.Text.Trim();
                string EmploymentType = DropDownListEmploymentType.SelectedItem.Value;
                string Benefits = TextBox8.Text.Trim();
                string HowToApply = DropDownList1.SelectedItem.Value;
                string SkillName = TextBox10.Text.Trim();
                string Company = TextBox11.Text.Trim();
                string CompanyLocation = TextBox12.Text.Trim();

                string Query = "INSERT INTO jobs_table(JobID,JobPosition,Requirements,Description,Pay,ApplicationDeadline,EmploymentType,Benefits,HowToApply,SkillName,Company,CompanyLocation) VALUES('" + JobID + "', '" + JobPosition + "', '" + Requirements + "', '" + Description + "', '" + Pay + "', '" + ApplicationDeadline + "', '" + EmploymentType + "', '" + Benefits + "', '" + HowToApply + "', '" + SkillName + "', '" + Company + "','" + CompanyLocation + "')";



                //execute query
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                //close connection
                con.Close();
                //MessageBox.Show("User registered successfully!");
                // Response.Write("<script>alert('Registered Successfully!');</script>");
                Response.Write("<script>alert('Added Successfully!');</script>");
                clear();
                GridView1.DataBind();

            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }

        }
        void addNewEvent()
        {
            try
            {

                //establish connection
                SqlConnection con = new SqlConnection(ConnectionString);

                //open connection
                con.Open();
                //prepare query
                string EventID = TextBox25.Text.Trim();
                string EventName = TextBox21.Text.Trim();

                string Description = TextBox22.Text.Trim();
                string Date = TextBox23.Text.Trim();
                string Time = TextBox24.Text.Trim();

                string BuildingNo = TextBox26.Text.Trim();
                string BuildingName = TextBox27.Text.Trim();
                string StreetName = TextBox28.Text.Trim();
                string City = TextBox29.Text.Trim();
                string ZipCode = TextBox30.Text.Trim();

                string Query = "INSERT INTO events_table(EventID,EventName,Description,Date,Time,BuildingNo,BuildingName,StreetName,City,ZipCode) VALUES('" + EventID + "', '" + EventName + "', '" + Description + "', '" + Date + "', '" + Time + "', '" + BuildingNo + "', '" + BuildingName + "', '" + StreetName + "', '" + City + "', '" + ZipCode + "')";



                //execute query
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                //close connection
                con.Close();
                //MessageBox.Show("User registered successfully!");
                // Response.Write("<script>alert('Registered Successfully!');</script>");
                Response.Write("<script>alert('Added Successfully!');</script>");
                //clear();
                GridView2.DataBind();

            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }

        }

        void updateJobInfo()
        {

            try
            {

                //establish connection
                SqlConnection con = new SqlConnection(ConnectionString);

                //open connection
                con.Open();
                //prepare query
                string JobID = TextBox1.Text.Trim();
                string JobPosition = TextBox2.Text.Trim();
                string Requirements = DropDownList2.SelectedItem.Value;
                string Description = TextBox3.Text.Trim();
                string Pay = DropDownList3.SelectedItem.Value;
                string ApplicationDeadline = TextBox6.Text.Trim();
                string EmploymentType = DropDownListEmploymentType.SelectedItem.Value;
                string Benefits = TextBox8.Text.Trim();
                string HowToApply = DropDownList1.SelectedItem.Value;
                string SkillName = TextBox10.Text.Trim();
                string Company = TextBox11.Text.Trim();
                string CompanyLocation = TextBox12.Text.Trim();



                string Query = "UPDATE jobs_table SET JobPosition = '" + JobPosition + "', Pay = '" + Pay + "', ApplicationDeadline = '" + ApplicationDeadline + "', Requirements = '" + Requirements + "', EmploymentType = '" + EmploymentType + "', Benefits = '" + Benefits + "', Description = '" + Description + "', HowToApply = '" + HowToApply + "', SkillName = '" + SkillName + "', Company = '" + Company + "', CompanyLocation = '" + CompanyLocation + "' WHERE JobID = '" + JobID + "'";


                //execute query
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                //close connection
                con.Close();
                //MessageBox.Show("User registered successfully!");
                // Response.Write("<script>alert('Registered Successfully!');</script>");

                Response.Write("<script>alert('Updated Successfully');</script>");
                clear();
                GridView1.DataBind();
            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }
        }
        void updateEventInfo()
        {

            try
            {

                //establish connection
                SqlConnection con = new SqlConnection(ConnectionString);

                //open connection
                con.Open();
                //prepare query
                string EventID = TextBox25.Text.Trim();
                string EventName = TextBox21.Text.Trim();

                string Description = TextBox22.Text.Trim();
                string Date = TextBox23.Text.Trim();
                string Time = TextBox24.Text.Trim();

                string BuildingNo = TextBox26.Text.Trim();
                string BuildingName = TextBox27.Text.Trim();
                string StreetName = TextBox28.Text.Trim();
                string City = TextBox29.Text.Trim();
                string ZipCode = TextBox30.Text.Trim();




                string Query = "UPDATE events_table SET EventID = '" + EventID + "', EventName = '" + EventName + "', Description = '" + Description + "', Date = '" + Date + "', Time = '" + Time + "', BuildingNo = '" + BuildingNo + "', BuildingName = '" + BuildingName + "', StreetName = '" + StreetName + "', City = '" + City + "', ZipCode = '" + ZipCode + "' WHERE EventID = '" + EventID + "'";


                //execute query
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                //close connection
                con.Close();
                //MessageBox.Show("User registered successfully!");
                // Response.Write("<script>alert('Registered Successfully!');</script>");

                Response.Write("<script>alert('Updated Successfully');</script>");
                //clear();
                GridView2.DataBind();
            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }
        }

        void deleteJob()
        {
            try
            {

                //establish connection
                SqlConnection con = new SqlConnection(ConnectionString);

                //open connection
                con.Open();
                //prepare query
                string JobID = TextBox1.Text.Trim();
                string JobPosition = TextBox2.Text.Trim();
                string Requirements = DropDownList2.SelectedItem.Value;
                string Description = TextBox3.Text.Trim();
                string Pay = DropDownList3.SelectedItem.Value;
                string ApplicationDeadline = TextBox6.Text.Trim();
                string EmploymentType = DropDownListEmploymentType.SelectedItem.Value;
                string Benefits = TextBox8.Text.Trim();
                string HowToApply = DropDownList1.SelectedItem.Value;
                string SkillName = TextBox10.Text.Trim();
                string Company = TextBox11.Text.Trim();
                string CompanyLocation = TextBox12.Text.Trim();



                string Query = "DELETE FROM jobs_table WHERE JobID = '" + JobID + "'";
                //execute query
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                //close connection
                con.Close();
                //MessageBox.Show("User registered successfully!");
                // Response.Write("<script>alert('Registered Successfully!');</script>");
                Response.Write("<script>alert('Deleted Successfully');</script>");
                clear();
                GridView1.DataBind();

            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }
        }
        void deleteEvent()
        {
            try
            {

                //establish connection
                SqlConnection con = new SqlConnection(ConnectionString);

                //open connection
                con.Open();
                //prepare query
                string EventID = TextBox25.Text.Trim();
                string EventName = TextBox21.Text.Trim();

                string Description = TextBox22.Text.Trim();
                string Date = TextBox23.Text.Trim();
                string Time = TextBox24.Text.Trim();

                string BuildingNo = TextBox26.Text.Trim();
                string BuildingName = TextBox27.Text.Trim();
                string StreetName = TextBox28.Text.Trim();
                string City = TextBox29.Text.Trim();
                string ZipCode = TextBox30.Text.Trim();


                string Query = "DELETE FROM events_table WHERE EventID = '" + EventID + "'";
                //execute query
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                //close connection
                con.Close();
                //MessageBox.Show("User registered successfully!");
                // Response.Write("<script>alert('Registered Successfully!');</script>");
                Response.Write("<script>alert('Deleted Successfully');</script>");
                //clear();
                GridView2.DataBind();

            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }
        }


        void clear()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            DropDownList2.SelectedItem.Value = "";
            TextBox3.Text = "";
            DropDownList3.SelectedItem.Value = "";
            TextBox6.Text = "";
            DropDownListEmploymentType.SelectedItem.Value = "";
            TextBox8.Text = "";
            DropDownList1.SelectedItem.Value = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
            TextBox25.Text = "";







        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button8_Click(object sender, EventArgs e)
        {

        }
    }

}