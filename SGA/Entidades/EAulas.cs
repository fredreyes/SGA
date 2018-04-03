using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EAulas: EGrados
    {
        public int AulaId { get; set; }
        public string Aula { get; set; }
        public int Capacidad { get; set; }
        public int Vacantes { get; set; }
        public int Turno { get; set; }
        public new bool Activo { get; set; }
    }
}
