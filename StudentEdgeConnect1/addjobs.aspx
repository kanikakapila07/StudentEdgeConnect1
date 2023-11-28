<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="addjobs.aspx.cs" Inherits="StudentEdgeConnect1.addjobs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script type="text/javascript">
        $(document).ready(function (){
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
            //$('.table1').DataTable();

        });


    </script>
    <script>
    $(document).ready(function() {
    $('.table').parent().css('overflow-x', 'auto');
    $('.table').parent().css('width', '100%'); 

    $('.table').css('width', '100px'); 
    
    $('.table').prepend($('<thead></thead>').append($(this).find('tr:first'))).dataTable();
    });
    </script>
     
  
    

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <div class="container">
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
                                        <asp:ListItem Text="High School" Value="Full-time"></asp:ListItem>
                                        <asp:ListItem Text="Bachelors" Value="Part-time"></asp:ListItem>
                                        <asp:ListItem Text="Masters" Value="Contract"></asp:ListItem>
                                        <asp:ListItem Text="PhD" Value="Freelance"></asp:ListItem>
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
                                <label>Pay Range</label>
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
            <div class="col-md-7">
                <div class="card">
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
                              
                                <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames="JobID" DataSourceID="SqlDataSource1" >
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

</asp:Content>
