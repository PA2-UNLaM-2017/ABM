using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdmEdificios.Negocio;

namespace AdmEdificios.Presentacion
{
    public partial class Alta : System.Web.UI.Page
    {
        BarrioServicio barrioServicio = new BarrioServicio();
        EdificioServicio edificioServicio = new EdificioServicio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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
            edificio.Amenities = "SUM";
            //edificio.Amenities = Convert.ToString(cblAmenities.Items);
            edificio.FechaAlta = calNuevaTareaFecha.SelectedDate.Date;
            edificio.Comentarios = txtComentarios.Text;



            edificioServicio.CrearEdificio(edificio);
            Response.Redirect("~/Presentacion/Home.aspx");

        }


        /*protected void btnGuardarTarea_Click(object sender, EventArgs e)
        {
            Tarea tarea = new Tarea();

            int idUsuario = Convert.ToInt32(Session["IdUsuario"]);
            int id = Convert.ToInt32(ddlNuevaTareaIdCarpeta.SelectedValue);
            tarea.IdCarpeta = id;
            tarea.IdUsuario = idUsuario;
            tarea.Nombre = txtNuevaTareaNombre.Text;
            tarea.Descripcion = txtNuevaTareaDescripcion.Text;
            tarea.Fecha = calNuevaTareaFecha.SelectedDate.Date;
            tarea.Prioridad = Convert.ToInt16(ddlNuevaTareaPrioridad.SelectedValue);

            if (tarea.Fecha >= DateTime.Now.Date)
            {
                tareaService.CrearNuevaTarea(tarea);
                Response.Redirect("~/Presentacion/Home.aspx");
            }
            else
            {
                lblError.Text = "La fecha tienen que ser mayor o igual al dia de hoy";
            }
        }*/
    }
}