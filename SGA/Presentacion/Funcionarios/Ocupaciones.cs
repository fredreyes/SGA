using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using Entidades;
using Negocio;

namespace Presentacion.Funcionarios
{
    public partial class Ocupaciones : MaterialForm
    {
        public Ocupaciones()
        {
            InitializeComponent();
            EstiloMenu x = new EstiloMenu();
            x.AplicarEstilo(this);
        }
        public int bandera = 0;
        private void Ocupaciones_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar();
                chkeditar.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Cargar()
        {
            try
            {
                NOcupaciones n = new NOcupaciones();
                List<EOcupaciones> lista = n.ListaOcupaciones();
                dataGridView1.DataSource = lista;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "LISTA OCUPACION";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

     

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (txtprofesion.Text != null)
            {
                DialogResult o = MessageBox.Show("¿Realmente deseas cancelar?", "SGA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (o == DialogResult.OK)
                {
                    Limpiar();
                }
                else
                    Limpiar();
            }
        }
         void Limpiar()
        {
            txtprofesion.Clear();
            chkeditar.Checked = false;
            chkeditar.Visible = false;
            bandera = 0;
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                EOcupaciones o = new EOcupaciones();
                NOcupaciones n = new NOcupaciones();
                if (bandera == 0)
                {
                    o.Ocupacion = txtprofesion.Text;
                    n.IngresarOcupacion(o);
                    //MessageBox.Show("Ocupación ingresada con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    Cargar();
                }
                if (bandera == 1)
                {
                    if (chkeditar.Checked)
                    {
                        o.OcupacionId = Convert.ToInt32(txtprofesion.Tag);
                        o.Ocupacion = txtprofesion.Text;
                        n.ModifiarOcupacion(o);
                        MessageBox.Show("Ocupación Modificada con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                        Cargar();
                    }
                    else
                        MessageBox.Show("Si has seleccionado un dato, por favor vuelve a marcar EDITAR", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"SGA", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                try
                {
                    EOcupaciones o = new EOcupaciones();
                    o.OcupacionId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["OcupacionId"].Value.ToString());
                    var i = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Ocupacion"].Value.ToString();
                    DialogResult d = MessageBox.Show("¿Realmente desea Eliminar la ocupacion " + i + "?", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    if (d == DialogResult.OK)
                    {
                        NOcupaciones n = new NOcupaciones();
                        n.EliminarOcupacion(o);
                        MessageBox.Show("Eliminado con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("No hay registros que Eliminar", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                try
                {
                    txtprofesion.Tag = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["OcupacionId"].Value.ToString());
                    txtprofesion.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Ocupacion"].Value.ToString();
                    bandera = 1;
                    chkeditar.Checked = true;
                    chkeditar.Visible = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No hay registros que seleccionar", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
