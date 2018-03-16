using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocio
{
 public  class NMateriaDocenteID
    {
        public List<EMateriasDocentes> ListaMateriaDocente()
        {
            try
            {
                DMateriaDocente d = new DMateriaDocente();
                List<EMateriasDocentes> lista = d.ListaMateriaDocente();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void IngresarMateriaDocente(EMateriasDocentes md)
        {
            try
            {
                DMateriaDocente n = new DMateriaDocente();
                n.IngresarMateriaDocente(md);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ModificarMateriaDocente(EMateriasDocentes md)
        {
            try
            {
                DMateriaDocente n = new DMateriaDocente();
                n.ModificarMateriaDocente(md);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EliminarMateriaDocente(EMateriasDocentes md)
        {
            try
            {
                DMateriaDocente n = new DMateriaDocente();
                n.EliminarMateriaDocente(md);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
