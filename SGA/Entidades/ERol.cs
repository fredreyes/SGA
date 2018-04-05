using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class ERol
    {
        public int RolId { get; set; }
        public bool Matricula { get; set; }
        public bool Administracion { get; set; }
        public bool Funcionarios { get; set; }
        public bool Calificaciones { get; set; }
    }
}
