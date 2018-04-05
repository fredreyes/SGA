﻿using System;
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
    }
}
