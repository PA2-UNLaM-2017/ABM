using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdmEdificios.Negocio;

namespace AdmEdificios.Presentacion
{
    public partial class Baja : System.Web.UI.Page
    {
        EdificioServicio es = new EdificioServicio();
        Edificios edificio = new Edificios();

        protected void Page_Load(object sender, EventArgs e)
        {
            //CARGAR EL EDIFICIO QUE QUIERO ELIMINAR 

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

            lblDatosEdificio.Text = edificio.Nombre + " situado en " + edificio.Direccion;
            lblGuardaIdEdificio.Text = edificio.IdEdificio.ToString();
        }

        protected void btnGuardarBaja_Click(object sender, EventArgs e)
        {

            int idEdificio = Int32.Parse(lblGuardaIdEdificio.Text);
            es.EliminarEdificio(idEdificio);
            Response.Redirect("~/Presentacion/Home.aspx");

        }

        protected void btnCancelarBaja_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Presentacion/Home.aspx");
        }
    }
}