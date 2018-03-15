using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EPadres_Tutor
    {
        public int ID_PARENTEZCO { get; set; }
        public EAlumnos Alumno { get; set; }
        public string NOMBRE_MADRE { get; set; }
        public string OCUPACION_MADRE { get; set; }
        public string CEDULA_MADRE { get; set; }
        public string TELEFONO_MADRE { get; set; }
        public string EMAIL_MADRE { get; set; }
        public string NOMBRE_PADRE { get; set; }
        public string OCUPACION_PADRE { get; set; }
        public string CEDULA_PADRE { get; set; }
        public string TELEFONO_PADRE { get; set; }
        public string EMAIL_PADRE { get; set; }
        public string NOMBRE_TUTOR { get; set; }
        public string TELEFONO_TUTOR { get; set; }
        public EPadres_Tutor()
        {
            Alumno = new EAlumnos();
        }

    }
}
