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
    public partial class GestionProyectos : System.Web.UI.Page
    {
        private ProyectoNegocio proyectoNegocio = new ProyectoNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarProyectos();
            }
        }

        private void CargarProyectos()
        {
            gvProyectos.DataSource = proyectoNegocio.ObtenerProyectos();
            gvProyectos.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Proyecto nuevoProyecto = new Proyecto
            {
                Codigo = txtCodigo.Text,
                Nombre = txtNombre.Text,
                FechaInicio = Convert.ToDateTime(txtFechaInicio.Text),
                FechaFin = Convert.ToDateTime(txtFechaFin.Text)
            };

            proyectoNegocio.AgregarProyecto(nuevoProyecto);
            CargarProyectos();
        }

        protected void gvProyectos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int proyectoID = Convert.ToInt32(gvProyectos.DataKeys[e.RowIndex].Value);
            proyectoNegocio.EliminarProyecto(proyectoID);
            CargarProyectos();
        }
    }
}
