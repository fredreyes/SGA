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


namespace Presentacion.Otros
{
    public partial class Asignaturas : MaterialForm
    {
        public Asignaturas()
        {
            InitializeComponent();
            EstiloMenu x = new EstiloMenu();
            x.AplicarEstilo(this);

        }
        public int Bandera = 0;
        private void Asignaturas_Load(object sender, EventArgs e)
        {
            try
            {
                CargarLista();
                rbtnactivo.Visible = false;
                rbtnCancelar.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CargarLista()
        {
            try
            {
                NAsignatura n = new NAsignatura();
                List<EAsignatura> l = n.ListaAsignatura();
                gridControl1.DataSource = l;
                gridView1.Columns[0].Visible = false;
                gridView1.BestFitColumns();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
             try
            {
                if (gridView1.RowCount > 0)
                {
                    txtasignatura.Tag = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "AsignaturaId"));
                    txtasignatura.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Asignatura").ToString();
                    if (Convert.ToBoolean(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Activo")) == true)
                        rbtnactivo.Checked = true;
                    else
                        rbtnCancelar.Checked = true;
                    Bandera = 1;
                    chkEditar.Checked = true;
                    rbtnactivo.Visible = true;
                    rbtnCancelar.Visible = true;
                }
                else
                    MessageBox.Show("No hay datos que seleccionar", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    EAsignatura E = new EAsignatura();
                    NAsignatura n = new NAsignatura();
                    E.Asignatura = txtasignatura.Text;
                    n.IngresarAsignatura(E);
                    txtasignatura.Clear();
                    chkEditar.Checked = false;
                    CargarLista();
                    MessageBox.Show("Asignatura Ingresado con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtasignatura.Focus();
                }
                if (Bandera == 1)
                {
                    EAsignatura E = new EAsignatura();
                    NAsignatura n = new NAsignatura();
                    E.AsignaturaId = Convert.ToInt32(txtasignatura.Tag);
                    E.Asignatura = txtasignatura.Text;
                    E.Activo = Convert.ToBoolean(rbtnactivo.Checked ? 1 : 0);
                    n.ModificarAsignatura(E);
                    txtasignatura.Clear();
                    CargarLista();
                    chkEditar.Checked = false;
                    rbtnactivo.Visible = false;
                    rbtnCancelar.Visible = false;
                    MessageBox.Show("Asignatura Modificada con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Bandera = 0;
                    txtasignatura.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (txtasignatura.Text != "")
            {
                DialogResult o = MessageBox.Show("¿Realmente deseas cancelar?", "SGA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (o == DialogResult.OK)
                {
                    txtasignatura.Clear();
                    rbtnactivo.Visible = false;
                    rbtnCancelar.Visible = false;
                    chkEditar.Checked = false;
                    txtasignatura.Focus();
                }
            }
            else
            txtasignatura.Clear();
            rbtnactivo.Visible = false;
            rbtnCancelar.Visible = false;
            chkEditar.Checked = false;
            txtasignatura.Focus();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAsignatura a = new EAsignatura();
            NAsignatura n = new NAsignatura();

            a.AsignaturaId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "AsignaturaId"));
            var As = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Asignatura").ToString();
            DialogResult o = MessageBox.Show("¿Realmente deseas elliminar la asignatura " + As +" ?","SGA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (o == DialogResult.OK)
            {
                n.Eliminarsignatura(a);
                MessageBox.Show("¿Asignatura eliminada con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarLista();
            }
        }
    }
}
