using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdmEdificios.Datos;

namespace AdmEdificios.Negocio
{
    public class UsuarioServicios
    {

        UsuarioDatos ud = new UsuarioDatos();

        // VA A BUSCAR LOS DATOS DEL USUARIO LOGUEADO
        public Usuarios TraerDatosUsuario(string emailIngresado)
        {
            return ud.TraerDatosUsuario(emailIngresado);
        }
    }
}