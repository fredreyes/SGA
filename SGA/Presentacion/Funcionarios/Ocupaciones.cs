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
            MaterialSkinManager m = MaterialSkinManager.Instance;
            m.AddFormToManage(this);
            m.Theme = MaterialSkinManager.Themes.LIGHT;
            m.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue600, Primary.Blue500, Accent.LightBlue700, TextShade.WHITE);
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
                gridControl1.DataSource = lista;
                gridView1.Columns[0].Visible = false;
                gridView1.Columns[1].Caption = "LISTA OCUPACION";
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount>0)
            {
                try
                {
                    txtprofesion.Tag = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "OcupacionId").ToString());
                    txtprofesion.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ocupacion").ToString();
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
                MessageBox.Show("No hay registros que seleccionar","SGA",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (txtprofesion.Text != null)
            {
                DialogResult o = MessageBox.Show("¿Realmente deseas cancelar?", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Question);
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
                    MessageBox.Show("Ocupación ingresada con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            try
            {
                EOcupaciones o = new EOcupaciones();
                o.OcupacionId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "OcupacionId"));
                var i = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ocupacion").ToString();
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

                MessageBox.Show(ex.Message,"SGA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
