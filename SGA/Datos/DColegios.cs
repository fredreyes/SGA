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
        public List<EColegios> ListaColegios()
        {
            try
            {
                SqlCommand comando;
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);

                comando = new SqlCommand("select * from Colegio", conexion);
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
                conexion.Open();
                List<EColegios> lista = new List<EColegios>();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    EColegios c = new EColegios();
                    c.COLEGIO_ID = (int)leer[0];
                    c.NOMBRE_COLEGIO = leer[1].ToString();
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
    }
}
