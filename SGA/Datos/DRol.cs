using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
  public  class DRol
    {
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);

        public List<ERol> ListaRoles()
        {
            try
            {
                comando = new SqlCommand("select * from Rol");
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
                conexion.Open();
                List<ERol> lista = new List<ERol>();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    ERol r = new ERol();
                    r.RolId = (int)leer[0];
                    r.Descripcion = leer[1].ToString();
                    r.Matricula = Convert.ToBoolean(leer[2]);
                    r.Administracion = Convert.ToBoolean(leer[3]);
                    r.Funcionarios = Convert.ToBoolean(leer[4]);
                    r.Calificaciones = Convert.ToBoolean(leer[5]);
                    lista.Add(r);
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
        public void IngresarRol(ERol rol)
        {
            try
            {
                comando = new SqlCommand("IngresarRoles", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Descripcion", rol.Descripcion);
                comando.Parameters.AddWithValue("@Matricula", rol.Matricula);
                comando.Parameters.AddWithValue("@Administracion", rol.Administracion);
                comando.Parameters.AddWithValue("@Funcionarios", rol.Funcionarios);
                comando.Parameters.AddWithValue("@Calificaciones", rol.Calificaciones);
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
        public void ModificarRol(ERol rol)
        {
            try
            {
                comando = new SqlCommand("ModificarRoles", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Descripcion", rol.Descripcion);
                comando.Parameters.AddWithValue("@Matricula", rol.Matricula);
                comando.Parameters.AddWithValue("@Administracion", rol.Administracion);
                comando.Parameters.AddWithValue("@Funcionarios", rol.Funcionarios);
                comando.Parameters.AddWithValue("@Calificaciones", rol.Calificaciones);
                comando.Parameters.AddWithValue("@RolId", rol.RolId);
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
