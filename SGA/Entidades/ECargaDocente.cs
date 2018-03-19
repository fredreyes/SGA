using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ECargaDocente
    {
        public int CargaId { get; set;}
        public int FuncionarioId { get; set; }
        public int AsingaturaId { get; set; }
        public int GradoId { get; set; }
        public int CicloEscolarID { get; set; }
    }
}
