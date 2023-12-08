<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="studentprofile.aspx.cs" Inherits="StudentEdgeConnect1.studentprofile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
       
        .nav-tabs .nav-link {
            color: black;
        }
       
        .nav-tabs .nav-item.show .nav-link, .nav-tabs .nav-link.active {
            color: black;
            background-color: lavender;
            border-color: black;
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
                <a class="nav-link" data-toggle="tab" href="#apply-jobs" role="tab">Apply Jobs</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" data-toggle="tab" href="#view-application-status" role="tab">View Application Status</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" data-toggle="tab" href="#registered-events" role="tab">View Networking Events</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" data-toggle="tab" href="#certifications" role="tab">View Certifications</a>
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
                                        Text="Student"></asp:Label>
                   
                                        <hr>
                                        
                                <div class="row">
                        <div class="col">
                            <form>
                                <div class="form-group row">
                                    <label for="fname" class="col-sm-4 col-form-label text-left">First Name:</label>
                                    <div class="col-sm-8">
                                        <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"  placeholder="fname"></asp:TextBox>
                                </div>
                                </div> 
                                <div class="form-group row">
                                    <label for="mname" class="col-sm-4 col-form-label text-left">Middle Name:</label>
                                    <div class="col-sm-8">
                                        <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"  placeholder="mname"></asp:TextBox>
                                </div>
                                </div>
                                <div class="form-group row">
                                    <label for="lname" class="col-sm-4 col-form-label text-left">Last Name:</label>
                                    <div class="col-sm-8">
                                         <asp:TextBox ID="TextBox7" runat="server" CssClass="form-control"  placeholder="lname"></asp:TextBox>
                                </div>
                                </div>
                                
                                <!-- Birthdate -->
                                <div class="form-group row">
                                    <label for="birthdate" class="col-sm-4 col-form-label text-left">Birthdate:</label>
                                    <div class="col-sm-4">
                                    <asp:TextBox ID="TextBox9" runat="server" CssClass="form-control"  TextMode="Date" placeholder="birthDate"></asp:TextBox>
                                </div>
                                    </div>
                              
                                <!--SSN-->
                                <div class="form-group row">
                                    <label for="ssn" class="col-sm-4 col-form-label text-left">Social Security Number:</label>
                                    <div class="col-sm-8">
                                       <asp:TextBox ID="TextBox13" runat="server" CssClass="form-control" TextMode="Number" placeholder="SSN" required="required"></asp:TextBox>
                                </div>
                                </div>  
                                <!-- Email ID -->
                                <div class="form-group row">
                                    <label for="email" class="col-sm-4 col-form-label text-left">Email ID:</label>
                                    <div class="col-sm-8">
                                        <asp:TextBox ID="TextBox14" runat="server" CssClass="form-control" TextMode="Email" placeholder="Email"></asp:TextBox>
                                </div>
                                </div>
                                <!-- Phone number -->
                                <div class="form-group row">
                                    <label for="phone" class="col-sm-4 col-form-label text-left">Phone Number:</label>
                                    <div class="col-sm-8">
                                        <asp:TextBox ID="TextBox15" runat="server" CssClass="form-control" TextMode="Phone" placeholder="Phoneno"></asp:TextBox>
                                </div>
                                </div>
                                <!-- Education Level -->
                                <div class="form-group row">
                                    <label for="zip" class="col-sm-4 col-form-label text-left">Education Level:</label>
                                    <div class="col-sm-8">
                                       <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"  placeholder="EducationLevel"></asp:TextBox>
                                </div>
                                </div>
                                <!-- University Name -->
                                <div class="form-group row">
                                    <label for="zip" class="col-sm-4 col-form-label text-left">University Name:</label>
                                    <div class="col-sm-8">
                                       <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"  placeholder="UniversityName"></asp:TextBox>
                                </div>
                                </div>
                                <!-- Graduation Date -->
                                <div class="form-group row">
                                    <label for="zip" class="col-sm-4 col-form-label text-left">Graduation Date:</label>
                                    <div class="col-sm-8">
                                       <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" TextMode="Date"  placeholder="GraduationDate"></asp:TextBox>
                                </div>
                                </div>
                                <!-- City -->
                                <div class="form-group row">
                                    <label for="city" class="col-sm-4 col-form-label text-left">City:</label>
                                    <div class="col-sm-8">
                                        <asp:TextBox ID="TextBox16" runat="server" CssClass="form-control"  placeholder="City"></asp:TextBox>
                                </div>
                                </div>
                                <!-- State -->
                                <div class="form-group row">
                                    <label for="state" class="col-sm-4 col-form-label text-left">State:</label>
                                    <div class="col-sm-8">
                                         <asp:TextBox ID="TextBox17" runat="server" CssClass="form-control"  placeholder="State"></asp:TextBox>
                                </div>
                                </div>
                                <!-- Country -->
                                <div class="form-group row">
                                    <label for="country" class="col-sm-4 col-form-label text-left">Country:</label>
                                    <div class="col-sm-8">
                                        <asp:TextBox ID="TextBox18" runat="server" CssClass="form-control"  placeholder="Country"></asp:TextBox>
                                </div>
                                </div>
                                <!-- ZIP Code -->
                                <div class="form-group row">
                                    <label for="zip" class="col-sm-4 col-form-label text-left">ZIP Code:</label>
                                    <div class="col-sm-8">
                                       <asp:TextBox ID="TextBox19" runat="server" CssClass="form-control"  placeholder="ZipCode"></asp:TextBox>
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
                                       <asp:TextBox ID="TextBox20" runat="server" CssClass="form-control"  placeholder="username"></asp:TextBox>
                                </div>
                                </div>
                                <!--oldpassword-->
                                <div class="form-group row">
                                    <label for="oldpassword" class="col-sm-4 col-form-label text-left">Old Password:</label>
                                    <div class="col-sm-8">
                                        <asp:TextBox ID="TextBox42" runat="server" CssClass="form-control" TextMode="Password" placeholder="Old Password" ReadOnly="true"></asp:TextBox>
                                </div>
                                </div>
                                <!--newpassword-->
                                 <div class="form-group row">
                                     <label for="newpassword" class="col-sm-4 col-form-label text-left">New Password:</label>
                                        <div class="col-sm-8">
                                 <asp:TextBox ID="TextBox43" runat="server" CssClass="form-control" TextMode="Password" placeholder="New Password"></asp:TextBox>
                                </div>
                            </div>


                              
                                <div class="form-group">
                                        <asp:Button class="btn btn-success btn-block" ID="Button8" runat="server" Text="Update" OnClick="Button8_Click" />
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
                 <div class="tab-pane fade" id="apply-jobs" role="tabpanel">
                        <!-- Content for Apply Jobs Tab -->
                       <div class="scroll-container" style="overflow-x: auto;">
                        <div class="card">
                            <div class="card-body">
                                <div class="row">
                                    <div class="col-md-12">
                                        <h4>Jobs List</h4>
                                        <hr />
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-12">
                                        <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:studentEdgeConnect1DBConnectionString %>" SelectCommand="SELECT * FROM [jobs_table]"></asp:SqlDataSource>
                                        <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames="JobID" DataSourceID="SqlDataSource">
                                            <Columns>
                                

                                              <asp:BoundField DataField="JobID" HeaderText="JobID" SortExpression="JobID" />
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
                                            <asp:TemplateField HeaderText="Apply">
                                            <ItemTemplate>
                                            <asp:LinkButton ID=Button11 runat="server" Text="Apply" OnClick="Button11_Click"  />
                                            </ItemTemplate>
                                            </asp:TemplateField>
                                            </Columns>
                                        </asp:GridView>
                                    </div>
                                    </div>
                                    <div class="row mt-3">
                                        <div class="col-md-12">
                                        <a href="studentprofile.aspx">&lt;&lt;<< Back to previous page</a><br /><br />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                 </div>      

              <div class="tab-pane fade" id="view-application-status" role="tabpanel">
                 <!-- Content for View Application Tab -->
                
              
               <div class="scroll-container">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col-md-12">
                                <h4>View Application Status</h4>
                                <hr />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12">
                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:studentEdgeConnect1DBConnectionString %>" SelectCommand="SELECT * FROM [Status] WHERE StudentID = @StudentID">
                                <SelectParameters>
                                    <asp:Parameter Name="StudentID" Type="String" DefaultValue="" />
                                </SelectParameters>
                                </asp:SqlDataSource>
                       
                                <asp:GridView class="table table-striped table-bordered" ID="GridView3" runat="server" OnSelectedIndexChanged="GridView3_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames="JobID" >
                                <Columns>
                             
                                <asp:BoundField DataField="JobID" HeaderText="JobID" SortExpression="JobID" />
                                <asp:BoundField DataField="StudentID" HeaderText="StudentID" SortExpression="StudentID" />
                                <asp:BoundField DataField="ApplicationStatus" HeaderText="ApplicationStatus" SortExpression="ApplicationStatus" />
                                <asp:TemplateField HeaderText="Withdraw">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="Button16" runat="server" Text="Withdraw" OnClick="Button16_Click" />
                                    </ItemTemplate>
                                 </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
                <div class="row mt-3">
                    <div class="col-md-12">
                        <a href="studentprofile.aspx">&lt;&lt;<< Back to previous page</a><br /><br />
                        </div>
                    </div>
                </div>
            </div>
        </div>
     </div>
              <div class="tab-pane fade" id="registered-events" role="tabpanel">
                            <!-- Content for Registered Networking Events Tab -->
                        <div class="scroll container">
                        <div class="card">
                            <div class="card-body">
                                <div class="row">
                                    <div class="col-md-12">
                                        <h4>Events List</h4>
                                        <hr />
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-12">
                                        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:studentEdgeConnect1DBConnectionString %>" SelectCommand="SELECT * FROM [events_table]"></asp:SqlDataSource>
                                        <asp:GridView class="table table-striped table-bordered" ID="GridView2" runat="server" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames="EventID" DataSourceID="SqlDataSource3">
                                         <Columns>

                                              <asp:BoundField DataField="EventID" HeaderText="EventID" SortExpression="EventID" />
                                              <asp:BoundField DataField="EventName" HeaderText="EventName" SortExpression="EventName" />
                                              <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                                              <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                                              <asp:BoundField DataField="Time" HeaderText="Time" SortExpression="Time" />
                                              <asp:BoundField DataField="BuildingNo" HeaderText="BuildingNo" SortExpression="BuildingNo"/>
                                              <asp:BoundField DataField="BuildingName" HeaderText="BuildingName" SortExpression="BuildingName" />
                                              <asp:BoundField DataField="StreetName" HeaderText="StreetName" SortExpression="StreetName" />
                                              <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                                              <asp:BoundField DataField="ZipCode" HeaderText="ZipCode" SortExpression="ZipCode" />
                                              <asp:TemplateField HeaderText="Register">
                                                <ItemTemplate>
                                                    <asp:LinkButton ID=Button17 runat="server" Text="Register" OnClick="Button17_Click"  />
                                               </ItemTemplate>
                                                 </asp:TemplateField>
                                            </Columns>
                                        </asp:GridView>
                                    </div>
                                </div>
                                <div class="row mt-3">
                                    <div class="col-md-12">
                                        <a href="studentprofile.aspx">&lt;&lt;<< Back to previous page</a><br /><br />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                
                </div>
            <div class="tab-pane fade" id="certifications" role="tabpanel">
                <!-- Content for Certifications Completed Tab -->
                 <div class="container">
                    <div class="row">
                        <div class="col-md-5">
                            <div class="card">
                                <div class="card-body">
                                    <div class="row">
                                        <div class="col">
                                            <center>
                                                <h4>Add Links</h4>
                                            </center>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col">
                                            <center>
                                                <img width="100px" src="images/certification.jpg" />
                                            </center>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col">
                                            <hr>
                                        </div>
                                    </div>
                                    <!-- Certification Link -->
                                    <div class="row">
                                        <div class="col-md-12">
                                            <label>Link</label>
                                            <div class="form-group">
                                                <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="Link"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- Add Button -->
                                    <div class="row">
                                        <div class="col-md-12">
                                            <asp:Button ID="Button2" CssClass="btn btn-success btn-block" runat="server" Text="Add" OnClick="Button2_Click" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <br />
                            <a href="studentprofile.aspx">&lt;&lt;<< Back to previous page</a><br /><br />
                        </div>
                        <div class="col-md-7">
                            <div class="card">
                                <div class="card-body">
                                    <div class="row">
                                        <div class="col">
                                            <center>
                                                <h4>Certifications List</h4>
                                            </center>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col">
                                            <hr>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:studentEdgeConnect1DBConnectionString %>" SelectCommand="SELECT * FROM [certifications]"></asp:SqlDataSource>
                                        <div class="col">
                                            <asp:GridView class="table table-striped table-bordered" ID="GridView6" runat="server" OnSelectedIndexChanged="GridView6_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames="Link" DataSourceID="SqlDataSource1">
                                                <Columns>
                                                    <asp:BoundField DataField="Link" HeaderText="Link" SortExpression="Link" />
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
