using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            Student.AddNewStudent a = new Student.AddNewStudent();
            a.ShowDialog();

        }
    }
}
