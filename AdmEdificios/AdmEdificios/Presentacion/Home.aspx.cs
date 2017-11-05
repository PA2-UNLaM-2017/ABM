using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdmEdificios.Negocio;

namespace AdmEdificios.Presentacion
{
    public partial class Home1 : System.Web.UI.Page
    {

        EdificioServicio es = new EdificioServicio();
        BarrioServicio bs = new BarrioServicio();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                CargaTablaEdificios();
            }

        }


        public void CargaTablaEdificios()
        {

            List<Edificios> edificios = new List<Edificios>();
            List<EdificioGridView> ListaGridView = new List<EdificioGridView>();


            edificios = es.ListarEdificios();

            foreach (var item in edificios)
            {

                EdificioGridView ediGridView = new EdificioGridView();

                var barrio = bs.BuscarBarrioXID(item.IdBarrioCABA);

                ediGridView.IdEdificio = item.IdEdificio;
                ediGridView.Nombre = item.Nombre;
                ediGridView.Direccion = item.Direccion;
                ediGridView.BarrioCABA = barrio.Nombre;
                ediGridView.CodPostal = item.CodPostal;
                ediGridView.CantPisos = item.CantPisos;
                ediGridView.CantDptos = item.CantDptos;
                ediGridView.CantCocheras = item.CantCocheras;
                ediGridView.AnioCreacion = item.AnioCreacion;
                ediGridView.FechaAlta = item.FechaAlta;
                ediGridView.Amenities = item.Amenities;
                ediGridView.Comentarios = item.Comentarios;

                ListaGridView.Add(ediGridView);

            }

            gvListaEdificios.DataSource = ListaGridView;
            gvListaEdificios.DataBind();

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

            string barrio = txtBuscaBarrio.Text;
            string anioCreacion = txtBuscaAnioCreacion.Text;
            List<EdificioGridView> ListaGridViewBusqueda = new List<EdificioGridView>();

            if (barrio != "" || anioCreacion != "")
            {

                if (barrio != "" && anioCreacion == "")
                {
                    // barrio no es null

                    int idBarrio = bs.BuscarUnBarrio(barrio);

                    if (idBarrio != 1000)
                    {
                        List<Edificios> edificiosXBarrio = new List<Edificios>();

                        edificiosXBarrio = es.BuscaEdificiosXBarrio(idBarrio);

                        foreach (var item in edificiosXBarrio)
                        {

                            EdificioGridView ediGridView = new EdificioGridView();

                            var barrioNombre = bs.BuscarBarrioXID(item.IdBarrioCABA);

                            ediGridView.IdEdificio = item.IdEdificio;
                            ediGridView.Nombre = item.Nombre;
                            ediGridView.Direccion = item.Direccion;
                            ediGridView.BarrioCABA = barrioNombre.Nombre;
                            ediGridView.CodPostal = item.CodPostal;
                            ediGridView.CantPisos = item.CantPisos;
                            ediGridView.CantDptos = item.CantDptos;
                            ediGridView.CantCocheras = item.CantCocheras;
                            ediGridView.AnioCreacion = item.AnioCreacion;
                            ediGridView.FechaAlta = item.FechaAlta;
                            ediGridView.Amenities = item.Amenities;
                            ediGridView.Comentarios = item.Comentarios;

                            ListaGridViewBusqueda.Add(ediGridView);

                        }


                        gvListaEdificios.DataSource = ListaGridViewBusqueda;
                        gvListaEdificios.DataBind();
                    }

                }
                else if (anioCreacion != "" && barrio == "")
                {
                    List<Edificios> edificiosXAnioCreacion = new List<Edificios>();

                    edificiosXAnioCreacion = es.BuscaEdificiosXAnioCreacion(Convert.ToInt16(anioCreacion));

                    foreach (var item in edificiosXAnioCreacion)
                    {

                        EdificioGridView ediGridView = new EdificioGridView();

                        var barrioNombre = bs.BuscarBarrioXID(item.IdBarrioCABA);

                        ediGridView.IdEdificio = item.IdEdificio;
                        ediGridView.Nombre = item.Nombre;
                        ediGridView.Direccion = item.Direccion;
                        ediGridView.BarrioCABA = barrioNombre.Nombre;
                        ediGridView.CodPostal = item.CodPostal;
                        ediGridView.CantPisos = item.CantPisos;
                        ediGridView.CantDptos = item.CantDptos;
                        ediGridView.CantCocheras = item.CantCocheras;
                        ediGridView.AnioCreacion = item.AnioCreacion;
                        ediGridView.FechaAlta = item.FechaAlta;
                        ediGridView.Amenities = item.Amenities;
                        ediGridView.Comentarios = item.Comentarios;

                        ListaGridViewBusqueda.Add(ediGridView);

                    }

                    gvListaEdificios.DataSource = ListaGridViewBusqueda;
                    gvListaEdificios.DataBind();
                }
                else
                {
                    // barrio y anioCreacion no son null

                    int idBarrio = bs.BuscarUnBarrio(barrio);

                    if (idBarrio != 1000)
                    {
                        List<Edificios> edificiosXBarrioAnio = new List<Edificios>();

                        edificiosXBarrioAnio = es.BuscaEdificiosXBarrioYAnioCreacion(idBarrio, Convert.ToInt16(anioCreacion));

                        foreach (var item in edificiosXBarrioAnio)
                        {

                            EdificioGridView ediGridView = new EdificioGridView();

                            var barrioNombre = bs.BuscarBarrioXID(item.IdBarrioCABA);

                            ediGridView.IdEdificio = item.IdEdificio;
                            ediGridView.Nombre = item.Nombre;
                            ediGridView.Direccion = item.Direccion;
                            ediGridView.BarrioCABA = barrioNombre.Nombre;
                            ediGridView.CodPostal = item.CodPostal;
                            ediGridView.CantPisos = item.CantPisos;
                            ediGridView.CantDptos = item.CantDptos;
                            ediGridView.CantCocheras = item.CantCocheras;
                            ediGridView.AnioCreacion = item.AnioCreacion;
                            ediGridView.FechaAlta = item.FechaAlta;
                            ediGridView.Amenities = item.Amenities;
                            ediGridView.Comentarios = item.Comentarios;

                            ListaGridViewBusqueda.Add(ediGridView);

                        }

                        gvListaEdificios.DataSource = ListaGridViewBusqueda;
                        gvListaEdificios.DataBind();
                    }

                }
            }
            else
            {
                CargaTablaEdificios();
            }

        }

    }
}