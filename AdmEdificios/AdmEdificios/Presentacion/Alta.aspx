<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Home.Master" AutoEventWireup="true" CodeBehind="Alta.aspx.cs" Inherits="AdmEdificios.Presentacion.Alta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--  PARA DAR DE ALTA UN EDIFICIO -->
    <div class="container margin-bottom">
        <div id="page-wrapper" class="col-md-6 col-md-offset-3">
            <h3 class="page-header">Alta de Edificio</h3>
            <div class="form-group">
                <asp:Label ID="lblNombreEdificio" Text="Nombre:" runat="server" for="txtNombreEdificio" />
                <asp:TextBox class="form-control" runat="server" ID="txtNombreEdificio" placeholder="Escriba aquí el nombre" />
                <asp:RequiredFieldValidator ID="rfvNombreEdificio" ControlToValidate="txtNombreEdificio"
                    Display="Dynamic" ForeColor="Red" runat="server" ValidationGroup="altaEdificio" ErrorMessage="*Campo obligatorio" />
                <asp:RegularExpressionValidator ID="revNombreEdificio" ControlToValidate="txtNombreEdificio"
                    ValidationExpression=".{1,50}" Display="Dynamic" runat="server" ForeColor="Red"
                    ValidationGroup="altaEdificio" ErrorMessage="*Máximo 50 caracteres" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblDireccion" Text="Dirección:" runat="server" for="txtDireccion" />
                <asp:TextBox class="form-control" runat="server" ID="txtDireccion" placeholder="Escriba aquí la dirección" />
                <asp:RequiredFieldValidator ID="rfvDireccion" ControlToValidate="txtDireccion"
                    Display="Dynamic" ForeColor="Red" runat="server" ValidationGroup="altaEdificio" ErrorMessage="*Campo obligatorio" />
                <asp:RegularExpressionValidator ID="revDireccion" ControlToValidate="txtDireccion"
                    ValidationExpression=".{1,50}" Display="Dynamic" runat="server" ForeColor="Red"
                    ValidationGroup="altaEdificio" ErrorMessage="*Máximo 50 caracteres" />
            </div>
            <div class="row">
                <div class="form-group col-md-6">
                    <asp:Label ID="lblBarrioCABA" Text="Barrio CABA:" for="ddlBarrioCABA"
                        runat="server" />
                    <asp:DropDownList class="form-control" ID="ddlBarrioCABA" runat="server">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="row">
                <div class="form-group col-md-6">
                    <asp:Label ID="lblCodPostal" Text="Cod. Postal:" for="txtCodPostal"
                        runat="server" />
                    <asp:TextBox class="form-control" runat="server" ID="txtCodPostal" placeholder="Código Postal" />
                    <asp:RequiredFieldValidator ID="rfvCodPostal" ControlToValidate="txtCodPostal"
                        Display="Dynamic" ForeColor="Red" runat="server" ValidationGroup="altaEdificio" ErrorMessage="*Campo obligatorio" />
                    <asp:RegularExpressionValidator ID="revCodPostal" ControlToValidate="txtCodPostal"
                        ValidationExpression=".{1,10}" Display="Dynamic" runat="server" ForeColor="Red"
                        ValidationGroup="altaEdificio" ErrorMessage="*Máximo 10 caracteres" />
                </div>
                <div class="form-group col-md-6">
                    <asp:Label ID="lblCantPisos" Text="Cant. Pisos:" for="txtCantPisos"
                        runat="server" />
                    <asp:TextBox class="form-control" runat="server" ID="txtCantPisos" placeholder="Pisos" />
                    <asp:RequiredFieldValidator ID="rfvCantPisos" ControlToValidate="txtCantPisos"
                        Display="Dynamic" ForeColor="Red" runat="server" ValidationGroup="altaEdificio" ErrorMessage="*Campo obligatorio" />
                    <asp:RangeValidator ID="rvCantPisos" ControlToValidate="txtCantPisos" MinimumValue="1" MaximumValue="100"
                        Type="Integer" ForeColor="Red" ErrorMessage="*De 1 a 100 pisos" runat="server" ValidationGroup="altaEdificio"
                        Display="Dynamic" />
                </div>
                <div class="form-group col-md-6">
                    <asp:Label ID="lblCantDptos" Text="Cant. Dptos:" for="txtCantDptos"
                        runat="server" />
                    <asp:TextBox class="form-control" runat="server" ID="txtCantDptos" placeholder="Dptos" />
                    <asp:RequiredFieldValidator ID="rfvCantDptos" ControlToValidate="txtCantDptos"
                        Display="Dynamic" ForeColor="Red" runat="server" ValidationGroup="altaEdificio" ErrorMessage="*Campo obligatorio" />
                    <asp:RangeValidator ID="rvCantDptos" ControlToValidate="txtCantDptos" MinimumValue="1" MaximumValue="1000"
                        Type="Integer" ForeColor="Red" ErrorMessage="*De 1 a 1000 Dptos" runat="server" ValidationGroup="altaEdificio"
                        Display="Dynamic" />
                    <!-- validación requerida en TP -->
                </div>
                <div class="form-group col-md-6">
                    <asp:Label ID="lblCocheras" Text="Cant. Cocheras:" for="txtCocheras"
                        runat="server" />
                    <asp:TextBox class="form-control" runat="server" ID="txtCocheras" placeholder="Cocheras" />
                    <asp:RequiredFieldValidator ID="rfvCocheras" ControlToValidate="txtCocheras"
                        Display="Dynamic" ForeColor="Red" runat="server" ValidationGroup="altaEdificio" ErrorMessage="*Campo obligatorio" />
                    <asp:RangeValidator ID="rvCocheras" ControlToValidate="txtCocheras" MinimumValue="0" MaximumValue="1000"
                        Type="Integer" ForeColor="Red" ErrorMessage="*Hasta 1000 cocheras" runat="server" ValidationGroup="altaEdificio"
                        Display="Dynamic" />
                </div>
                <div class="form-group col-md-6">
                    <asp:Label ID="lblAnioCreacion" Text="Año Creación:" for="txtAnioCreacion"
                        runat="server" />
                    <asp:TextBox class="form-control" runat="server" ID="txtAnioCreacion" placeholder="Año" />
                    <asp:RequiredFieldValidator ID="rfvAnioCreacion" ControlToValidate="txtAnioCreacion"
                        Display="Dynamic" ForeColor="Red" runat="server" ValidationGroup="altaEdificio" ErrorMessage="*Campo obligatorio" />
                    <asp:RangeValidator ID="rvAnioCreacion" ControlToValidate="txtAnioCreacion" MinimumValue="1900" MaximumValue="2017"
                        Type="Integer" ForeColor="Red" ErrorMessage="*Ingrese un año entre 1900 y 2017" runat="server" ValidationGroup="altaEdificio"
                        Display="Dynamic" />
                </div>
            </div>
            <asp:Label ID="lblAmenities" Text="Amenities:" runat="server" />
            <div class="checkbox">
                <asp:CheckBoxList ID="cblAmenities" runat="server">
                    <asp:ListItem Value="SUM"
                        Selected="False">
                        SUM
                    </asp:ListItem>
                    <asp:ListItem Value="Parrilla"
                        Selected="False">
                        Parrilla
                    </asp:ListItem>
                    <asp:ListItem Value="Pileta"
                        Selected="False">
                        Pileta
                    </asp:ListItem>
                    <asp:ListItem Value="Gimnasio"
                        Selected="False">
                        Gimnasio
                    </asp:ListItem>
                    <asp:ListItem Value="Seguridad"
                        Selected="False">
                        Seguridad
                    </asp:ListItem>
                </asp:CheckBoxList>
            </div>
            <div class="form-group">
                <asp:Label ID="lblFechaAlta" Text="Fecha de Alta:" runat="server" for="calFechaAlta" />
                <asp:Calendar runat="server" ID="calFechaAlta" BackColor="White" BorderColor="#3366CC"
                    BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana"
                    Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
                    <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                    <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                    <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True"
                        Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                    <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                    <WeekendDayStyle BackColor="#CCCCFF" />
                </asp:Calendar>
                <asp:Label ID="lblError" ForeColor="Red" runat="server" Text=""></asp:Label>
            </div>
            <div class="form-group">
                <asp:Label ID="lblComentarios" Text="Comentarios:" runat="server" MaxLength="200"
                    for="txtComentarios" />
                <asp:TextBox class="form-control" TextMode="MultiLine" runat="server" ID="txtComentarios"
                    placeholder="Escriba aquí algún comentario" />
                <asp:RequiredFieldValidator ID="rfvComentarios" ControlToValidate="txtComentarios"
                    Display="Dynamic" ForeColor="Red" runat="server" ValidationGroup="altaEdificio" ErrorMessage="*Campo obligatorio" />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="txtComentarios"
                    ValidationExpression=".{1,200}" Display="Dynamic" runat="server" ForeColor="Red"
                    ValidationGroup="altaEdificio" ErrorMessage="*Máximo 200 caracteres" />
            </div>
            <div class="form-group">
                <asp:Button ID="btnGuardar" Text="Guardar"
                    ValidationGroup="altaEdificio" runat="server" class="btn btn-success" OnClick="btnGuardarEdificio_Click" />
                <asp:Button ID="btnCancelar" runat="server" class="btn btn-warning" Text="Cancelar" OnClick="btnCancelar_Click" />
            </div>
        </div>
    </div>
</asp:Content>
