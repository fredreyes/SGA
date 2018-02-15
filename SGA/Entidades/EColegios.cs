using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EColegios
    {
        public int ColegioId { get; set; }
        public string Colegio { get; set; }
        public EDepartamentos Departamento;
    }
}
