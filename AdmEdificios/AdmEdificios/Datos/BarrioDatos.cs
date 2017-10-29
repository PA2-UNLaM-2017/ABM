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

    }
}