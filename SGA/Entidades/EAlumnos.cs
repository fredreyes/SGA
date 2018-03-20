using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    public class EAlumnos
    {
        public int AlumnoId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public int CodigoMined { get; set; }
        public bool Activo { get; set; }
        //Documenotos
        public int DOCUMENTO_ALUMNO_ID { get; set; }
        public string PARTIDA_DE_NACIMINETO { get; set; }
        public string CERTIFICADO_NOTAS { get; set; }
        public string TARJETA_VACUNA { get; set; }
        public string CARTA_TRASLADO { get; set; }
        public string CERTIFICADO_DE_SALUD { get; set; }
        public byte[] FOTO { get; set; }
        //Padres Alumnos
        public int ID_PARENTEZCO { get; set; }
        public string NOMBRE_PADRE { get; set; }
        public string CEDULA_PADRE { get; set; }
        public string TELEFONO_PADRE { get; set; }
        public string EMAIL_PADRE { get; set; }
        public string OCUPACION_PADRE { get; set; }
        public string NOMBRE_MADRE { get; set; }
        public string CEDULA_MADRE { get; set; }
        public string TELEFONO_MADRE { get; set; }
        public string EMAIL_MADRE { get; set; }
        public string OCUPACION_MADRE { get; set; }
        //aLUMNO tuTOR

        public int TutorAlumnoID { get; set; }
        public string NombreTutor { get; set; }
        public string CedulaTutor { get; set; }
        public string TelefonoTutor { get; set; }
        public string ParentezcoAlumno { get; set; }
    }
}
