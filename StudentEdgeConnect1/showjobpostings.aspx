<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="showjobpostings.aspx.cs" Inherits="StudentEdgeConnect1.applyjobs_enterinfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
      $(document).ready(function () {
          $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
      });
    </script>
     <script>
         $(document).ready(function () {
             $('.table').parent().css('overflow-x', 'auto');
             $('.table').parent().css('width', '100%');

             $('.table').css('width', '100px');

             $('.table').prepend($('<thead></thead>').append($(this).find('tr:first'))).dataTable();
         });
     </script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--this page shows list of posted jobs by employer--> 
      
    <div class="container">
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
 </asp:Content>
