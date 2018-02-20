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
    public partial class AgregarGrado : MaterialForm
    {
        public AgregarGrado()
        {
            InitializeComponent();
            EstiloMenu x = new EstiloMenu();
            x.AplicarEstilo(this);
        }
        public int Bandera = 0;
        private void AgregarGrado_Load(object sender, EventArgs e)
        {
            try
            {
                CargarLista();
                chkmodificar.Visible = false;
                rbtncancelar.Visible = false;
                rbtnactivo.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"SGA", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
              
        void LimpiaContorles()
        {
            txtxgrado.Clear();
            chk1.Checked = false;
            chk2.Checked = false;
            chk3.Checked = false;
            chkmodificar.Checked = false;
            chkmodificar.Visible = false;
            rbtncancelar.Checked = false;
            rbtnactivo.Checked = false;
            rbtncancelar.Visible = false;
            rbtnactivo.Visible = false;
            Bandera = 0;
            CargarLista();
        }

        void CargarLista()
        {
            try
            {
                NGrado n = new NGrado();
                List<EGrados> L = n.ListaGrados();
                gridControl1.DataSource = L;
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
                if (txtxgrado.Text != "")
                {
                    DialogResult o = MessageBox.Show("¿Estas seguro de cancelar la operación actual?", "SGA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (o == DialogResult.OK)
                    {
                        LimpiaContorles();
                    }
                }
                else
                    LimpiaContorles();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (chk1.Checked && chk2.Checked && chk3.Checked || chk1.Checked && chk2.Checked)
                    MessageBox.Show("Marcar un Solo Tipo", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    EGrados g = new EGrados();
                    NGrado N = new NGrado();
                    if (Bandera == 0)
                    {
                        g.Grado = txtxgrado.Text;
                        char x;
                        if (chk1.Checked)
                            x = Convert.ToChar('I');
                        else if (chk2.Checked)
                            x = Convert.ToChar('P');
                        else
                            x = Convert.ToChar('S');
                        g.Tipo = Convert.ToChar(x).ToString();
                        N.IngresarGrado(g);
                        MessageBox.Show("Grados ingresados con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiaContorles();
                    }
                    if (Bandera == 1)
                    {
                        g.GradoId = Convert.ToInt32(txtxgrado.Tag);
                        g.Grado = txtxgrado.Text;
                        char x;
                        if (chk1.Checked)
                            x = Convert.ToChar('I');
                        else if (chk2.Checked)
                            x = Convert.ToChar('P');
                        else
                            x = Convert.ToChar('S');
                        g.Tipo = Convert.ToChar(x).ToString();
                        g.Activo = Convert.ToBoolean(rbtnactivo.Checked ? 1 : 0);
                        N.ModificarGrado(g);
                        MessageBox.Show("Grados Modificados con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiaContorles();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControl1_DoubleClick_1(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount > 0)
                {
                    txtxgrado.Tag = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GradoId"));
                    txtxgrado.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Grado").ToString();
                    if (Convert.ToChar(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tipo").ToString()) == 'I')
                        chk1.Checked = true;
                    else if (Convert.ToChar(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tipo").ToString()) == 'P')
                        chk2.Checked = true;
                    else
                        chk3.Checked = true;
                    if (Convert.ToBoolean(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Activo").ToString()) == true)
                        rbtnactivo.Checked = true;
                    else
                        rbtncancelar.Checked = true;
                    Bandera = 1;
                    chkmodificar.Checked = true;
                    chkmodificar.Visible = true;
                    rbtnactivo.Visible = true;
                    rbtncancelar.Visible = true;
                }
                else
                    MessageBox.Show("No hay registros que seleccionar", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                EGrados gr = new EGrados();
                NGrado n = new NGrado();
                gr.GradoId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GradoId"));
                var g = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Grado").ToString();
                DialogResult o = MessageBox.Show("¿Estas seguro de eliminar el grado " + g + "?", "SGA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (o == DialogResult.OK)
                {
                    n.EliminarGrado(gr);
                    LimpiaContorles();
                    MessageBox.Show("Grado eliminado con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
