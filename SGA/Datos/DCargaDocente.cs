using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Datos
{
 public   class DCargaDocente
    {
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
        public void IngresarCargaDocente(ECargaDocente cd)
        {
            try
            {
                comando = new SqlCommand("InsertarCargaAcademicaDocente");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@FuncionarioId",cd.FuncionarioId );
                comando.Parameters.AddWithValue("@AsingaturaId", cd.AsingaturaId);
                comando.Parameters.AddWithValue("@GradoId", cd.GradoId);
                comando.Parameters.AddWithValue("@CicloEscolarID", cd.CicloEscolarID);
                comando.Parameters.AddWithValue("@TurnoID", cd.TurnoId);                
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
