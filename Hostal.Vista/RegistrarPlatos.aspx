<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrarPlatos.aspx.cs" Inherits="Hostal.Vista.RegistrarPlatos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div>
            <h1>Registro de platos</h1>
            <section>

                <div class="row">
                    <center>
                    <img src="img/minuta.jpg"/>
                    </center>
                    </br>
                </div>


                <%--TIPO DE SERVICIO--%>
                <div class="form-horizontal">
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="dropTipoServicio" CssClass="col-md-2 control-label">Tipo de Servicio</asp:Label>
                        <div class="col-md-10">
                            <asp:DropDownList ID="dropTipoServicio" runat="server" CssClass="form-control ">
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>

                <%--PRECIO DE SERVICIO--%>
                <div class="form-horizontal">
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="dropPrecioServicio" CssClass="col-md-2 control-label">Precio de Servicio</asp:Label>
                        <div class="col-md-10">
                            <asp:DropDownList ID="dropPrecioServicio" runat="server" CssClass="form-control ">
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>

                <%--MENSAJE ERROR--%>
                <asp:Label runat="server" CssClass="text-danger" ID="lblErrorMsg"></asp:Label>

                <%--BOTON--%>


                <div class="col-md-offset-2 col-md-10">
                    <asp:Button runat="server" ID="btnCrearPlato" Text="Registrar Plato" CssClass="btn btn-default" OnClick="btnCrearPlato_Click" />
                </div>

            </section>
        </div>
    </div>
</asp:Content>
