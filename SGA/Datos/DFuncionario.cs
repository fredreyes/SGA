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

                comando = new SqlCommand
               ("select FuncionarioId,Nombres,Apellidos,Cedula,Sexo,FechaNacimiento,Telefono,Cargo,F.OcupacionId,Ocupacion,Email,Foto,Activo \n"+
               "from funcionarios f inner join ProfesionOcupacion po on f.OcupacionId = po.OcupacionId",conexion);
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
                conexion.Open();
                List<EFuncionarios> lista = new List<EFuncionarios>();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    EFuncionarios f = new EFuncionarios();
                    f.FuncionarioId = (int)leer[0];
                    f.Nombres = leer[1].ToString();
                    f.Apellidos = leer[2].ToString();
                    f.Cedula = leer[3].ToString();
                    f.Sexo = leer[4].ToString();
                    f.FechaNacimiento = (DateTime)leer[5];
                    f.Telefono = leer[6].ToString();
                    f.Cargo = leer[7].ToString();
                    f.Ocupacion.OcupacionId = (int)leer[8];
                    f.Ocupacion.Ocupacion = leer[9].ToString();
                    f.Email = leer[10].ToString();
                    f.Foto = (byte[])leer[11];
                    f.Activo = (bool)leer[12];
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
