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
  public class DAsignatura
    {
        SqlCommand comando = new SqlCommand();
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
        public List<EAsignatura> listaAsignatura()
        {
            try
            {
                comando = new SqlCommand("SELECT * FROM Asignaturas");
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
                conexion.Open();
                List<EAsignatura> lista = new List<EAsignatura>();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    EAsignatura A = new EAsignatura();
                    A.AsignaturaId = (int)leer[0];
                    A.Asignatura = leer[1].ToString();
                    A.Activo = Convert.ToBoolean(leer[2]);
                    lista.Add(A);
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

        public void IngresarAsignatura(EAsignatura a)
        {
            try
            {
                comando = new SqlCommand("INSERTAR_ASIGNATURAS");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NOMBRE", a.Asignatura);
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
        public void ModificarAsignatura(EAsignatura A)
        {
            try
            {
                comando = new SqlCommand("MODIFICAR_ASIGNATURAS");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NOMBRE",A.Asignatura);
                comando.Parameters.AddWithValue("@ACTIVO", A.Activo);
                comando.Parameters.AddWithValue("@CODIGO_ASIGNATURA", A.AsignaturaId);
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
