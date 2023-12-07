﻿using System;
using System.Data.SqlClient;

namespace StudentEdgeConnect1
{
    public partial class employerlogin : System.Web.UI.Page
    {
        string ConnectionString = "Data Source=DESKTOP-8DP7DQP\\SQLEXPRESS;Initial Catalog=studentEdgeConnect1DB;Integrated Security=True";
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //establish connection
                SqlConnection con = new SqlConnection(ConnectionString);
                //open connection
                con.Open();
                //prepare query
                string Username = TextBox1.Text.Trim();
                string Password = TextBox2.Text.Trim();
                string Query = "SELECT * FROM employer_table WHERE E_username = @Username AND E_Password = @Password";

                //Response.Write("<script>alert('Success!');</script>");
                //Response.Redirect("employerprofile.aspx");

                //execute query
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);
                SqlDataReader reader = cmd.ExecuteReader();
                //int count = (int)cmd.ExecuteScalar();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {
                        // Response.Write("<script>alert('"+reader.GetValue(15).ToString()+"');</script>");

                      
                       
                        Session["E_username"] = reader["E_username"].ToString();
                        Session["Fname"] = reader["Fname"].ToString();
                        Session["role"] = "Employer";
                        Response.Write("<script>alert('Success');</script>");
                        Response.Redirect("employerprofile.aspx");


                    }

                }
                else
                {
                    Response.Write("<script>alert('Invalid Credentials');</script>");

                }


            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }

        }
    }
}