<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="employerlogin.aspx.cs" Inherits="StudentEdgeConnect1.employerlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto"> 
                <div class="card">
                    <div class="card-body text-center">
                        <div>
                            <img style="width: 50px; margin-bottom: 10px;" src="images/adminlogin.jpg" />
                        </div>
                        <h3>
                            Employer Login
                        </h3>
                        <hr>
                        <div class="row">
                            <div class="col">
                                <asp:Panel runat="server" ID="LoginPanel">
                                    <!--Employer username-->
                                    <div class="form-group row">
                                        <label for="TextBox1" class="col-sm-4 col-form-label text-left">Enter your username:</label>
                                        <div class="col-sm-8">
                                            <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Username"></asp:TextBox>
                                        </div>
                                    </div> 
                                    <!--Employer password-->
                                    <div class="form-group row">
                                        <label for="TextBox2" class="col-sm-4 col-form-label text-left">Enter your password:</label>
                                        <div class="col-sm-8">
                                            <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                                        </div>
                                    </div>
                                    <!--Login button-->
                                    <div class="form-group">
                                        <asp:Button class="btn btn-success btn-block" ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                                    </div>  
                                    <!--SignUp button-->
                                    <div class="form-group">
                                        <a href="signup.aspx">
                                            <input class="btn btn-info btn-block" id="Button2" type="button" value="Sign Up" />
                                        </a>
                                    </div> 
                                </asp:Panel>
                            </div>
                        </div>
                    </div>
                </div>

                <a href="homepage.aspx"><< Back to Home</a><br > <br >
            </div>
        </div>
    </div>
</asp:Content>
