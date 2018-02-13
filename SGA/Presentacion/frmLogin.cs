using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace Presentacion
{
    public partial class frmLogin : MaterialForm
    {
        public frmLogin()
        {
            InitializeComponent();
            MaterialSkinManager m = MaterialSkinManager.Instance;
            m.AddFormToManage(this);
            m.Theme = MaterialSkinManager.Themes.DARK;
            m.ColorScheme = new ColorScheme(Primary.Green400, Primary.Green900,Primary.Green800,Accent.DeepPurple200,TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            frmPrincipal f = new frmPrincipal();
            f.Show();
            this.Hide();
        }
    }
}
