using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ENotas
    {
        public int CalificacionesId { get; set; }
        public EAlumnos Alumno { get; set; }
        public  EMateriasDocentes MateriaDocente { get; set; }
        public int Acumulado { get; set; }
        public int Examen { get; set; }
        public int Rescate { get; set; }
        public  EEvaluaciones Evaluacion { get; set; }
        public string Observacion { get; set; }
        public ENotas()
        {
            Alumno = new EAlumnos();
            Evaluacion = new EEvaluaciones();
        }
    }
}
