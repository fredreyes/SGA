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
using Entidades;
using Negocio;

namespace Presentacion.Funcionarios
{
    public partial class Ocupaciones : MaterialForm
    {
        public Ocupaciones()
        {
            InitializeComponent();
            MaterialSkinManager m = MaterialSkinManager.Instance;
            m.AddFormToManage(this);
            m.Theme = MaterialSkinManager.Themes.LIGHT;
            m.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue600, Primary.Blue500, Accent.LightBlue700, TextShade.WHITE);
        }

        public string ocupacion = "";
        public int id = 0;

        private void Ocupaciones_Load(object sender, EventArgs e)
        {
            try
            {
                Cargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Cargar()
        {
            try
            {
                NOcupaciones n = new NOcupaciones();
                List<EOcupaciones> lista = n.ListaOcupaciones();
                gridControl1.DataSource = lista;
                gridView1.Columns[0].Visible = false;
                gridView1.Columns[1].Caption = "LISTA OCUPACION";
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.RowCount>0)
            {
                try
                {
                    id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "OCUPACION_ID").ToString());
                    ocupacion = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NOMBRE_OCUPACION").ToString();
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No hay registros que mostrar");
            }
        }
    }
}
