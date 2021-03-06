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
  public  class DDepartamentos
    {
        //Conexion
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);
        //Lista de Departamentos
        public List<EDepartamentos> ListaDepartmento()
        {
            try
            {
                comando = new SqlCommand("SELECT * FROM dba.Departamentos");
                comando.CommandType = CommandType.Text;
                comando.Connection = conexion;
                conexion.Open();
                List<EDepartamentos> lista = new List<EDepartamentos>();
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    EDepartamentos d = new EDepartamentos();
                    d.DepartamentoID = (int)leer[0];
                    d.Departamento = leer[1].ToString();
                    lista.Add(d);
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
        //Ingresar Departamento
        public void IngresarDepartamento(EDepartamentos d)
        {
            try
            {
                comando = new SqlCommand("IngresarDepartamento");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Departamento", d.Departamento);
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
        //Modificar Departamento
        public void ModificarDepartamento(EDepartamentos d)
        {
            try
            {
                comando = new SqlCommand("ModificarDepartamento");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Departamento", d.Departamento);
                comando.Parameters.AddWithValue("@DepartamentoId", d.DepartamentoID);
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
        //Eliminar Departamento, siempre y cuando el registro este recientemente ingresado (NO FOREIGNK KEY)
        public void EliminarDepartamento(EDepartamentos d)
        {
            try
            {
                comando = new SqlCommand("EliminarDepartamento");
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@DepartamentoId", d.DepartamentoID);
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
