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
            MaterialSkinManager m = MaterialSkinManager.Instance;
            m.AddFormToManage(this);
            m.Theme = MaterialSkinManager.Themes.LIGHT;
            m.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue800, Primary.Blue500, Accent.LightBlue400, TextShade.WHITE);
        }
        public int Bandera;
        private void AgregarGrado_Load(object sender, EventArgs e)
        {
            try
            {
                CargarLista();
                BloquearControles();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"SGA", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        #region Controles
            void BloquearControles()
                {
                    txtxgrado.Enabled = false;
                    chk1.Enabled = false;
                    chk2.Enabled = false;
            chk3.Enabled = false;
            btnagregar.Enabled = false;
                }
                void DesbloquearControles()
                {
                    txtxgrado.Enabled = true;
            chk1.Enabled = true;
            chk2.Enabled = true;
            chk3.Enabled = true;
            btnagregar.Enabled = true;
        }
        void LimpiaContorles()
        {
            txtxgrado.Clear();
            chk1.Checked = false;
            chk2.Checked = false;
            chk3.Checked = false;
        }
        #endregion

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

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DesbloquearControles();
            Bandera = 0;
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (chk1.Checked && chk2.Checked && chk3.Checked || chk1.Checked && chk2.Checked)
                    MessageBox.Show("Marcar un Solo Tipo", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (Bandera == 0)
                    {
                        EGrados g = new EGrados();
                        NGrado N = new NGrado();
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
                        BloquearControles();
                        CargarLista();
                    }
                    if (Bandera == 1)
                    {
                        EGrados g = new EGrados();
                        NGrado N = new NGrado();
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
                        N.ModificarGrado(g);
                        MessageBox.Show("Grados Modificados con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiaContorles();
                        BloquearControles();
                        CargarLista();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtxgrado.Tag = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GradoId"));
                txtxgrado.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Grado").ToString();
                if (Convert.ToChar(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tipo").ToString()) == 'I')
                    chk1.Checked = true;
                else if (Convert.ToChar(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Tipo").ToString()) == 'P')
                    chk2.Checked = true;
                else
                    chk3.Checked = true;
                Bandera = 1;
                DesbloquearControles();
                chkmodificar.Checked = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportarXLSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                 exportarArchivos ex = new exportarArchivos();
                  ex.ExportarExcel(gridControl1,"Grados");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void exportarPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                exportarArchivos EX = new exportarArchivos();
                EX.ExportarPDF(gridControl1, "Grados");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
