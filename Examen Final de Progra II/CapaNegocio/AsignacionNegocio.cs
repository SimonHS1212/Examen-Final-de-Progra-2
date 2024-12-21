using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Examen_Final_de_Progra_II.CapaModelo;

namespace Examen_Final_de_Progra_II.CapaNegocio
{
    public class AsignacionNegocio
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;

        public List<Asignacion> ObtenerAsignaciones()
        {
            List<Asignacion> asignaciones = new List<Asignacion>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("ConsultarAsignaciones", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    asignaciones.Add(new Asignacion
                    {
                        AsignacionID = Convert.ToInt32(reader["AsignacionID"]),
                        NombreEmpleado = reader["Empleado"].ToString(),
                        NombreProyecto = reader["Proyecto"].ToString(),
                        FechaAsignacion = Convert.ToDateTime(reader["FechaAsignacion"])
                    });
                }
            }
            return asignaciones;
        }

        public void AgregarAsignacion(Asignacion asignacion)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("InsertarAsignacion", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpleadoID", asignacion.EmpleadoID);
                cmd.Parameters.AddWithValue("@ProyectoID", asignacion.ProyectoID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarAsignacion(int asignacionID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("EliminarAsignacion", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AsignacionID", asignacionID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
