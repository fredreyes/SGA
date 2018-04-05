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
    public  class DUsuario
    {
        SqlCommand comando;
        SqlConnection conexion = new SqlConnection(Properties.Settings.Default.CadenaConexion);

        public EUsuarios Login(EUsuarios user)
        {
            try
            {
                comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "LoginUsuario";
                comando.Parameters.AddWithValue("@Usuario", user.Usuario);
                comando.Parameters.AddWithValue("@Password", user.Password);
                comando.Connection = conexion;
                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataTable tb = new DataTable();
                da.Fill(tb);
                if (tb.Rows.Count > 0)
                {
                    EUsuarios usuario = new EUsuarios();
                    usuario.UsuarioID = (int)tb.Rows[0]["UsuarioID"];
                    usuario.Usuario = tb.Rows[0]["Usuario"].ToString();
                    usuario.Password = tb.Rows[0]["Password"].ToString();
                    usuario.FuncionarioID = (int)tb.Rows[0]["FuncionarioID"];
                    usuario.FuncionarioName = tb.Rows[0]["Nombres"].ToString();
                    usuario.FuncionarioLastName = tb.Rows[0]["Apellidos"].ToString();
                    usuario.Rol.RolId = Convert.ToInt32(tb.Rows[0]["RolID"].ToString());
                    usuario.Rol.Descripcion = tb.Rows[0]["Descripcion"].ToString();
                    usuario.Rol.Matricula = Convert.ToBoolean(tb.Rows[0]["Matricula"]);
                    usuario.Rol.Administracion = Convert.ToBoolean(tb.Rows[0]["Administracion"]);
                    usuario.Rol.Funcionarios = Convert.ToBoolean(tb.Rows[0]["Funcionarios"]);
                    usuario.Rol.Calificaciones = Convert.ToBoolean(tb.Rows[0]["Calificaciones"]);
                    usuario.Activo = Convert.ToBoolean(tb.Rows[0]["Activo"]);
                    return usuario;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void IngresarUsuario(EUsuarios u)
        {
            try
            {
                comando = new SqlCommand("IngresarUsuario", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Usuario", u.Usuario);
                comando.Parameters.AddWithValue("@Password", u.Password);
                comando.Parameters.AddWithValue("@FuncionarioID", u.FuncionarioID);
                comando.Parameters.AddWithValue("@RolId", u.Rol.RolId);
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
