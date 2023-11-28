<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="initialsignup.aspx.cs" Inherits="StudentEdgeConnect1.initialsignup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        /* Container styles */
        .container {
            text-align: center;
            margin-top: 50px;
        }
        
        /* Image styles */
        .header-image {
            max-width: 100%;
            height: auto;
            margin-bottom: 20px;
        }
        
        /* Button styles */
        .blue-btn {
            background-color: #007bff; /* Blue color */
            color: white;
            display: block;
            width: 100%;
            padding: 10px;
            font-size: 18px;
            border: none;
            border-radius: 5px;
            margin-bottom: 10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
       
        <!-- Buttons within the container -->
        <asp:Button class="blue-btn" ID="btnSignUpStudent" runat="server" Text="Sign Up as Student" OnClick="btnSignUpStudent_Click" />
        <asp:Button class="blue-btn" ID="btnSignUpEmployer" runat="server" Text="Sign Up as Employer" OnClick="btnSignUpEmployer_Click" />
    </div>
</asp:Content>
