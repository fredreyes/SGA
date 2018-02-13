using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class NColegio
    {
        public List<EColegios> ListaColegios()
        {
            DColegios c = new DColegios();
            List<EColegios> lista = c.ListaColegios();
            return lista;
        }

    }
}
