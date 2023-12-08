<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="studentsignup.aspx.cs" Inherits="StudentEdgeConnect1.studentsignup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
      <div class="row">
         <div class="col-md-8 mx-auto">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <img width="100px" src="images/userlogin.jpg"/>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Student Registration</h4>
                        </center>
                     </div>
                  </div>
                <div class="row">
                <div class="col">
                    <hr>
                </div>
            </div>
            <div class="row">
                <!--First name-->
                <div class="col-md-4">
                    <label>First Name</label>
                    <div class="form-group">
                        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Fname"></asp:TextBox>
                    </div>
                </div>
                  <!--Middle name-->
                <div class="col-md-4"> 
                    <label>Middle Name</label>
                    <div class="form-group">
                        <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Mname"></asp:TextBox>
                    </div>
                </div>
                  <!--Last name-->
                <div class="col-md-4">
                    <label>Last Name</label>
                    <div class="form-group">
                        <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Lname"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                  <!--Role type-->
                <div class="col-md-4">
                    <label>Role Type</label>
                    <div class="form-group">
                        <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="roleType"></asp:TextBox>
                    </div>
                </div>
                  <!--Role description-->
                <div class="col-md-4">
                    <label>Role Description</label>
                    <div class="form-group">
                        <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="roleDescription"></asp:TextBox>
                    </div>
                </div>
                  <!--SSN-->
                <div class="col-md-4">
                    <label>SSN</label>
                    <div class="form-group">
                        <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="SSN"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                  <!--Email ID -->
                <div class="col-md-4">
                    <label>Email ID</label>
                    <div class="form-group">
                        <asp:TextBox CssClass="form-control" ID="TextBox7" runat="server" placeholder="EmailID" TextMode="Email"></asp:TextBox>
                    </div>
                </div>
                  <!--Birthdate-->
                <div class="col-md-4">
                    <label>BirthDate</label>
                    <div class="form-group">
                        <asp:TextBox CssClass="form-control" ID="TextBox8" runat="server" placeholder="BirthDate" type="date"></asp:TextBox>
                    </div>
                </div>
                <!--Phone no-->
                <div class="col-md-4">
                    <label>Phone No</label>
                    <div class="form-group">
                        <asp:TextBox CssClass="form-control" ID="TextBox9" runat="server" placeholder="Phone" ></asp:TextBox>
                    </div>
                </div>
            </div>

                <div class="row">
                <!--ZipCode-->
                <div class="col-md-4">
                    <label>ZipCode</label>
                    <div class="form-group">
                        <asp:TextBox CssClass="form-control" ID="TextBox10" runat="server" placeholder="ZipCode"></asp:TextBox>
                    </div>
                </div>
                  <!--City-->
                <div class="col-md-4">
                    <label>City</label>
                    <div class="form-group">
                        <asp:TextBox CssClass="form-control" ID="TextBox11" runat="server" placeholder="City"></asp:TextBox>
                    </div>
                </div>
                  <!--State-->
                <div class="col-md-4">
                    <label>State</label>
                    <div class="form-group">
                        <asp:TextBox CssClass="form-control" ID="TextBox12" runat="server" placeholder="State"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <!--Country-->
                <div class="col-md-4">
                    <label>Country</label>
                    <div class="form-group">
                        <asp:TextBox CssClass="form-control" ID="TextBox13" runat="server" placeholder="Country"></asp:TextBox>
                    </div>
                </div>
                <!--Student ID-->
                <div class="col-md-4">
                    <label>Student ID</label>
                    <div class="form-group">
                        <asp:TextBox CssClass="form-control" ID="TextBox14" runat="server" placeholder="StudentID"></asp:TextBox>
                    </div>
                </div>
                <!--Education level-->
                <div class="col-md-4">
                    <label>Education Level</label>
                    <div class="form-group">
                        <asp:TextBox CssClass="form-control" ID="TextBox15" runat="server" placeholder="EducationLevel"></asp:TextBox>
                    </div>
                </div>
            </div>
                               <div class="col-md-4">
                    <label>University Name</label>
                    <div class="form-group">
                        <asp:TextBox CssClass="form-control" ID="TextBox19" runat="server" placeholder="UniversityName"></asp:TextBox>
                    </div>
                </div>
            </div>
                <!--Graduation date-->
             <div class="col-md-4">
                    <label>Graduation Date</label>
                    <div class="form-group">
                        <asp:TextBox CssClass="form-control" ID="TextBox18" runat="server" placeholder="GraduationDate" type="date"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <!--Student Username-->
                <div class="col-md-6">
                    <label>S_Username</label>
                    <div class="form-group">
                        <asp:TextBox CssClass="form-control" ID="TextBox16" runat="server" placeholder="S_username"></asp:TextBox>
                    </div>
                </div>
                <!--Student Password-->
                <div class="col-md-6">
                    <label>S_Password</label>
                    <div class="form-group">
                        <asp:TextBox CssClass="form-control" ID="TextBox17" runat="server" placeholder="S_Password" TextMode="Password"></asp:TextBox>
                    </div>
                </div>
            </div>
             <!--Register button-->
            <div class="row">
                <div class="col">
                    <div class="form-group">
                        <asp:Button class="btn btn-success btn-block btn-lg" ID="Button9" runat="server" Text="Register" OnClick="Button9_Click" />
                    </div>
                </div>
            </div>
        </div>
      </div>
     <a href="homepage.aspx"><< Back to Home</a><br><br>
     </div>
 </asp:Content>
