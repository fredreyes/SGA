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
        public List<EGrados> ListaGrados()
        {
            try
            {
                SqlCommand comando;
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);

                comando = new SqlCommand("select * FROM GRADOS ", conexion);
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
                conexion.Open();
                List<EGrados> lista = new List<EGrados>();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    EGrados g = new EGrados();
                    g.CODIGO_GRADO = (int)leer[0];
                    g.GRADO = leer[1].ToString();
                    g.TIPO = leer[2].ToString();
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
    }
}
