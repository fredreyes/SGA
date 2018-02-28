using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
   public class NAulas
    {
       
        public List<EAulas> ListaAulas()
        {
            DAulas D = new DAulas();
            List<EAulas> lista = D.ListaAulas();
                return lista;
        }
        public void IngresaAulas(EAulas e)
        {
            try
            {
                if (e.Aula == "")
                    throw new ArgumentException("Ingrese una Aula");
                List<EAulas> Lista = ListaAulas().Where(x => x.Aula == e.Aula && x.GradoId == e.GradoId).ToList();
                if(Lista.Count >0)
                    throw new ArgumentException("La Aula " + e.Aula + " ya existe");
            DAulas d= new DAulas();
            d.IngresarAula(e);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ModificarAulas(EAulas e)
        {
            try
            {
                if (e.Aula == "")
                    throw new ArgumentException("Ingrese una Aula");
                DAulas d = new DAulas();
                d.ModificarAula(e);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EliminarAulas(EAulas e)
        {
            try
            {
                DAulas d = new DAulas();
                d.EliminarAula(e);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
