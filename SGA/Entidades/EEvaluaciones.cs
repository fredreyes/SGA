using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EEvaluaciones
    {
        public int ID_EVALUACION { get; set; }
        public string MES { get; set; }
        public string PARCIAL { get; set; }
        public string OBSERVACIONES { get; set; }
        public int ID_CICLO { get; set; }
    }
}
