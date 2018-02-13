using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ENotas
    {
        public int ID_NOTAS { get; set; }
        public string CODIGO_ALUMNO { get; set; }
        public int CODIGO_MATERIA_DOCENTE { get; set; }
        public int ACUMULADO { get; set; }
        public int EXAMEN { get; set; }
        public int ID_EVALUACION { get; set; }
        public string OBSERVACION { get; set; }

    }
}
