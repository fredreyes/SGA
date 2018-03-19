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

        private void listBox2_Click(object sender, EventArgs e)
        {
            var Asignatura = listBox1.Text;
            var AsignaturaId = listBox1.SelectedValue.ToString();
            var GradoId = listBox2.SelectedValue.ToString();
            var Grado = listBox2.Text;
                if (listBox2.SelectedItem != null)
                {
                    dataGridView1.Rows.Add(AsignaturaId,Asignatura, GradoId,Grado);
                    Asignatura = "";
                    Grado = "";
                }
                else
                    MessageBox.Show("Seleccione un Grado", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}