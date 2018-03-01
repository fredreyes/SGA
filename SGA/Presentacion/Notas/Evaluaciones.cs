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
    public partial class Evaluaciones : MaterialForm
    {
        public Evaluaciones()
        {
            InitializeComponent();
            EstiloMenu x = new EstiloMenu();
            x.AplicarEstilo(this);
       
        }

        public int Bandera = 0;
        private void Evaluaciones_Load(object sender, EventArgs e)
        {
            CargarEvaluaciones();
            CargarCiclo();
        }

        private void calendarControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void calendarControl1_DateTimeChanged(object sender, EventArgs e)
        {
            
        }

      
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                int id = Convert.ToDateTime(calendarControl1.EditValue).Month;
                switch (id)
                {
                    case 1:
                        dataGridView1.Rows.Add("Enero",listBox1.Text,txtobservaciones.Text,cbmciclo.Text,cbmciclo.SelectedValue.ToString());
                        break;
                    case 2:
                        dataGridView1.Rows.Add("Febrero", listBox1.Text,txtobservaciones.Text, cbmciclo.Text, cbmciclo.SelectedValue.ToString());
                        break;
                    case 3:
                        dataGridView1.Rows.Add("Marzo", listBox1.Text, txtobservaciones.Text, cbmciclo.Text, cbmciclo.SelectedValue.ToString());
                        break;
                    case 4:
                        dataGridView1.Rows.Add("Abril", listBox1.Text, txtobservaciones.Text, cbmciclo.Text, cbmciclo.SelectedValue.ToString());
                        break;
                    case 5:
                        dataGridView1.Rows.Add("Mayo", listBox1.Text, txtobservaciones.Text, cbmciclo.Text);
                        break;
                    case 6:
                        dataGridView1.Rows.Add("Junio", listBox1.Text, txtobservaciones.Text, cbmciclo.Text);
                        break;
                    case 7:
                        dataGridView1.Rows.Add("Julio", listBox1.Text, txtobservaciones.Text, cbmciclo.Text);
                        break;
                    case 8:
                        dataGridView1.Rows.Add("Agosto", listBox1.Text, txtobservaciones.Text, cbmciclo.Text);
                        break;
                    case 9:
                        dataGridView1.Rows.Add("Septiembre", listBox1.Text, txtobservaciones.Text, cbmciclo.Text);
                        break;
                    case 10:
                        dataGridView1.Rows.Add("Octubre", listBox1.Text, txtobservaciones.Text, cbmciclo.Text);
                        break;
                    case 11:
                        dataGridView1.Rows.Add("Noviembre", listBox1.Text, txtobservaciones.Text, cbmciclo.Text);
                        break;
                    case 12:
                        dataGridView1.Rows.Add("Diciembre", listBox1.Text, txtobservaciones.Text, cbmciclo.Text);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Debes de seleccionar un Parcial","SGA", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        void Limpiar()
        {
            try
            {
                txtobservaciones.Clear();
                calendarControl1.EditValue = DateTime.Today;
                cbmciclo.Text = "";
                dataGridView1.Rows.Clear();
                Bandera = 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        void CargarCiclo()
        {
            try
            {
                Nciclo n = new Nciclo();
                List<CicloEscolar> lista = n.ListaCicloEscolar();
                cbmciclo.DataSource = lista;
                cbmciclo.DisplayMember = "ciclo";
                cbmciclo.ValueMember = "CicloEscolarId";
            }
            catch (Exception ex)
            {
 
                throw ex;
            }
        }

        void CargarEvaluaciones()
        {
            try
            {
                NEvaluacion _NegocioEvaluacion = new NEvaluacion();
                List<EEvaluaciones>Lista = _NegocioEvaluacion.ListaEvaluacion();
                var NuevaLista = (from i in Lista 
                                  select new
                                  {
                                      i.EvaluacionId,
                                      i.Mes,
                                      i.Pacial,
                                      i.CicloEscolar.ciclo,
                                      i.Observaciones,
                                      i.Activo
                                  }
                                  ).ToList();
                gridControl1.DataSource = NuevaLista;
                gridView1.BestFitColumns();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount > 0)
                {
                    DialogResult Mensaje = MessageBox.Show("¿Realmente deseas cancelar?", "SGA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Mensaje == DialogResult.OK)
                    {
                        Limpiar();
                    }
                }
                else
                    Limpiar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Bandera == 0)
                {
                    foreach (DataGridViewRow datos in dataGridView1.Rows)
                    {
                        EEvaluaciones _Evaluaciones = new EEvaluaciones();
                        _Evaluaciones.Mes = datos.Cells["Column1"].ToString();
                        _Evaluaciones.Pacial = datos.Cells["Column2"].ToString();
                        _Evaluaciones.Observaciones = datos.Cells["Column3"].ToString();
                        _Evaluaciones.CicloEscolar.CicloEscolarId = Convert.ToInt32(datos.Cells["Column5"].ToString());
                        NEvaluacion n = new NEvaluacion();
                        n.IngresarEvaluaciones(_Evaluaciones);
                    }
                    CargarEvaluaciones();
                    MessageBox.Show("Guardado");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
