using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EUniforme
    {
        public int UNIFORME_ID { get; set; }
        public string NOMBRE_UNIFORME { get; set; }
        public string DESCRIPCION { get; set; }
        public int CANTIDAD { get; set; }
        public int RESTANTE { get; set; }
        public bool DISPONIBILIDAD { get; set; }
        public double PRECIO { get; set; }

    }
}
