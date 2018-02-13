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
    public class DGrados
    {
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
        public List<EGrados> ListaGrados()
        {
            try
            {
                comando = new SqlCommand("select * FROM GRADOS ", conexion);
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
                conexion.Open();
                List<EGrados> lista = new List<EGrados>();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    EGrados g = new EGrados();
                    g.GradoId = (int)leer[0];
                    g.Grado = leer[1].ToString();
                    g.Tipo = leer[2].ToString();
                    lista.Add(g);
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

        public void IngresarGrados(EGrados g)
        {
            try
            {
                comando = new SqlCommand("");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
