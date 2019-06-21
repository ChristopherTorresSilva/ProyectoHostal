<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroOrdenPedido.aspx.cs" Inherits="Hostal.Vista.RegistroOrdenPedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group col-lg-12">
        <div class="form-group">
            </br></br></br></br>
            <h1>ORDEN DE PEDIDO</h1>

            <%--EMPLEADO--%>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="dropEmpleado" CssClass="col-md-2 control-label">Empleado</asp:Label>
                    <div class="col-md-10">
                        <asp:DropDownList ID="dropEmpleado" runat="server" CssClass="form-control " OnSelectedIndexChanged="dropEmpleado_SelectedIndexChanged" AutoPostBack="True">
                        </asp:DropDownList>
                    </div>
                </div>
            </div>

            <%--PROVEEDOR--%>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="dropProveedor" CssClass="col-md-2 control-label">Proveedor</asp:Label>
                    <div class="col-md-10">
                        <asp:DropDownList ID="dropProveedor" runat="server" CssClass="form-control " OnSelectedIndexChanged="dropProveedor_SelectedIndexChanged" AutoPostBack="True">
                        </asp:DropDownList>
                    </div>
                </div>
            </div>

            <%--PRODUCTO--%>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="dropProducto" CssClass="col-md-2 control-label">Producto</asp:Label>
                    <div class="col-md-10">
                        <asp:DropDownList ID="dropProducto" runat="server" CssClass="form-control " OnSelectedIndexChanged="dropProducto_SelectedIndexChanged" AutoPostBack="True">
                        </asp:DropDownList>
                    </div>
                </div>
            </div>

            <%--CANTIDAD--%>
            <%--                <div class="form-horizontal">
                    <div class="form-group">
                        <asp:Label runat="server" CssClass="col-md-2 control-label">Cantidad</asp:Label>
                        <div class="col-md-10">
                           <input ID="inCantidad" type="number" OnSelectedIndexChanged="inCantidad_SelectedIndexChanged" CssClass="form-control " runat="server" min="1"/>
                        </div>
                    </div>
                </div>--%>

            <%--CANTIDAD--%>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" CssClass="col-md-2 control-label">Cantidad</asp:Label>
                    <div class="col-md-10">
                        <asp:DropDownList ID="dropCantidad" AutoPostBack="True" CssClass="form-control " OnSelectedIndexChanged="dropCantidad_Selection_Change" runat="server">
                            <asp:ListItem Selected="True" Value="1"> 1 </asp:ListItem>
                            <asp:ListItem Value="2">2</asp:ListItem>
                            <asp:ListItem Value="3">3</asp:ListItem>
                            <asp:ListItem Value="4">4</asp:ListItem>
                            <asp:ListItem Value="5">5</asp:ListItem>
                            <asp:ListItem Value="6">6</asp:ListItem>
                            <asp:ListItem Value="7">7</asp:ListItem>
                            <asp:ListItem Value="8">8</asp:ListItem>
                            <asp:ListItem Value="9">9</asp:ListItem>
                            <asp:ListItem Value="10">10</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
            </div>

            <%--TOTAL--%>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="txtTotal" CssClass="col-md-2 control-label">Total</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox ID="txtTotal" CssClass="form-control " runat="server" Enabled="False" />
                    </div>
                </div>
            </div>

             <%--MENSAJE ERROR--%>
                <asp:Label runat="server" CssClass="text-danger" ID="lblErrorMsg"></asp:Label>

            <%--BOTON--%>
            <div class="col-md-offset-2 col-md-10">
                <asp:Button class="btn btn-w-m btn-danger" runat="server" ID="btnCrearOrden" Text="Registrar Orden" OnClick="btnCrearOrden_Click" />
            </div>

        </div>
    </div>

    <script>

</script>
</asp:Content>
