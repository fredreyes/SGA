using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmAdministracion : Form
    {
        public frmAdministracion()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblasignatura.ForeColor = Color.DarkBlue;
            Otros.Asignaturas asignatura = new Otros.Asignaturas();
            asignatura.ShowDialog();
            lblasignatura.ForeColor = Color.Black;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblgrado.ForeColor = Color.DarkBlue;
            Otros.AgregarGrado grado = new Otros.AgregarGrado();
            grado.ShowDialog();
            lblgrado.ForeColor = Color.Black;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lblaula.ForeColor = Color.DarkBlue;
            Otros.AgregarAula Aula = new Otros.AgregarAula();
            Aula.ShowDialog();
            lblaula.ForeColor = Color.Black;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            lblciclo.ForeColor = Color.DarkBlue;
            Otros.CicloEscolar ciclo = new Otros.CicloEscolar();
            ciclo.ShowDialog();
            lblciclo.ForeColor = Color.Black;
        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void frmAdministracion_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            lblturnos.ForeColor = Color.DarkBlue;
            Otros.Turnos turnos = new Otros.Turnos();
            turnos.ShowDialog();
            lblturnos.ForeColor = Color.Black;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            lblcolegio.ForeColor = Color.DarkBlue;
            Otros.Colegios colegios = new Otros.Colegios();
            colegios.ShowDialog();
            lblcolegio.ForeColor = Color.Black;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            lblDepartamento.ForeColor = Color.DarkBlue;
            Otros.Departamentos departamento = new Otros.Departamentos();
            departamento.ShowDialog();
            lblDepartamento.ForeColor = Color.Black;
        }
    }
}
