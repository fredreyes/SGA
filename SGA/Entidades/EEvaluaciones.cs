using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EEvaluaciones
    {
        public int EvaluacionId  { get; set; }
        public string Mes { get; set; }
        public string Pacial { get; set; }
        public string Observaciones { get; set; }
        public CicloEscolar CicloEscolar { get; set; }
        public bool Activo { get; set; }

        public EEvaluaciones()
        {
            this.CicloEscolar = new CicloEscolar();
        }
    }
}
