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
    public partial class Asignaturas : MaterialForm
    {
        public Asignaturas()
        {
            InitializeComponent();
            MaterialSkinManager m = MaterialSkinManager.Instance;
            m.Theme = MaterialSkinManager.Themes.LIGHT;
            m.ColorScheme = new ColorScheme(Primary.Blue500,Primary.Blue400,Primary.BlueGrey100,Accent.DeepOrange100,TextShade.WHITE); 
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (txtasignatura.Hint != "Nombre Asignatura" || txtasignatura.Text != string.Empty)
            {
                
                dataGridView1.Rows.Add(txtasignatura.Text);
                txtasignatura.Clear();
            }
            else
            {
                MessageBox.Show("No hay registro que agregar");
            }
            
        }

        private void Asignaturas_Load(object sender, EventArgs e)
        {
            
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
