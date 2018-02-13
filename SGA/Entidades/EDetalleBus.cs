using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EDetalleBus
    {
        public int ID_DETALLEBUS { get; set; }
        public string MARCA { get; set; }
        public string MODELO { get; set; }
        public int CAPACIDAD { get; set; }
        public int VACANTES { get; set; }
        public string TIPO { get; set; }
        public bool DISPONIBLE { get; set; }
    }
}
