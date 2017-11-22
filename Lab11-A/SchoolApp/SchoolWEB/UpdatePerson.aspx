<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdatePerson.aspx.cs" Inherits="SchoolWEB.UpdatePerson" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="PersonID"></asp:Label><asp:TextBox ID="txtPersonID" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label><asp:TextBox ID="txtLastName" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label3" runat="server" Text="First Name"></asp:Label><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label4" runat="server" Text="Hire Date"></asp:Label><asp:TextBox ID="txtHireDate" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label5" runat="server" Text="Enrollment Date"></asp:Label><asp:TextBox ID="txtEnrollmentDate" runat="server"></asp:TextBox><br />
    <asp:Button ID="Button1" runat="server" Text="Guardar" OnClick="Button1_Click" /><br />
    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Regresar</asp:LinkButton>
</asp:Content>
