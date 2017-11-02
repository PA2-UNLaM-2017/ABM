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

            return edificio;

        }

        // ELIMINAR EDIFICIO
        public void EliminarEdificio(int idEdificio)
        {
            var baja = (from e in context.Edificios
                        where e.IdEdificio == idEdificio
                        select e).Single();

            context.Edificios.Remove(baja);
            context.SaveChanges();
        }


        // MODIFICA EDIFICIO
        public void ModificarEdificio(int idEdi, Edificios edificioModif)
        {
            Edificios edificioAnt = context.Edificios.Where(e => e.IdEdificio == idEdi).FirstOrDefault();
            edificioAnt.Nombre = edificioModif.Nombre;
            edificioAnt.Direccion = edificioModif.Direccion;
            edificioAnt.IdBarrioCABA = edificioModif.IdBarrioCABA;
            edificioAnt.CodPostal = edificioModif.CodPostal;
            edificioAnt.CantPisos = edificioModif.CantPisos;
            edificioAnt.CantDptos = edificioModif.CantDptos;
            edificioAnt.CantCocheras = edificioModif.CantCocheras;
            edificioAnt.AnioCreacion = edificioModif.AnioCreacion;
            edificioAnt.FechaAlta = edificioModif.FechaAlta;
            edificioAnt.Comentarios = edificioModif.Comentarios;
            edificioAnt.Amenities = edificioModif.Amenities;
            context.SaveChanges();
        }


        // BUSCA EDIFICIOS POR BARRIO
        public List<Edificios> BuscaEdificiosXBarrio(int idBarrio)
        {
            var edificiosXBarrio = context.Edificios.Where(e => e.IdBarrioCABA == idBarrio).ToList();

            return edificiosXBarrio;
        }



    }
}