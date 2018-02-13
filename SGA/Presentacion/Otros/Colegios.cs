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
    public partial class Colegios : MaterialForm
    {
        public Colegios()
        {
            InitializeComponent();
            MaterialSkinManager m = MaterialSkinManager.Instance;
            m.AddFormToManage(this);
            m.Theme = MaterialSkinManager.Themes.LIGHT;
            m.ColorScheme = new ColorScheme(Primary.Blue900,Primary.Blue500,Primary.Blue400,Accent.Amber400,TextShade.WHITE);
        }
       public string texto = "";
        private void Colegios_Load(object sender, EventArgs e)
        {
            try
            {
                CargarColegios();
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void CargarColegios()
        {
            try
            {
                NColegio n = new NColegio();
                List<EColegios> l = n.ListaColegios().Where(x => x.NOMBRE_COLEGIO.ToLower().StartsWith(texto.ToLower())).ToList();
                gridControl1.DataSource = l;
                gridView1.Columns[0].Visible = false;
                gridView1.Columns[1].Caption = "NOMBRE COLEGIO";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
