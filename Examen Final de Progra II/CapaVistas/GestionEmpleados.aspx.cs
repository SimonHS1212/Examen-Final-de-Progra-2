using Examen_Final_de_Progra_II.CapaModelo;
using Examen_Final_de_Progra_II.CapaVistas;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Remoting.Messaging;
using System.Web.UI.WebControls;
using System.Web.UI;
using System;
using Examen_Final_de_Progra_II.CapaNegocio;


namespace Examen_Final_de_Progra_II.CapaVistas
{
    public partial class GestionEmpleados : System.Web.UI.Page
    {
        private EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarEmpleados();
                CargarCategorias();
            }
        }

        private void CargarEmpleados()
        {
            gvEmpleados.DataSource = empleadoNegocio.ObtenerEmpleados();
            gvEmpleados.DataBind();
        }

        private void CargarCategorias()
        {
            ddlCategoria.DataSource = empleadoNegocio.ObtenerCategorias();
            ddlCategoria.DataTextField = "Nombre";
            ddlCategoria.DataValueField = "CategoriaID";
            ddlCategoria.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Empleado nuevoEmpleado = new Empleado
            {
                NumeroCarnet = txtNumeroCarnet.Text,
                Nombre = txtNombre.Text,
                FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text),
                CategoriaID = Convert.ToInt32(ddlCategoria.SelectedValue),
                Salario = string.IsNullOrEmpty(txtSalario.Text) ? 250000 : Convert.ToDecimal(txtSalario.Text),
                Direccion = string.IsNullOrEmpty(txtDireccion.Text) ? "San José" : txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text
            };

            empleadoNegocio.AgregarEmpleado(nuevoEmpleado);
            CargarEmpleados();
        }

        protected void gvEmpleados_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int empleadoID = Convert.ToInt32(gvEmpleados.DataKeys[e.RowIndex].Value);
            empleadoNegocio.EliminarEmpleado(empleadoID);
            CargarEmpleados();
        }
    }
}

