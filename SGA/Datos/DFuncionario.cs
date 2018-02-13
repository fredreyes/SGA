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
   public class DFuncionario
    {
        public List<EFuncionarios> ListaFuncionarios()
        {
            try
            {
                SqlCommand comando;
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);

                comando = new SqlCommand("select ID_FUNCIONARIO,NOMBRE,APELLIDO,SEXO,FECHA_NACIMIENTO,CEDULA,TELEFONO,CARGO,F.OCUPACION_ID,NOMBRE_OCUPACION FROM FUNCIONARIOS F INNER JOIN PROFESION_OCUPACION O ON F.OCUPACION_ID = O.OCUPACION_ID", conexion);
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
                conexion.Open();
                List<EFuncionarios> lista = new List<EFuncionarios>();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    EFuncionarios f = new EFuncionarios();
                    f.ID_FUNCIONARIO = (int)leer[0];
                    f.NOMBRE = leer[1].ToString();
                    f.APELLIDO = leer[2].ToString();
                    f.SEXO = leer[3].ToString();
                    f.FECHA_NACIMIENTO = Convert.ToDateTime(leer[4].ToString());
                    f.CEDULA = leer[5].ToString();
                    f.TELEFONO = leer[6].ToString();
                    f.CARGO = leer[7].ToString();
                    f.EMAIL = leer[8].ToString();
                    f.OCUPACION_ID = (int)leer[9];
                    f.OCUPACION = leer[10].ToString();
                    lista.Add(f);
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
