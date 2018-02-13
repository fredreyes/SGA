using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EPago
    {
        public int ID_PAGO { get; set; }
        public string CODIGO_ALUMNO { get; set; }
        public int ID_DETALLESERVICIO { get; set; }
        public int UNIFORME_ID { get; set; }
        public string MES { get; set; }
        public DateTime FECHA_PAGO { get; set; }
        public string CANCELADO { get; set; }
        public int USUARIO_ID { get; set; }
    }
}
