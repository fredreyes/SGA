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
        public void IngresarMatricula(EMatricula m)
        {
            try
            {
                comando = new SqlCommand("IngresarMatricula", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@AlumnoId", m.Alumnos.AlumnoId);
                comando.Parameters.AddWithValue("@GradoId", m.Grados.GradoId);
                comando.Parameters.AddWithValue("@Seccion", m.seccion);
                comando.Parameters.AddWithValue("@Repitente", m.Repitente);
                comando.Parameters.AddWithValue("@TurnoId", m.Turno.TurnoId);
                comando.Parameters.AddWithValue("@ColegioId", m.ColegioId);
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

        public List<EAulas> MostrarVacantesAulas( int turnoid, int id)
        {
            comando = new SqlCommand("mostrarVacantesAula", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Gradoid", id);
            comando.Parameters.AddWithValue("@Turno", turnoid);
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

        public List<EMatricula> ListaMatriculas()
        {
            comando = new SqlCommand("ListaMatricula", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            SqlDataReader leer = comando.ExecuteReader();
            List<EMatricula> lista = new List<EMatricula>();
            while (leer.Read())
            {
                EMatricula a = new EMatricula();
                a.MatriculaId = (int)leer[0];
                a.FechaMatricula = (DateTime)leer[1];
                a.Ciclo.CicloEscolarId = (int)leer[2];
                a.Ciclo.ciclo = (int)leer[3];
                a.Alumnos.AlumnoId = (int)leer[4];
                a.Alumnos.Nombres = leer[5].ToString();
                a.Grados.GradoId = (int)leer[6];
                a.Grados.Grado = leer[7].ToString();
                a.seccion = leer[8].ToString();
                a.Turno.TurnoId = (int)leer[9];
                a.Turno.Turno = leer[10].ToString();
                a.ColegioId = (int)leer[11];
                a.Colegio = leer[12].ToString();
                a.Repitente = leer[13].ToString();
                lista.Add(a);
            }
            leer.Close();
            conexion.Close();
            conexion.Dispose();
            return lista;
        }
    }
}
