using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdmEdificios.Datos;

namespace AdmEdificios.Negocio
{
    public class EdificioServicio
    {

        EdificioDatos ed = new EdificioDatos();

        // TRANSPORTA EL OBJETO EDIFICIO A LA CAPA DE DATOS PARA SER GUARDADO
        public void CrearEdificio(Edificios edificio)
        {
            ed.CrearEdificio(edificio);
        }

    }
}