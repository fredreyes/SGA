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
    public partial class CicloEscolar : MaterialForm
    {
        public CicloEscolar()
        {
            InitializeComponent();
            EstiloMenu x = new EstiloMenu();
            x.AplicarEstilo(this);
        }
        public int Bandera = 0;
        private void CicloEscolar_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCiclo();
                rbtnactivo.Visible = false;
                rbrncancelar.Visible = false;
                chkEditar.Visible = false;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        void Limpiar()
        {
            try
            {
                txtciclo.Clear();
                datefin.EditValue = "";
                dateinicio.EditValue = "";
                rbtnactivo.Visible = false;
                rbrncancelar.Visible = false;
                chkEditar.Visible = false;
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
                List<Entidades.CicloEscolar> l = n.ListaCicloEscolar();
                gridControl1.DataSource = l;
                gridView1.Columns[0].Visible = false;
                gridView1.BestFitColumns();
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
                if (Bandera == 0)
                {
                    Entidades.CicloEscolar c = new Entidades.CicloEscolar();
                    Nciclo n = new Nciclo();
                    c.ciclo = Convert.ToInt32(txtciclo.Text);
                    c.FechaInicio = Convert.ToDateTime(dateinicio.EditValue);
                    c.FechaFin = Convert.ToDateTime(datefin.EditValue);
                    n.IngresarCicloEscolar(c);
                    MessageBox.Show("Ciclo Ingresado con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    CargarCiclo();
                }
                if (Bandera == 1)
                {
                    Entidades.CicloEscolar c = new Entidades.CicloEscolar();
                    Nciclo n = new Nciclo();
                    c.CicloEscolarId = Convert.ToInt32(txtciclo.Tag);
                    c.ciclo = Convert.ToInt32(txtciclo.Text);
                    c.FechaInicio = Convert.ToDateTime(dateinicio.EditValue);
                    c.FechaFin = Convert.ToDateTime(datefin.EditValue);
                    c.Activo = Convert.ToBoolean(rbtnactivo.Checked ? 1 : 0);
                    n.ModificarCicloEscolar(c);
                    MessageBox.Show("Ciclo Modificado con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    CargarCiclo();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (txtciclo.Text != "")
            {
                DialogResult o = MessageBox.Show("¿Realmente deseas cancelar?", "SGA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (o == DialogResult.OK)
                {
                    Limpiar();
                }
            }
            else
                Limpiar();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount > 0)
                {
                    txtciclo.Tag = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CicloEscolarId").ToString());
                    txtciclo.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ciclo").ToString();
                    dateinicio.EditValue = Convert.ToDateTime(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FechaInicio").ToString());
                    datefin.EditValue = Convert.ToDateTime(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FechaFin").ToString());
                    if (Convert.ToBoolean(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Activo").ToString()) == true)
                        rbtnactivo.Checked = true;
                    else
                        rbrncancelar.Checked = true;
                    Bandera = 1;
                    rbtnactivo.Visible = true;
                    rbrncancelar.Visible = true;
                    chkEditar.Visible = true;
                    chkEditar.Checked = true;
                }
                else
                    MessageBox.Show("No hay registros que seleccionar", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {

                MessageBox.Show( ex.Message,"SGA", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entidades.CicloEscolar c = new Entidades.CicloEscolar();
            Nciclo n = new Nciclo();
            c.CicloEscolarId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CicloEscolarId").ToString());
           var ciclo = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ciclo").ToString();
            DialogResult o = MessageBox.Show("¿Estas seguro de eliminar El ciclo " + ciclo + " ?", "SGA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (o == DialogResult.OK)
            {
                n.EliminarCicloEscolar(c);
                MessageBox.Show("Registro Eliminado con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                Limpiar();
                CargarCiclo();
            }
        }
    }
}
