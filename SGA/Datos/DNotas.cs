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
  public  class DNotas
    {
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
        //public List<ETurnos> ListaCalificaciones()
        //{
        //    try
        //    {
        //        comando = new SqlCommand("select * from turnos");
        //        comando.CommandType = CommandType.Text;
        //        comando.Connection = conexion;
        //        conexion.Open();
        //        List<ETurnos> lista = new List<ETurnos>();
        //        SqlDataReader leer = comando.ExecuteReader();
        //        while (leer.Read())
        //        {
        //            ETurnos t = new ETurnos();
        //            t.TurnoId = (int)leer[0];
        //            t.Turno = leer[1].ToString();
        //            t.Descripcion = leer[2].ToString();
        //            t.Activo = Convert.ToBoolean(leer[3]);
        //            lista.Add(t);
        //        }
        //        leer.Close();
        //        conexion.Close();
        //        conexion.Dispose();
        //        return lista;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

        public void IngresarCalificacion(ENotas notas)
        {
            try
            {
                comando = new SqlCommand("IngresarCalificaciones");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@AlumnoId", notas.Alumno.AlumnoId);
                comando.Parameters.AddWithValue("@MateriaDocenteId", notas.MateriaDocente.MateriaDocenteId);
                comando.Parameters.AddWithValue("@Acumulado", notas.Acumulado);
                comando.Parameters.AddWithValue("@Examen", notas.Examen);
                comando.Parameters.AddWithValue("@Rescate", notas.Rescate);
                //comando.Parameters.AddWithValue("@EvaluacionId", notas.Evaluacion.EvaluacionId);
                comando.Parameters.AddWithValue("@Observacion", notas.Observacion);
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
