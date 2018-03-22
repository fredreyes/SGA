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
 public   class DPlanClase
    {
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
        public void IngresarPlanClase(EplanClase pc)
        {
            try
            {
                comando = new SqlCommand("IngresarPlanClase");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@AsignaturaId", pc.Asignatura.AsignaturaId );
                comando.Parameters.AddWithValue("@GradoId", pc.Grado.GradoId);
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
        public void BuscarListaAsignaturaGrado(int id, ListBox cbm)
        {
            SqlCommand comando = new SqlCommand("BuscarAsignaturaPorGrados");
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@GradoId", id);
            comando.Connection = conexion;
            conexion.Open();
            SqlDataAdapter Adaptador = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            Adaptador.Fill(dt);
            conexion.Close();
            //DataRow fila = dt.NewRow();
            //fila["modelo"] = "Selecc";
            //dt.Rows.InsertAt(fila, 0);
            cbm.DataSource = dt;
        }
        //public List<EplanClase> BuscarListaAsignaturaGrado(int GradoID)
        //{
        //    try
        //    {
        //        comando = new SqlCommand("",conexion);
        //        comando.CommandType = CommandType.StoredProcedure;
        //        comando.Parameters.AddWithValue("@", GradoID);
        //        conexion.Open();
        //        SqlDataReader leer = comando.ExecuteReader();
        //        List<EplanClase> lista = new List<EplanClase>();
        //        while (leer.Read())
        //        {
        //            EplanClase pc = new EplanClase();
        //            pc.PlanClaseID = (int)leer[0];
        //            pc.Asignatura.AsignaturaId = (int)leer[1];
        //            pc.Asignatura.Asignatura = leer[2].ToString();
        //            pc.Grado.GradoId = (int)leer[3];
        //            pc.CicloEscolar.ciclo = (int)leer[4];
        //            lista.Add(pc);
        //        }
        //        leer.Close();
        //        conexion.Close();
        //        return lista;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public List<EMateriasDocentes> BuscarDocenteAsignatura(int AsignaturaID)
        {
            try
            {
                comando = new SqlCommand("BuscarDocenePorAsignatura", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Asignatura", AsignaturaID);
                conexion.Open();
                SqlDataReader leer = comando.ExecuteReader();
                List<EMateriasDocentes> lista = new List<EMateriasDocentes>();
                while (leer.Read())
                {
                    EMateriasDocentes md = new EMateriasDocentes();
                    md.Funcionario.Nombres = leer[0].ToString();
                    md.Funcionario.Apellidos = leer[1].ToString();
                    md.Asignatura.Asignatura = leer[2].ToString();
                    md.Funcionario.FuncionarioId = (int)leer[3];
                    lista.Add(md);
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
