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
 public  class DCicloEscolar
    {
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
        public List<CicloEscolar> ListaCicloEscolar()
        {
            try
            {
                comando = new SqlCommand("select * from CicloEscolar", conexion);
                comando.CommandType = CommandType.Text;
                conexion.Open();
                List<CicloEscolar> lista = new List<CicloEscolar>();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    CicloEscolar c = new CicloEscolar();
                    c.CicloEscolarId = (int)leer[0];
                    c.ciclo = (int)leer[1];
                    c.FechaInicio = Convert.ToDateTime(leer[2].ToString());
                    c.FechaFin = Convert.ToDateTime(leer[3].ToString());
                    c.Activo = (bool)leer[4];
                    lista.Add(c);
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

        public void IngresarCiclo(CicloEscolar c)
        {
            try
            {
                comando = new SqlCommand("IngresarCicloEscolar");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Ciclo", c.ciclo);
                comando.Parameters.AddWithValue("@FechaInicio", c.FechaInicio);
                comando.Parameters.AddWithValue("@FechaFin", c.FechaFin);
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

        public void ModificarCiclo(CicloEscolar c)
        {
            try
            {
                comando = new SqlCommand("ModificarCicloEscolar");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Ciclo", c.ciclo);
                comando.Parameters.AddWithValue("@FechaInicio", c.FechaInicio);
                comando.Parameters.AddWithValue("@FechaFin", c.FechaFin);
                comando.Parameters.AddWithValue("@Activo", c.Activo);
                comando.Parameters.AddWithValue("@CicloEscolarId", c.CicloEscolarId);
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

        public void EliminarCiclo(CicloEscolar c)
        {
            try
            {
                comando = new SqlCommand("EliminarCicloEscolar");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CicloEscolarId", c.CicloEscolarId);
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
