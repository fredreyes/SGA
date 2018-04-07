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
using MaterialSkin;
using MaterialSkin.Controls;

namespace Presentacion.Notas
{
    public partial class PlandeClase : MaterialForm
    {
        public PlandeClase()
        {
            InitializeComponent();
            EstiloMenu x = new EstiloMenu();
            x.AplicarEstilo(this);
            CargarPlanClase();
            CargarGrados();
            CargarAsignaturas();
        }

        private void PlandeClase_Load(object sender, EventArgs e)
        {
        }

        void Limpiar()
        {
            listBox1.ClearSelected();
            listBox2.ClearSelected();
            dataGridView1.Rows.Clear();
        }

        void CargarGrados()
        {
            try
            {
                NGrado n = new NGrado();
                List<EGrados> listaGrados = n.ListaGrados();
                listBox2.DataSource = listaGrados;
                listBox2.DisplayMember = "Grado";
                listBox2.ValueMember = "GradoId";

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        void CargarAsignaturas()
        {
            try
            {
                NAsignatura n = new NAsignatura();
                List<EAsignatura> listaAsignatura = n.ListaAsignatura();
                listBox1.DataSource = listaAsignatura;
                listBox1.DisplayMember = "Asignatura";
                listBox1.ValueMember = "AsignaturaId";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        void CargarPlanClase()
        {
            try
            {
                NPlanClase n = new NPlanClase();
                List<EplanClase> listaPlan = n.ListaPlandeClase();
                var newData = (from i in listaPlan
                               select new
                               {
                                   i.PlanClaseID,
                                   i.Asignatura.AsignaturaId,
                                   i.Asignatura.Asignatura,
                                   i.Grado.GradoId,
                                   i.Grado.Grado,
                                   i.CicloEscolar.CicloEscolarId,
                                   i.CicloEscolar.ciclo
                               }).ToList();

                gridControl1.DataSource = newData;
                gridView1.Columns[0].Visible = false;
                gridView1.Columns[1].Visible = false;
                gridView1.Columns[3].Visible = false;
                gridView1.Columns[5].Visible = false;
                gridView1.Columns[4].Group();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            try
            {
                var Asignatura = listBox1.Text;
                var AsignaturaId = listBox1.SelectedValue.ToString();
                var GradoId = listBox2.SelectedValue.ToString();
                var Grado = listBox2.Text;
                if (listBox2.SelectedItem != null)
                {
                    dataGridView1.Rows.Add(AsignaturaId, Asignatura, GradoId, Grado);
                    Asignatura = "";
                    Grado = "";
                }
                else
                    MessageBox.Show("Seleccione un Grado", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
         }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dataGridView1.RowCount >0)
                {
                    DialogResult mensaje = MessageBox.Show("¿Ya ha revisado la informacion antes de Guardarla?", "SGA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (mensaje == DialogResult.OK)
                    {
                        EplanClase pc = new EplanClase();
                        foreach (DataGridViewRow datos in dataGridView1.Rows)
                        {
                            pc.Asignatura.AsignaturaId = Convert.ToInt32(datos.Cells[0].Value);
                            pc.Grado.GradoId = Convert.ToInt32(datos.Cells[2].Value);
                            NPlanClase n = new NPlanClase();
                            n.IngresarPlanClase(pc);
                        }
                        MessageBox.Show("Plan de Clase Ingresado con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarPlanClase();
                    }
                }
                else
                    MessageBox.Show("No hay registro que guardar", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}