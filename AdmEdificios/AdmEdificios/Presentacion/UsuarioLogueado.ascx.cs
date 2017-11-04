using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdmEdificios.Presentacion
{
    public partial class UsuarioLogueado : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string Usuario
        {

            get { return lblUsuario.Text; }

            set { lblUsuario.Text = value; }

        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Response.Redirect("~/Presentacion/Login.aspx");
        }
    }
}