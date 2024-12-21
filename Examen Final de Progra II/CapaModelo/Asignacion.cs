using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examen_Final_de_Progra_II.CapaModelo
{
    public class Asignacion
    {
        public int AsignacionID { get; set; }
        public int EmpleadoID { get; set; }
        public int ProyectoID { get; set; }
        public string NombreEmpleado { get; set; }
        public string NombreProyecto { get; set; }
        public DateTime FechaAsignacion { get; set; }
    }
}