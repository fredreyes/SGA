using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EFuncionarios
    {
        public int ID_FUNCIONARIO { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string SEXO { get; set; }
        public DateTime FECHA_NACIMIENTO { get; set; }
        public string CEDULA { get; set; }
        public string TELEFONO { get; set; }
        public string CARGO { get; set; }
        public string EMAIL { get; set; }
        public int OCUPACION_ID { get; set; }
        public string OCUPACION { get; set; }

    }
}
