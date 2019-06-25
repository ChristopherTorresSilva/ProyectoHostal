<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="RecepcionProducto.aspx.cs" Inherits="Hostal.Vista.RecepcionProducto" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group col-lg-12">
        <div class="form-group">
            </br></br></br></br>
            <h1>RECEPCION DE PRODUCTOS</h1>

            <%--NOMBRE DEL PRODUCTO--%>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="dropProducto" CssClass="col-md-2 control-label">Producto</asp:Label>
                    <div class="col-md-10">
                        <asp:DropDownList ID="dropProducto" runat="server" CssClass="form-control " OnSelectedIndexChanged="dropProducto_SelectedIndexChanged" AutoPostBack="True">
                        </asp:DropDownList>
                    </div>
                </div>
            </div>

            <%--PRECIO--%>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="txtPrecio" CssClass="col-md-2 control-label">Precio unitario</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox ID="txtPrecio" CssClass="form-control " runat="server" Enabled="False" />
                    </div>
                </div>
            </div>

            <%--TIPO DE PRODUCTO--%>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="dropTipoProducto" CssClass="col-md-2 control-label">Tipo de Producto</asp:Label>
                    <div class="col-md-10">
                        <asp:DropDownList ID="dropTipoProducto" runat="server" CssClass="form-control " OnSelectedIndexChanged="dropTipoProducto_SelectedIndexChanged" AutoPostBack="True">
                        </asp:DropDownList>
                    </div>
                </div>
            </div>

            <%--FAMILIA DE PRODUCTO--%>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="dropFamilia" CssClass="col-md-2 control-label">Familia de Producto</asp:Label>
                    <div class="col-md-10">
                        <asp:DropDownList ID="dropFamilia" runat="server" CssClass="form-control " OnSelectedIndexChanged="dropFamilia_SelectedIndexChanged" AutoPostBack="True">
                        </asp:DropDownList>
                    </div>
                </div>
            </div>

            <%--DESCRIPCION--%>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="txtDescripcion" CssClass="col-md-2 control-label">Descripcion</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox ID="txtDescripcion" CssClass="form-control " runat="server" Enabled="False" />
                    </div>
                </div>
            </div>

            <%--CANTIDAD--%>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="txtCantidad" CssClass="col-md-2 control-label">Cantidad de Productos</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox ID="txtCantidad" CssClass="form-control " runat="server" AutoPostBack="True" TextMode="Number" OnTextChanged="txtCantidad_TextChanged" />
                    </div>
                </div>
            </div>

            <%--STOCK--%>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="txtStock" CssClass="col-md-2 control-label">Stock</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox ID="txtStock" CssClass="form-control " runat="server" AutoPostBack="True" TextMode="Number" Enabled="False" />
                    </div>
                </div>
            </div>

            <%--STOCK CRITICO--%>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="txtStockCritico" CssClass="col-md-2 control-label">Stock Crítico</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox ID="txtStockCritico" CssClass="form-control " runat="server" AutoPostBack="True" TextMode="Number" Enabled="False" />
                    </div>
                </div>
            </div>

            <%--FECHA DE VENCIMIENTO--%>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="txtFecha" CssClass="col-md-2 control-label">Fecha de Vencimiento</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox ID="txtFecha" CssClass="form-control " runat="server" TextMode="Date" AutoPostBack="True" OnTextChanged="txtFecha_TextChanged" />
                    </div>
                </div>
            </div>

            <%--CODIGO--%>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="txtCodigo" CssClass="col-md-2 control-label">Código</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox ID="txtCodigo" CssClass="form-control " runat="server" AutoPostBack="True" />
                    </div>
                </div>
            </div>

            <%--MENSAJE ERROR--%>
            <asp:Label runat="server" CssClass="text-danger" ID="lblErrorMsg"></asp:Label>

            <%--BOTON--%>
            <div class="col-md-offset-2 col-md-10">
                <asp:Button class="btn btn-w-m btn-danger" runat="server" ID="btnCrearRecepcionProducto" Text="Registrar Productos" OnClick="btnCrearRecepcionProducto_Click" />
            </div>
        </div>
    </div>

</asp:Content>
