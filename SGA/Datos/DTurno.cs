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
   public class DTurno
    {
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
        public List<ETurnos> ListaTurnos()
        {
            try
            {
                comando = new SqlCommand("select * from dba.turnos", conexion);
                comando.CommandType = CommandType.Text;
                conexion.Open();
                List<ETurnos> lista = new List<ETurnos>();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    ETurnos t = new ETurnos();
                    t.TurnoId = (int)leer[0];
                    t.Turno = leer[1].ToString();
                    t.Descripcion = leer[2].ToString();
                    t.Activo = Convert.ToBoolean(leer[3]);
                    lista.Add(t);
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
        public void IngresarTurno(ETurnos t)
        {
            try
            {
                comando = new SqlCommand("InsertarTurnos");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Turno", t.Turno);
                comando.Parameters.AddWithValue("@Descripcion", t.Descripcion);
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
        public void ModificarTurnos(ETurnos t)
        {
            try
            {
                comando = new SqlCommand("ModificarTurnos");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Turno", t.Turno);
                comando.Parameters.AddWithValue("@Descripcion", t.Descripcion);
                comando.Parameters.AddWithValue("@Activo", t.Activo);
                comando.Parameters.AddWithValue("@TurnoId", t.TurnoId);
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
        public void EliminarTurnos(ETurnos t)
        {
            try
            {
                comando = new SqlCommand("eliminarTurno");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@TurnoId", t.TurnoId);
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
