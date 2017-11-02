using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdmEdificios
{
    public class EdificioGridView
    {
        public int IdEdificio { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string BarrioCABA { get; set; }
        public string CodPostal { get; set; }
        public short CantPisos { get; set; }
        public short CantDptos { get; set; }
        public short CantCocheras { get; set; }
        public short AnioCreacion { get; set; }
        public string Amenities { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public string Comentarios { get; set; }

    }
}