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
  public class DAulas
    {
        public List<EAulas> ListaAulas()
        {
            try
            {
                SqlCommand comando;
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);

                comando = new SqlCommand("select AulaId,AULA,CAPACIDAD,VACANTES,A.GradoId,GRADO from AULAS A inner join GRADOS G ON A.GradoId = G.GradoId", conexion);
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
                conexion.Open();
                List<EAulas> lista = new List<EAulas>();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    EAulas a = new EAulas();
                    a.CODIGO_AULA = (int)leer[0];
                    a.AULA = leer[1].ToString();
                    a.CAPACIDAD = (int)leer[2];
                    a.VACANTES = (int)leer[3];
                    a.GRADOS.GradoId = (int)leer[4];
                    a.GRADOS.Grado = leer[5].ToString();
                    lista.Add(a);
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
    }
}
