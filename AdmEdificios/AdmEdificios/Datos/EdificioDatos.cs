using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdmEdificios.Datos
{
    public class EdificioDatos
    {

        AdmEdificiosEntities context = new AdmEdificiosEntities();


        // GUARDA EL EDIFICIO CREADO EN EL ALTA
        public void CrearEdificio(Edificios edificio)
        {

            context.Edificios.Add(edificio);
            context.SaveChanges();

        }


        // LISTA TODOS LOS EIDIFICIOS DE LA BASE DE DATOS
        public List<Edificios> ListarEdificios()
        {

            var edificios = context.Edificios.ToList();

            return edificios;

        }


        // BUSCAR UN EDIFICIO EN PARTICULAR
        public Edificios BuscarEdificio(int idEdificio)
        {

            Edificios edificio = context.Edificios.Single(e => e.IdEdificio == idEdificio);

            /*var edificio = (from e in context.Edificios
                             where e.IdEdificio == idEdificio
                            select e).Single();*/

            return edificio;

        }


        /* MODIFICAR
        public void ModificarTarea(int idTarea, int idCarpeta, string nombre, string descripcion, DateTime fechaFin, int prioridad)
        {
            Tareas tarea = context.Tareas.Where(e => e.IdTarea == idTarea).FirstOrDefault();
            tarea.IdCarpeta = idCarpeta;
            tarea.Nombre = nombre;
            tarea.Descripcion = descripcion;
            tarea.FechaFin = fechaFin;
            tarea.Prioridad = Convert.ToInt16(prioridad);
            context.SaveChanges();
        } */


        /* ELIMINAR
        public void EliminarTarea(int idTarea)
        {
            var baja = (from e in context.Tareas
                        where e.IdTarea == idTarea
                        select e).Single();

            context.Tareas.DeleteObject(baja);
            context.SaveChanges();
        }*/

    }
}