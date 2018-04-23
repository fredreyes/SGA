using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Presentacion.Student
{
    public partial class verListaAlumnos : Form
    {
        public verListaAlumnos()
        {
            InitializeComponent();
            cargarAlumno();
        }

        private void verListaAlumnos_Load(object sender, EventArgs e)
        {

        }
        void cargarAlumno()
        {
            try
            {
                NAlumno n = new NAlumno();
                List<EAlumnos> lista = n.ListaTotalAlumnos();
                var newlista = (from i in lista
                                select new
                                {
                                    i.AlumnoId,
                                    i.Nombres,
                                    i.Apellidos,
                                    i.Sexo,
                                    i.FechaNacimiento,
                                    i.Direccion,
                                    i.CodigoMined,
                                    i.Activo
                                }).ToList();
                dataGridView1.DataSource = newlista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
