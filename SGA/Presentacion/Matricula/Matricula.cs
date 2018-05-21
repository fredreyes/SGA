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
                  
        }
        public int modificar = 0;
        private void Matricula_Load(object sender, EventArgs e)
        {
            cargarTurno();
            CargarGrados();
            CargaColegio();
        }

        void cargarTurno()
        {
            try
            {
                NTurnos n = new NTurnos();
                List<ETurnos> listaTurnos = n.ListaTurnos();
                cbmTurnos.DataSource = listaTurnos;
                cbmTurnos.DisplayMember = "Turno";
                cbmTurnos.ValueMember = "TurnoId";
                cbmTurnos.Text = "Seleccione un Turno";
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        void CargarGrados()
        {
            try
            {
                NGrado n = new NGrado();
                List<EGrados> listaGrado = n.ListaGrados();
                cbmGrados.DisplayMember = "Grado";
                cbmGrados.ValueMember = "GradoId";
                cbmGrados.DataSource = listaGrado;
                cbmGrados.Text = "Seleccione un Grado";
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
                cbmColegio.Text = "Seleccione Colegio";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                 Student.ListAlumno listarlumno = new Student.ListAlumno();
                if (listarlumno.ShowDialog() == DialogResult.OK)
                {
                    txtNombre.Tag = listarlumno.id;
                    txtNombre.Text = listarlumno.nombre;
                    txtApellido.Text = listarlumno.apellido;
                    txtdireccion.Text = listarlumno.direccion;
                    if (listarlumno.sexo == "M")
                        rbtnMasculino.Checked = true;
                    else
                        rbtnFememino.Checked = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void chkPrimerIngreso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPrimerIngreso.Checked)
                groupBoxColegio.Show();
            else
                groupBoxColegio.Hide();

        }

        void Limpiar()
        {
            txtApellido.Clear();
            txtdireccion.Clear();
            txtNombre.Clear();
            chkPrimerIngreso.Checked = false;
            chkrepitente.Checked = false;
            rbtnFememino.Checked = false;
            rbtnMasculino.Checked = false;
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (modificar == 0)
                {
                    if (txtNombre.Text != "" || txtApellido.Text != "" )
                    {
                        DialogResult mensaje = MessageBox.Show("¿Estas seguro de Matricular a  " + txtNombre.Text + " en el " + cbmGrados.Text, " SGA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (mensaje == DialogResult.OK)
                        {
                            EMatricula matricula = new EMatricula();
                            matricula.Alumnos.AlumnoId = Convert.ToInt32(txtNombre.Tag);
                            matricula.Grados.GradoId = Convert.ToInt32(cbmGrados.SelectedValue.ToString());
                            matricula.seccion = comboBox1.SelectedValue.ToString();
                            matricula.Repitente = chkrepitente.Checked ? "SI" : "NO";
                            matricula.Turno.TurnoId = Convert.ToInt32(cbmTurnos.SelectedValue.ToString());
                            //if (cbmColegio.SelectedItem != null)
                            //    matricula.ColegioId = Convert.ToInt32(cbmColegio.SelectedValue.ToString());
                            //else
                            //    matricula.ColegioId = null;
                            matricula.ColegioId = chkPrimerIngreso.Checked ? Convert.ToInt32(cbmColegio.SelectedValue.ToString()) : 0;
                            NMatricula n = new NMatricula();
                            n.IngresarMatricula(matricula);
                            MessageBox.Show("Matricula ingresada con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();
                        }
                    }
                    else
                        MessageBox.Show("No hay registro que guardar", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (modificar == 1)
                {

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cbmTurnos.SelectedValue.ToString() != null)
            {

                int TurnoID = Convert.ToInt32(cbmTurnos.SelectedValue.ToString());
                int GradoId = Convert.ToInt32(cbmGrados.SelectedValue.ToString());
                NMatricula m = new NMatricula();
                List<EAulas> lista = m.MostraVacantesLibres(TurnoID, GradoId);
                if (lista.Count > 0)
                {
                    comboBox1.DataSource = lista;
                    comboBox1.DisplayMember = "Capacidad";
                    comboBox1.ValueMember = "Aula";
                }
                else
                    comboBox1.DataSource = null;
                    lblCapacidad.Text = "";
            }

        }
    }
}
