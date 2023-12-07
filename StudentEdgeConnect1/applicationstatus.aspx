<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="applicationstatus.aspx.cs" Inherits="StudentEdgeConnect1.applicationstatus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <div class="container">
        <h2>Applications Status</h2>
       
        
   
                 <div class="col-md-7">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Application Status</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col" >
                                <hr>
                            </div>
                        </div>
                        
                        <div class="row">

                          <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:studentEdgeConnect1DBConnectionString %>" SelectCommand="SELECT s.JobID, s.StudentID, COALESCE(s.ApplicationStatus, 'Pending') AS ApplicationStatus 
                          FROM Status s INNER JOIN appliedjobs_table a ON s.StudentID = a.StudentID;">
                              <SelectParameters>
        <asp:Parameter Name="StudentID" Type="String" DefaultValue="" />
    </SelectParameters>
</asp:SqlDataSource>
                         
    

                            

                            <div class="col">
                              
                                <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames="StudentID" DataSourceID="SqlDataSource3" >
                                    <Columns>
                                       
                                        <asp:BoundField DataField="JobID" HeaderText="JobID" SortExpression="JobID" />
                                        
                                        <asp:BoundField DataField="StudentID" HeaderText="StudentID" SortExpression="StudentID" />
                                          
                                        <asp:BoundField DataField="ApplicationStatus" HeaderText="ApplicationStatus" SortExpression="ApplicationStatus" NullDisplayText="Pending" />
                                        
                                        
                                    </Columns>
                                </asp:GridView>
                            </div>
                            
                        </div>
                    </div>
                </div>
            </div>
        </div>
        

                              
</asp:Content>
