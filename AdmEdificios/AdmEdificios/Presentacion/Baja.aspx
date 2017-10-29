<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Home.Master" AutoEventWireup="true" CodeBehind="Alta.aspx.cs" Inherits="AdmEdificios.Presentacion.Alta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--  PARA DAR DE BAJA UN EDIFICIO (es baja lógica) -->
    <div class="container margin-bottom">
        <div id="page-wrapper" class="col-md-6 col-md-offset-3">
            <h3 class="page-header">
                Baja de Edificio</h3>
            <div class="form-group">
                <asp:Label ID="lblNombreEdificio" Text="Desea eliminar el siguiente edificio?:" runat="server" />
                <asp:Label ID="lblDatosEdificio" Text="" runat="server" />
            </div>

            <div class="form-group">
                <asp:Button ID="btnGuardar" Text="Aceptar" runat="server" class="btn btn-success" />
                <asp:Button ID="btnCancelar" runat="server" class="btn btn-warning" Text="Cancelar" />
            </div>
        </div>
    </div>
</asp:Content>
