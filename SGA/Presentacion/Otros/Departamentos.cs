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
namespace Presentacion.Otros
{
    public partial class Departamentos : MaterialForm
    {
        public Departamentos()
        {
            InitializeComponent();
            //Aplicar Estilo
            EstiloMenu e = new EstiloMenu();
            e.AplicarEstilo(this);
        }
        //Controlar si edita o guardar
        public int Bandera = 0;
        private void Departamentos_Load(object sender, EventArgs e)
        {
            try
            {
                Bandera = 0;
                chkeditar.Visible = false;
                CargarDepartamento();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Cargar Lista de Departamento
        void CargarDepartamento()
        {
            try
            {
                NDepartamento n = new NDepartamento();
                List<EDepartamentos> d = n.ListaDepartamento();
                dataGridView1.DataSource = d;
                dataGridView1.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        //Limpiar Controles
        void Limpiar()
        {
            try
            {
                txtdepartamento.Text = "";
                txtdepartamento.Tag = "";
                chkeditar.Visible = false;
                chkeditar.Checked = false;
                txtdepartamento.Focus();
                Bandera = 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
               //Veerificamos si guarda o Moficica si la Bandera = 0 Guarda, si es 1 Modifica
                if (Bandera == 0)
                {
                    EDepartamentos d = new EDepartamentos();
                    NDepartamento n = new NDepartamento();
                    d.Departamento = txtdepartamento.Text;
                    n.IngresarDepartamento(d);
                    //MessageBox.Show("Departamento Ingresado con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    CargarDepartamento();
                }
                if (Bandera == 1)
                {
                    if (chkeditar.Checked)
                    {
                        EDepartamentos d = new EDepartamentos();
                        NDepartamento n = new NDepartamento();
                        d.DepartamentoID = Convert.ToInt32(txtdepartamento.Tag);
                        d.Departamento = txtdepartamento.Text;
                        n.ModificarDepartamento(d);
                        MessageBox.Show("Departamento Modificado con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        CargarDepartamento();
                    }
                    else
                        MessageBox.Show("Si desea editar el dato, por favor vuelve a marca la casila EDITAR", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"SGA", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                EDepartamentos d = new EDepartamentos();
                NDepartamento n = new NDepartamento();
                d.DepartamentoID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["DepartamentoID"].Value.ToString());
                var Departamento = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Departamento"].Value.ToString();
                DialogResult o = MessageBox.Show("¿Eliminar el Departamento " + Departamento + " ?", "SGA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (o == DialogResult.OK)
                {
                    n.EliminarDepartamento(d);
                    MessageBox.Show("Departamento Eliminado con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDepartamento();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount > 0)
                {
                    txtdepartamento.Tag = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["DepartamentoID"].Value.ToString();
                    txtdepartamento.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Departamento"].Value.ToString();
                    Bandera = 1;
                    chkeditar.Visible = true;
                    chkeditar.Checked = true;
                }
                else
                {
                    MessageBox.Show("No hay registros que seleccionar", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
