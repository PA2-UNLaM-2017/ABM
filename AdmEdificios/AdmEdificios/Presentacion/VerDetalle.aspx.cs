using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdmEdificios.Negocio;

namespace AdmEdificios.Presentacion
{
    public partial class VerDetalle : System.Web.UI.Page
    {

        BarrioServicio bs = new BarrioServicio();
        EdificioServicio es = new EdificioServicio();
        Edificios edificio = new Edificios();

        protected void Page_Load(object sender, EventArgs e)
        {
            //CARGA EL EDIFICIO QUE QUIERO MODIFICAR 

            if (!Page.IsPostBack)
            {
                if (!String.IsNullOrEmpty(Request.QueryString["id"]))
                {
                    int idEdificio = Int32.Parse(Request.QueryString["id"]);

                    edificio = es.BuscarEdificio(idEdificio);
                    CargaEdificio(edificio);
                }
            }
        }


        public void CargaEdificio(Edificios edificio)
        {
            EdificioGridView edificioBarrio = new EdificioGridView();

            var barrio = bs.BuscarBarrioXID(edificio.IdBarrioCABA);

            edificioBarrio.IdEdificio = edificio.IdEdificio;
            edificioBarrio.Nombre = edificio.Nombre;
            edificioBarrio.Direccion = edificio.Direccion;
            edificioBarrio.BarrioCABA = barrio.Nombre;
            edificioBarrio.CodPostal = edificio.CodPostal;
            edificioBarrio.CantPisos = edificio.CantPisos;
            edificioBarrio.CantDptos = edificio.CantDptos;
            edificioBarrio.CantCocheras = edificio.CantCocheras;
            edificioBarrio.AnioCreacion = edificio.AnioCreacion;
            edificioBarrio.FechaAlta = edificio.FechaAlta;
            edificioBarrio.Amenities = edificio.Amenities;
            edificioBarrio.Comentarios = edificio.Comentarios;

            lblParaID.Text = edificioBarrio.IdEdificio.ToString();
            lblNombreEdificio.Text = edificioBarrio.Nombre;
            lblDireccionEdificio.Text = edificioBarrio.Direccion;
            lblBarrioCABA.Text = edificioBarrio.BarrioCABA;
            lblCodPostal.Text = edificioBarrio.CodPostal;
            lblCantPisos.Text = edificioBarrio.CantPisos.ToString();
            lblCantDptos.Text = edificioBarrio.CantDptos.ToString();
            lblCantCocheras.Text = edificioBarrio.CantCocheras.ToString();
            lblAnioCreacion.Text = edificioBarrio.AnioCreacion.ToString();
            lblFechaAlta.Text = edificioBarrio.FechaAlta.ToString("dd/MM/yyyy");
            lblAmenities.Text = edificioBarrio.Amenities;
            lblComentarios.Text = edificioBarrio.Comentarios.ToString();
        }


        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Presentacion/Home.aspx");
        }
    }
}