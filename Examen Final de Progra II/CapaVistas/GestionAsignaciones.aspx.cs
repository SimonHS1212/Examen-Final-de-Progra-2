using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Examen_Final_de_Progra_II.CapaNegocio;
using Examen_Final_de_Progra_II.CapaModelo;

namespace Examen_Final_de_Progra_II.CapaVistas
{
    public partial class GestionAsignaciones : System.Web.UI.Page
    {
        private AsignacionNegocio asignacionNegocio = new AsignacionNegocio();
        private EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();
        private ProyectoNegocio proyectoNegocio = new ProyectoNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarAsignaciones();
                CargarEmpleados();
                CargarProyectos();
            }
        }

        private void CargarAsignaciones()
        {
            gvAsignaciones.DataSource = asignacionNegocio.ObtenerAsignaciones();
            gvAsignaciones.DataBind();
        }

        private void CargarEmpleados()
        {
            ddlEmpleado.DataSource = empleadoNegocio.ObtenerEmpleados();
            ddlEmpleado.DataTextField = "Nombre"; // Campo del nombre del empleado
            ddlEmpleado.DataValueField = "EmpleadoID";
            ddlEmpleado.DataBind();
        }

        private void CargarProyectos()
        {
            ddlProyecto.DataSource = proyectoNegocio.ObtenerProyectos();
            ddlProyecto.DataTextField = "Nombre"; // Campo del nombre del proyecto
            ddlProyecto.DataValueField = "ProyectoID";
            ddlProyecto.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Asignacion nuevaAsignacion = new Asignacion
            {
                EmpleadoID = Convert.ToInt32(ddlEmpleado.SelectedValue),
                ProyectoID = Convert.ToInt32(ddlProyecto.SelectedValue)
            };

            asignacionNegocio.AgregarAsignacion(nuevaAsignacion);
            CargarAsignaciones();
        }

        protected void gvAsignaciones_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int asignacionID = Convert.ToInt32(gvAsignaciones.DataKeys[e.RowIndex].Value);
            asignacionNegocio.EliminarAsignacion(asignacionID);
            CargarAsignaciones();
        }
    }
}
