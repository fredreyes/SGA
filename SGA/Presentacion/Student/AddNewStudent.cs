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

namespace Presentacion.Student
{
    public partial class AddNewStudent : MaterialForm
    {
        public AddNewStudent()
        {
            InitializeComponent();
            MaterialSkinManager m = MaterialSkinManager.Instance;
            m.AddFormToManage(this);
            m.Theme = MaterialSkinManager.Themes.LIGHT;
            m.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue600, Primary.Blue800, Accent.Cyan200, TextShade.BLACK);

        }

        private void AddNewStudent_Load(object sender, EventArgs e)
        {
            dtpFechaNacimiento.EditValue = DateTime.Today;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {
                    }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txttutorName.Text = txtnombrePadre.Text;
                txttutorTelefono.Text = txtelPadre.Text;    
            }
            else
            {
                txttutorName.Clear();
                txttutorTelefono.Clear();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txttutorName.Text = txtnombreMadre.Text;
                txttutorTelefono.Text = txttelMadre.Text;
            }
            else
            {
                txttutorName.Clear();
                txttutorTelefono.Clear();
            }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            
        }

        private void ocupacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionarios.Ocupaciones o = new Funcionarios.Ocupaciones();
            if (o.ShowDialog() == DialogResult.OK)
            {
             //   txtocupacionPadre.Text = o.ocupacion;
            }
        }

        private void txtocupacionPadre_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void txtocupacionPadre_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
               

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
