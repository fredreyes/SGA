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
    }
}
