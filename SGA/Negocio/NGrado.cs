using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class NGrado
    {
        public List<EGrados>ListaGrados()
        {
            try
            {
                DGrados d = new DGrados();
                List<EGrados> l = d.ListaGrados();
                return l;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
