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

        private void AgregarGrado_Load(object sender, EventArgs e)
        {

        }

        private void materialRadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (materialCheckBox1.Checked)
            {

            }
            else
            {
                MessageBox.Show("Confirmación no aceptada");
            }
        }
    }
}
