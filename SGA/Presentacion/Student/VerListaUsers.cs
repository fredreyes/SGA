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
    public partial class VerListaUsers : Form
    {
        public VerListaUsers()
        {
            InitializeComponent();
            CargarAlumnos();
        }

        private void VerListaUsers_Load(object sender, EventArgs e)
        {

        }
        void CargarAlumnos()
        {
            try
            {
                NUsuario n = new NUsuario();
                List<EAlumnos> lista = n.ListaUsers();
                var newLista = (from i in lista
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
                dataGridView1.DataSource = newLista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
