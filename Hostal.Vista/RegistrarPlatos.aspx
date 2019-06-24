<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrarPlatos.aspx.cs" Inherits="Hostal.Vista.RegistrarPlatos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group col-lg-12">
        <div class="form-group">
            </br></br></br></br>
            
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
                            <asp:DropDownList ID="dropTipoServicio" runat="server" CssClass="form-control " OnSelectedIndexChanged="dropTipoServicio_SelectedIndexChanged" AutoPostBack="True">
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>

                <%--PLATO DE SERVICIO--%>

                 <div class="form-horizontal">
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="inPlato" CssClass="col-md-2 control-label">Plato</asp:Label>
                        <div class="col-md-10">
                           <input ID="inPlato" type="text" OnSelectedIndexChanged="inCantidad_SelectedIndexChanged" CssClass="form-control " runat="server" min="1"/>
                        </div>
                    </div>
                </div>

                <%--<div class="form-horizontal">
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtPrecio" CssClass="col-md-2 control-label">Plato</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox Id="txtPrecio" CssClass="form-control " runat="server" Enabled="False" />
                        </div>
                    </div>
                </div>--%>

                <%--MENSAJE ERROR--%>
                <asp:Label runat="server" CssClass="text-danger" ID="lblErrorMsg"></asp:Label>

                <%--BOTON--%>
                <div class="col-md-offset-2 col-md-10">
                    <asp:Button class="btn btn-w-m btn-danger" runat="server" ID="btnCrearPlato" Text="Registrar Plato" OnClick="btnCrearPlato_Click" />
                </div>

            </section>
        </div>
    </div>
</asp:Content>
