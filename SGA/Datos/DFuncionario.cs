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
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
        public List<EFuncionarios> ListaFuncionarios()
        {
            try
            {
                string sql = "select FuncionarioId,Nombres,Apellidos,Cedula,Sexo,FechaNacimiento,Telefono,Cargo,F.OcupacionId,  \n"+
                              "Ocupacion,Email,Foto,Activo,isDocente \n" +
                              "from dbd.funcionarios f \n" +
                               "inner join dbd.ProfesionOcupacion po on f.OcupacionId = po.OcupacionId";
                comando = new SqlCommand(sql,conexion);
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
                    f.IsDocenet = (bool)leer[13];
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

        public List<EFuncionarios> ListaFuncionariosSinUsuario()
        {
            try
            {
                string sql = "select FuncionarioId,Nombres,Apellidos,Telefono,Cargo \n"+
                             "from dbd.Funcionarios where FuncionarioId not in (select FuncionarioID from Usuarios)";
                comando = new SqlCommand(sql, conexion);
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
                    f.Telefono = leer[3].ToString();
                    f.Cargo = leer[4].ToString();
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

        public void IngresarFuncionario(EFuncionarios f)
        {
            try
            {
                comando = new SqlCommand("IngresarFuncioarios", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombres", f.Nombres);
                comando.Parameters.AddWithValue("@Apellidos", f.Apellidos);
                comando.Parameters.AddWithValue("@Cedula", f.Cedula);
                comando.Parameters.AddWithValue("@Sexo", f.Sexo);
                comando.Parameters.AddWithValue("@FechaNacimiento", f.FechaNacimiento);
                comando.Parameters.AddWithValue("@Telefono", f.Telefono);
                comando.Parameters.AddWithValue("@Cargo", f.Cargo);
                comando.Parameters.AddWithValue("@OcupacionId", f.Ocupacion.OcupacionId);
                comando.Parameters.AddWithValue("@Email", f.Email);
                comando.Parameters.AddWithValue("@Foto", f.Foto);
                comando.Parameters.AddWithValue("@IsDocente", f.IsDocenet);
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
        public void ModificarFuncionario(EFuncionarios f)
        {
            try
            {
                comando = new SqlCommand("ModificarFuncioarios", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Nombres", f.Nombres);
                comando.Parameters.AddWithValue("@Apellidos", f.Apellidos);
                comando.Parameters.AddWithValue("@Cedula", f.Cedula);
                comando.Parameters.AddWithValue("@Sexo", f.Sexo);
                comando.Parameters.AddWithValue("@FechaNacimiento", f.FechaNacimiento);
                comando.Parameters.AddWithValue("@Telefono", f.Telefono);
                comando.Parameters.AddWithValue("@Cargo", f.Cargo);
                comando.Parameters.AddWithValue("@OcupacionId", f.Ocupacion.OcupacionId);
                comando.Parameters.AddWithValue("@Email", f.Email);
                comando.Parameters.AddWithValue("@Foto", f.Foto);
                comando.Parameters.AddWithValue("@activo", f.Activo);
                comando.Parameters.AddWithValue("@IsDocente", f.IsDocenet);
                comando.Parameters.AddWithValue("@FuncionarioId", f.FuncionarioId);
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
