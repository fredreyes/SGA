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
                dateInicio.Value = DateTime.Today;
                dateFin.Value = DateTime.Today;
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
                dataGridView1.DataSource = l;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["Activo"].Value.ToString()) == false)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    }
                    else
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[4].Visible = false;
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
                    c.FechaInicio = Convert.ToDateTime(dateInicio.Value);
                    c.FechaFin = Convert.ToDateTime(dateFin.Value);
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
                    c.FechaInicio = Convert.ToDateTime(dateInicio.Value);
                    c.FechaFin = Convert.ToDateTime(dateFin.Value);
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

       

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Entidades.CicloEscolar c = new Entidades.CicloEscolar();
                Nciclo n = new Nciclo();
                c.CicloEscolarId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["CicloEscolarId"].Value.ToString());
                var ciclo = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ciclo"].Value.ToString();
                DialogResult o = MessageBox.Show("¿Estas seguro de eliminar El ciclo " + ciclo + " ?", "SGA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (o == DialogResult.OK)
                {
                    n.EliminarCicloEscolar(c);
                    MessageBox.Show("Registro Eliminado con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    Limpiar();
                    CargarCiclo();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (dataGridView1.RowCount > 0)
                    {
                        
                        txtciclo.Tag = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["CicloEscolarId"].Value.ToString());
                        txtciclo.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["ciclo"].Value.ToString();
                        dateInicio.Value = Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["FechaInicio"].Value.ToString());
                        dateFin.Value = Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["FechaFin"].Value.ToString());
                        if (Convert.ToBoolean(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Activo"].Value.ToString()) == true)
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

                    MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
