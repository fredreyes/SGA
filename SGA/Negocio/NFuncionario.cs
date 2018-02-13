using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class NFuncionario
    {
        public List<EFuncionarios> ListaFuncionarios()
        {
            try
            {
                NFuncionario n = new NFuncionario();
                List<EFuncionarios> l = n.ListaFuncionarios();
                return l;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
