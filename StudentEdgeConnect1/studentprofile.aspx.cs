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
