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
        public void IngresarGrado(EGrados g)
        {
            try
            {
                DGrados n = new DGrados();
                n.IngresarGrados(g);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ModificarGrado(EGrados g)
        {
            try
            {
                NGrado n = new NGrado();
                n.ModificarGrado(g);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
