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
           <%-- <asp:BulletedList ID="bullCarpetas" CssClass="nav" DisplayMode="LinkButton" runat="server" OnClick="bullCarpetas_Click">
            </asp:BulletedList> --%>
            <br />
            <a class="btn btn-primary fa-with-txt">&#xf002; Buscar</a>
        </div>
        <div id="page-wrapper" class="col-md-9">
            <h2>Lista de Edificios
            </h2>
            <div class="panel-body">
                <div class="table-responsive">
                    <%-- VA A IR LA LISTA ACA --%>
                    <%--<asp:GridView ID="gvListaTareas" CssClass="table table-hover table-striped" runat="server" AutoGenerateColumns="False"
                        ForeColor="#333333" GridLines="None" CellPadding="10" CellSpacing="4" DataKeyNames="IdTarea"
                        OnRowDataBound="gvListaTareas_RowDataBound">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="IdTarea" HeaderText="IdTarea" Visible="False" />
                            <asp:BoundField DataField="Fecha" DataFormatString="{0:d}" HeaderText="Fecha" ReadOnly="True" />
                            <asp:BoundField DataField="Tarea" HeaderText="Nombre" ReadOnly="True" />
                            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" ReadOnly="True" />
                            <asp:BoundField DataField="Prioridad" HeaderText="Prioridad" ReadOnly="True" />
                            <asp:BoundField DataField="Carpeta" HeaderText="Carpeta" ReadOnly="True" />
                            <asp:BoundField DataField="Estado" HeaderText="Estado" />
                            <asp:TemplateField HeaderText="Accion" ShowHeader="False">
                                <ItemTemplate>
                                    <asp:Button ID="btnModificar" class="btn btn-outline btn-success btn-sm" runat="server" CausesValidation="false" CommandName="Update"
                                        Text="Modif" OnClick="btnCompletar_Click" />
                                </ItemTemplate>
                                <ItemTemplate>
                                    <asp:Button ID="btnEliminar" class="btn btn-outline btn-success btn-sm" runat="server" CausesValidation="false" CommandName="Update"
                                        Text="Eliminar" OnClick="btnCompletar_Click" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView> --%>
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