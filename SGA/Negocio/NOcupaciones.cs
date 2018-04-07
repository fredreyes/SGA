using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class NOcupaciones
    {
        public List<EOcupaciones> ListaOcupaciones()
        {
            try
            {
                DOcupaciones d = new DOcupaciones();
                List<EOcupaciones> lista = d.ListaOcupaciones();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

             public void IngresarOcupacion(EOcupaciones o)
          {
            try
            {
                if (o.Ocupacion == "")
                    throw new ArgumentException("Ingrese un Nombre de Ocupación");
                List<EOcupaciones> l = ListaOcupaciones().Where(x => x.Ocupacion == o.Ocupacion).ToList();
                if (l.Count > 0)
                    throw new ArgumentException(o.Ocupacion + " " +" ya existe");

                DOcupaciones D = new DOcupaciones();
                D.IngresarOcupaciones(o);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ModifiarOcupacion(EOcupaciones o)
        {
            try
            {
                if (o.OcupacionId == 0)
                    throw new ArgumentException("La ocupación no es valida");
                DOcupaciones d = new DOcupaciones();
                d.ModificarOcupaciones(o);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EliminarOcupacion(EOcupaciones o)
        {
            try
            {
                if (o.OcupacionId == 0)
                    throw new ArgumentException("La ocupación no existe");
                DOcupaciones d = new DOcupaciones();
                d.EliminarOcupaciones(o);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }   
}
