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
        public void IngresarColegio(EColegios c)
        {
            try
            {
                if (c.Colegio == "")
                    throw new ArgumentException("Ingrese Nombre del Colegio");
                List<EColegios> l = ListaColegios().Where(x => x.Colegio == c.Colegio.ToLower()).ToList();
                if(l.Count >0)
                    throw new ArgumentException("El Colegio : " + c.Colegio + " ya existe");
                DColegios d = new DColegios();
                d.IngresarColegio(c);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ModificarColegio(EColegios c)
        {
            try
            {
                if (c.Colegio == "")
                    throw new ArgumentException("Ingrese Nombre del Colegio");
                DColegios d = new DColegios();
                d.ModificarColegio(c);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
