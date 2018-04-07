using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocio
{
  public  class NUsuario
    {

        public EUsuarios Login(EUsuarios user)
        {
            try
            {
                DUsuario datosUsuario = new DUsuario();
                return datosUsuario.Login(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<EUsuarios> ListaUsuarios() {
            try
            {
                DUsuario d = new DUsuario();
                List<EUsuarios> listaUsuarios = d.ListaUsuarios();
                return listaUsuarios;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<EAlumnos> ListaUsers()
        {
            try
            {
                DUsers d = new DUsers();
                List<EAlumnos> listaUsuarios = d.ListarUsers();
                return listaUsuarios;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void IngresarUsuario(EUsuarios usuario)
        {
            try
            {
                DUsuario d = new DUsuario();
                d.IngresarUsuario(usuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ModificarsUsuario(EUsuarios usuario)
        {
            try
            {
                DUsuario d = new DUsuario();
                d.ModificarUsuario(usuario);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
