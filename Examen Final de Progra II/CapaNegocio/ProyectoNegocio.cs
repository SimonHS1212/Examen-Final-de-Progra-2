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
    public class ProyectoNegocio
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;

        public List<Proyecto> ObtenerProyectos()
        {
            List<Proyecto> proyectos = new List<Proyecto>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("ConsultarProyectos", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    proyectos.Add(new Proyecto
                    {
                        ProyectoID = Convert.ToInt32(reader["ProyectoID"]),
                        Codigo = reader["Codigo"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        FechaInicio = Convert.ToDateTime(reader["FechaInicio"]),
                        FechaFin = Convert.ToDateTime(reader["FechaFin"])
                    });
                }
            }
            return proyectos;
        }

        public void AgregarProyecto(Proyecto proyecto)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("InsertarProyecto", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", proyecto.Codigo);
                cmd.Parameters.AddWithValue("@Nombre", proyecto.Nombre);
                cmd.Parameters.AddWithValue("@FechaInicio", proyecto.FechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", proyecto.FechaFin);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EliminarProyecto(int proyectoID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("EliminarProyecto", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProyectoID", proyectoID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
