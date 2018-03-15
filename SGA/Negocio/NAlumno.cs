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
        public void IngresarAlumno(EAlumnos alumno,EPadres_Tutor padres, EDocuemntosAlumnos documentos)
        {
            try
            {
                //List<EAlumnos> lista = ListaAlumnos(alumno).Where(x => x.CodigoMined == alumno.CodigoMined).ToList();
                //if (lista.Count > 0)
                  //  throw new ArgumentException("El codigo Mined " + alumno.CodigoMined + " ya existe");
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
