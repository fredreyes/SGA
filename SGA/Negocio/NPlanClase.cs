using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
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
        public List<EplanClase> BuscarAsignaturaGrado(int  GradoId)
        {
            try
            {
                DPlanClase d = new DPlanClase();
                List<EplanClase> lista = d.BuscarListaAsignaturaGrado(GradoId);
                return lista;
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
