using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EColegios: EDepartamentos
    {
        public int ColegioId { get; set; }
        public string Colegio { get; set; }
        public string Telefono { get; set; }
        //public  EDepartamentos Departamentos { get; set; }
        //public EColegios()
        //{
        //    this.Departamentos = new EDepartamentos();            
        //}

    }
}
