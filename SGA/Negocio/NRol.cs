using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;


namespace Negocio
{
public class NRol
    {

        public List<ERol> ListaRol()
        {
            try
            {
                DRol d = new DRol();
                List<ERol> lista = d.ListaRoles();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void IngresarRol(ERol rol)
        {
            try
            {
                DRol d = new DRol();
                d.IngresarRol(rol);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void ModificarRol(ERol rol)
        {
            try
            {
                DRol d = new DRol();
                d.ModificarRol(rol);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
