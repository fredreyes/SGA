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
    public class DMateriaDocente
    {
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
        public List<EMateriasDocentes> ListaMateriaDocente()
        {
            try
            {
                string sql = "select MateriaDocenteId,MD.FuncionarioId, CONCAT(Nombres, ' ',Apellidos) AS Docente, MD.AsignaturaId, Asignatura,MD.TurnoID,Turno,Primaria,Secundaria \n"+
                             "from dbd.MateriaDocente MD \n"+
                             "inner join dbd.Funcionarios F on MD.FuncionarioId = F.FuncionarioId \n"+
                             "inner join dba.Asignaturas A on MD.AsignaturaId = A.AsignaturaId \n" +
                             "inner join dba.Turnos t on MD.TurnoID = t.TurnoId";

                comando = new SqlCommand(sql,conexion);
                comando.CommandType = CommandType.Text;
                conexion.Open();
                List<EMateriasDocentes> lista = new List<EMateriasDocentes>();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    EMateriasDocentes md = new EMateriasDocentes();
                    md.MateriaDocenteId = (int)leer[0];
                    md.Funcionario.FuncionarioId = (int)leer[1];
                    md.Funcionario.Nombres = leer[2].ToString();
                    md.Asignatura.AsignaturaId = (int)leer[3];
                    md.Asignatura.Asignatura = leer[4].ToString();
                    md.turno.TurnoId = (int)leer[5];
                    md.turno.Turno = leer[6].ToString();
                    md.Primaria = (bool)leer[7];
                    md.Secundaria = (bool)leer[8];
                    lista.Add(md);
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

        public void IngresarMateriaDocente(EMateriasDocentes md)
        {
            try
            {
                comando = new SqlCommand("IngresarMateriaDocente");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@FuncionarioId", md.Funcionario.FuncionarioId);
                comando.Parameters.AddWithValue("@AsignaturaId", md.Asignatura.AsignaturaId);
                comando.Parameters.AddWithValue("@TurnoID", md.turno.TurnoId);
                comando.Parameters.AddWithValue("@Primaria", md.Primaria);
                comando.Parameters.AddWithValue("@Secundaria", md.Secundaria);
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

        public void ModificarMateriaDocente(EMateriasDocentes md)
        {
            try
            {
                comando = new SqlCommand("ModificarMateriaDocente");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@AsignaturaId", md.Asignatura.AsignaturaId);
                comando.Parameters.AddWithValue("@TurnoID", md.turno.TurnoId);
                comando.Parameters.AddWithValue("@Primaria", md.Primaria);
                comando.Parameters.AddWithValue("@Secundaria", md.Secundaria);
                comando.Parameters.AddWithValue("@MateriaDocenteId", md.MateriaDocenteId);
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

        public void EliminarMateriaDocente(EMateriasDocentes md)
        {
            try
            {
                comando = new SqlCommand("EliminarMateriaDocente");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@MateriaDocenteID", md.MateriaDocenteId);
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
