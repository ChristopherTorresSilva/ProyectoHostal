<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="RecepcionProducto.aspx.cs" Inherits="Hostal.Vista.RecepcionProducto" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <style type="text/css">
        #x
        {
                    font-family:Arial;
                    font-size: 15px;
                    color: white;
        }
    </style>
    <div id="x" class="form-group col-lg-12">
        <h3>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Recepción Productos</h3>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image1" runat="server" Height="113px" ImageUrl="~/img/recepcion.jpg" Width="717px" />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <div class="form-group">
            <%--Orden de Pedido--%>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="dropOrden" CssClass="col-md-2 control-label">Tipo de Producto</asp:Label>
                    <div class="col-md-10">
                        <asp:DropDownList ID="dropOrden" runat="server" CssClass="form-control ">
                        </asp:DropDownList>
                    </div>
                </div>
            </div>
            <%--NOMBRE DEL PRODUCTO--%>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="txtProducto" CssClass="col-md-2 control-label">Producto</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox ID="txtProducto" CssClass="form-control " runat="server" />
                    </div>
                </div>
            </div>

            <%--PRECIO--%>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="txtPrecio" CssClass="col-md-2 control-label">Precio unitario</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox ID="txtPrecio" CssClass="form-control " runat="server" />
                    </div>
                </div>
            </div>

            <%--TIPO DE PRODUCTO--%>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="dropTipoProducto" CssClass="col-md-2 control-label">Tipo de Producto</asp:Label>
                    <div class="col-md-10">
                        <asp:DropDownList ID="dropTipoProducto" runat="server" CssClass="form-control ">
                        </asp:DropDownList>
                    </div>
                </div>
            </div>

            <%--FAMILIA DE PRODUCTO--%>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="dropFamilia" CssClass="col-md-2 control-label">Familia de Producto</asp:Label>
                    <div class="col-md-10">
                        <asp:DropDownList ID="dropFamilia" runat="server" CssClass="form-control " >
                        </asp:DropDownList>
                    </div>
                </div>
            </div>

            <%--DESCRIPCION--%>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="txtDescripcion" CssClass="col-md-2 control-label">Descripcion</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox ID="txtDescripcion" CssClass="form-control " runat="server" />
                    </div>
                </div>
            </div>

            <%--STOCK--%>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="txtStock" CssClass="col-md-2 control-label">Stock</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox ID="txtStock" CssClass="form-control " runat="server" TextMode="Number" />
                    </div>
                </div>
            </div>

            <%--STOCK CRITICO--%>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="txtStockCritico" CssClass="col-md-2 control-label">Stock Crítico</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox ID="txtStockCritico" CssClass="form-control " runat="server" TextMode="Number" />
                    </div>
                </div>
            </div>

            <%--FECHA DE VENCIMIENTO--%>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="txtFecha" CssClass="col-md-2 control-label">Fecha de Vencimiento</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox ID="txtFecha" CssClass="form-control " runat="server" TextMode="Date" />
                    </div>
                </div>
            </div>

            <%--CODIGO--%>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="txtCodigo" CssClass="col-md-2 control-label">Código</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox ID="txtCodigo" CssClass="form-control " runat="server" Enabled="false" />
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
