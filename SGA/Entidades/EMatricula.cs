using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EMatricula
    {
        public int CODIGO_MATRICULA { get; set; }
        public string CODIGO_ALUMNO { get; set; }
        public int CODIGO_GRADO { get; set; }
        public DateTime FECHA_MATRICULA { get; set; }
        public string REPITENTE { get; set; }
        public int ID_TURNOS { get; set; }
        public int USUARIO_ID{ get; set; }
        public int COLEGIO_ID { get; set; }
        public int ID_CICLO { get; set; }

    }
}
