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
    public partial class Turnos : MaterialForm
    {
        public Turnos()
        {
            InitializeComponent();
            MaterialSkinManager m = MaterialSkinManager.Instance;
            m.AddFormToManage(this);
            m.Theme = MaterialSkinManager.Themes.LIGHT;
            m.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700, Primary.Blue500, Accent.LightBlue700, TextShade.WHITE);
        }
        public int Bandera;
        private void Turnos_Load(object sender, EventArgs e)
        {
            try
            {

                BloquearControles();
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
            gridControl1.DataSource = Lista;
            gridView1.Columns[0].Visible = false;
            gridView1.BestFitColumns();
            
        }
        #region Controles
                void OcultarControles()
                    {
                        rbtnActivo.Visible = false;
                        rbtncancelar.Visible = false;
                    }
                void MostarControles()
                {
                    rbtnActivo.Visible = true;
                    rbtncancelar.Visible = true;
                }
        void BloquearControles()
                {
                    txtObservacion.Enabled = false;
                    txtTurno.Enabled = false;
                    btnGuardar.Enabled = false;
                }
                void DesbloquearControles()
                {
                    txtObservacion.Enabled = true;
                    txtTurno.Enabled = true;
                    txtTurno.Focus();
                    btnGuardar.Enabled = true;
                }
                void LimpiarControles()
                {
                    txtObservacion.Clear();
                    txtTurno.Clear();
                    rbtnActivo.Checked = false;
                    rbtncancelar.Checked = false;
                    chkeditar.Checked = false;
        }
        #endregion

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesbloquearControles();
            Bandera = 0;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtTurno.Tag = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TurnoId").ToString());
                txtTurno.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Turno").ToString();
                txtObservacion.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Descripcion").ToString();
                if (Convert.ToBoolean(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Activo").ToString()) == true)
                    rbtnActivo.Checked = true;
                else
                rbtncancelar.Checked = true;
                chkeditar.Checked = true;
                Bandera = 1;
                DesbloquearControles();
                MostarControles();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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
                    BloquearControles();
                    MessageBox.Show("Turno Ingresado con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargaLista();
                }
                if (Bandera == 1)
                {
                    t.TurnoId = Convert.ToInt32(txtTurno.Tag);
                    t.Turno = txtTurno.Text;
                    t.Descripcion = txtObservacion.Text;
                    t.Activo = Convert.ToBoolean(rbtnActivo.Checked ?1 : 0 ); 
                    n.ModificarTurno(t);
                    LimpiarControles();
                    BloquearControles();
                    MessageBox.Show("Turno Modificado con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargaLista();
                    OcultarControles();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }  
            
        }
    }
}
