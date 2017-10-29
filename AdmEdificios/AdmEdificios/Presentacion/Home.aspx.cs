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

    }
}