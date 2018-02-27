using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
 public  class Nciclo
    {
        public List<CicloEscolar> ListaCicloEscolar()
        {
            try
            {
                DCicloEscolar d = new DCicloEscolar();
                List<CicloEscolar> lista = d.ListaCicloEscolar();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void IngresarCicloEscolar(CicloEscolar c)
        {
            try
            {
                if (c.ciclo == 0)
                    throw new ArgumentException("Ingrese un Ciclo Valido");
                List<CicloEscolar> Lista = ListaCicloEscolar().Where(x => x.ciclo == c.ciclo).ToList();
                if (Lista.Count > 0)
                    throw new ArgumentException("El ciclo escolar " + c.ciclo + " ya eiste");
                DCicloEscolar d = new DCicloEscolar();
                d.IngresarCiclo(c);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ModificarCicloEscolar(CicloEscolar c)
        {
            try
            {
                if (c.ciclo == 0)
                    throw new ArgumentException("Ingrese un Ciclo Valido");
                DCicloEscolar d = new DCicloEscolar();
                d.ModificarCiclo(c);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void EliminarCicloEscolar(CicloEscolar c)
        {
            try
            {
                DCicloEscolar d = new DCicloEscolar();
                d.EliminarCiclo(c);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
