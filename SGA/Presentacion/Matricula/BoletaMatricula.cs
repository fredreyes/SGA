using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Matricula
{
    public partial class BoletaMatricula : Form
    {
        public BoletaMatricula()
        {
            InitializeComponent();
        }
        public int MatriculaID;
        private void BoletaMatricula_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatosBoletaMatricula.BoletaMatricula' Puede moverla o quitarla según sea necesario.
            this.BoletaMatriculaTableAdapter.Fill(this.DatosBoletaMatricula.BoletaMatricula,MatriculaID);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
