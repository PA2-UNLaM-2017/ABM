<%@ Page Title="" Language="C#" MasterPageFile="~/Presentacion/Home.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="AdmEdificios.Presentacion.Home1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-md-12">
        <div id="sidebar" class="col-md-3 navbar-default navbar-static-side">
            <h2>Buscar
            </h2>
            <asp:TextBox class="form-control" runat="server" ID="txtBuscaBarrio" placeholder="Ingrese barrio" />
            <br />
            <asp:TextBox class="form-control" runat="server" ID="txtBuscaAnioCreacion" placeholder="Ingrese año de creación" />
            <br />
            <a class="btn btn-primary fa-with-txt">&#xf002; Buscar</a>
        </div>
        <div id="page-wrapper" class="col-md-9">
            <h2>Lista de Edificios
            </h2>
            <div class="panel-body">
                <div class="table-responsive">
                    <%-- VA A IR LA LISTA ACA --%>
                    
                    <asp:GridView ID="gvListaEdificios" CssClass="table table-hover table-striped" runat="server" AutoGenerateColumns="False"
                        ForeColor="#333333" GridLines="None" CellPadding="10" CellSpacing="4" DataKeyNames="IdEdificio">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="IdEdificio" HeaderText="IdEdificio" Visible="False" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" ReadOnly="True" />
                            <asp:BoundField DataField="Direccion" HeaderText="Direccion" ReadOnly="True" />
                            <asp:BoundField DataField="IdBarrioCABA" HeaderText="Barrio CABA" ReadOnly="True" />
                            <asp:BoundField DataField="CodPostal" HeaderText="Cod. Postal" ReadOnly="True" />
                            <asp:BoundField DataField="CantPisos" HeaderText="Cant. Pisos" ReadOnly="True" />
                            <asp:BoundField DataField="CantDptos" HeaderText="Cant. Dptos" ReadOnly="True" />
                            <asp:BoundField DataField="CantCocheras" HeaderText="Cant. Cocheras" ReadOnly="True" />
                            <asp:BoundField DataField="AnioCreacion" HeaderText="Año Creación" ReadOnly="True" />
                            <asp:BoundField DataField="Amenities" HeaderText="Amenities" ReadOnly="True" />
                            <asp:BoundField DataField="FechaAlta" DataFormatString="{0:d}" HeaderText="Fecha Alta" ReadOnly="True" />                         
                            <asp:BoundField DataField="Comentarios" HeaderText="Comentarios" ReadOnly="True" />
                            <asp:TemplateField HeaderText="Modificar" ShowHeader="False">
                               <ItemTemplate>
                                    <asp:Button ID="btnModificar" class="btn btn-outline btn-success btn-sm" runat="server" CausesValidation="false" CommandName="Update"
                                        Text="Modif" /><%--  OnClick="btnModificar_Click" /> --%>
                                </ItemTemplate> 
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Eliminar" ShowHeader="False">
                                 <ItemTemplate>


                                     <a href="/Presentacion/Baja.aspx?id=<%# Eval("IdEdificio") %>" title="Eliminar" name="Eliminar" >
                                    <span aria-hidden="true" class="glyphicon glyphicon-pencil"></span>
                                    </a>


                                    <%-- <asp:Button ID="btnEliminar" class="btn btn-outline btn-success btn-sm" runat="server" CausesValidation="false" CommandName="Delete"
                                        Text="E" /> OnClick="btnEliminar_Click" />--%>


                                </ItemTemplate> 
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>



                </div>
                <!-- /.table-responsive -->
            </div>

            <asp:Label ID="lblNoHayEdificios" class="alert alert-info fa-with-txt" runat="server" Text="&#xf06a; No hay edificios agregados."
                Visible="false"></asp:Label>

            <asp:Button Text="&#xf067; Nuevo Edificio" class="btn btn-primary fa-with-txt" PostBackUrl="~/Presentacion/Alta.aspx"
                runat="server" />

        </div>
    </div>
</asp:Content>