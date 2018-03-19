using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class NNotas
    {

        public void IngresarCalificaciones(ENotas notas)
        {
            try
            {
                DNotas d = new DNotas();
                d.IngresarCalificacion(notas);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
