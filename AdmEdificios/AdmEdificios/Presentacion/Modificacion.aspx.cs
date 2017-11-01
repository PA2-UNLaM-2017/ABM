﻿using System;
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
                    cblAmenities.Items.FindByValue(item).Selected = true;                
                }           
            }
        }

    }
}