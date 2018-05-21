using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class DGrados
    {
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
        public List<EGrados> ListaGrados()
        {
            try
            {
                comando = new SqlCommand("select * FROM dba.GRADOS ", conexion);
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
                conexion.Open();
                List<EGrados> lista = new List<EGrados>();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    EGrados g = new EGrados();
                    g.GradoId = (int)leer[0];
                    g.Grado = leer[1].ToString();
                    g.Tipo = leer[2].ToString();
                    g.Activo = (bool)leer[3];
                    lista.Add(g);
                }
                leer.Close();
                conexion.Close();
                conexion.Dispose();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void IngresarGrados(EGrados g)
        {
            try
            {
                comando = new SqlCommand("InsertarGrados");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Grado", g.Grado);
                comando.Parameters.AddWithValue("@Tipo", g.Tipo);
                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                conexion.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ModificarGrados(EGrados g)
        {
            try
            {
                comando = new SqlCommand("ModificarGrados");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Grado", g.Grado);
                comando.Parameters.AddWithValue("@Tipo", g.Tipo);
                comando.Parameters.AddWithValue("@Activo", g.Activo);
                comando.Parameters.AddWithValue("@GradoId", g.GradoId);
                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                conexion.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void EliminarGrados(EGrados g)
        {
            try
            {
                comando = new SqlCommand("eliminarGrado");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@GradoId", g.GradoId);
                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                conexion.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
