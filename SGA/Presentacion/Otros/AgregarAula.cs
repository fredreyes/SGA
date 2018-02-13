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
    public partial class AgregarAula : MaterialForm
    {
        public AgregarAula()
        {
            InitializeComponent();
            MaterialSkinManager m = MaterialSkinManager.Instance;
            m.AddFormToManage(this);
            m.Theme = MaterialSkinManager.Themes.LIGHT;
            m.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue800, Primary.Blue500,Accent.LightBlue700, TextShade.WHITE);
        }

        private void AgregarAula_Load(object sender, EventArgs e)
        {

        }

        private void txtcpacidad_TextChanged(object sender, EventArgs e)
        {
            txtvacantes.Text = txtcpacidad.Text;
        }
    }
}
