<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Login.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AdmEdificios.Presentacion.Login1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentLogin" runat="server">
    <!-- CONTENIDO DEL LOGIN -->
    <div class="container  margin-bottom">
        <div class="contenedor-imagen col-md-6">
            <img src="img/edificio-colorido.jpg" />
        </div>
        <div class="col-md-6 ">
            <h2>Inicie Sesión<small> para poder administrar</small></h2>
            <div class="form-group">
                <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
                <asp:TextBox ID="txtEmail" class="form-control" runat="server" TextMode="Email"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvEmail" ControlToValidate="txtEmail"
                    ValidationGroup="inicioSesion" Display="Dynamic" ForeColor="Red" runat="server"
                    ErrorMessage="*Campo obligatorio"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revEmail" ControlToValidate="txtEmail"
                    ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="inicioSesion"
                    Display="Dynamic" ForeColor="Red" runat="server" ErrorMessage="*Formato inválido"></asp:RegularExpressionValidator>
            </div>
            <div class="form-group">
                <asp:Label ID="lblContrasenia" runat="server" Text="Contraseña:"></asp:Label>
                <asp:TextBox ID="txtContrasenia" class="form-control" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvContrasenia" ControlToValidate="txtContrasenia"
                    ValidationGroup="inicioSesion" Display="Dynamic" ForeColor="Red" runat="server"
                    ErrorMessage="*Campo obligatorio"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:Label ID="lblMensajeError" CssClass="col-md-12" runat="server" Text=""></asp:Label>
                <br />
            </div>
            <div class="form-group">
                <asp:Button ID="btnIngresar" runat="server" ValidationGroup="inicioSesion" Text="Ingresar"
                    class="btn btn-success btn-lg" OnClick="btnIngresar_Click" />
            </div>
        </div>
    </div>
</asp:Content>
