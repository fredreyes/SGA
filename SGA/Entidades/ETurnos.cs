using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ETurnos
    {
        public int TurnoId { get; set; }
        public string Turno { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
    }
}
