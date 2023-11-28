using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentEdgeConnect1
{
    public partial class studentsignup : System.Web.UI.Page
    {
        string ConnectionString = "Data Source=DESKTOP-8DP7DQP\\SQLEXPRESS;Initial Catalog=studentEdgeConnect1DB;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button9_Click(object sender, EventArgs e)
        {
            if (checkExists())
            {
                Response.Write("<script>alert('User Already Registered! Please Login');</script>");
            }
            else
            {
                register();
            }
        }
        //check if user exists


        bool checkExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();

                string SSN = TextBox6.Text.Trim();
                string Query = "(SELECT COUNT(*) student WHERE SSN='" + SSN + "')";

                SqlCommand cmd = new SqlCommand(Query, con);

                cmd.Parameters.AddWithValue("@SSN", SSN);
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
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
                return false;
            }
        }

        //register new user
        void register()
        {
            try
            {

                //establish connection
                SqlConnection con = new SqlConnection(ConnectionString);

                //open connection
                con.Open();
                //prepare query
                string Fname = TextBox1.Text.Trim();
                string Mname = TextBox2.Text.Trim();
                string Lname = TextBox3.Text.Trim();
                string roleType = TextBox4.Text.Trim();
                string roleDescription = TextBox5.Text.Trim();
                string SSN = TextBox6.Text.Trim();
                string EmailID = TextBox7.Text.Trim();
                string BirthDate = TextBox8.Text.Trim();
                string Phone = TextBox9.Text.Trim();
                string ZipCode = TextBox10.Text.Trim();
                string City = TextBox11.Text.Trim();
                string State = TextBox12.Text.Trim();
                string Country = TextBox13.Text.Trim();
                string StudentID = TextBox14.Text.Trim();
                string EducationLevel = TextBox15.Text.Trim();
                string UniversityName = TextBox19.Text.Trim();
                string GraduationDate = TextBox18.Text.Trim();
                string S_username = TextBox16.Text.Trim();
                string S_Password = TextBox17.Text.Trim();



                string Query = "INSERT INTO student(Fname, Mname, Lname, roleType, roleDescription, SSN, EmailID, BirthDate, Phone, ZipCode, City, State, Country, StudentID, EducationLevel,UniversityName,GraduationDate,S_username, S_Password) VALUES('" + Fname + "', '" + Mname + "', '" + Lname + "', '" + roleType + "', '" + roleDescription + "', '" + SSN + "', '" + EmailID + "', '" + BirthDate + "', '" + Phone + "', '" + ZipCode + "', '" + City + "', '" + State + "', '" + Country + "', '" + StudentID + "', '" + EducationLevel + "', '" + UniversityName + "', '" + GraduationDate + "' ,'" + S_username + "','" + S_Password + "')";

                //execute query
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                //close connection
                con.Close();
                //MessageBox.Show("User registered successfully!");
                Response.Write("<script>alert('Registered Successfully!');</script>");


            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }
        }
    }
}