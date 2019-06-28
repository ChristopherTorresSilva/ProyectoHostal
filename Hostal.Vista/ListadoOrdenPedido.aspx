<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListadoOrdenPedido.aspx.cs" Inherits="Hostal.Vista.ListadoOrdenPedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group col-lg-12">
        <h3>ORDENES DE PEDIDO</h3>
    </div>
    <asp:GridView ID="gridUser" runat="server" CssClass="table table-bordered bs-table" Width="100%" OnSelectedIndexChanged="gridUser_SelectedIndexChanged"
        AutoGenerateColumns="False">
        <Columns>

            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ORDEN_PEDIDO.ID" ItemStyle-Width="50px" ItemStyle-Wrap="true">
                <%--  <ControlStyle Width="100px" />--%>
                <ItemStyle Wrap="True" Width="50px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="CANTIDAD" HeaderText="CANTIDAD" ReadOnly="True" SortExpression="ORDEN_PEDIDO.CANTIDAD" ItemStyle-Width="50px" ItemStyle-Wrap="true">
                <%--  <ControlStyle Width="100px" />--%>
                <ItemStyle Wrap="True" Width="50px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="TOTAL" HeaderText="PRECIO TOTAL" ReadOnly="True" SortExpression="ORDEN_PEDIDO.TOTAL" ItemStyle-Width="50px" ItemStyle-Wrap="true">
                <%--  <ControlStyle Width="100px" />--%>
                <ItemStyle Wrap="True" Width="50px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="NOMBRE" HeaderText="NOMBRE PRODUCTO" ReadOnly="True" SortExpression="PRODUCTO.NOMBRE" ItemStyle-Width="50px" ItemStyle-Wrap="true">
                <%--  <ControlStyle Width="100px" />--%>
                <ItemStyle Wrap="True" Width="50px"></ItemStyle>
            </asp:BoundField>

        </Columns>
    </asp:GridView>
</asp:Content>
