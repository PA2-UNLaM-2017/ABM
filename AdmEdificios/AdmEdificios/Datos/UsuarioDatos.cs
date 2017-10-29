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

            //var user = context.Usuarios.Where(e => e.Email == mail);

            var user = (from Usuarios in context.Usuarios
                        where Usuarios.Email == mail
                        select Usuarios).First();
            return user;
       
        }

    }
}