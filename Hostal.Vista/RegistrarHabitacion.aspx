<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrarHabitacion.aspx.cs" Inherits="Hostal.Vista.RegistrarHabitacion" %>

 <asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        
     <div class="row">
        <div>
            <h3>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Reserva Habitación</h3>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image1" runat="server" Height="113px" ImageUrl="~/img/habitacionDoble.jpg" Width="717px" />
            <br />
            <section>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="dropCama"  CssClass="col-md-2 control-label">Tipo de Cama:</asp:Label>
                      <div class="col-md-10">
                        <asp:DropDownList ID="dropCama" runat="server" CssClass="form-control ">
                        </asp:DropDownList>
                           <br />
                      </div>
                </div>
                 <div class="form-group">
                  <asp:Label runat="server" AssociatedControlID="dropHabitacion" CssClass="col-md-2 control-label">Seleccione Habitación:</asp:Label>
                   <div class="col-md-10">
                    
                   <asp:DropDownList ID="dropHabitacion" runat="server" CssClass="form-control ">
                   </asp:DropDownList>
                    <br />
                  </div>
                </div>
                <div class="form-group">
                   <asp:Label runat="server" AssociatedControlID="txtPrecio"  CssClass="col-md-2 control-label">Precio:</asp:Label>
                     <div class="col-md-10">
                        <asp:TextBox ID="txtPrecio" runat="server" Width="1473px"></asp:TextBox>
                        <br />
                     </div>
                     <br />
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

