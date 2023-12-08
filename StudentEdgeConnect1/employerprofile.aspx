<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="employerprofile.aspx.cs" Inherits="StudentEdgeConnect1.employerprofile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style>
        /* Style for blue tab links */
        .nav-tabs .nav-link {
            color: black;
        }
        /* Style for active tab link */
        .nav-tabs .nav-item.show .nav-link, .nav-tabs .nav-link.active {
            color: black;
            background-color: lavender;
            border-color: black;
        }

        .scroll-container{
            width:auto;
            overflow-x:auto;
            white-space:nowrap;
            padding-bottom:20px;
        }
    </style>
    
     
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <ul class="nav nav-tabs" role="tablist">
            <li class="nav-item">
                <a class="nav-link active" data-toggle="tab" href="#edit-profile" role="tab">Edit Profile</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" data-toggle="tab" href="#posts-jobs" role="tab">Current Job Openings</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" data-toggle="tab" href="#view-applications" role="tab">View Applications</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" data-toggle="tab" href="#posts-events" role="tab">Posts Networking Events</a>
            </li>
        </ul>
  
        <div class="tab-content">
            <div class="tab-pane fade show active" id="edit-profile" role="tabpanel">
                <!-- Content for Edit Profile Tab -->
                
                 <div class="container">
    <div class="row">
        <div class="col-md-8 mx-auto"> 
            <div class="card">
                <div class="card-body text-center">
                    <div>
                        <img style="width: 25px; margin-bottom: 1px;" src="images/userlogin.jpg" />
                    </div>
                    <h4>
                       Edit your profile
                         </h4>
                        <span> User Status -</span>
                        <asp:Label class="badge badge-pill badge-primary" ID="Label1" runat="server" 
                            Text="Employer"></asp:Label>
                   
                    <hr>
                    <div class="row">
                        <div class="col">
                            <form>
                                <div class="form-group row">
                                    <label for="fname" class="col-sm-4 col-form-label text-left">First Name:</label>
                                    <div class="col-sm-8">
                                        <input class="form-control" type="text" id="fname" placeholder="First Name:">
                                    </div>
                                </div> 
                                <div class="form-group row">
                                    <label for="mname" class="col-sm-4 col-form-label text-left">Middle Name:</label>
                                    <div class="col-sm-8">
                                        <input class="form-control" type="text" id="mname" placeholder="Middle Name:">
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <label for="lname" class="col-sm-4 col-form-label text-left">Last Name:</label>
                                    <div class="col-sm-8">
                                        <input class="form-control" type="text" id="lname" placeholder="Last Name:">
                                    </div>
                                </div>
                                <!-- Additional fields -->
                                <!-- Birthdate -->
                                <div class="form-group row">
                                    <label for="birthdate" class="col-sm-4 col-form-label text-left">Birthdate:</label>
                                    <div class="col-sm-8">
                                        <input class="form-control" type="date" id="birthdate">
                                    </div>
                                </div>
                                <!--SSN-->
                                <div class="form-group row">
                                    <label for="ssn" class="col-sm-4 col-form-label text-left">Social Security Number:</label>
                                    <div class="col-sm-8">
                                        <input class="form-control" type="text" id="ssn" placeholder="Social Security Number">
                                    </div>
                                </div>
                                <!-- Email ID -->
                                <div class="form-group row">
                                    <label for="email" class="col-sm-4 col-form-label text-left">Email ID:</label>
                                    <div class="col-sm-8">
                                        <input class="form-control" type="email" id="email" placeholder="Email">
                                    </div>
                                </div>
                                <!-- Phone number -->
                                <div class="form-group row">
                                    <label for="phone" class="col-sm-4 col-form-label text-left">Phone Number:</label>
                                    <div class="col-sm-8">
                                        <input class="form-control" type="tel" id="phone" placeholder="Phone Number">
                                    </div>
                                </div>
                                <!-- City -->
                                <div class="form-group row">
                                    <label for="city" class="col-sm-4 col-form-label text-left">City:</label>
                                    <div class="col-sm-8">
                                        <input class="form-control" type="text" id="city" placeholder="City">
                                    </div>
                                </div>
                                <!-- State -->
                                <div class="form-group row">
                                    <label for="state" class="col-sm-4 col-form-label text-left">State:</label>
                                    <div class="col-sm-8">
                                        <input class="form-control" type="text" id="state" placeholder="State">
                                    </div>
                                </div>
                                <!-- Country -->
                                <div class="form-group row">
                                    <label for="country" class="col-sm-4 col-form-label text-left">Country:</label>
                                    <div class="col-sm-8">
                                        <input class="form-control" type="text" id="country" placeholder="Country">
                                    </div>
                                </div>
                                <!-- ZIP Code -->
                                <div class="form-group row">
                                    <label for="zip" class="col-sm-4 col-form-label text-left">ZIP Code:</label>
                                    <div class="col-sm-8">
                                        <input class="form-control" type="text" id="zip" placeholder="ZIP Code">
                                    </div>
                                </div>
                                <!--login credentials--> 
                                
                                <div class="form-group row">
                                    <div class="col-sm-12">
                                        <div class="form-group text-center">
                                    
                                        <span class="badge badge-pill badge-primary">Login Credentials</span>
                                   
                                </div>
                                </div>
                                </div>
                               

                                <!--Username-->
                                <div class="form-group row"> 
                                    <label for="username" class="col-sm-4 col-form-label text-left">Username:</label>
                                    <div class="col-sm-8">
                                        <input class="form-control" type="text" id="username" placeholder="Username" readonly>
                                    </div>
                                </div>
                                <!--oldpassword-->
                                <div class="form-group row">
                                    <label for="oldpassword" class="col-sm-4 col-form-label text-left">Old Password:</label>
                                    <div class="col-sm-8">
                                        <input class="form-control" type="text" id="oldpassword" placeholder="Old Password" TextMode="Old Password" readonly>
                                    </div>
                                </div>
                                <!--newpassword-->
                                 <div class="form-group row">
                                    <label for="newpassword" class="col-sm-4 col-form-label text-left">New Password:</label>
                                    <div class="col-sm-8">
                                        <input class="form-control" type="text" id="newpassword" placeholder="New Password" TextMode="New Password">
                                    </div>
                                </div>

                                <!-- End of additional fields -->
                                <div class="form-group">
                                    <button class="btn btn-success btn-block" type="submit">Update</button>
                                </div>  
                                
                            </form>
                        </div>
                    </div>
                </div>
            </div>
            <a href="homepage.aspx"><< Back to Home</a><br > <br >
        </div>
    </div>
</div>


            </div>
             
            <div class="tab-pane fade" id="posts-jobs" role="tabpanel">
                

                <!-- Content for Current Job Openings Tab -->
                <div class="scroll-container">
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Add Jobs</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="100px" src="images/jobs.png" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>
                        <div class="row">
                            <!--Job ID-->
                            <div class="col-md-4">
                                <label>Job ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="JobID"></asp:TextBox>
                                        
                                    </div>
                                </div>
                            </div>
                              <!--Job Position-->
                            <div class="col-md-8">
                                <label>Job Position</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="JobPosition"></asp:TextBox>
                                </div>
                            </div>
                              
                             <!--Requirements-->
                            <div class="col-md-8">
                                <label>Requirements</label>
                                <div class="form-group">
                                    <asp:DropDownList CssClass="form-control" ID="DropDownList2" runat="server" placeholder="Requirements">
                                        <asp:ListItem Text="--Select--" Value=""></asp:ListItem>
                                        <asp:ListItem Text="High School" Value="High School"></asp:ListItem>
                                        <asp:ListItem Text="Bachelors" Value="Bachelors"></asp:ListItem>
                                        <asp:ListItem Text="Masters" Value="Masters"></asp:ListItem>
                                        <asp:ListItem Text="PhD" Value="PhD"></asp:ListItem>
                                     </asp:DropDownList>
                                </div>
                            </div>

                            <!--Description-->
                            <div class="col-md-8">
                                <label>Description</label>
                                <div class="form-group">
                                      <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Description"></asp:TextBox>
                                </div>
                            </div>

                              <!--Pay-->
                              <div class="col-md-8">
                                <label>Pay Range per hour</label>
                                <div class="form-group">
                                    <asp:DropDownList CssClass="form-control" ID="DropDownList3" runat="server" placeholder="Pay">
                                        <asp:ListItem Text="--Select--" Value=""></asp:ListItem>
                                        <asp:ListItem Text="$15-$20" Value="$15-$20"></asp:ListItem>
                                        <asp:ListItem Text="$21-$25" Value="$21-$25"></asp:ListItem>
                                        <asp:ListItem Text="$26-$30" Value="$26-$30"></asp:ListItem>
                                        <asp:ListItem Text="$30-$40" Value="$30-$40"></asp:ListItem>
                                     </asp:DropDownList>
                                </div>
                            </div>
                            
                              <!--Application Deadline-->
                              <div class="col-md-8">
                                <label>Application Deadline</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" type="date" placeholder="ApplicationDeadline"></asp:TextBox>
                                </div>
                            </div>
                              <!--Employment Type-->
                              <div class="col-md-8">
                                <label>Employment Type</label>
                                <div class="form-group">
                                   <asp:DropDownList CssClass="form-control" ID="DropDownListEmploymentType" runat="server" placeholder="EmploymentType">
                                        <asp:ListItem Text="--Select--" Value=""></asp:ListItem>
                                        <asp:ListItem Text="Full-time" Value="Full-time"></asp:ListItem>
                                        <asp:ListItem Text="Part-time" Value="Part-time"></asp:ListItem>
                                        <asp:ListItem Text="Contract" Value="Contract"></asp:ListItem>
                                        <asp:ListItem Text="Freelance" Value="Freelance"></asp:ListItem>
                                        <asp:ListItem Text="Intern" Value="Intern"></asp:ListItem>
                                     </asp:DropDownList>
            
        
                                </div>
                            </div>
                              <!--Benefits-->
                              <div class="col-md-8">
                                <label>Benefits</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox8" runat="server" placeholder="Benefis"></asp:TextBox>
                                </div>
                            </div>
                              <!--How to apply-->
                              <div class="col-md-8">
                                <label>How to apply</label>
                                <div class="form-group">
                                     <asp:DropDownList CssClass="form-control" ID="DropDownList1" runat="server" placeholder="HowToApply">
                                        <asp:ListItem Text="--Select--" Value=""></asp:ListItem>
                                        <asp:ListItem Text="E-mail your Resume" Value="E-mail your Resume"></asp:ListItem>
                                        <asp:ListItem Text="Apply on Website" Value="Apply on Website"></asp:ListItem>
                                        <asp:ListItem Text="Walk-In" Value="Walk-In"></asp:ListItem>
                                       
                                     </asp:DropDownList>
                                </div>
                            </div>
                              <!--Skill Name-->
                              <div class="col-md-8">
                                <label>Skill Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox10" runat="server" placeholder="SkillName"></asp:TextBox>
                                </div>
                            </div>
                              <!--Company-->
                              <div class="col-md-8">
                                <label>Company</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox11" runat="server" placeholder="Company"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-8">
                                <label>Location</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox12" runat="server" placeholder="CompanyLocation"></asp:TextBox>
                                </div>
                            </div>
                          
                        </div>
                        <!--add-->
                        <div class="row">
                            <div class="col-4">
                                <asp:Button ID="Button2" class="btn btn-lg btn-block btn-success" runat="server" Text="Add" OnClick="Button2_Click" />
                            </div>
                            <!--Update -->
                            
                            <div class="col-4">
                                <asp:Button ID="Button1" class="btn btn-lg btn-block btn-primary" runat="server" Text="Update"  OnClick="Button1_Click"/>
                            </div>

                             <!--Delete -->
                               
                                <div class="col-4">
                                <asp:Button ID="Button3" class="btn btn-lg btn-block btn-danger" runat="server" Text="Delete" OnClick="Button3_Click" />
                            </div>

                        </div>
                    </div>
                </div>
                <a href="employerprofile.aspx">&lt;&lt; Back</a><br><br>
            </div>
            <div class="col-md-7" >
                <div class="card" >
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Jobs List</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col" >
                                <hr>
                            </div>
                        </div>
                        <div class="row">
                          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:studentEdgeConnect1DBConnectionString %>" SelectCommand="SELECT * FROM [jobs_table]"></asp:SqlDataSource>
                            <div class="col">
                              
                                <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False"  DataKeyNames="JobID" DataSourceID="SqlDataSource1" >
                                    <Columns>
                                        <asp:BoundField DataField="JobID" HeaderText="JobID" ReadOnly="True" SortExpression="JobID" />
                                        <asp:BoundField DataField="JobPosition" HeaderText="JobPosition" SortExpression="JobPosition" />
                                        <asp:BoundField DataField="Requirements" HeaderText="Requirements" SortExpression="Requirements" />
                                        <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                                        <asp:BoundField DataField="Pay" HeaderText="Pay" SortExpression="Pay" />
                                        <asp:BoundField DataField="ApplicationDeadline" HeaderText="ApplicationDeadline" SortExpression="ApplicationDeadline" />
                                        <asp:BoundField DataField="EmploymentType" HeaderText="EmploymentType" SortExpression="EmploymentType" />
                                        <asp:BoundField DataField="Benefits" HeaderText="Benefits" SortExpression="Benefits" />
                                        <asp:BoundField DataField="HowToApply" HeaderText="HowToApply" SortExpression="HowToApply" />
                                        <asp:BoundField DataField="SkillName" HeaderText="SkillName" SortExpression="SkillName" />
                                        <asp:BoundField DataField="Company" HeaderText="Company" SortExpression="Company" />
                                        <asp:BoundField DataField="CompanyLocation" HeaderText="CompanyLocation" SortExpression="CompanyLocation" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                            
                        </div>
                    </div>
                </div>
            </div>
        </div>
        </div>
                   
            </div>
            <div class="tab-pane fade" id="view-applications" role="tabpanel">
                <!-- Content for View Applications Tab -->
                    <div class="scroll-container">
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Student Details</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="100px" src="images/networking.jpg" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>
                        <div class="row">
                            <!--Student Fname-->
                            <div class="col-md-4">
                                <label>First Name</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox31" runat="server" placeholder="fname" ReadOnly="true"></asp:TextBox>
                                        
                                    </div>
                                </div>
                            </div>
                             
                            <!--Student Mname-->
                            <div class="col-md-4">
                                <label>Middle Name</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox32" runat="server" placeholder="mname" ReadOnly="true"></asp:TextBox>
                                        
                                    </div>
                                </div>
                            </div>
                             
                              
                            
                            <!--Student Lname-->
                            <div class="col-md-8">
                                <label>Lname</label>
                                <div class="form-group">
                                      <asp:TextBox CssClass="form-control" ID="TextBox33" runat="server" placeholder="lname" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>

                              
                            
                              <!--Student ID-->
                              <div class="col-md-8">
                                <label>Student ID</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox34" runat="server" placeholder="StudentID" ></asp:TextBox>
                                    <asp:LinkButton ID="LinkButton8" class="btn btn-lg btn-block btn-primary" runat="server" text="Go" OnClick="LinkButton8_Click">
                                    <i class="fas fa-check-circle"></i> </asp:LinkButton>
                                </div>
                            </div>
                            <!--EmailID-->
                            <div class="col-md-8">
                                <label>EmailID</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox35" runat="server" placeholder="EmailID" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>
                              <!--Student Education level-->
                              <div class="col-md-8">
                                <label>Education Level</label>
                                <div class="form-group">
                                   <asp:TextBox CssClass="form-control" ID="TextBox36" runat="server" placeholder="EducationLevel" ReadOnly="true" >
                                        
                                     </asp:TextBox>
            
        
                                </div>
                            </div>
                              <!--University NAME-->
                              <div class="col-md-8">
                                <label>University Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox37" runat="server"  placeholder="UniversityName" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>
                              
                              <!--Graduation date-->
                              <div class="col-md-8">
                                <label>Graduation Date</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox38" runat="server" type="date" placeholder="GraduationDate" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>
                              <!--Applied Job ID-->
                              <div class="col-md-8">
                                <label>Applied Job ID</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox39" runat="server" placeholder="JobID" ></asp:TextBox>
                                </div>
                            </div>
                            <!--Applied Job Name-->
                              <div class="col-md-8">
                                <label>Applied Job Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox40" runat="server" placeholder="JobPosition" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>
                            <!--Applied Job Company-->
                              <div class="col-md-8">
                                <label>Applied Job Company</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox41" runat="server" placeholder="Company" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>

                            <!--Application Status-->
                            <div class="col-md-8">
                                <label>Application status</label>
                                <div class="form-group">
                                  <!--accept-->
                            <div class="row">
                            <div class="col-8">
                                <asp:Button ID="Button7" class="btn btn-lg btn-block btn-success" runat="server" Text="Accept"  OnClick="Button7_Click"/>
                            </div>
                           

                             <!--reject -->
                               
                                <div class="col-8">
                                <asp:Button ID="Button9" class="btn btn-lg btn-block btn-danger" runat="server" Text="Reject"  OnClick="Button9_Click"/>
                            </div>

                        </div>
                                </div>
                            </div>
                          
                        </div>
                        
                    </div>
                </div>
                <a href="employerprofile.aspx">&lt;&lt; Back</a><br><br>
            </div>
            <div class="col-md-7">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Students List</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col" >
                                <hr>
                            </div>
                        </div>
                        
                        <div class="row">

                          <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:studentEdgeConnect1DBConnectionString %>" SelectCommand=" SELECT s.fname, s.mname, s.lname, s.StudentID, s.EmailID,
                          a.EducationLevel, a.UniversityName, a.GraduationDate, a.JobID, a.JobPosition, a.Company FROM student s INNER JOIN appliedjobs_table a ON s.StudentID = a.StudentID;">

                          </asp:SqlDataSource>
                            <div class="col">
                              
                                <asp:GridView class="table table-striped table-bordered" ID="GridView3" runat="server" OnSelectedIndexChanged="GridView3_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames="StudentID" DataSourceID="SqlDataSource3" >
                                    <Columns>
                                       
                                        <asp:BoundField DataField="fname" HeaderText="fname" SortExpression="fname" />
                                        <asp:BoundField DataField="mname" HeaderText="mname" SortExpression="mname" />
                                        <asp:BoundField DataField="lname" HeaderText="lname" SortExpression="lname" />
                                        <asp:BoundField DataField="StudentID" HeaderText="StudentID" SortExpression="StudentID" />
                                          <asp:BoundField DataField="EmailID" HeaderText="EmailID" SortExpression="EmailID" />
                                        <asp:BoundField DataField="EducationLevel" HeaderText="EducationLevel" SortExpression="EducationLevel" />
                                        <asp:BoundField DataField="UniversityName" HeaderText="UniversityName" SortExpression="UniversityName" />
                                        <asp:BoundField DataField="GraduationDate" HeaderText="GraduationDate" SortExpression="GraduationDate" />
                                          <asp:BoundField DataField="JobID" HeaderText="JobID" SortExpression="JobID" />
                                        <asp:BoundField DataField="JobPosition" HeaderText="JobPosition" SortExpression="JobPosition" />
                                        <asp:BoundField DataField="Company" HeaderText="Company" SortExpression="Company" />
                                        
                                        
                                    </Columns>
                                </asp:GridView>
                            </div>
                            
                        </div>
                    </div>
                </div>
            </div>
        </div>
        </div>

            

            </div>
            
            <div class="tab-pane fade" id="posts-events" role="tabpanel">
                <!-- Content for Posts Networking Events Tab -->
               
                <div class="scroll-container">
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Add Events</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="100px" src="images/networking.jpg" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>
                        <div class="row">
                            <!--EventID-->
                            <div class="col-md-4">
                                <label>Event ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox25" runat="server" placeholder="EventID"></asp:TextBox>
                                        
                                    </div>
                                </div>
                            </div>
                             
                            <!--Event Name-->
                            <div class="col-md-4">
                                <label>Event Name</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox21" runat="server" placeholder="EventName"></asp:TextBox>
                                        
                                    </div>
                                </div>
                            </div>
                             
                              
                            
                            <!--Description-->
                            <div class="col-md-8">
                                <label>Description</label>
                                <div class="form-group">
                                      <asp:TextBox CssClass="form-control" ID="TextBox22" runat="server" placeholder="Description"></asp:TextBox>
                                </div>
                            </div>

                              
                            
                              <!--Date-->
                              <div class="col-md-8">
                                <label>Date</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox23" runat="server" type="date" placeholder="Date"></asp:TextBox>
                                </div>
                            </div>
                            <!--Time-->
                            <div class="col-md-8">
                                <label>Time</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox24" runat="server" type="time" placeholder="Time"></asp:TextBox>
                                </div>
                            </div>
                              <!--BuildingNo-->
                              <div class="col-md-8">
                                <label>Building Number</label>
                                <div class="form-group">
                                   <asp:TextBox CssClass="form-control" ID="TextBox26" runat="server" placeholder="BuildingNo">
                                        
                                     </asp:TextBox>
            
        
                                </div>
                            </div>
                              <!--Building Name-->
                              <div class="col-md-8">
                                <label>Building Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox27" runat="server" placeholder="BuildingName"></asp:TextBox>
                                </div>
                            </div>
                              
                              <!--Street Name-->
                              <div class="col-md-8">
                                <label>Street Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox28" runat="server" placeholder="StreetName"></asp:TextBox>
                                </div>
                            </div>
                              <!--City-->
                              <div class="col-md-8">
                                <label>City</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox29" runat="server" placeholder="City"></asp:TextBox>
                                </div>
                            </div>
                            <!--ZipCode-->
                            <div class="col-md-8">
                                <label>Zip Code</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox30" runat="server" placeholder="ZipCode"></asp:TextBox>
                                </div>
                            </div>
                          
                        </div>
                        <!--add-->
                        <div class="row">
                            <div class="col-4">
                                <asp:Button ID="Button4" class="btn btn-lg btn-block btn-success" runat="server" Text="Add" OnClick="Button4_Click" />
                            </div>
                            <!--Update -->
                            
                            <div class="col-4">
                                <asp:Button ID="Button5" class="btn btn-lg btn-block btn-primary" runat="server" Text="Update"  OnClick="Button5_Click"/>
                            </div>

                             <!--Delete -->
                               
                                <div class="col-4">
                                <asp:Button ID="Button6" class="btn btn-lg btn-block btn-danger" runat="server" Text="Delete" OnClick="Button6_Click" />
                            </div>

                        </div>
                    </div>
                </div>
                <a href="employerprofile.aspx">&lt;&lt; Back</a><br><br>
            </div>
            <div class="col-md-7">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Events List</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col" >
                                <hr>
                            </div>
                        </div>
                        <div class="row">
                          <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:studentEdgeConnect1DBConnectionString %>" SelectCommand="SELECT * FROM [events_table]"></asp:SqlDataSource>
                            <div class="col">
                              
                                <asp:GridView class="table table-striped table-bordered" ID="GridView2" runat="server" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames="EventID" DataSourceID="SqlDataSource2" >
                                    <Columns>
                                        <asp:BoundField DataField="EventID" HeaderText="EventID" ReadOnly="True" SortExpression="EventID" />
                                        <asp:BoundField DataField="EventName" HeaderText="EventName" SortExpression="EventName" />
                                        <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                                        <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                                        <asp:BoundField DataField="Time" HeaderText="Time" SortExpression="Time" />
                                        <asp:BoundField DataField="BuildingNo" HeaderText="BuildingNo" SortExpression="BuildingNo" />
                                        <asp:BoundField DataField="BuildingName" HeaderText="BuildingName" SortExpression="BuildingName" />
                                        <asp:BoundField DataField="StreetName" HeaderText="StreetName" SortExpression="StreetName" />
                                        <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                                        <asp:BoundField DataField="ZipCode" HeaderText="ZipCode" SortExpression="ZipCode" />
                                        
                                    </Columns>
                                </asp:GridView>
                            </div>
                            
                        </div>
                    </div>
                </div>
            </div>
        </div>
        </div>
              
            </div>

        </div>
    </div>
    


</asp:Content>