﻿using System;
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
            try
            {
                string username = Session["E_username"] as string;

               //establish connection
                SqlConnection con = new SqlConnection(ConnectionString);

                //open connection
                con.Open();

                //prepare query
                string query = "SELECT SSN, E_password, Fname, Mname, Lname, BirthDate, EmailID, Phoneno, City, State, Country, ZipCode, E_username FROM employer_table WHERE E_username = @Username";
                
                //exceute query
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", username);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        TextBox13.Text = reader["SSN"].ToString();
                        TextBox43.Text = reader["E_password"].ToString();
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
                        TextBox20.Text = reader["E_username"].ToString();
                    }
                }
                con.Close();

                Button8.Click += Button8_Click; 
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
            }
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

        //update employer info
        protected void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                string ssn = TextBox13.Text.Trim(); 
                string newpassword = TextBox43.Text.Trim(); 
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
                


               
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();

              
                string query = "UPDATE employer_table SET E_password = @NewPassword, Fname = @Fname, Mname = @Mname, Lname = @Lname, BirthDate = @BirthDate, EmailID = @Email, Phone = @Phone, City = @City, State = @State, Country = @Country, ZipCode = @ZipCode, E_username = @Username WHERE SSN = @SSN";


              
                SqlCommand cmd = new SqlCommand(query, con);

                
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
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@SSN", ssn);

               
                int rowsAffected = cmd.ExecuteNonQuery();

                con.Close();

                if (rowsAffected > 0)
                {
                   
                    Response.Write("<script>alert('Updated successfully!');</script>");
                }
                else
                {
                   
                    Response.Write("<script>alert('No employer found ');</script>");
                }
            }
            catch (Exception ex)
            {
                
                Response.Write("<script>alert('Error: " + ex.Message + "');</script>");
            }
        }

        //update event 
        protected void Button5_Click(object sender, EventArgs e)
        {
            if (checkEventExists())
            {
                updateEventInfo();


            }
            else
            {

                Response.Write("<script>alert('Event with this ID doesn't exist!');</script>");
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


        //add new event
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

              
                string JobID = TextBox39.Text.Trim();
                string StudentID = TextBox34.Text.Trim();

                //prepare query
                string Query = "INSERT INTO Status(JobID, StudentID, ApplicationStatus) VALUES('" + JobID + "', '" + StudentID + "','Accepted')";

                //execute query
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();

                //close connection
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

               
                string JobID = TextBox39.Text.Trim();
                string StudentID = TextBox34.Text.Trim();

                //prepare query
                string Query = "INSERT INTO Status(JobID, StudentID, ApplicationStatus) VALUES('" + JobID + "', '" + StudentID + "','Rejected')";

                //execute query
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();

                //close connection
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
               

                string JobID = TextBox39.Text.Trim();
                string StudentID = TextBox34.Text.Trim();

                //prepare query
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
                Response.Write("<script>alert('Event with this ID doesn't exist!');</script>");
            }

        }

        //check if job exists 
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

        //check if event exists
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

        //add new job 
        void addNewJob()
        {
            try
            {

                //establish connection
                SqlConnection con = new SqlConnection(ConnectionString);

                //open connection
                con.Open();

               
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

                //prepare query
                string Query = "INSERT INTO jobs_table(JobID,JobPosition,Requirements,Description,Pay,ApplicationDeadline,EmploymentType,Benefits,HowToApply,SkillName,Company,CompanyLocation) VALUES('" + JobID + "', '" + JobPosition + "', '" + Requirements + "', '" + Description + "', '" + Pay + "', '" + ApplicationDeadline + "', '" + EmploymentType + "', '" + Benefits + "', '" + HowToApply + "', '" + SkillName + "', '" + Company + "','" + CompanyLocation + "')";



                //execute query
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();

                //close connection
                con.Close();
               
                Response.Write("<script>alert('Added Successfully!');</script>");
                clear();
                GridView1.DataBind();

            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }

        }

        //add new event
        void addNewEvent()
        {
            try
            {

                //establish connection
                SqlConnection con = new SqlConnection(ConnectionString);

                //open connection
                con.Open();

              
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

                //prepare query
                string Query = "INSERT INTO events_table(EventID,EventName,Description,Date,Time,BuildingNo,BuildingName,StreetName,City,ZipCode) VALUES('" + EventID + "', '" + EventName + "', '" + Description + "', '" + Date + "', '" + Time + "', '" + BuildingNo + "', '" + BuildingName + "', '" + StreetName + "', '" + City + "', '" + ZipCode + "')";

                //execute query
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();

                //close connection
                con.Close();
               
                Response.Write("<script>alert('Added Successfully!');</script>");
               
                GridView2.DataBind();

            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }

        }

        //update job info
        void updateJobInfo()
        {

            try
            {

                //establish connection
                SqlConnection con = new SqlConnection(ConnectionString);

                //open connection
                con.Open();

          
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


                //prepare query
                string Query = "UPDATE jobs_table SET JobPosition = '" + JobPosition + "', Pay = '" + Pay + "', ApplicationDeadline = '" + ApplicationDeadline + "', Requirements = '" + Requirements + "', EmploymentType = '" + EmploymentType + "', Benefits = '" + Benefits + "', Description = '" + Description + "', HowToApply = '" + HowToApply + "', SkillName = '" + SkillName + "', Company = '" + Company + "', CompanyLocation = '" + CompanyLocation + "' WHERE JobID = '" + JobID + "'";


                //execute query
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();

                //close connection
                con.Close();
                
                Response.Write("<script>alert('Updated Successfully');</script>");
                clear();
                GridView1.DataBind();
            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }
        }

        //update event info
        void updateEventInfo()
        {

            try
            {

                //establish connection
                SqlConnection con = new SqlConnection(ConnectionString);

                //open connection
                con.Open();
               
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

                //prepare query
                string Query = "UPDATE events_table SET EventID = '" + EventID + "', EventName = '" + EventName + "', Description = '" + Description + "', Date = '" + Date + "', Time = '" + Time + "', BuildingNo = '" + BuildingNo + "', BuildingName = '" + BuildingName + "', StreetName = '" + StreetName + "', City = '" + City + "', ZipCode = '" + ZipCode + "' WHERE EventID = '" + EventID + "'";

                //execute query
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();

                //close connection
                con.Close();
                
                Response.Write("<script>alert('Updated Successfully');</script>");

                GridView2.DataBind();
            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }
        }


        //delete job
        void deleteJob()
        {
            try
            {

                //establish connection
                SqlConnection con = new SqlConnection(ConnectionString);

                //open connection
                con.Open();
               
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


                //prepare query
                string Query = "DELETE FROM jobs_table WHERE JobID = '" + JobID + "'";

                //execute query
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();

                //close connection
                con.Close();
                Response.Write("<script>alert('Deleted Successfully');</script>");
                clear();
                GridView1.DataBind();

            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }
        }

        //delete event
        void deleteEvent()
        {
            try
            {

                //establish connection
                SqlConnection con = new SqlConnection(ConnectionString);

                //open connection
                con.Open();
              
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

                //prepare query
                string Query = "DELETE FROM events_table WHERE EventID = '" + EventID + "'";

                //execute query
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();

                //close connection
                con.Close();
               
                Response.Write("<script>alert('Deleted Successfully');</script>");
             
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

        

    }

}