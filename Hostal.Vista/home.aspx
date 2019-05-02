<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Hostal.Vista.home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <asp:Label runat="server" ID="lblUSerDetails"></asp:Label>
        <asp:Button runat="server" ID="btnLogOut" Text="Cerrar Sesion" OnClick="btnLogOut_Click"/>
    </div>
</asp:Content>
