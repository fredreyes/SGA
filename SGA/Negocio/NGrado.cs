﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class NGrado
    {
        public List<EGrados>ListaGrados()
        {
            try
            {
                DGrados d = new DGrados();
                List<EGrados> l = d.ListaGrados();
                return l;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void IngresarGrado(EGrados g)
        {
            try
            {
                if(g.Grado == "")
                    throw new ArgumentException("Ingrese un Grado");
                List<EGrados> lista = ListaGrados().Where(x => x.Grado == g.Grado && x.Tipo == g.Tipo).ToList();
                if (lista.Count > 0)
                            throw new ArgumentException("El Grado : " + g.Grado + " ya existe");
                if (g.Tipo == null)
                    throw new ArgumentException("Seleccione una clasificación");
                DGrados n = new DGrados();
                n.IngresarGrados(g);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ModificarGrado(EGrados g)
        {
            try
            {
                DGrados n = new DGrados();
                n.ModificarGrados(g);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void EliminarGrado(EGrados g)
        {
            try
            {
                DGrados n = new DGrados();
                n.EliminarGrados(g);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
