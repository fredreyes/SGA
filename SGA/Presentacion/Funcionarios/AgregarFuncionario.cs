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
    public partial class AgregarFuncionario : MaterialForm
    {
        public AgregarFuncionario()
        {
            InitializeComponent();
            MaterialSkinManager m = MaterialSkinManager.Instance;
            m.AddFormToManage(this);
            m.Theme = MaterialSkinManager.Themes.LIGHT;
            m.ColorScheme = new ColorScheme(Primary.Blue900,Primary.Blue600,Primary.Blue500,Accent.LightBlue700,TextShade.WHITE);
        }

        private void AgregarFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Ocupaciones o = new Ocupaciones();
            if (o.ShowDialog() == DialogResult.OK)
            {
                txtocupacion.Text = o.ocupacion; 
            }
        }
    }
}
