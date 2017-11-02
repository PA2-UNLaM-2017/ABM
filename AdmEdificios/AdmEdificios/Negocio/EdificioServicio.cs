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


        // VA A BUSCAR EL EDIFICIO POR ID
        public Edificios BuscarEdificio(int idEdificio)
        {
            return ed.BuscarEdificio(idEdificio);
        }


        // VA A ELIMINAR EL EDIFICIO
        public void EliminarEdificio(int idEdificio)
        {      
           ed.EliminarEdificio(idEdificio); 
        }


        // VA A MODIFICAR EL EDIFICIO
        public void ModificarEdificio(int idEdi, Edificios edificio)
        {
            ed.ModificarEdificio(idEdi, edificio);  
        }

        // VA A BUSCAR EDIFICIOS POR BARRIO
        public List<Edificios> BuscaEdificiosXBarrio(int idBarrio)
        {
            return ed.BuscaEdificiosXBarrio(idBarrio);    
        }


        // VA A BUSCAR EDIFICIOS POR AÑO DE CREACIÓN
        public List<Edificios> BuscaEdificiosXAnioCreacion(int anioCreacion)
        {
            return ed.BuscaEdificiosXAnioCreacion(anioCreacion);
        }


        // BUSCA EDIFICIOS POR AÑO Y FECHA DE CREACION
        public List<Edificios> BuscaEdificiosXBarrioYAnioCreacion(int idBarrio, int anioCreacion)
        {
            return ed.BuscaEdificiosXBarrioYAnioCreacion(idBarrio, anioCreacion);
        }

    }
}