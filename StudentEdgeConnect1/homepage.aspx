<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="StudentEdgeConnect1.homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Your content -->
    <section style="height: 120vh; background-image: url('images/studentedgeconnecthome.png'); background-size: cover; background-position: center; position: relative;">
        <div style="position: absolute; top: 60%; left: 50%; transform: translate(-50%, -50%); color:#e0b0ff; font-size: 2em; font-style:italic; font-weight: bold; text-align: center;">
            What We Offer
        </div>
        <div style="position: absolute; top: 73%; left: 50%; transform: translateX(-50%); width: 80%; text-align: center; z-index: 0; display: flex; justify-content: space-around;">
            <!-- Jobs -->
            <div style="display: inline-block; text-align: center; margin-top: -15px;">
                <img src="images/jobs.png" text="Search Jobs" style="width: 100px; height: 100px; " />
                <div style=" font-style: italic; color:#e0b0ff;">Search Jobs</div>
            </div>

            <!-- Networking events -->
            <div style="display: inline-block; text-align: center; margin-top: -15px;">
                <img src="images/networking.jpg" text="Build Connections" style="width: 100px; height: 100px; " />
                <div style="font-style: italic; color: #e0b0ff;">Build Connections</div>
            </div>

            <!-- Certifications -->
            <div style="display: inline-block; text-align: center; margin-top: -15px;">
                <img src="images/certificate.jpg" text="Learn New Skills" style="width: 100px; height: 100px; " />
                <div style="font-style: italic; color: #e0b0ff;">Learn New Skills</div>
            </div>
        </div>
    </section>
</asp:Content>
