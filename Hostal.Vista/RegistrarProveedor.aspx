<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrarProveedor.aspx.cs" Inherits="Hostal.Vista.RegistrarProveedor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <style type="text/css">
        #x
        {
                    font-family:Arial;
                    font-size: 15px;
                    color: white;
        }
    </style>
    <div id="x" class="row">
        <div>
            <h3>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Registro Proveedor</h3>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image1" runat="server" Height="113px" ImageUrl="~/img/formulario.jpg" Width="717px" />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <section>
                <div class="form-horizontal">
                    
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtProveedor" CssClass="col-md-2 control-label">Nombre del Proveedor:</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtProveedor" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtProveedor" CssClass="text-danger" ErrorMessage="El campo de nombre del proveedor es obligatorio." />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtRut" CssClass="col-md-2 control-label">Rut Empresa:</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtRut" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtRut" CssClass="text-danger" ErrorMessage="El campo de rut del proveedor es obligatorio." />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="dropRubro"  CssClass="col-md-2 control-label">Rubro:</asp:Label>
                        <div class="col-md-10">
                            <asp:DropDownList ID="dropRubro" runat="server" CssClass="form-control ">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtTel" CssClass="col-md-2 control-label">Telefono:</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtTel" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtTel" CssClass="text-danger" ErrorMessage="El campo de telefono de empresa es obligatorio." />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtCorreo" CssClass="col-md-2 control-label">Correo:</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtCorreo" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtCorreo" CssClass="text-danger" ErrorMessage="El campo de correo de empresa es obligatorio." />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtUsuario" CssClass="col-md-2 control-label">Nombre de Usuario:</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtUsuario" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtUsuario" CssClass="text-danger" ErrorMessage="El campo de nombre de usuario es obligatorio." />
                        </div>
                    </div>
                    <asp:Label ID="lblMsg" runat="server"></asp:Label>
                    <asp:Label runat="server" CssClass="text-danger" ID="lblErrorMsg"></asp:Label>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server" ID="btnCrear" Text="Crear Usuario" CssClass="btn btn-default" OnClick="btnCrear_Click" />
                        </div>
                    </div>
                </div>
            </section>
        </div>
    </div>
</asp:Content>
