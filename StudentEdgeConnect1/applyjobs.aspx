<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="applyjobs.aspx.cs" Inherits="StudentEdgeConnect1.applyjobs" %>
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
    <!--goes to this page after clicking apply on show job postings and adds following info-->

       <div class="scroll-container">
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Apply Jobs</h4>
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
                                        <asp:TextBox CssClass="form-control" ID="TextBox51" runat="server" placeholder="JobID" ></asp:TextBox>
                                        
                                    </div>
                                </div>
                            </div>
                              <!--Job Position-->
                            <div class="col-md-8">
                                <label>Job Position</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox52" runat="server" placeholder="JobPosition"  ></asp:TextBox>
                                </div>
                            </div>
                            <!--company-->
                             <div class="col-md-8">
                                <label>Company</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server"  placeholder="Company"></asp:TextBox>
                                </div>
                            </div>
                              <!--location-->
                             <div class="col-md-8">
                                <label>CompanyLocation</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="CompanyLocation"></asp:TextBox>
                                </div>
                            </div>
                             <!--Education Level-->
                            <div class="col-md-8">
                                <label>Education Levels</label>
                                <div class="form-group">
                                    <asp:DropDownList CssClass="form-control" ID="DropDownList53" runat="server" placeholder="EducationLevel">
                                        <asp:ListItem Text="--Select--" Value=""></asp:ListItem>
                                        <asp:ListItem Text="High School" Value="High School"></asp:ListItem>
                                        <asp:ListItem Text="Bachelors" Value="Bachelors"></asp:ListItem>
                                        <asp:ListItem Text="Masters" Value="Masters"></asp:ListItem>
                                        <asp:ListItem Text="PhD" Value="PhD"></asp:ListItem>
                                     </asp:DropDownList>
                                </div>
                            </div>

                          

                          
                              <!--University Name-->
                              <div class="col-md-8">
                                <label>University Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox54" runat="server" placeholder="UniversityName"></asp:TextBox>
                                </div>
                            </div>
                             <!--Graduation Date-->
                              <div class="col-md-8">
                                <label>Graduation Date</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox55" runat="server" type="date" placeholder="GraduationDate"></asp:TextBox>
                                </div>
                            </div>
                            
                               <!--sTUDENT ID-->
                              <div class="col-md-8">
                                <label>Student ID</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server"  placeholder="StudentID"></asp:TextBox>
                                </div>
                            </div>
                             
                            
                              
                          
                        </div>
                        <!--apply-->
                        <div class="row">
                            <div class="col-4">
                                <asp:Button ID="Button2" class="btn btn-lg btn-block btn-success" runat="server" Text="Apply" OnClick="Button2_Click" />
                            </div>
                           
                        </div>
                    </div>
                </div>
                <a href="showjobpostings.aspx">&lt;&lt; Bac</a><br><br>
            </div>
            <div class="col-md-7" >
                <div class="card" >
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Applied Jobs List</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col" >
                                <hr>
                            </div>
                        </div>
                        <div class="row">
                          <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:studentEdgeConnect1DBConnectionString %>" SelectCommand="SELECT * FROM [appliedjobs_table]">

                        </asp:SqlDataSource>
                            <div class="col">
                              
                                <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False"  DataKeyNames="StudentID" DataSourceID="SqlDataSource" >
                                    <Columns>
                                        <asp:BoundField DataField="JobID" HeaderText="JobID" ReadOnly="true" SortExpression="JobID" />
                                        <asp:BoundField DataField="JobPosition" HeaderText="JobPosition" SortExpression="JobPosition" />
                                         <asp:BoundField DataField="Company" HeaderText="Company" SortExpression="Company" />
                                         <asp:BoundField DataField="CompanyLocation" HeaderText="CompanyLocation" SortExpression="CompanyLocation" />

                                        <asp:BoundField DataField="EducationLevel" HeaderText="EducationLevel" SortExpression="EducationLevel" />
                                        <asp:BoundField DataField="UniversityName" HeaderText="UniversityName" SortExpression="UniversityName" />
                                     
                                        <asp:BoundField DataField="GraduationDate" HeaderText="GraduationDate" SortExpression="GraduationDate" />
                                        <asp:BoundField DataField="StudentID" HeaderText="StudentID" SortExpression="StudentID" />
                                       
                                        
                                        
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
