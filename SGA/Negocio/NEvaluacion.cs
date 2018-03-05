using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
 public   class NEvaluacion
    {
        public List<EEvaluaciones> ListaEvaluacion()
        {
            try
            {
                DEvaluaciones d = new DEvaluaciones();
                List<EEvaluaciones> Lista = d.ListaEvaluaciones();
                return Lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void IngresarEvaluaciones(EEvaluaciones e)
        {
            try
            {
                DEvaluaciones d = new DEvaluaciones();
                d.IngresarEvaluaciones(e);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EliminarEvaluaciones(EEvaluaciones e)
        {
            try
            {
                DEvaluaciones d = new DEvaluaciones();
                d.EliminarEvaluaciones(e);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
