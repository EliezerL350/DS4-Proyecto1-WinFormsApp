using API.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace API.Services
{
    public class HistorialService
    {
        private string connectionString = ConfigurationManager
            .ConnectionStrings["CalculadoraDB"].ConnectionString;

        public List<Historial> GetAll()
        {
            List<Historial> lista = new List<Historial>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Historial ORDER BY Id DESC";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Historial
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Operacion = reader["Operacion"].ToString(),
                            Resultado = reader["Resultado"].ToString(),
                            Fecha = Convert.ToDateTime(reader["Fecha"])
                        });
                    }
                }
            }
            return lista;
        }

        public List<Historial> GetByOperacion(string simbolo)
        {
            List<Historial> lista = new List<Historial>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Historial WHERE Operacion LIKE @op ORDER BY Id DESC";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@op", "%" + simbolo + "%");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Historial
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Operacion = reader["Operacion"].ToString(),
                                Resultado = reader["Resultado"].ToString(),
                                Fecha = Convert.ToDateTime(reader["Fecha"])
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}


 