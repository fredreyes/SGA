using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CicloEscolar
    {
        public int CicloEscolarId { get; set; }
        public int ciclo { get; set; }
        public DateTime FechaInicio { get; set;}
        public DateTime FechaFin { get; set; }
        public bool Activo { get; set; }
    }
}
