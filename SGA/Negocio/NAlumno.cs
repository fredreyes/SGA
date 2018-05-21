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
        public EAlumnos ListaAlumnos(EAlumnos alumno)
        {
            try
            {
                DAlumnos d = new DAlumnos();
                return d.BuscarAlumno(alumno);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<EAlumnos> ListaAlumnoMatricula()
        {
            try
            {
                DAlumnos d = new DAlumnos();
                List<EAlumnos> lista = d.ListaAlumno();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<EAlumnos> ListaTotalAlumnos()
        {
            try
            {
                DAlumnos d = new DAlumnos();
                List<EAlumnos> lista = d.ListaTotalAlumnos();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void IngresarAlumno(EAlumnos alumno,EPadres_Tutor padres, EDocuemntosAlumnos documentos)
        {
            try
            {
                DAlumnos d = new DAlumnos();
                d.IngresarAlumno(alumno,padres,documentos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ModificarAlumno(EAlumnos alumno, EPadres_Tutor padres, EDocuemntosAlumnos documentos)
        {
            try
            {
                DAlumnos d = new DAlumnos();
                d.ModificarAlumno(alumno, padres, documentos);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
