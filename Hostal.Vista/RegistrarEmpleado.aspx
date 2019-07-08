﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrarEmpleado.aspx.cs" Inherits="Hostal.Vista.RegistrarEmpleado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style type="text/css">
        #x {
            font-family: Arial;
            font-size: 15px;
            color: white;
        }
    </style>
    <div id="x" class="row">
        <div>
            <h3>Registro Empleado</h3>
        <div class="row">
              <center>
                 <img src="img/formulario.jpg"/>
              </center>
           </br>
        </div> 
            <section>
                <div class="form-horizontal">
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="dropPerfil" CssClass="col-md-2 control-label">Tipo de Usuario:</asp:Label>
                        <div class="col-md-10">
                            <asp:DropDownList ID="dropPerfil" runat="server" CssClass="form-control ">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtNombre" CssClass="col-md-2 control-label">Nombre:</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtNombre" CssClass="text-danger" ErrorMessage="El campo de nombre es obligatorio." />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtApellido" CssClass="col-md-2 control-label">Apellido:</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtApellido" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtApellido" CssClass="text-danger" ErrorMessage="El campo de apellido es obligatorio." />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtRut" CssClass="col-md-2 control-label">Rut:</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtRut" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtRut" CssClass="text-danger" ErrorMessage="El campo de rut  es obligatorio." />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="dropCargo" CssClass="col-md-2 control-label">Cargo:</asp:Label>
                        <div class="col-md-10">
                            <asp:DropDownList ID="dropCargo" runat="server" CssClass="form-control ">
                            </asp:DropDownList>
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
