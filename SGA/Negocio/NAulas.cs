using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
   public class NAulas
    {
        public List<EAulas> ListaAulas()
        {
           
                DAulas n = new DAulas();
                List<EAulas> lista = n.ListaAulas();
                return lista;
         
        }
    }
}
