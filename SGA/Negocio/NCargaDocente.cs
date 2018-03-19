using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;


namespace Negocio
{
  public  class NCargaDocente
    {
        public void IngresarCargaDocente(ECargaDocente cd)
        {
            DCargaDocente d = new DCargaDocente();
            d.IngresarCargaDocente(cd);
        }
    }
}
