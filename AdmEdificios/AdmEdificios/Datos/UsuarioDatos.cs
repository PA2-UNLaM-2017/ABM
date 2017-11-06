using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdmEdificios.Datos
{
    public class UsuarioDatos
    {

        AdmEdificiosEntities context = new AdmEdificiosEntities();

        // METODO PARA PODER LOGUEARSE
        public Usuarios TraerDatosUsuario(string mail)
        {
            Usuarios user = new Usuarios();

            try
            {
                user = (from Usuarios in context.Usuarios
                            where Usuarios.Email == mail
                            select Usuarios).First();
            }
            catch (InvalidOperationException)
            {
                user = null;
            }
            
            return user;
        }

    }
}