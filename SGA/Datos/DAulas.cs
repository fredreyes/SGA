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
  public class DAulas
    {
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
        public List<EAulas> ListaAulas()
        {
            try
            {
                string sql = "select AulaId,Aula,Capacidad,Vacantes,A.GradoId,Grado,A.activo,A.TurnoId, Turno \n"+
                            "from dba.Aulas A \n"+
                            "inner join dba.Grados G ON A.GradoId = G.GradoId \n"+
                            "inner join dba.Turnos T on A.TurnoId = T.TurnoId";
                comando = new SqlCommand(sql, conexion);
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
                conexion.Open();
                List<EAulas> lista = new List<EAulas>();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    EAulas a = new EAulas();
                    a.AulaId = (int)leer[0];
                    a.Aula = leer[1].ToString();
                    a.Capacidad = (int)leer[2];
                    a.Vacantes = (int)leer[3];
                    a.GradoId = (int)leer[4];
                    a.Grado = leer[5].ToString();
                    a.Activo = (bool)leer[6];
                    a.Turno = Convert.ToInt32(leer[7].ToString());
                    a.TurnoName = leer[8].ToString();
                    lista.Add(a);
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
        public void IngresarAula(EAulas A)
        {
            try
            {
                comando = new SqlCommand("IngresarAula",conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Aula", A.Aula);
                comando.Parameters.AddWithValue("@capacidad", A.Capacidad);
                comando.Parameters.AddWithValue("@Vacantes", A.Vacantes);
                comando.Parameters.AddWithValue("@GradoId", A.GradoId);
                comando.Parameters.AddWithValue("@Turno", A.Turno);
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

        public void ModificarAula(EAulas A)
        {
            try
            {
                comando = new SqlCommand("ModificarAula");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Aula", A.Aula);
                comando.Parameters.AddWithValue("@capacidad", A.Capacidad);
                comando.Parameters.AddWithValue("@Vacantes", A.Vacantes);
                comando.Parameters.AddWithValue("@GradoId", A.GradoId);
                comando.Parameters.AddWithValue("@Turno", A.Turno);
                comando.Parameters.AddWithValue("@activo", A.Activo);
                comando.Parameters.AddWithValue("@AulaId", A.AulaId);
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

        public void EliminarAula(EAulas A)
        {
            try
            {
                comando = new SqlCommand("EliminarAulas");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@AulaId", A.AulaId);
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
