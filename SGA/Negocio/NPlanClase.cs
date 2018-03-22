using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.Windows.Forms;

namespace Negocio
{
    public class NPlanClase
    {
        public void IngresarPlanClase(EplanClase pc)
        {
            try
            {
                DPlanClase d = new DPlanClase();
                d.IngresarPlanClase(pc);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
  
        public void CargarAsignaturaPorGrado(int id, ListBox cbm)
        {
            try
            {
                DPlanClase d = new DPlanClase();
                d.BuscarListaAsignaturaGrado(id, cbm);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<EMateriasDocentes> BuscarDocentePorAsignatura(int AsignaturaId)
        {
            try
            {
                DPlanClase d = new DPlanClase();
                List<EMateriasDocentes> lista = d.BuscarDocenteAsignatura(AsignaturaId);
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
