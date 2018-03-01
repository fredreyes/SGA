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
            Otros.Asignaturas asignatura = new Otros.Asignaturas();
            asignatura.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Otros.AgregarGrado grado = new Otros.AgregarGrado();
            grado.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Otros.AgregarAula Aula = new Otros.AgregarAula();
            Aula.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Otros.CicloEscolar ciclo = new Otros.CicloEscolar();
            ciclo.ShowDialog();
        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void frmAdministracion_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Otros.Turnos turnos = new Otros.Turnos();
            turnos.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Otros.Colegios colegios = new Otros.Colegios();
            colegios.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            lblDepartamento.ForeColor = Color.DarkBlue;
            ToolTip t = new ToolTip();
            t.SetToolTip(pictureBox7, "DEPARTAMENTO");
            Otros.Departamentos departamento = new Otros.Departamentos();
            departamento.ShowDialog();
            lblDepartamento.ForeColor = Color.Black;
        }
    }
}
