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
            MaterialSkinManager m = MaterialSkinManager.Instance;
            m.Theme = MaterialSkinManager.Themes.LIGHT;
            m.ColorScheme = new ColorScheme(Primary.Blue900,Primary.Blue700,Primary.Blue500,Accent.LightBlue700,TextShade.WHITE); 
        }
        public int Bandera = 0;
        private void Asignaturas_Load(object sender, EventArgs e)
        {
            try
            {
                CargarLista();
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

        private void btnGuardar_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Asignatura Modificada con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtasignatura.Tag = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "AsignaturaId"));
                txtasignatura.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Asignatura").ToString();
                if (Convert.ToBoolean(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Activo")) == true)
                    rbtnactivo.Checked = true;
                else
                    rbtnCancelar.Checked = true;
                Bandera = 1;
                chkEditar.Checked = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportarXlsxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                exportarArchivos ex = new exportarArchivos();
                ex.ExportarExcel(gridControl1, "Asignaturas");
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
                exportarArchivos ex = new exportarArchivos();
                ex.ExportarPDF(gridControl1, "Asignaturas");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
