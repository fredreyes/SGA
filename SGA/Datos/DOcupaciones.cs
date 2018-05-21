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
    public class DOcupaciones
    {
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
        public List<EOcupaciones> ListaOcupaciones()
        {
            try
            {
                comando = new SqlCommand("select * from dbd.ProfesionOcupacion", conexion);
                comando.Connection = conexion;
                conexion.Open();
                SqlDataReader leer = comando.ExecuteReader();
                List<EOcupaciones> lista = new List<EOcupaciones>();
                while (leer.Read())
                {
                    EOcupaciones o = new EOcupaciones();
                    o.OcupacionId = (int)leer[0];
                    o.Ocupacion = leer[1].ToString();
                    lista.Add(o);
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
         public void IngresarOcupaciones(EOcupaciones o)
        {
            try
            {
                comando = new SqlCommand("InsertarOcupacion");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Ocupacion", o.Ocupacion);
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
        public void ModificarOcupaciones(EOcupaciones o)
        {
            try
            {
                comando = new SqlCommand("EditarOcupacion");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Ocupacion", o.Ocupacion);
                comando.Parameters.AddWithValue("@OcupacionId", o.OcupacionId);
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

        public void EliminarOcupaciones(EOcupaciones o)
        {
            try
            {
                comando = new SqlCommand("eliminarOcupacion");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@OcupacionId", o.OcupacionId);
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
