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

namespace Presentacion.Notas
{
    public partial class Evaluaciones : MaterialForm
    {
        public Evaluaciones()
        {
            InitializeComponent();
            MaterialSkinManager m = MaterialSkinManager.Instance;
            m.AddFormToManage(this);
            m.Theme = MaterialSkinManager.Themes.LIGHT;
            m.ColorScheme = new ColorScheme(Primary.Blue900,Primary.Blue700,Primary.Blue500,Accent.LightBlue700,TextShade.WHITE);
        }

        private void Evaluaciones_Load(object sender, EventArgs e)
        {
            
        }

        private void calendarControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void calendarControl1_DateTimeChanged(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                int id = Convert.ToDateTime(calendarControl1.EditValue).Month;
                switch (id)
                {
                    case 1:
                        dataGridView1.Rows.Add("Enero",listBox1.Text,txtobservaciones.Text,cbmciclo.Text);
                        break;
                    case 2:
                        dataGridView1.Rows.Add("Febrero", listBox1.Text,txtobservaciones.Text, cbmciclo.Text);
                        break;
                    case 3:
                        dataGridView1.Rows.Add("Marzo", listBox1.Text, txtobservaciones.Text, cbmciclo.Text);
                        break;
                    case 4:
                        dataGridView1.Rows.Add("Abril", listBox1.Text, txtobservaciones.Text, cbmciclo.Text);
                        break;
                    case 5:
                        dataGridView1.Rows.Add("Mayo", listBox1.Text, txtobservaciones.Text, cbmciclo.Text);
                        break;
                    case 6:
                        dataGridView1.Rows.Add("Junio", listBox1.Text, txtobservaciones.Text, cbmciclo.Text);
                        break;
                    case 7:
                        dataGridView1.Rows.Add("Julio", listBox1.Text, txtobservaciones.Text, cbmciclo.Text);
                        break;
                    case 8:
                        dataGridView1.Rows.Add("Agosto", listBox1.Text, txtobservaciones.Text, cbmciclo.Text);
                        break;
                    case 9:
                        dataGridView1.Rows.Add("Septiembre", listBox1.Text, txtobservaciones.Text, cbmciclo.Text);
                        break;
                    case 10:
                        dataGridView1.Rows.Add("Octubre", listBox1.Text, txtobservaciones.Text, cbmciclo.Text);
                        break;
                    case 11:
                        dataGridView1.Rows.Add("Noviembre", listBox1.Text, txtobservaciones.Text, cbmciclo.Text);
                        break;
                    case 12:
                        dataGridView1.Rows.Add("Diciembre", listBox1.Text, txtobservaciones.Text, cbmciclo.Text);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Debes de seleccionar un Parcial","ERROR", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
