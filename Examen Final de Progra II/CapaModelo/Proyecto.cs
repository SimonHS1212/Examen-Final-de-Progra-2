using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen_Final_de_Progra_II.CapaModelo
{
    public class Proyecto
    {
        public int ProyectoID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}
