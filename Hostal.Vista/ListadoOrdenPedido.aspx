<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListadoOrdenPedido.aspx.cs" Inherits="Hostal.Vista.ListadoOrdenPedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group col-lg-12">
        <h3>ORDENES DE PEDIDO</h3>
    </div>
    <asp:GridView ID="gridUser" runat="server" CssClass="table table-bordered bs-table" Width="100%" OnSelectedIndexChanged="gridUser_SelectedIndexChanged"
        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>

            <asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ORDEN_PEDIDO.ID" ItemStyle-Width="50px" ItemStyle-Wrap="true">
                <%--  <ControlStyle Width="100px" />--%>
                <ItemStyle Wrap="True" Width="50px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="CANTIDAD" HeaderText="CANTIDAD" ReadOnly="True" SortExpression="ORDEN_PEDIDO.CANTIDAD" ItemStyle-Width="50px" ItemStyle-Wrap="true">
                <%--  <ControlStyle Width="100px" />--%>
                <ItemStyle Wrap="True" Width="50px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="PRODUCTO" HeaderText="NOMBRE PRODUCTO" ReadOnly="True" SortExpression="ORDEN_PEDIDO.PRODUCTO" ItemStyle-Width="50px" ItemStyle-Wrap="true">
                <%--  <ControlStyle Width="100px" />--%>
                <ItemStyle Wrap="True" Width="50px"></ItemStyle>
            </asp:BoundField>

        </Columns>
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
    </asp:GridView>
</asp:Content>
