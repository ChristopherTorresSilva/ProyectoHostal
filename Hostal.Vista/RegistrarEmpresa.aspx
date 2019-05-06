<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrarEmpresa.aspx.cs" Inherits="Hostal.Vista.CrearUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div>
            <h1>Registro de Empresa</h1>
            <section>
                <div class="form-horizontal">
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtEmpresa" CssClass="col-md-2 control-label">Nombre de Empresa:</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtEmpresa" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtEmpresa" CssClass="text-danger" ErrorMessage="El campo de nombre de empresa es obligatorio." />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtRut" CssClass="col-md-2 control-label">Rut Empresa:</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtRut" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtRut" CssClass="text-danger" ErrorMessage="El campo de rut empresa es obligatorio." />
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
                        <asp:Label runat="server" AssociatedControlID="txtNombre" CssClass="col-md-2 control-label">Nombre de Usuario:</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtNombre" CssClass="text-danger" ErrorMessage="El campo de nombre de usuario es obligatorio." />
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
