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
  public  class DAlumnos
    {
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
        public List<EAlumnos> ListaAlunos()
        {
            try
            {
                comando = new SqlCommand("select * from Alumnos", conexion);
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
                conexion.Open();
                List<EAlumnos> lista = new List<EAlumnos>();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    EAlumnos a = new EAlumnos();
                    a.AlumnoId = (int)leer[0];
                    a.Nombres = leer[1].ToString();
                    a.Apellidos = leer[2].ToString();
                    a.Sexo = leer[3].ToString();
                    a.FechaNacimiento = (DateTime)leer[4];
                    a.Direccion = leer[5].ToString();
                    a.CodigoMined = (int)leer[6];
                    a.Activo = (bool)leer[7];
                    lista.Add(a);
                }
                leer.Close();
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void IngresarAlumno(EAlumnos a)
        {
            try
            {
                comando = new SqlCommand("IngresarEstudiante");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombres", a.Nombres);
                comando.Parameters.AddWithValue("@Apellidos", a.Apellidos);
                comando.Parameters.AddWithValue("@Sexo", a.Sexo);
                comando.Parameters.AddWithValue("@FechaNacimiento", a.FechaNacimiento);
                comando.Parameters.AddWithValue("@Direccion", a.Direccion);
                comando.Parameters.AddWithValue("@CodigoMined", a.CodigoMined);
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
