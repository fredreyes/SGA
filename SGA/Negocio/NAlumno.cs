using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class NAlumno
    {
        public List<EAlumnos> ListaAlumnos()
        {
            try
            {
                DAlumnos d = new DAlumnos();
                List<EAlumnos> lista = d.ListaAlunos();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void IngresarAlumno(EAlumnos alumno)
        {
            try
            {
                List<EAlumnos> lista = ListaAlumnos().Where(x => x.CodigoMined == alumno.CodigoMined).ToList();
                if (lista.Count > 0)
                    throw new ArgumentException("El codigo Mined " + alumno.CodigoMined + " ya existe");
                DAlumnos d = new DAlumnos();
                d.IngresarAlumno(alumno);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
