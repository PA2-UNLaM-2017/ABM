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

            edificios = es.ListarEdificios();

            int elementos = ConvierteLista(edificios); // convierte lista Edificios a lista EdificiosGridView

            if (elementos == 0)
            {
                lblMsjBusqueda.Text = "&#xf06a; No hay edificios agregados";
                lblMsjBusqueda.Visible = true;
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string barrio = txtBuscaBarrio.Text;
            string anioCreacion = txtBuscaAnioCreacion.Text;
            lblMsjBusqueda.Visible = false;

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

                        int elementos = ConvierteLista(edificiosXBarrio); // convierte lista Edificios a lista EdificiosGridView

                        if (elementos == 0)
                        {
                            lblMsjBusqueda.Text = "&#xf06a; No hay edificios para ese barrio";
                            lblMsjBusqueda.Visible = true;
                        }
                    }
                    else
                    {
                        lblBusquedaBarrio.Visible = true;
                    }
                }
                else if (anioCreacion != "" && barrio == "")
                {
                    // año no es null

                    List<Edificios> edificiosXAnioCreacion = new List<Edificios>();

                    edificiosXAnioCreacion = es.BuscaEdificiosXAnioCreacion(Convert.ToInt16(anioCreacion));

                    int elementos = ConvierteLista(edificiosXAnioCreacion); // convierte lista Edificios a lista EdificiosGridView

                    if (elementos == 0)
                    {
                        lblMsjBusqueda.Text = "&#xf06a; No hay edificios para ese año";
                        lblMsjBusqueda.Visible = true;
                    }
                }
                else
                {
                    // barrio y anioCreacion no son null

                    int idBarrio = bs.BuscarUnBarrio(barrio);

                    if (idBarrio != 1000)
                    {
                        List<Edificios> edificiosXBarrioAnio = new List<Edificios>();

                        edificiosXBarrioAnio = es.BuscaEdificiosXBarrioYAnioCreacion(idBarrio, Convert.ToInt16(anioCreacion));

                        int elementos = ConvierteLista(edificiosXBarrioAnio); // convierte lista Edificios a lista EdificiosGridView

                        if (elementos == 0)
                        {
                            lblMsjBusqueda.Text = "&#xf06a; No hay edificios para ese barrio en ese año";
                            lblMsjBusqueda.Visible = true;
                        } 
                    }
                    else
                    {
                        lblBusquedaBarrio.Visible = true;
                    }
                }
            }
            else
            {
                CargaTablaEdificios();
            }
        }


        public int ConvierteLista(List<Edificios> edificios)
        {
            List<EdificioGridView> ListaGridView = new List<EdificioGridView>();

            foreach (var item in edificios)
            {
                EdificioGridView edificioGridView = new EdificioGridView();

                var barrioNombre = bs.BuscarBarrioXID(item.IdBarrioCABA);

                edificioGridView.IdEdificio = item.IdEdificio;
                edificioGridView.Nombre = item.Nombre;
                edificioGridView.Direccion = item.Direccion;
                edificioGridView.BarrioCABA = barrioNombre.Nombre;
                edificioGridView.CodPostal = item.CodPostal;
                edificioGridView.CantPisos = item.CantPisos;
                edificioGridView.CantDptos = item.CantDptos;
                edificioGridView.CantCocheras = item.CantCocheras;
                edificioGridView.AnioCreacion = item.AnioCreacion;
                edificioGridView.FechaAlta = item.FechaAlta;
                edificioGridView.Amenities = item.Amenities;
                edificioGridView.Comentarios = item.Comentarios;

                ListaGridView.Add(edificioGridView);
            }

            gvListaEdificios.DataSource = ListaGridView;
            gvListaEdificios.DataBind();

            return ListaGridView.Count();
        }

    }

}