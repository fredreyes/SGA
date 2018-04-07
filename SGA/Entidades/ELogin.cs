using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class ELogin
    {
        [Required(ErrorMessage = ("USUARIO ES REQUERIDA"), AllowEmptyStrings = false)]
        public int UserID { get; set; }

        [Required(ErrorMessage = ("CONTRASEÑA ES REQUERIDA"), AllowEmptyStrings = false)]
        public string Password { get; set; }

        public string NOMBRES { get; set; }
        public string SEXO { get; set; }
        public string TELEFONO { get; set; }
        public string TIPO { get; set; }
        public Nullable<bool> ACTIVO { get; set; }
        public string ERROR_MENSAJE { get; set; }
    }
}
