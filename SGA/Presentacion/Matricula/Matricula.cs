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
using Entidades;
using Negocio;

namespace Presentacion.Matricula
{
    public partial class Matricula : MaterialForm
    {
        public Matricula()
        {
            InitializeComponent();
            EstiloMenu x = new EstiloMenu();
            x.AplicarEstilo(this);
            groupBoxColegio.Hide();
            CargarGrados();
            CargaColegio();
        }

        private void Matricula_Load(object sender, EventArgs e)
        {

        }
        void CargarGrados()
        {
            try
            {
                NGrado n = new NGrado();
                List<EGrados> listaGrado = n.ListaGrados();
                cbmGrados.DataSource = listaGrado;
                cbmGrados.DisplayMember = "Grado";
                cbmGrados.ValueMember = "GradoId";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        void CargaColegio()
        {
            try
            {
                NColegio n = new NColegio();
                List<EColegios> listaColegio = n.ListaColegios();
                cbmColegio.DataSource = listaColegio;
                cbmColegio.DisplayMember = "Colegio";
                cbmColegio.ValueMember = "ColegioId";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                NAlumno n = new NAlumno();
                EAlumnos alumno = n.ListaAlumnos(new EAlumnos() { Nombres = txtNombre.Text });
                //EAlumnos alumno = n.ListaAlumnos(new EAlumnos() { AlumnoId = Convert.ToInt32(txtbuscaralumno.Text) });
            }
            else
            {
                Student.ListAlumno listarlumno = new Student.ListAlumno();
                listarlumno.ShowDialog();
            }
        }

        private void chkPrimerIngreso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPrimerIngreso.Checked)
                groupBoxColegio.Show();
            else
                groupBoxColegio.Hide();

        }

        private void chkMatutino_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var turno = chkMatutino.Text;
                int GradoId = Convert.ToInt32(cbmGrados.SelectedValue.ToString());
                NMatricula m = new NMatricula();
                List<EAulas> lista = m.MostraVacantesLibres(turno, GradoId);
                if (lista.Count > 0)
                {
                    comboBox1.DataSource = lista;
                    comboBox1.DisplayMember = "Capacidad";
                    comboBox1.ValueMember = "Aula";                    
                }
                else
                {
                    this.chkMatutino.Checked = false;
                }
                    
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void chkvespertino_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var turno = chkvespertino.Text;
                int GradoId = Convert.ToInt32(cbmGrados.SelectedValue.ToString());
                NMatricula m = new NMatricula();
                List<EAulas> lista = m.MostraVacantesLibres(turno, GradoId);
                if (lista.Count > 0)
                {
                    comboBox1.DataSource = lista;
                    comboBox1.DisplayMember = "Capacidad";
                    comboBox1.ValueMember = "Aula";
                }
                else
                {
                    this.chkMatutino.Checked = false;   
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() != null)
                lblCapacidad.Text = comboBox1.SelectedValue.ToString();
            else
            lblCapacidad.Text = "";
        }
    }
}
