using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Presentacion
{
    public partial class frmPrincipal : MaterialForm
    {
        public frmPrincipal()
        {
            EstiloMenu x = new EstiloMenu();
            x.AplicarEstilo(this);
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Otros.Asignaturas A = new Otros.Asignaturas();
            A.ShowDialog();
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmAdministracion a = new frmAdministracion();
            a.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Student.Buscar buscar = new Student.Buscar();
            buscar.ShowDialog();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionarios.docenteAsignatura docenteAsignatura = new Funcionarios.docenteAsignatura();
            docenteAsignatura.ShowDialog();
        }

        private void gestiónFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionarios.Funcionarios funcionario = new Funcionarios.Funcionarios();
            funcionario.ShowDialog();
        }

        private void evaluacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notas.Evaluaciones evaluaciones = new Notas.Evaluaciones();
            evaluaciones.ShowDialog();
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notas.Calificaciones calificaciones = new Notas.Calificaciones();
            calificaciones.ShowDialog();
        }

        private void planDeClasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notas.PlandeClase planclase = new Notas.PlandeClase();
            planclase.ShowDialog();
        }

        private void cargaAcademicaDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notas.CargaDocente cardaD = new Notas.CargaDocente();
            cardaD.ShowDialog();
        }
    }
}
