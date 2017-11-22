<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SchoolWEB._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="gvListado" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gvListado_SelectedIndexChanged"></asp:GridView>
    <asp:LinkButton ID="InkNuevo" runat="server" OnClick="InkNuevo_Click">Nuevo</asp:LinkButton>
</asp:Content>
