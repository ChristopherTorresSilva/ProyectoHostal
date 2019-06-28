<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrarHabitacion.aspx.cs" Inherits="Hostal.Vista.RegistrarHabitacion" %>

 <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        
     <div class="row">
        <div>
            <h3>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Reserva Habitación</h3>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image1" runat="server" Height="130px" ImageUrl="~/img/habitacionDoble.jpg" Width="717px" />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <section>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="dropHuesped"  CssClass="col-md-2 control-label">Tipo de Huesped:</asp:Label>
                      <div class="col-md-10">
                        <asp:DropDownList ID="dropHuesped" runat="server" CssClass="form-control " AutoPostBack="True" OnSelectedIndexChanged="dropHuesped_SelectedIndexChanged1" >
                            <asp:ListItem Text="" Value=""></asp:ListItem>
                            <asp:ListItem Text="Antiguo" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Nuevo" Value="2"></asp:ListItem>
                        </asp:DropDownList>
                           <br />
                      </div>
                </div>
                <div class="form-group">
                  <asp:Label runat="server" AssociatedControlID="huespedAntiguo" CssClass="col-md-2 control-label">Huesped:</asp:Label>
                   <div class="col-md-10">
                   <asp:DropDownList ID="huespedAntiguo" runat="server" CssClass="form-control " Enabled="False">
                   </asp:DropDownList>
                    <br />
                  </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="dropCama"  CssClass="col-md-2 control-label">Tipo de Cama:</asp:Label>
                      <div class="col-md-10">
                        <asp:DropDownList ID="dropCama" runat="server" CssClass="form-control " Enabled="False">
                        </asp:DropDownList>
                           <br />
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
                  <asp:Label runat="server" AssociatedControlID="dropEmpresa" CssClass="col-md-2 control-label">Empresa:</asp:Label>
                   <div class="col-md-10">
                   <asp:DropDownList ID="dropEmpresa" runat="server" CssClass="form-control " Enabled="False">
                   </asp:DropDownList>
                    <br />
                  </div>
                </div>
                 <div class="form-group">
                  <asp:Label runat="server" AssociatedControlID="dropHabitacion" CssClass="col-md-2 control-label">Seleccione Habitación:</asp:Label>
                   <div class="col-md-10">
                   <asp:DropDownList ID="dropHabitacion" runat="server" CssClass="form-control " Enabled="False" AutoPostBack="True">
                   </asp:DropDownList>
                    <br />
                  </div>
                </div>
                <div class="form-group">
                  <asp:Label runat="server" AssociatedControlID="dropServicio" CssClass="col-md-2 control-label">Servicio:</asp:Label>
                   <div class="col-md-10">
                   <asp:DropDownList ID="dropServicio" runat="server" CssClass="form-control " Enabled="False" AutoPostBack="True">
                   </asp:DropDownList>
                    <br />
                  </div>
                </div>
                <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="txtPrecio" CssClass="col-md-2 control-label">Precio:</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="txtPrecio" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPrecio" CssClass="text-danger" ErrorMessage="El campo de Precio es obligatorio." />
                        </div>
               </div>
                <asp:Label ID="lblMsg" runat="server"></asp:Label>
                <asp:Label runat="server" CssClass="text-danger" ID="lblErrorMsg"></asp:Label>
                 <div class="form-group">
                   <div class="col-md-offset-2 col-md-10">
                      <asp:Button runat="server" ID="btnReservar" Text="Reservar" CssClass="btn btn-default" OnClick="btnReservar_Click" />
                   </div>
                 </div>
            </section>
        </div>
    </div>
</asp:Content>

