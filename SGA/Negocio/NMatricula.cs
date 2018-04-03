using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
   public class NMatricula
    {
            public List<EAulas> MostraVacantesLibres( string turno, int id)
        {
            try
            {
                DMatricula d = new DMatricula();
                List<EAulas> lista = d.MostrarVacantesAulas(turno, id);
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
