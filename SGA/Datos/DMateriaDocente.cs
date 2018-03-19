﻿using System;
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
                comando = new SqlCommand("select MateriaDocenteId,MD.FuncionarioId, CONCAT(Nombres, ' ',Apellidos) AS Docente, MD.AsignaturaId, Asignatura,Mañana,Tarde,Noche,Sabado,Domingo from MateriaDocente MD inner join Funcionarios F on MD.FuncionarioId = F.FuncionarioId inner join Asignaturas A on MD.AsignaturaId = A.AsignaturaId",conexion);
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
                    md.mañana = (bool)leer[5];
                    md.tarde = (bool)leer[6];
                    md.noche = (bool)leer[7];
                    md.sabado = (bool)leer[8];
                    md.domingo = (bool)leer[9];
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
                comando.Parameters.AddWithValue("@Mañana", md.mañana);
                comando.Parameters.AddWithValue("@Tarde", md.tarde);
                comando.Parameters.AddWithValue("@Noche", md.noche);
                comando.Parameters.AddWithValue("@Sabado", md.sabado);
                comando.Parameters.AddWithValue("@Domingo", md.domingo);
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
                comando.Parameters.AddWithValue("@Mañana", md.mañana);
                comando.Parameters.AddWithValue("@Tarde", md.tarde);
                comando.Parameters.AddWithValue("@Noche", md.noche);
                comando.Parameters.AddWithValue("@Sabado", md.sabado);
                comando.Parameters.AddWithValue("@Domingo", md.domingo);
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