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
    public class DColegios
    {
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
        public List<EColegios> ListaColegios()
        {
            try
            {
                string sql = "select ColegioId,Colegio,Telefono,c.DepartamentoId,Departamento from dba.colegio c inner \n"+
                              "join dba.Departamentos d on c.DepartamentoId = d.DepartamentoID";
                comando = new SqlCommand(sql, conexion);
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
                conexion.Open();
                List<EColegios> lista = new List<EColegios>();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    EColegios c = new EColegios();
                    c.ColegioId = (int)leer[0];
                    c.Colegio = leer[1].ToString();
                    c.Telefono = leer[2].ToString();
                    c.DepartamentoID = (int)leer["DepartamentoId"];
                    c.Departamento = leer["Departamento"].ToString();
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
        public void IngresarColegio(EColegios c)
        {
            try
            {
                comando = new SqlCommand("IngresarColegio");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Colegio", c.Colegio);
                comando.Parameters.AddWithValue("@Telefono", c.Telefono);
                comando.Parameters.AddWithValue("@DepartamentoId", c.DepartamentoID);
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
        public void ModificarColegio(EColegios c)
        {
            try
            {
                comando = new SqlCommand("ModificarColegio");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Colegio", c.Colegio);
                comando.Parameters.AddWithValue("@Telefono", c.Telefono);
                comando.Parameters.AddWithValue("@DepartamentoId", c.DepartamentoID);
                comando.Parameters.AddWithValue("@ColegioId", c.ColegioId);
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
        public void EliminarColegio(EColegios c)
        {
            try
            {
                comando = new SqlCommand("EliminarColegio");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@ColegioId", c.ColegioId);
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
