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
using DevExpress.XtraGrid.Views.Grid;

namespace Presentacion.Otros
{
    public partial class Turnos : MaterialForm
    {
        public Turnos()
        {
            InitializeComponent();
            EstiloMenu e = new EstiloMenu();
            e.AplicarEstilo(this);
        }
        public int Bandera = 0;
        private void Turnos_Load(object sender, EventArgs e)
        {
            try
            {
                OcultarControles();
                CargaLista();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        void CargaLista()
        {
            NTurnos n = new NTurnos();
            List<ETurnos> Lista = n.ListaTurnos();
            dataGridView1.DataSource = Lista;
            dataGridView1.Columns[0].Visible = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells["Activo"].Value.ToString()) == false)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }
                else
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
            }
        }
                void OcultarControles()
                    {
                        rbtnActivo.Visible = false;
                        rbtncancelar.Visible = false;
                        chkeditar.Visible = false;
                    }
                void MostarControles()
                {
                    rbtnActivo.Visible = true;
                    rbtncancelar.Visible = true;
                    chkeditar.Visible = true;
                }
      
                void LimpiarControles()
                {
                    txtObservacion.Clear();
                    txtTurno.Clear();
                    rbtnActivo.Checked = false;
                    rbtncancelar.Checked = false;
                    chkeditar.Checked = false;
                    Bandera = 0;
        }
 
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ETurnos t = new ETurnos();
                NTurnos n = new NTurnos();
                
                t.TurnoId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["TurnoId"].Value.ToString());
                var tu = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Turno"].Value.ToString(); 
                DialogResult o = MessageBox.Show("¿Realmente deseas eliminar el turno " + tu + "?", "SGA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (o == DialogResult.OK)
                {
                    n.EliminarTurno(t);
                    MessageBox.Show("Turno eliminado con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    CargaLista();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btningresar_Click_1(object sender, EventArgs e)
        {
            ETurnos t = new ETurnos();
            NTurnos n = new NTurnos();
            try
            {
                if (Bandera == 0)
                {
                    t.Turno = txtTurno.Text;
                    t.Descripcion = txtObservacion.Text;
                    n.IngresarTurno(t);
                    LimpiarControles();
                    MessageBox.Show("Turno Ingresado con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargaLista();
                }
                if (Bandera == 1)
                {
                    if (chkeditar.Checked)
                    {
                        t.TurnoId = Convert.ToInt32(txtTurno.Tag);
                        t.Turno = txtTurno.Text;
                        t.Descripcion = txtObservacion.Text;
                        t.Activo = Convert.ToBoolean(rbtnActivo.Checked ? 1 : 0);
                        n.ModificarTurno(t);
                        LimpiarControles();
                        MessageBox.Show("Turno Modificado con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargaLista();
                        OcultarControles();
                    }
                    else
                        MessageBox.Show("si has seleccionado un dato, por favor vuelve a marcar EDITAR", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount > 0)
                {

                    txtTurno.Tag = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["TurnoId"].Value.ToString());
                    txtTurno.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Turno"].Value.ToString();
                    txtObservacion.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Descripcion"].Value.ToString();
                    if (Convert.ToBoolean(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Activo"].Value.ToString()) == true)
                        rbtnActivo.Checked = true;
                    else
                        rbtncancelar.Checked = true;
                    chkeditar.Checked = true;
                    Bandera = 1;
                    MostarControles();
                }
                else
                    MessageBox.Show("No hay registros que seleccionar", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
