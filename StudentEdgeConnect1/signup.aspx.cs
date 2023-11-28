using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentEdgeConnect1
{
    public partial class signup : System.Web.UI.Page
    {
        //address of sql server
        //string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        string ConnectionString = "Data Source=DESKTOP-8DP7DQP\\SQLEXPRESS;Initial Catalog=studentEdgeConnectDB;Integrated Security=True";


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //sign up button 
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

        //check if user exists in database
        bool checkExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();

                string SSN = TextBox6.Text.Trim();
                string Query = "(SELECT COUNT(*) FROM employer_table WHERE SSN='" + SSN + "')";

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
                string EmployerID = TextBox14.Text.Trim();
                string E_CompanyID = TextBox15.Text.Trim();
                string E_username = TextBox16.Text.Trim();
                string E_Password = TextBox17.Text.Trim();



                string Query = "INSERT INTO employer_table(Fname, Mname, Lname, roleType, roleDescription, SSN, EmailID, BirthDate, Phone, ZipCode, City, State, Country, EmployerID, E_CompanyID, E_username, E_Password) VALUES('" + Fname + "', '" + Mname + "', '" + Lname + "', '" + roleType + "', '" + roleDescription + "', '" + SSN + "', '" + EmailID + "', '" + BirthDate + "', '" + Phone + "', '" + ZipCode + "', '" + City + "', '" + State + "', '" + Country + "', '" + EmployerID + "', '" + E_CompanyID + "', '" + E_username + "','" + E_Password + "')";

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