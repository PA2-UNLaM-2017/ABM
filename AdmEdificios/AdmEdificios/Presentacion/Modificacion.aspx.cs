using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdmEdificios.Negocio;

namespace AdmEdificios.Presentacion
{
    public partial class Modificacion : System.Web.UI.Page
    {
        BarrioServicio barrioServicio = new BarrioServicio();
        EdificioServicio es = new EdificioServicio();
        Edificios edificio = new Edificios();

        protected void Page_Load(object sender, EventArgs e)
        {

            //CARGA EL EDIFICIO QUE QUIERO MODIFICAR 

            if (!Page.IsPostBack)
            {
                if (!String.IsNullOrEmpty(Request.QueryString["id"]))
                {

                    ddlBarrioCABA.DataSource = barrioServicio.ListarBarrios();
                    ddlBarrioCABA.DataTextField = "Nombre";
                    ddlBarrioCABA.DataValueField = "IdBarrio";
                    ddlBarrioCABA.DataBind();

                    int idEdificio = Int32.Parse(Request.QueryString["id"]);

                    edificio = es.BuscarEdificio(idEdificio);
                    CargaEdificio(edificio);

                }
            }

        }


         public void CargaEdificio(Edificios edificio)
        {
            lblParaID.Text = edificio.IdEdificio.ToString();
            txtNombreEdificio.Text = edificio.Nombre;
            txtDireccion.Text = edificio.Direccion;
            ddlBarrioCABA.SelectedValue = edificio.IdBarrioCABA.ToString();
            txtCodPostal.Text = edificio.CodPostal;
            txtCantPisos.Text = edificio.CantPisos.ToString();
            txtCantDptos.Text = edificio.CantDptos.ToString();
            txtCocheras.Text = edificio.CantCocheras.ToString();
            txtAnioCreacion.Text = edificio.AnioCreacion.ToString();
            calNuevaTareaFecha.SelectedDate = edificio.FechaAlta;
            txtComentarios.Text = edificio.Comentarios.ToString();

            if (edificio.Amenities != "Ninguno")
            {
                string[] separo;

                separo = edificio.Amenities.Split('|');

                foreach (string item in separo)
                {
                    if(item != "")
                        cblAmenities.Items.FindByValue(item).Selected = true;                
                }           
            }
        }

         protected void btnGuardarCambios_Click(object sender, EventArgs e)
         {
             Edificios edificio = new Edificios();

             int idEdi = Convert.ToInt16(lblParaID.Text);

             edificio.Nombre = txtNombreEdificio.Text;
             edificio.Direccion = txtDireccion.Text;
             edificio.IdBarrioCABA = Convert.ToInt16(ddlBarrioCABA.SelectedValue);
             edificio.CodPostal = txtCodPostal.Text;
             edificio.CantPisos = Convert.ToInt16(txtCantPisos.Text);
             edificio.CantDptos = Convert.ToInt16(txtCantDptos.Text);
             edificio.CantCocheras = Convert.ToInt16(txtCocheras.Text);
             edificio.AnioCreacion = Convert.ToInt16(txtAnioCreacion.Text);
             edificio.FechaAlta = calNuevaTareaFecha.SelectedDate.Date;
             edificio.Comentarios = txtComentarios.Text;

             int itemsChequeados = 0;
             string amenities = "";

             foreach (ListItem item in cblAmenities.Items)
             {
                 if (item.Selected)
                 {
                     itemsChequeados++;
                     amenities += String.Concat(item.Value, "|");
                 }
             }

             if (itemsChequeados != 0)
             {
                 edificio.Amenities = amenities.ToString();
             }
             else
             {
                 edificio.Amenities = "Ninguno";
             }


             es.ModificarEdificio(idEdi, edificio);


             Response.Redirect("~/Presentacion/Home.aspx");
         }

         protected void btnCancelar_Click(object sender, EventArgs e)
         {
             Response.Redirect("~/Presentacion/Home.aspx");
         }

    }
}