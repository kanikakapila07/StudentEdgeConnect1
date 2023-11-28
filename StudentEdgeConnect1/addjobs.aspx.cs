using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentEdgeConnect1
{
    public partial class addjobs : System.Web.UI.Page
    {
        string ConnectionString = "Data Source=DESKTOP-8DP7DQP\\SQLEXPRESS;Initial Catalog=studentEdgeConnect1DB;Integrated Security=True";
        string AnotherConnectionString = "Data Source=DESKTOP-8DP7DQP\\SQLEXPRESS;Initial Catalog=studentEdgeConnect1DB;Integrated Security=True;providerName=System.Data.SqlClient";


        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }
        //update
        protected void Button1_Click(object sender,EventArgs e)
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
        //delete
        protected void Button3_Click(object sender, EventArgs e)
        {
            if(checkExists())
            {
                deleteJob();
               
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

                string JobID= TextBox1.Text.Trim();
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

                string Query = "INSERT INTO jobs_table(JobID,JobPosition,Requirements,Description,Pay,ApplicationDeadline,EmploymentType,Benefits,HowToApply,SkillName,Company,CompanyLocation) VALUES('" + JobID + "', '" + JobPosition + "', '" + Requirements + "', '" + Description + "', '" + Pay + "', '" + ApplicationDeadline + "', '" + EmploymentType+ "', '" + Benefits+ "', '" + HowToApply + "', '" + SkillName+ "', '" + Company + "','" + CompanyLocation + "')";


               
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


        void clear()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            DropDownList2.SelectedItem.Value = "";
            TextBox3.Text = "";
            DropDownList3.SelectedItem.Value="";
            TextBox6.Text="";
            DropDownListEmploymentType.SelectedItem.Value="";
            TextBox8.Text="";
            DropDownList1.SelectedItem.Value="";
            TextBox10.Text="";
            TextBox11.Text="";
            TextBox12.Text="";



        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}