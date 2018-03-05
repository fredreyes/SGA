using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EFuncionarios
    {
        public int FuncionarioId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        
        public string Telefono { get; set; }
        public string Cargo { get; set; }
        public EOcupaciones Ocupacion { get; set; }
        public string Email { get; set; }
        public byte[] Foto { get; set; }
        public bool Activo { get; set; }

        public EFuncionarios()
        {
            Ocupacion = new EOcupaciones();
        }
    }
}
