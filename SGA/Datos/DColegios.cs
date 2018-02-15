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
                comando = new SqlCommand("select * from Colegio", conexion);
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
                    c.Departamento.DepartamentoID = (int)leer[2];
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
                comando = new SqlCommand("INGRESAR_COLEGIO");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@COLEGIO", c.Colegio);
                comando.Parameters.AddWithValue("@DEPARTAMENTO_ID", c.Departamento.DepartamentoID);
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
                comando = new SqlCommand("MODIFICAR_COLEGIO");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@COLEGIO", c.Colegio);
                comando.Parameters.AddWithValue("@DEPARTAMENTO_ID", c.Departamento.DepartamentoID);
                comando.Parameters.AddWithValue("@COLEGIO_ID", c.ColegioId);
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
