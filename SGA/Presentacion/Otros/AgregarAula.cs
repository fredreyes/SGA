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
        public int Bandera;
        private void AgregarAula_Load(object sender, EventArgs e)
        {
            try
            {
                CargarGrados();
                CargarLista();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        #region CargarListas
        void CargarLista()
        {
            try
            {
                NAulas n = new NAulas();
                List<EAulas> L = n.ListaAulas();
                gridControl1.DataSource = L;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        void CargarGrados()
        {
            try
            {
                NGrado n = new NGrado();
                List<EGrados> L = n.ListaGrados();
                LbxGrado.DataSource = L;
                LbxGrado.DisplayMember = "Grado";
                LbxGrado.ValueMember = "GradoId";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        private void txtcpacidad_TextChanged(object sender, EventArgs e)
        {
            txtvacantes.Text = txtcpacidad.Text;
        }
    }
}
