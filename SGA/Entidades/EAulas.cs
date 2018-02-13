using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EAulas
    {
        public int CODIGO_AULA { get; set; }
        public string AULA { get; set; }
        public int CAPACIDAD { get; set; }
        public int VACANTES { get; set; }
        public EGrados GRADOS;
    }
}
