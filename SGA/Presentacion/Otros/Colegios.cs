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
using Entidades;
using Negocio;

namespace Presentacion.Otros
{
    public partial class Colegios : MaterialForm
    {
        public Colegios()
        {
            InitializeComponent();
            EstiloMenu e = new EstiloMenu();
            e.AplicarEstilo(this);
        }
        public int Bandera = 0;
        private void Colegios_Load(object sender, EventArgs e)
        {
            try
            {
                CargarColegios();
                chkeditar.Visible = false;
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void CargarColegios()
        {
            try
            {
                NColegio n = new NColegio();
                List<EColegios> l = n.ListaColegios();
                gridControl1.DataSource = l;
                gridView1.Columns[0].Visible = false;
                gridView1.Columns[1].Caption = "NOMBRE COLEGIO";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        void limpiar()
        {
            txtcolegio.Clear();
            cbmDepartmento.SelectedValue = -1;
            chkeditar.Visible = false;
            chkeditar.Checked = false;
            Bandera = 0;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                EColegios C = new EColegios();
                NColegio n = new NColegio();
                if (Bandera == 0)
                {
                    C.Colegio = txtcolegio.Text;
                    C.Departamento.DepartamentoID = int.Parse(cbmDepartmento.SelectedValue.ToString());
                    n.IngresarColegio(C);
                    MessageBox.Show("Colegio ingresado correctamente", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                    CargarColegios();
                }
                if (Bandera == 1)
                {
                    if (chkeditar.Checked == true)
                    {
                        C.ColegioId = Convert.ToInt32(txtcolegio.Tag);
                        C.Colegio = txtcolegio.Text;
                        C.Departamento.DepartamentoID = int.Parse(cbmDepartmento.SelectedValue.ToString());
                        n.ModificarColegio(C);
                        MessageBox.Show("Colegio Modificado correctamente", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                        CargarColegios();
                    }
                    else
                        MessageBox.Show("Si has elegido un dato, por favor vuelve a marcar el check editar", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            txtcolegio.Tag = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ColegioId").ToString());
            txtcolegio.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Colegio").ToString();
            cbmDepartmento.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Departamento").ToString();
            Bandera = 1;
            chkeditar.Visible = true;
            chkeditar.Checked = true;
        }
    }
}
