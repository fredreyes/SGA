using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EDocuemntosAlumnos
    {
        public int DOCUMENTO_ALUMNO_ID { get; set; }
        public string CODIGO_ALUMNO { get; set; }
        public string PARTIDA_DE_NACIMINETO { get; set; }
        public string CERTIFICADO_NOTAS { get; set; }
        public string TARJETA_VACUNA { get; set; }
        public string CARTA_TRASLADO { get; set; }
        public byte[] FOTO { get; set; }
        public string CERTIFICADO_DE_SALUD { get; set; }
    }
}
