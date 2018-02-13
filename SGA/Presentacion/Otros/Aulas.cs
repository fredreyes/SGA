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
    public partial class Aulas : MaterialForm
    {
        public Aulas()
        {
            InitializeComponent();
            MaterialSkinManager m = MaterialSkinManager.Instance;
            m.AddFormToManage(this);
            m.Theme = MaterialSkinManager.Themes.LIGHT;
            m.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700, Primary.Blue500, Accent.LightBlue700, TextShade.WHITE);
        }

        private void Aulas_Load(object sender, EventArgs e)
        {
            try
            {
                CargarAulas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void CargarAulas()
        {
            try
            {
                NAulas n = new NAulas();
                List<EAulas> l = n.ListaAulas();
                gridControl1.DataSource = l;
                gridView1.Columns[0].Visible = false;
                gridView1.Columns[4].Visible = false;
                gridView1.Columns[5].Caption = "GRADO";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void nuevaAulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AgregarAula a = new AgregarAula();
                a.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
