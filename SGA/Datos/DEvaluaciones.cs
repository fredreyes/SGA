using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
   public class DEvaluaciones
    {
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
        public List<EEvaluaciones> ListaEvaluaciones()
        {
            try
            {
                comando = new SqlCommand("select EvaluacionId,Mes,Pacial,Observaciones,E.CicloEscolarId,ciclo,E.Activo from Evaluaciones E inner join CicloEscolar C ON E.CicloEscolarId = C.CicloEscolarId");
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
                conexion.Open();
                List<EEvaluaciones> Lista = new List<EEvaluaciones>();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    EEvaluaciones E = new EEvaluaciones();
                    E.EvaluacionId = (int)leer[0];
                    E.Mes = leer[1].ToString();
                    E.Pacial = leer[2].ToString();
                    E.Observaciones = leer[3].ToString();
                    E.CicloEscolar.CicloEscolarId = (int)leer[4];
                    E.CicloEscolar.ciclo = (int)leer[5];
                    E.Activo = (bool)leer[6];
                    Lista.Add(E);
                }
                leer.Close();
                conexion.Close();
                conexion.Dispose();
                return Lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void IngresarEvaluaciones(EEvaluaciones e)
        {
            try
            {
                comando = new SqlCommand("InsertarEvaluaciones");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Mes", e.Mes);
                comando.Parameters.AddWithValue("@Pacial", e.Pacial);
                comando.Parameters.AddWithValue("@Observaciones", e.Observaciones);
                comando.Parameters.AddWithValue("@CicloEscolarId", e.CicloEscolar.CicloEscolarId);
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
