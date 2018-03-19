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

namespace Presentacion.Notas
{
    public partial class Calificaciones : MaterialForm
    {

        public Calificaciones()
        {
            InitializeComponent();
            EstiloMenu x = new EstiloMenu();
            x.AplicarEstilo(this);
            CargarAsignatura();
        }

        private void Calificaciones_Load(object sender, EventArgs e)
        {
            
        }
        void Limpiar()
        {
            txtAcumulado.Clear();
            txtbuscaralumno.Clear();
            txtexamen.Clear();
            txtNombreAlumno.Clear();
            txtrescate.Clear();
            listBox1.ClearSelected();
            dataGridView1.Rows.Clear();
        }

        void CargarAsignatura()
        {
            try
            {
                NAsignatura n = new NAsignatura();
                List<EAsignatura> Lista = n.ListaAsignatura();
                var NuevaLista = (from i in Lista
                                  select new
                                  {
                                      i.AsignaturaId,
                                      i.Asignatura
                                  }).ToList();
                listBox1.DataSource = NuevaLista;
                listBox1.DisplayMember = "Asignatura";
                listBox1.ValueMember = "AsignaturaId";
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
                if (txtbuscaralumno.Text != "")
                {
                    NAlumno n = new NAlumno();

                    EAlumnos alumno = n.ListaAlumnos(new EAlumnos() { AlumnoId = Convert.ToInt32(txtbuscaralumno.Text) });
                    if (alumno.AlumnoId != 0)
                    {
                        txtbuscaralumno.Text = alumno.AlumnoId.ToString();
                        txtNombreAlumno.Text = alumno.Nombres + " " + alumno.Apellidos;            
                    }
                    else
                    {
                        MessageBox.Show("El  Estudiante con el Código "+ txtbuscaralumno.Text + " no existe", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombreAlumno.Clear();
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Asignatura = listBox1.Text;
            var Acumulado = Convert.ToInt32(txtAcumulado.Text);
            var examen = Convert.ToInt32(txtexamen.Text);
            var rescate = "";
             var NotaFinal = Acumulado + examen;
            if (NotaFinal <=100)
            {
                dataGridView1.Rows.Add(Asignatura, Acumulado, examen, rescate, NotaFinal);
            }
            else
            {
                MessageBox.Show("Nota Final no debe de ser mayor a 100, revise ACUMULADO o EXAMEN", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[4].Value)<60)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
                else
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
           
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                //NNotas n = new NNotas();
                //ENotas notas = new ENotas();
                //notas.Alumno.AlumnoId = Convert.ToInt32(txtbuscaralumno.Text);
                //notas.MateriaDocente.MateriaDocenteId = Convert.ToInt32(txtbuscaralumno.Text);
                MessageBox.Show("Aun no programado");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtAcumulado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtAcumulado_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textolargo_Tick(object sender, EventArgs e)
        {

            ErrorProvider error = new ErrorProvider();
            if (txtAcumulado.Text.Length > 2)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Max. 2 Numeros";
                label1.Visible = true;
            }
            else
            {
                label1.ForeColor = Color.Black;
                label1.Text = "";
                label1.Visible = false;
            }

            if (txtexamen.Text.Length > 2)
            {
                label2.ForeColor = Color.Red;
                label2.Text = "Max. 2 Numeros";
                label2.Visible = true;
            }
            else
            {
                label2.ForeColor = Color.Black;
                label2.Text = "";
                label2.Visible = false;
            }



        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (txtNombreAlumno.Text != "" || txtAcumulado.Text != "" || txtexamen.Text != "")
            {
                DialogResult mensaje = MessageBox.Show("¿Realmente deseas cancelar el registro?", "SGA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (mensaje == DialogResult.OK)
                {
                    Limpiar();
                }
            }
            else
                Limpiar();
        }
    }
}
