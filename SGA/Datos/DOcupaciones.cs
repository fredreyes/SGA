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
                comando = new SqlCommand("SELECT OCUPACION_ID,UPPER(NOMBRE_OCUPACION)FROM PROFESION_OCUPACION", conexion);
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
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
