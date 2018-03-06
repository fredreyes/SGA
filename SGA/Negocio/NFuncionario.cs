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
                DFuncionario D = new DFuncionario();
                List<EFuncionarios> l = D.ListaFuncionarios();
                return l;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void IngresarFuncionario(EFuncionarios f)
        {
            try
            {
                if (f.Nombres == "" || f.Apellidos == "")
                    throw new ArgumentException("Ingrese Nombre y Apellido");
                List<EFuncionarios> lista = ListaFuncionarios().Where(x => x.Cedula == f.Cedula).ToList();
                if (lista.Count > 0)
                    throw new ArgumentException("La cedula " + f.Cedula + " ya existe");
                DFuncionario d = new DFuncionario();
                d.IngresarFuncionario(f);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ModificarFuncionario(EFuncionarios f)
        {
            try
            {
                if (f.Nombres == "" || f.Apellidos == "")
                    throw new ArgumentException("Ingrese Nombre y Apellido");
                DFuncionario d = new DFuncionario();
                d.ModificarFuncionario(f);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
