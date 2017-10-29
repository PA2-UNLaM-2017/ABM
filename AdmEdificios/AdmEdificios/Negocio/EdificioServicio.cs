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


        // VA A BUSCAR TODOS LOS EDIFICIOS DE LA BASE DE DATOS
        public List<Edificios> ListarEdificios()
        {
            return ed.ListarEdificios();
        }


        public Edificios BuscarEdificio(int idEdificio)
        {

            return ed.BuscarEdificio(idEdificio);

        }


        public void EliminarEdificio(int idEdificio)
         { 
            
            ed.EliminarEdificio(idEdificio);
        
         }

    }
}