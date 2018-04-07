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
            public List<EAulas> MostraVacantesLibres( int turno, int id)
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
        public List<EMatricula> ListaMatriculas()
        {
            try
            {
                DMatricula d = new DMatricula();
                List<EMatricula> lista = d.ListaMatriculas();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void IngresarMatricula(EMatricula matricula)
        {
            try
            {
                DMatricula d = new DMatricula();
                d.IngresarMatricula(matricula);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
