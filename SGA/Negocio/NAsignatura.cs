using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
  public class NAsignatura
    {
        public List<EAsignatura> ListaAsignatura()
        {
            try
            {
                DAsignatura d = new DAsignatura();
                List<EAsignatura> l = d.listaAsignatura();
                return l;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void IngresarAsignatura(EAsignatura A)
        {
            try
            {
                if (A.Asignatura == "")
                    throw new ArgumentException("Ingrese una Asignatura");
                List<EAsignatura> lista = ListaAsignatura().Where(x => x.Asignatura == A.Asignatura).ToList();
                    if(lista.Count>0)
                            throw new ArgumentException("La Asignatura: " + A.Asignatura + " ya existe");
                DAsignatura d = new DAsignatura();
                d.IngresarAsignatura(A);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ModificarAsignatura(EAsignatura A)
        {
            try
            {
                DAsignatura d = new DAsignatura();
                d.ModificarAsignatura(A);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
