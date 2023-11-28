using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentEdgeConnect1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }



        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("initialsignup.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("employerlogin.aspx");
        }
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            //Response.Redirect("logout.aspx");

            Response.Redirect("homepage.aspx");



        }
        protected void LinkButton5_Click(object sender, EventArgs e)
        {



        }


        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                if (Session["role"] == null)
                {
                    LinkButton1.Visible = true; //student login
                    LinkButton2.Visible = true; //sign up 
                    LinkButton4.Visible = true; //employer login
                    LinkButton3.Visible = false; //Logout 
                    LinkButton5.Visible = false; //Hello user

                }
                else if (Session["role"].Equals("Employer"))
                {
                    LinkButton1.Visible = false; //student login
                    LinkButton2.Visible = false; //sign up 
                    LinkButton4.Visible = false; //employer login
                    LinkButton3.Visible = true; //Logout 
                    LinkButton5.Visible = true; //Hello user
                    LinkButton5.Text = "Hello" + Session["E_username"].ToString();


                }
                else if (Session["role"].Equals("Student"))
                {
                    LinkButton1.Visible = false; //student login
                    LinkButton2.Visible = false; //sign up 
                    LinkButton4.Visible = false; //employer login
                    LinkButton3.Visible = true; //Logout 
                    LinkButton5.Visible = true; //Hello user
                    LinkButton5.Text = "Hello" + Session["S_username"].ToString();
                }
            }
            catch (Exception exception)
            {
                Response.Write("<script>alert('Error: " + exception.Message + "');</script>");
            }
        }
    }
}
