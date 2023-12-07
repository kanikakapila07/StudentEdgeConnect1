using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentEdgeConnect1
{
    public partial class applicationstatus : System.Web.UI.Page
    {
        string ConnectionString = "Data Source=DESKTOP-8DP7DQP\\SQLEXPRESS;Initial Catalog=studentEdgeConnect1DB;Integrated Security=True";
        string AnotherConnectionString = "Data Source=DESKTOP-8DP7DQP\\SQLEXPRESS;Initial Catalog=studentEdgeConnect1DB;Integrated Security=True;providerName=System.Data.SqlClient";
        string studentID = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["S_username"] != null)
                {
                    string studentID = RetrieveStudentID(); // Function to retrieve the StudentID

                    // Set the StudentID parameter for the SqlDataSource
                    SqlDataSource3.SelectParameters["StudentID"].DefaultValue = studentID;

                    GridView1.DataBind();
                }
            }
        }

        private string RetrieveStudentID()
        {
            string loggedInUsername = Session["S_username"].ToString();
            string studentID = "";

            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT StudentID FROM student WHERE S_username = @S_username", con);
                    cmd.Parameters.AddWithValue("@S_username", loggedInUsername);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        studentID = result.ToString();
                    }
                    else
                    {
                        Response.Write("<script>alert('No data found');</script>");
                    }
                }
            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }

            return studentID;
        }



        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();

                SqlCommand checkCmd = new SqlCommand("SELECT StudentID FROM student WHERE S_username = @S_username", con);
                checkCmd.Parameters.AddWithValue("@S_username", Session["S_username"].ToString());
                object result = checkCmd.ExecuteScalar();
                if (result != null && result.ToString() == studentID)
                {

                    string Query = "SELECT s.JobID, s.StudentID, ISNULL(s.ApplicationStatus, 'Pending') AS ApplicationStatus " +
                                   "FROM Status s " +
                                   "INNER JOIN appliedjobs_table a ON s.StudentID = a.StudentID";

                    SqlCommand cmd = new SqlCommand(Query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        GridView1.DataSource = reader;
                        GridView1.DataBind();
                    }
                    else
                    {
                        Response.Write("<script>alert('No records found.');</script>");
                    }

                    con.Close();
                }
            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }
        }


        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                // Check if ApplicationStatus is null or empty
                if (string.IsNullOrEmpty(DataBinder.Eval(e.Row.DataItem, "ApplicationStatus").ToString()))
                {
                    // Set default value to 'Pending'
                    e.Row.Cells[2].Text = "Pending";
                }
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}