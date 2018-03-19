using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public  class EplanClase
    {
        public int PlanClaseID { get; set; }
        public EAsignatura  Asignatura { get; set; }
        public EGrados Grado { get; set; }
        public CicloEscolar CicloEscolar { get; set; }

        public EplanClase()
        {
            Asignatura = new Entidades.EAsignatura();
            Grado = new EGrados();
            CicloEscolar = new CicloEscolar();
        }
     
    }
}
