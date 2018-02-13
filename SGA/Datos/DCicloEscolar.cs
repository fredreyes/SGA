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
        public List<CicloEscolar> ListaCicloEscolar()
        {
            try
            {
                SqlCommand comando;
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);

                comando = new SqlCommand("select * from CICLO_ESCOLAR", conexion);
                comando.CommandType = CommandType.Text;
                conexion.Open();
                List<CicloEscolar> lista = new List<CicloEscolar>();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    CicloEscolar c = new CicloEscolar();
                    c.ID_CICLO = (int)leer[0];
                    c.AÑO = (int)leer[1];
                    c.FECHA_INICIO = Convert.ToDateTime(leer[2].ToString());
                    c.FECHA_FIN = Convert.ToDateTime(leer[3].ToString());
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
