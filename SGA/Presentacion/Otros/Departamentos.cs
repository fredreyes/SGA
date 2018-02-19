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
            EstiloMenu e = new EstiloMenu();
            e.AplicarEstilo(this);
        }
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

        void CargarDepartamento()
        {
            try
            {
                NDepartamento n = new NDepartamento();
                List<EDepartamentos> d = n.ListaDepartamento();
                gridControl1.DataSource = d;
                gridView1.Columns[0].Visible = false;
                gridView1.BestFitColumns();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
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
               
                if (Bandera == 0)
                {
                    EDepartamentos d = new EDepartamentos();
                    NDepartamento n = new NDepartamento();
                    d.Departamento = txtdepartamento.Text;
                    n.IngresarDepartamento(d);
                    MessageBox.Show("Departamento Ingresado con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount > 0)
                {
                    txtdepartamento.Tag = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DepartamentoID"));
                    txtdepartamento.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Departamento").ToString();
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

                MessageBox.Show(ex.Message,"SGA", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                EDepartamentos d = new EDepartamentos();
                NDepartamento n = new NDepartamento();
                d.DepartamentoID = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DepartamentoID"));
                var Departamento = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Departamento").ToString();
                DialogResult o = MessageBox.Show("¿Eliminar el Departamento" + Departamento + "?", "SGA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
    }
}
