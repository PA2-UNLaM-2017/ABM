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

            gvListaEdificios.DataSource = edificios;
            gvListaEdificios.DataBind();

        }


        /* protected void btnEliminar_Click(object sender, EventArgs e)
         {
             Button btn = (Button)sender;
             GridViewRow row = (GridViewRow)btn.NamingContainer;

             int idEdificio = int.Parse(gvListaEdificios.DataKeys[row.RowIndex].Value.ToString());

             //NECESITO LLEVAR EL OBJETO A LA PAGINA DE ELIMINACION

             es.BuscarEdificio(idEdificio);

           //  CargaTablaEdificios();
         }*/

    }
}