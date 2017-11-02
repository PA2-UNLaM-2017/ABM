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

            gvListaEdificios.DataSource = edificios;
            gvListaEdificios.DataBind();

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

            string barrio = txtBuscaBarrio.Text;
            string anioCreacion = txtBuscaAnioCreacion.Text;

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

                        gvListaEdificios.DataSource = edificiosXBarrio;
                        gvListaEdificios.DataBind(); 
                    }

                }
                else if(anioCreacion != "" && barrio == "")
                {
                    // anioCreacion no es null


                }
                else
                {
                    // barrio y anioCreacion no son null
                
                }
            }


        }



    }
}