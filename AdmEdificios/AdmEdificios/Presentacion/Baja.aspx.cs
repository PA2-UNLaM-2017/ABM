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

            if (!Page.IsPostBack)
            {
                if (!String.IsNullOrEmpty(Request.QueryString["id"]))
                {

                    int idEdi = Int32.Parse(Request.QueryString["id"]);

                    edificio = es.BuscarEdificio(idEdi);

                    CargaEdificio(edificio);

                }
            
            }
            //CARGAR EL EDIFICIO QUE QUIERO ELIMINAR    

        }


        public void CargaEdificio(Edificios edificio)
        {

            lblDatosEdificio.Text = edificio.Nombre;

        }
    }
}