<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="applicationstatus.aspx.cs" Inherits="StudentEdgeConnect1.applicationstatus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

 <div class="container">
        <h2>Applications Status</h2>
       
        <asp:GridView ID="GridViewApplications" runat="server">
          
            <Columns>
                <asp:BoundField DataField="ApplicantName" HeaderText="Applicant Name" />
                <asp:BoundField DataField="ApplicantName" HeaderText="Applicant Name" />
                <asp:BoundField DataField="ApplicationDate" HeaderText="Application Date" />
                <asp:BoundField DataField="Status" HeaderText="Status" />
                <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>
                        <!-- Add buttons for accepting/rejecting applications -->
                        <asp:Button runat="server" ID="AcceptButton" Text="Accept"  />
                        <asp:Button runat="server" ID="RejectButton" Text="Reject" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
