<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="registerevents.aspx.cs" Inherits="StudentEdgeConnect1.registerevents" %>
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
    <!--goes to this page after clicking register for networking events--> 
       <div class="scroll-container">
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Register Events</h4>
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
                                <label>EventID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox51" runat="server" placeholder="EventID"  ></asp:TextBox>
                                        <asp:LinkButton ID="LinkButton8" class="btn btn-lg btn-block btn-primary" runat="server" text="Go" OnClick="LinkButton8_Click">
                                    <i class="fas fa-check-circle"></i> </asp:LinkButton>
                                    </div>
                                </div>
                            </div>
                              <!--EventName-->
                            <div class="col-md-8">
                                <label>EventName</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox52" runat="server" placeholder="EventName" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>
                            <!--Description -->
                             <div class="col-md-8">
                                <label>Description</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" type="date" placeholder="Description" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>
                              <!--date-->
                             <div class="col-md-8">
                                <label>Date</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" type="date" placeholder="Date" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>
                             <!--Time-->
                            <div class="col-md-8">
                                <label>Time</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" type="time" placeholder="Time" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>

                          

                          
                              <!--BuildingNo.-->
                              <div class="col-md-8">
                                <label>Building No.</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox54" runat="server" placeholder="BuildingNo" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>
                             <!--Building Name-->
                              <div class="col-md-8">
                                <label>Builing Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox55" runat="server" placeholder="BuildingName" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>
                            
                               <!--Street name-->
                              <div class="col-md-8">
                                <label>Street Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server"  placeholder="StreetName" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>
                             <div class="col-md-8">
                                <label>City</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server"  placeholder="City" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>
                              <div class="col-md-8">
                                <label>ZipCode</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server"  placeholder="ZipCode" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-8">
                                <label>Student ID</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox7" runat="server"  placeholder="StudentID"></asp:TextBox>
                                </div>
                            </div>
                            
                          
                        </div>
                        <!--register-->
                        <div class="row">
                            <div class="col-4">
                                <asp:Button ID="Button2" class="btn btn-lg btn-block btn-success" runat="server" Text="Register" OnClick="Button2_Click" />
                            </div>
                           
                        </div>
                    </div>
                </div>
                <a href="registerevents.aspx">&lt;&lt; Back</a><br><br>
            </div>
            <div class="col-md-7" >
                <div class="card" >
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Registered Events</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col" >
                                <hr>
                            </div>
                        </div>
                        <div class="row">
                          <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:studentEdgeConnect1DBConnectionString %>" SelectCommand="SELECT * FROM [registeredevents_table]">

                        </asp:SqlDataSource>
                            <div class="col">
                              
                                <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False"  DataKeyNames="EventID" DataSourceID="SqlDataSource" >
                                    <Columns>
                                        <asp:BoundField DataField="EventID" HeaderText="EventID" ReadOnly="true" SortExpression="ID" />
                                        <asp:BoundField DataField="EventName" HeaderText="EventName" SortExpression="EventName" />
                                         <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                                         <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />

                                        <asp:BoundField DataField="Time" HeaderText="Time" SortExpression="Time" />
                                        <asp:BoundField DataField="BuildingNo" HeaderText="BuildingNo" SortExpression="BuildingNo" />
                                         <asp:BoundField DataField="BuildingName" HeaderText="BuildingName" SortExpression="BuildingName" />
                                        <asp:BoundField DataField="StreetName" HeaderText="StreetName" SortExpression="StreetName" />
                                        <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                                        <asp:BoundField DataField="ZipCode" HeaderText="ZipCode" SortExpression="ZipCode" />
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
