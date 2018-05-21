using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EMateriasDocentes
    {
        public int MateriaDocenteId { get; set; }
        public  EFuncionarios Funcionario { get; set; } 
        public EAsignatura Asignatura { get; set; }
        public ETurnos turno { get; set; }
        public bool mañana { get; set; }
        public bool tarde { get; set; }
        public bool Primaria { get; set; }
        public bool Secundaria { get; set; }


        public EMateriasDocentes()
        {
            Funcionario = new EFuncionarios();
            Asignatura = new EAsignatura();
            turno = new ETurnos();
        }
    }
}
