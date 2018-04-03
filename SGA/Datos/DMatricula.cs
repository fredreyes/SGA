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
   public class DMatricula
    {
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
        public void IngresarTurno(EMatricula m)
        {
            try
            {
                comando = new SqlCommand("IngresarMatricula", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CicloEscolarId", m.Ciclo.CicloEscolarId);
                comando.Parameters.AddWithValue("@AlumnoId", m.Alumnos.AlumnoId);
                comando.Parameters.AddWithValue("@GradoId", m.Grados.GradoId);
                comando.Parameters.AddWithValue("@FechaMatricula", m.FechaMatricula);
                comando.Parameters.AddWithValue("@Repitente", m.Repitente);
                comando.Parameters.AddWithValue("@TurnoId", m.Turno.TurnoId);
                comando.Parameters.AddWithValue("@ColegioId", m.Colegio.ColegioId);
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

        public List<EAulas> MostrarVacantesAulas( string turno, int id)
        {
            comando = new SqlCommand("mostrarVacantesAula", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Gradoid", id);
            comando.Parameters.AddWithValue("@Turno", turno);
            conexion.Open();
            SqlDataReader leer = comando.ExecuteReader();
            List<EAulas> lista = new List<EAulas>();
            while (leer.Read())
            {
                EAulas a = new EAulas();
                a.Aula = leer[0].ToString();
                a.Capacidad = (int)leer[1];
                lista.Add(a);
            }
           leer.Close();
           conexion.Close();
           conexion.Dispose();
           return lista;
        }
           
    }
}
