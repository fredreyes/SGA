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
using DevExpress.XtraSplashScreen;

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
            try
            {
                btnAlumnos.Visible= Global.Users.Rol.Matricula;
                labelAlumnos.Visible = Global.Users.Rol.Matricula;
                btnCalificaciones.Visible = Global.Users.Rol.Calificaciones;
                lblCalificaciones.Visible = Global.Users.Rol.Calificaciones;
                btnFuncionarios.Visible = Global.Users.Rol.Funcionarios;
                labelFuncionarios.Visible = Global.Users.Rol.Funcionarios;
                btnMatricula.Visible = Global.Users.Rol.Matricula;
                labelMatricula.Visible = Global.Users.Rol.Matricula;
            }
            catch (Exception ex)
            {

                throw ex;
            }
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
            
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void gestiónFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void evaluacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void calificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void planDeClasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cargaAcademicaDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void nuevaMatriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion.Matricula.Matricula matricula = new Presentacion.Matricula.Matricula();
            matricula.ShowDialog();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void verMatriculadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Matricula.VerListaMatriculados listam = new Matricula.VerListaMatriculados();
            listam.ShowDialog();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void calificacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Notas.Calificaciones calificaciones = new Notas.Calificaciones();
            calificaciones.ShowDialog();
        }

        private void evaluacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowScreen();
            Notas.Evaluaciones evaluaciones = new Notas.Evaluaciones();
            evaluaciones.ShowDialog();
            
            
        }

        private void planDeClasesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Notas.PlandeClase planclase = new Notas.PlandeClase();
            planclase.ShowDialog();
        }

        private void disponibilidadDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowScreen();
            Funcionarios.docenteAsignatura docenteAsignatura = new Funcionarios.docenteAsignatura();
            docenteAsignatura.ShowDialog();
        }

        private void gestionDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void cargaAcademicaDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Notas.CargaDocente cardaD = new Notas.CargaDocente();
            cardaD.ShowDialog();
        }

        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion.Funcionarios.Roles rol = new Presentacion.Funcionarios.Roles();
            rol.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion.Funcionarios.Users users = new Presentacion.Funcionarios.Users();
            users.ShowDialog();
        }

        private void gestionAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student.Buscar buscar = new Student.Buscar();
            buscar.ShowDialog();
        }

        private void listaNoUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student.VerListaUsers verlista = new Student.VerListaUsers();
            verlista.ShowDialog();
        }

        private void verAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student.verListaAlumnos cerlista = new Student.verListaAlumnos();
            cerlista.ShowDialog();
        }

        public void ShowScreen()
        {
            SplashScreenManager.ShowForm(typeof(WaitFormGlobal));
        }
        public void CloseScreen()
        {
            SplashScreenManager.CloseForm();
        }

        private void buscarDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionarios.Funcionarios funcionario = new Funcionarios.Funcionarios();
            funcionario.ShowDialog();
        }

        private void nuevoDocenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowScreen();
            Funcionarios.AgregarFuncionario a = new Funcionarios.AgregarFuncionario();
            a.ShowDialog();
        }
    }
}
