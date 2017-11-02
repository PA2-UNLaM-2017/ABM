using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdmEdificios.Datos
{
    public class BarrioDatos
    {

        AdmEdificiosEntities context = new AdmEdificiosEntities();

        // LISTA TODOS LOS BARRIOS DE CABA
        public List<BarriosCABA> ListarBarrios()
        {

            var barrios = context.BarriosCABA.ToList();

            return barrios;

        }


        // BUSCA UN BARRIO POR SU NOMBRE Y DEVUELVE SU ID
        public int BuscarUnBarrio(string nombreBarrio)
        {
            
            int idBarrio;

            try
            {
                var barrio = (from e in context.BarriosCABA
                              where e.Nombre == nombreBarrio
                              select e).Single();

                idBarrio = Convert.ToInt16(barrio.IdBarrio);
            }
            catch (InvalidOperationException) // si la consulta no encuentra el barrio salvo el error
            {
                idBarrio = 1000;
            }

            return idBarrio; 
      
        }

    }
}