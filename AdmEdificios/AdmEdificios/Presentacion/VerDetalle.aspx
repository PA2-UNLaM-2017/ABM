<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Home.Master" AutoEventWireup="true" CodeBehind="VerDetalle.aspx.cs" Inherits="AdmEdificios.Presentacion.VerDetalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--  DETALLE DEL EDIFICIO -->
    <div class="container margin-bottom">
        <div id="page-wrapper" class="col-md-6 col-md-offset-3">
            <h3 class="page-header">Detalle del Edificio</h3>

            <asp:Label ID="lblParaID" Text="" Visible="false" runat="server" />

            <div class="form-group">
                <asp:Label ID="lblNombre" Text="Nombre:" runat="server" Font-Bold="true" />
                <asp:Label ID="lblNombreEdificio" runat="server" />
            </div>

            <div class="form-group">
                <asp:Label ID="lblDireccion" Text="Dirección:" runat="server" Font-Bold="true" />
                <asp:Label ID="lblDireccionEdificio" runat="server" />
            </div>

            <div class="form-group">
                <asp:Label ID="lblBarrio" Text="Barrio:" runat="server" Font-Bold="true" />
                <asp:Label ID="lblBarrioCABA" runat="server" />
            </div>

            <div class="form-group">
                <asp:Label ID="lblPosta" Text="Cod. Postal:" runat="server" Font-Bold="true" />
                <asp:Label ID="lblCodPostal" runat="server" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblPisos" Text="Cant. Pisos:" runat="server" Font-Bold="true" />
                <asp:Label ID="lblCantPisos" runat="server" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblDptos" Text="Cant. Dptos:" runat="server" Font-Bold="true" />
                <asp:Label ID="lblCantDptos" runat="server" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblCocheras" Text="Cant. Cocheras:" runat="server" Font-Bold="true" />
                <asp:Label ID="lblCantCocheras" runat="server" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblCreacion" Text="Año Creación:" runat="server" Font-Bold="true" />
                <asp:Label ID="lblAnioCreacion" runat="server" />
            </div>

            <div class="form-group">
                <asp:Label ID="lblAmeni" Text="Amenities:" runat="server" Font-Bold="true" />
                <asp:Label ID="lblAmenities" runat="server" />
            </div>

            <div class="form-group">
                <asp:Label ID="lblAlta" Text="Fecha de Alta:" runat="server" Font-Bold="true" />
                <asp:Label ID="lblFechaAlta" runat="server" />
            </div>

            <div class="form-group">
                <asp:Label ID="lblComent" Text="Comentarios:" runat="server" Font-Bold="true" />
                <asp:Label ID="lblComentarios" runat="server" />
            </div>

            <div class="form-group">
                <asp:Button ID="btnRegresar" Text="Regresar" runat="server" class="btn btn-warning" OnClick="btnRegresar_Click" />
            </div>

        </div>
    </div>
</asp:Content>
