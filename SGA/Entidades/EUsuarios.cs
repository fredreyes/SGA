using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EUsuarios
    {
        public int USUARIO_ID { get; set; }
        public string USUARIO { get; set; }
        public string CONTRASEÑA { get; set; }
        public bool ESTADO { get; set; }
        public int ID_FUNCIONARIO { get; set; }
    }
}
