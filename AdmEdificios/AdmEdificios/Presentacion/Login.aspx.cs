using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AdmEdificios.Negocio;
using System.Net;

namespace AdmEdificios.Presentacion
{
    public partial class Login1 : System.Web.UI.Page
    {
        UsuarioServicios us = new UsuarioServicios();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string contraseniaIngresada = txtContrasenia.Text;
            string emailIngresado = txtEmail.Text;
            Usuarios miUsuario;
            miUsuario = us.TraerDatosUsuario(emailIngresado);
            if ((miUsuario != null) && (contraseniaIngresada == miUsuario.Contrasenia))
            {
                Session["Nombre"] = miUsuario.Nombre;
                Session["IdUsuario"] = miUsuario.IdUsuario;
                Session["Email"] = miUsuario.Email;

                Response.Redirect("~/Presentacion/Home.aspx");
            }

            else
            {
                txtEmail.Text = "";
                txtContrasenia.Text = "";
                lblMensaje1.ForeColor = System.Drawing.Color.Red;
                lblMensaje1.Text = "Verifique usuario y/o contraseña";
            }
        }
    }
}