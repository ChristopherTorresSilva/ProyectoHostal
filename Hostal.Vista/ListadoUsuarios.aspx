<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListadoUsuarios.aspx.cs" Inherits="Hostal.Vista.ListadoUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="gridUser" runat="server" CssClass="table table-bordered bs-table" Width="100%" OnSelectedIndexChanged="gridUser_SelectedIndexChanged"
        AutoGenerateColumns="False">
        <Columns>

            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" ItemStyle-Width="50px" ItemStyle-Wrap="true">
                <%--  <ControlStyle Width="100px" />--%>
                <ItemStyle Wrap="True" Width="50px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="USERNAME" HeaderText="NOMBRE DE USUARIO" ReadOnly="True" SortExpression="USERNAME" ItemStyle-Width="50px" ItemStyle-Wrap="true">
                <%--  <ControlStyle Width="100px" />--%>
                <ItemStyle Wrap="True" Width="50px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="NOMBRE" HeaderText="PERFIL" ReadOnly="True" SortExpression="PERFIL" ItemStyle-Width="50px" ItemStyle-Wrap="true">
                <%--  <ControlStyle Width="100px" />--%>
                <ItemStyle Wrap="True" Width="50px"></ItemStyle>
            </asp:BoundField>

        </Columns>
    </asp:GridView>
</asp:Content>
