using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class NTurnos
    {
        public List<ETurnos> ListaTurnos()
        {
            try
            {
                DTurno d = new DTurno();
                List<ETurnos> l = d.ListaTurnos();
                return l;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void IngresarTurno(ETurnos t)
        {
            try
            {
                if (t.Turno == string.Empty)
                    throw new ArgumentException("Ingrese un Turno");
                List<ETurnos> lista = ListaTurnos().Where(x => x.Turno == t.Turno).ToList();
                if (lista.Count >0)
                    throw new ArgumentException("El Turno: " + t.Turno + " ya existe");
                DTurno d = new DTurno();
                d.IngresarTurno(t);
                    
            }
            catch (Exception ex)
            {
                throw ex; 
            }
        }
        public void ModificarTurno(ETurnos t)
        {
            try
            {
                if (t.Turno == string.Empty)
                    throw new ArgumentException("Ingrese un Turno");
                DTurno d = new DTurno();
                d.ModificarTurnos(t);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
