using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EUsuarios
    {
        public int UsuarioID { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public int FuncionarioID { get; set; }
        public string FuncionarioName { get; set; }
        public string FuncionarioLastName { get; set; }
        public DateTime FechaCreacion { get; set; }
        public ERol Rol { get; set; }
        public bool Activo { get; set; }
        public EUsuarios()
        {
            Rol = new ERol();
        }
    }
}
