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

namespace Presentacion
{
    public partial class frmPrincipal : MaterialForm
    {
        public frmPrincipal()
        {
            EstiloMenu x = new EstiloMenu();
            x.AplicarEstilo(this);
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Otros.Asignaturas A = new Otros.Asignaturas();
            A.ShowDialog();
        }
    }
}
