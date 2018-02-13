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
    public partial class Grado : MaterialForm
    {
        public Grado()
        {
            InitializeComponent();

            MaterialSkinManager m = MaterialSkinManager.Instance;
            m.AddFormToManage(this);
            m.Theme = MaterialSkinManager.Themes.LIGHT;
            m.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700,Primary.Blue500,Accent.LightBlue700,TextShade.WHITE);
        }

        private void Grado_Load(object sender, EventArgs e)
        {
            try
            {
                cargarGrado();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void cargarGrado()
        {
            try
            {
                NGrado n = new NGrado();
                List<EGrados> l = n.ListaGrados();
                gridControl1.DataSource = l;
                gridView1.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            AgregarGrado a = new AgregarGrado();
            a.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount>0 )
            {
                try
                {
                    SaveFileDialog o = new SaveFileDialog();
                    o.Filter = "LIBRO EXCEL|*.xlsx";
                    o.ShowDialog();
                    gridControl1.ExportToXlsx(o.FileName);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No hay registros que exportar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
