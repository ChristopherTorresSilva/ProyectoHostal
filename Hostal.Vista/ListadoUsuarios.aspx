<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListadoUsuarios.aspx.cs" Inherits="Hostal.Vista.ListadoUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="gridUser" runat="server" CssClass="table table-bordered bs-table" Width="100%" OnSelectedIndexChanged="gridUser_SelectedIndexChanged"
        AutoGenerateColumns="False" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4">
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
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <SortedAscendingCellStyle BackColor="#FEFCEB" />
        <SortedAscendingHeaderStyle BackColor="#AF0101" />
        <SortedDescendingCellStyle BackColor="#F6F0C0" />
        <SortedDescendingHeaderStyle BackColor="#7E0000" />
    </asp:GridView>
</asp:Content>
