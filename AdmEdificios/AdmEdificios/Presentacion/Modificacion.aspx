<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Home.Master" AutoEventWireup="true" CodeBehind="Modificacion.aspx.cs" Inherits="AdmEdificios.Presentacion.Modificacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--  PARA MODIFICAR UN EDIFICIO -->
    <div class="container margin-bottom">
        <div id="page-wrapper" class="col-md-6 col-md-offset-3">
            <h3 class="page-header">
                Modificación de Edificio</h3>
            <div class="form-group">
                <asp:Label ID="lblNombreEdificio" Text="Nombre:" runat="server" for="txtNombreEdificio" />
                <asp:TextBox class="form-control" runat="server" ID="txtNombreEdificio" placeholder="Escriba aquí el nombre" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtNombreEdificio"
                    Display="Dynamic" ForeColor="Red" runat="server" ValidationGroup="tarea" ErrorMessage="*Campo obligatorio"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="txtNombreEdificio"
                    ValidationExpression=".{1,20}" Display="Dynamic" runat="server" ForeColor="Red"
                    ValidationGroup="tarea" ErrorMessage="Máximo 20 caracteres"></asp:RegularExpressionValidator>
            </div>


            <div class="form-group">
                <asp:Label ID="lblDireccion" Text="Dirección:" runat="server" for="txtDireccion" />
                <asp:TextBox class="form-control" runat="server" ID="txtDireccion" placeholder="Escriba aquí la dirección" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtDireccion"
                    Display="Dynamic" ForeColor="Red" runat="server" ValidationGroup="tarea" ErrorMessage="*Campo obligatorio"></asp:RequiredFieldValidator>
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
                    <asp:TextBox class="form-control" runat="server" ID="txtCodPostal" placeholder="Pisos" />
                </div>
                <div class="form-group col-md-6">
                    <asp:Label ID="lblCantPisos" Text="Cant. Pisos:" for="txtCantPisos"
                        runat="server" />
                    <asp:TextBox class="form-control" runat="server" ID="txtCantPisos" placeholder="Pisos" />
                </div>
                <div class="form-group col-md-6">
                    <asp:Label ID="lblCantDptos" Text="Cant. Dptos:" for="txtCantDptos"
                        runat="server" />
                    <asp:TextBox class="form-control" runat="server" ID="txtCantDptos" placeholder="Dptos" />
                </div>
                <div class="form-group col-md-6">
                    <asp:Label ID="lblCocheras" Text="Cant. Cocheras:" for="txtCocheras"
                        runat="server" />
                    <asp:TextBox class="form-control" runat="server" ID="txtCocheras" placeholder="Cocheras" />
                </div>
                <div class="form-group col-md-6">
                    <asp:Label ID="lblAnioCreacion" Text="Año Creación:" for="txtAnioCreacion"
                        runat="server" />
                    <asp:TextBox class="form-control" runat="server" ID="txtAnioCreacion" placeholder="Año" />
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
                <asp:Label ID="lblNuevaTareaFecha" Text="Fecha de Alta:" runat="server" for="calNuevaTareaFecha" />
                <asp:Calendar runat="server" ID="calNuevaTareaFecha" BackColor="White" BorderColor="#3366CC"
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
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="txtComentarios"
                    ValidationExpression=".{1,200}" Display="Dynamic" runat="server" ForeColor="Red"
                    ValidationGroup="tarea" ErrorMessage="Máximo 200 caracteres"></asp:RegularExpressionValidator>
            </div>


            <div class="form-group">
                <asp:Button ID="btnGuardar" Text="Guardar" 
                    ValidationGroup="tarea" runat="server" class="btn btn-success" />
                <asp:Button ID="btnCancelar" runat="server" class="btn btn-warning" Text="Cancelar"/>
            </div>

        </div>
    </div>
</asp:Content>
