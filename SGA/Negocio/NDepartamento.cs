using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class NDepartamento
    {
      public List<EDepartamentos> ListaDepartamento()
        {
            try
            {
                DDepartamentos d = new DDepartamentos();
                List<EDepartamentos> l = d.ListaDepartmento();
                return l;
            }
            catch (Exception ex)
            {
 
                throw ex;
            }
        }
        public void IngresarDepartamento(EDepartamentos d)
        {
            try
            {
                if(d.Departamento == "")
                    throw new ArgumentException("Ingrese un Departamento");
                List<EDepartamentos> l = ListaDepartamento().Where(x => x.Departamento == d.Departamento).ToList();
                if (l.Count > 0)
                    throw new ArgumentException("El departamento: " + d.Departamento + " ya existe");
                DDepartamentos de = new DDepartamentos();
                de.IngresarDepartamento(d);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ModificarDepartamento(EDepartamentos d)
        {
            try
            {
                if (d.Departamento == "")
                    throw new ArgumentException("Ingrese un Departamento");
                DDepartamentos de = new DDepartamentos();
                de.ModificarDepartamento(d);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EliminarDepartamento(EDepartamentos d)
        {
            try
            {
                if (d.DepartamentoID == 0)
                    throw new ArgumentException("Departamento no se encuentra");
                    DDepartamentos de = new DDepartamentos();
                    de.EliminarDepartamento(d);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
 