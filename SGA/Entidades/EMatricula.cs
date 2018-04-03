using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EMatricula
    {
        public int MatriculaId { get; set; }
        public CicloEscolar Ciclo { get; set; }
        public EAlumnos Alumnos { get; set; }
        public EGrados Grados { get; set; }
        public string seccion { get; set; }
        public DateTime FechaMatricula { get; set; }
        public string Repitente { get; set; }
        public ETurnos Turno{ get; set; }
        public EColegios Colegio { get; set; }
        public EMatricula()
        {
            Ciclo = new CicloEscolar();
            Alumnos = new EAlumnos();
            Grados = new EGrados();
            Turno = new ETurnos();
            Colegio = new EColegios();
        }
    }
}
