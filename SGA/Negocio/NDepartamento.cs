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
        //Lista Departamento de Datos
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
        //Ingresar Departamento
        public void IngresarDepartamento(EDepartamentos d)
        {
            try
            {
                //Validamos si el campo donde se ingresan los departamentos esta lleno
                if(d.Departamento == "")
                    //Mandamos un mensaje
                    throw new ArgumentException("Ingrese un Departamento");
                //Verificamos si el registro existe en la Base de datos
                List<EDepartamentos> lista = ListaDepartamento().Where(x => x.Departamento == d.Departamento).ToList();
                //Si existe
                if (lista.Count > 0)
                    //Mandamos el mensaje
                    throw new ArgumentException("El departamento: " + d.Departamento + " ya existe");
                //Si no existe lo ingresamos
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
                //Verificamos si el departamento esta vacio
                if (d.Departamento == "")
                    //Mandamos un mensaje
                    throw new ArgumentException("Ingrese un Departamento");
                //Si no lo ingresamos
                DDepartamentos de = new DDepartamentos();
                de.ModificarDepartamento(d);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //Eliminar el registro recien ingresado (NO FOREINNK KEY)
        public void EliminarDepartamento(EDepartamentos d)
        {
            try
            {
                //Verificamos que no sea 0 el Id del departamento
                if (d.DepartamentoID == 0)
                    //si es 0 enviamos un mensaje
                    throw new ArgumentException("Departamento no se encuentra");
                //Si no es 0, lo eliminamos
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
 