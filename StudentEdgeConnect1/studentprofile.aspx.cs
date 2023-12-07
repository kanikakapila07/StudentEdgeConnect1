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

        }
        protected void LoadAppliedJobs()

        {
            string S_username = Session["S_username"] as string;

            if (!string.IsNullOrEmpty(S_username))
            {
                // Filter and bind the GridView with applied jobs specific to the current user
                BindAppliedJobs(S_username);
            }
            //status
            GridView3.DataBind();
        }
        protected void LoadApplyJobs()
        {
            GridView1.DataBind();
        }
        //status
        private void BindAppliedJobs(string S_username)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();

                    string query = "SELECT s.JobID, s.StudentID, s.ApplicationStatus " +
                                   "FROM Status s " +
                                   "INNER JOIN student u ON s.StudentID = u.StudentID " +
                                   "WHERE u.S_username = @S_username";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@S_username", S_username);

                    DataTable table = new DataTable();
                    table.Load(cmd.ExecuteReader());

                    // Bind the DataTable to the GridView
                    GridView3.DataSource = table;
                    GridView3.DataBind();
                }
            }
            catch (Exception exception)
            {
                // Handle exceptions as needed
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
        //withdraw 
        protected void Button16_Click(object sender, EventArgs e)
        {
            try
            {
                LinkButton btn = (LinkButton)sender;

                // Get the selected row of the GridView
                GridViewRow row = (GridViewRow)btn.NamingContainer;

                // Get the JobID value from the GridView's selected row
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
                //MessageBox.Show("User registered successfully!");
                // Response.Write("<script>alert('Registered Successfully!');</script>");
                Response.Write("<script>alert('Withdrawn!');</script>");



            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }

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
                GridView6.DataBind();

            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }

        }


    }
}
