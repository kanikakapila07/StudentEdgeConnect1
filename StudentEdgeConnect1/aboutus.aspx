<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="aboutus.aspx.cs" Inherits="StudentEdgeConnect1.aboutus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<style>
        /* Styles for the About Us page */
        body {
            background-color:#d8bced; /* Lavender background */
            color: black; /* Black text */
            font-family: s'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
           
        }

        h1 {
            color:black;
            text-align: center;
            font-weight: bold; 
            font-size:3em;
            margin-top:50px;
            
        }

        .content {
            font-style:normal;
           
            font-size:large;
            margin-left:210px;
            margin-right:210px;
            margin-top:100px;
            margin-bottom:150px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Content for the About Us page -->
    <h1 >About Us</h1>
    <div class="content" >
        <p> 
            Student Edge Connect is a specialized job portal designed exclusively for university students and recent graduates,
            aimed at bridging the gap between eager, fresh talent and forward-thinking employers. This platform offers a tailored
            space where students can showcase their skills, explore entry-level positions aligned with their preferences, and connect
            directly with employers seeking young, aspiring professionals. With personalized job matching, networking opportunities,
            and skill enhancement options, Student Edge Connect simplifies the job search process and facilitates meaningful connections,
            empowering students to kickstart their careers and aiding employers in discovering promising, enthusiastic
            talent.
            
        </p>
    </div>

</asp:Content>
