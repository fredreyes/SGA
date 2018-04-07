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
            EstiloMenu x = new EstiloMenu();
            x.AplicarEstilo(this);
            CargarTurno();
        }
        public int Bandera = 0;
        EAulas a = new EAulas();
        NAulas n = new NAulas();
        private void AgregarAula_Load(object sender, EventArgs e)
        {
            try
            {
                CargarGrados();
                CargarLista();
                rbtnactivo.Visible = false;
                rbrncancelar.Visible = false;
                chkEditar.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        void CargarLista()
        {
            try
            {
                NAulas n = new NAulas();
                List<EAulas> L = n.ListaAulas();
                var NuevaLista = (from i in L
                                  select new
                                  {
                                      i.AulaId,
                                      i.Aula,
                                      i.Capacidad,
                                      i.Vacantes,
                                      i.Turno,
                                      i.TurnoName,
                                      i.GradoId,
                                      i.Grado,
                                      i.Activo
                                  }).ToList();
                gridControl1.DataSource = NuevaLista;
                gridView1.BestFitColumns();
                gridView1.Columns[0].Visible = false;
                gridView1.Columns[4].Visible = false;
                gridView1.Columns[6].Visible = false;
                gridView1.Columns[7].Group();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        void CargarTurno()
        {
            try
            {
                NTurnos n = new NTurnos();
                List<ETurnos> turno = n.ListaTurnos();
                cbmTurno.DataSource = turno;
                cbmTurno.DisplayMember = "Turno";
                cbmTurno.ValueMember = "TurnoId";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        void Limpiar()
        {
            txtaula.Clear();
            txtcpacidad.Clear();
            txtvacantes.Clear();
            rbtnactivo.Checked = false;
            rbrncancelar.Checked = false;
            chkEditar.Checked = false;
            rbtnactivo.Visible = false;
            rbrncancelar.Visible = false;
            chkEditar.Visible = false;
            Bandera = 0;
            txtcpacidad.TextChanged += txtcpacidad_TextChanged;
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

        private void txtcpacidad_TextChanged(object sender, EventArgs e)
        {
            txtvacantes.Text = txtcpacidad.Text;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (txtaula.Text != "" || txtcpacidad.Text != "")
            {
                DialogResult o = MessageBox.Show("¿Realmente deseas cancelar?", "SGA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (o == DialogResult.OK)
                {
                    Limpiar();
                }
            }
            else
                Limpiar();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Bandera == 0)
                {
                    a.Aula = txtaula.Text;
                    a.Capacidad = int.Parse(txtcpacidad.Text);
                    a.Vacantes = int.Parse(txtcpacidad.Text);
                    a.GradoId = Convert.ToInt32(LbxGrado.SelectedValue.ToString());
                    a.Turno = Convert.ToInt32(cbmTurno.SelectedValue.ToString());
                    n.IngresaAulas(a);
                    MessageBox.Show("Aula Ingresada con Exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    CargarGrados();
                    CargarLista();
            }
                if (Bandera == 1)
                {
                    a.AulaId = Convert.ToInt32(txtaula.Tag);
                    a.Aula = txtaula.Text;
                    a.Capacidad = int.Parse(txtcpacidad.Text);
                    a.Vacantes = int.Parse(txtcpacidad.Text);
                    a.GradoId = Convert.ToInt32(LbxGrado.SelectedValue.ToString());
                    a.Turno = Convert.ToInt32(cbmTurno.SelectedValue.ToString());
                    a.Activo = Convert.ToBoolean(rbtnactivo.Checked ? 1 : 0);
                    n.ModificarAulas(a);
                    MessageBox.Show("Aula Modificada con Exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    CargarGrados();
                    CargarLista();
                }
        }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}


       

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                EAulas A = new EAulas();
                NAulas n = new NAulas(); 
               A.AulaId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "AulaId").ToString());
               var Aula =  gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Aula").ToString();
                DialogResult o = MessageBox.Show("¿Realmente deseas eliminar la Aula " + Aula + " ?", "SGA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (o == DialogResult.OK)
                {
                    n.EliminarAulas(A);
                    MessageBox.Show("Aula Eliminada con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    CargarGrados();
                    CargarLista();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount > 0)
                {
                    //Cancelar evento Textchange
                    txtcpacidad.TextChanged -= txtcpacidad_TextChanged;
                    //Pasar Datos a textbox
                    txtaula.Tag = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "AulaId").ToString());
                    txtaula.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Aula").ToString();
                    txtcpacidad.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Capacidad").ToString();
                    txtvacantes.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Vacantes").ToString();
                    cbmTurno.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TurnoName").ToString();
                    rbtnactivo.Visible = true;
                    rbrncancelar.Visible = true;
                    chkEditar.Visible = true;
                    chkEditar.Checked = true;
                    if (Convert.ToBoolean(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Activo").ToString()) == true)
                        rbtnactivo.Checked = true;
                    else
                        rbrncancelar.Checked = true;
                    Bandera = 1;
                }
                else
                    MessageBox.Show("No hay registros que seleccionar", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
