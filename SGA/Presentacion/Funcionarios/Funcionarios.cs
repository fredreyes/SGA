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
namespace Presentacion.Funcionarios
{
    public partial class Funcionarios : MaterialForm
    {
        public Funcionarios()
        {
            InitializeComponent();
            MaterialSkinManager m = MaterialSkinManager.Instance;
            m.AddFormToManage(this);
            m.Theme = MaterialSkinManager.Themes.LIGHT;
            m.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700,Primary.Blue500,Accent.LightGreen400,TextShade.WHITE);
        }

        private void Funcionarios_Load(object sender, EventArgs e)
        {
            try
            {
                CargarFuncionarios();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                try
                {
                    SaveFileDialog o = new SaveFileDialog();
                    o.Filter = "LIBRO EXCEL|*.xlsx";
                    o.ShowDialog();
                    gridControl1.ExportToXlsx(o.FileName);
                    MessageBox.Show("Datos exportados correctamente", "EXPORTAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("No hay registros que exportar","ADVERTENCIA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnNuevoFuncionario_Click(object sender, EventArgs e)
        {
            AgregarFuncionario a = new AgregarFuncionario();
            a.ShowDialog();
           
        }
        void CargarFuncionarios()
        {
            try
            {
                NFuncionario n = new NFuncionario();
                List<EFuncionarios> l = new List<EFuncionarios>();
                gridControl1.DataSource = l;
                gridView1.BestFitColumns();
                gridView1.Columns[0].Visible = false;
                gridView1.Columns[4].Visible = false;
                gridView1.Columns[9].Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
