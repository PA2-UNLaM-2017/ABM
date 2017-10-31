using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdmEdificios.Negocio;
using System.Text;

namespace AdmEdificios.Presentacion
{
    public partial class Alta : System.Web.UI.Page
    {
        BarrioServicio barrioServicio = new BarrioServicio();
        EdificioServicio edificioServicio = new EdificioServicio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                calNuevaTareaFecha.SelectedDate = DateTime.Now.Date; // Selecciona el dia de hoy en el calendario.
                ddlBarrioCABA.DataSource = barrioServicio.ListarBarrios();
                ddlBarrioCABA.DataTextField = "Nombre";
                ddlBarrioCABA.DataValueField = "IdBarrio";
                ddlBarrioCABA.DataBind();
            }

        }

        protected void btnGuardarEdificio_Click(object sender, EventArgs e)
        {

            Edificios edificio = new Edificios();

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
            //StringBuilder amenities = new StringBuilder();
            string amenities = "";

            foreach(ListItem item in cblAmenities.Items)
            {
                if(item.Selected)
                {
                    itemsChequeados++;

                   // amenities.Append(item.Value);
                    amenities += String.Concat(item.Value,"|");
                
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
            

            edificioServicio.CrearEdificio(edificio);
            Response.Redirect("~/Presentacion/Home.aspx");

        }

    }
}