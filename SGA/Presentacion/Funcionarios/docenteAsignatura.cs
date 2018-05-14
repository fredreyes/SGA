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

namespace Presentacion.Funcionarios
{
    public partial class docenteAsignatura : MaterialForm
    {
        public docenteAsignatura()
        {
            InitializeComponent();
            EstiloMenu x = new EstiloMenu();
            x.AplicarEstilo(this);
        }
        public bool Bandera;
        //captura el ID de MateriaID desde el contextMenu
        public int materiaDocenteId;
        private void docenteAsignatura_Load(object sender, EventArgs e)
        {
            CargaFuncionarios();
            CargarAsinaturas();
            CargarMateriaDocente();
            new frmPrincipal().CloseScreen();
        }

        void CargaFuncionarios()
        {
            NFuncionario n = new NFuncionario();
            List<EFuncionarios> listaFuncioanrio = n.ListaFuncionarios();
            var NuevaLista = (from i in listaFuncioanrio
                              where i.IsDocenet == true
                              select new
                              {
                                  i.FuncionarioId,
                                  i.Nombres,
                                  i.Apellidos,
                                  i.Telefono,
                                  i.Email,
                                  i.Cargo,
                                  i.Ocupacion.Ocupacion,
                              }).ToList();
            gridControl1.DataSource = NuevaLista;
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[6].Group();
            gridView1.BestFitColumns();
        }

        void CargarAsinaturas()
        {
            try
            {
                NAsignatura n = new NAsignatura();
                List<EAsignatura> Lista = n.ListaAsignatura();
                listBox1.DataSource = Lista;
                listBox1.DisplayMember = "Asignatura";
                listBox1.ValueMember = "AsignaturaId";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

       void CargarMateriaDocente()
        {
            try
            {
                NMateriaDocenteID n = new NMateriaDocenteID();
                List<EMateriasDocentes> lista = n.ListaMateriaDocente();
                var NuevaLista = (from i in lista
                                  select new
                                  {
                                      i.MateriaDocenteId,
                                      i.Funcionario.Nombres,
                                      i.Asignatura.Asignatura,
                                      i.mañana,
                                      i.tarde,
                                      i.Primaria,
                                      i.Secundaria
                                  }).ToList();
                gridControl2.DataSource = NuevaLista;
                gridView2.BestFitColumns();
                gridView2.Columns[0].Visible = false;
                gridView2.Columns[1].Group();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        void Limpiar()
        {
            listBox1.ClearSelected();
            chkmañana.Checked = false;
            chktarde.Checked = false;
            rbtnSecundaria.Checked = false;
            rbtnPrimaria.Checked = false;
            Bandera = false;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (Bandera == false)
                {
                    var DocenteID = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FuncionarioId").ToString());
                    var AsignaturaID = Convert.ToInt32(listBox1.SelectedValue.ToString());
                    EMateriasDocentes md = new EMateriasDocentes();
                    NMateriaDocenteID n = new NMateriaDocenteID();
                    md.Funcionario.FuncionarioId = DocenteID;
                    md.Asignatura.AsignaturaId = AsignaturaID;
                    md.mañana = Convert.ToBoolean(chkmañana.Checked ? 1 : 0);
                    md.tarde = Convert.ToBoolean(chktarde.Checked ? 1 : 0);
                    md.Primaria = Convert.ToBoolean(rbtnPrimaria.Checked ? 1 : 0);
                    md.Secundaria = Convert.ToBoolean(rbtnSecundaria.Checked ? 1 : 0);
                    n.IngresarMateriaDocente(md);
                    MessageBox.Show("Carga Academica Docente fue guardada con exito","SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    CargarMateriaDocente();
                }
                else
                {
                    var AsignaturaID = Convert.ToInt32(listBox1.SelectedValue.ToString());
                    
                    EMateriasDocentes md = new EMateriasDocentes();
                    NMateriaDocenteID n = new NMateriaDocenteID();
                    md.MateriaDocenteId = materiaDocenteId;
                    md.Asignatura.AsignaturaId = AsignaturaID;
                    md.mañana = Convert.ToBoolean(chkmañana.Checked ? 1 : 0);
                    md.tarde = Convert.ToBoolean(chktarde.Checked ? 1 : 0);
                    md.Primaria = Convert.ToBoolean(rbtnPrimaria.Checked ? 1 : 0);
                    md.Secundaria = Convert.ToBoolean(rbtnSecundaria.Checked ? 1 : 0);
                    n.ModificarMateriaDocente(md);
                    MessageBox.Show("Carga Academica Docente fue modificada con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    CargarMateriaDocente();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                EMateriasDocentes md = new EMateriasDocentes();
                md.MateriaDocenteId = Convert.ToInt32(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MateriaDocenteId").ToString());
                DialogResult mensaje = MessageBox.Show("¿Realmente desea eliminar este registro?", "SGA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (mensaje == DialogResult.OK)
                {
                    NMateriaDocenteID n = new NMateriaDocenteID();
                    n.EliminarMateriaDocente(md);
                    MessageBox.Show("Registro eliminado con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    CargarMateriaDocente();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eDITARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                materiaDocenteId = Convert.ToInt32(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "MateriaDocenteId").ToString());
                listBox1.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Asignatura").ToString();
                if (Convert.ToBoolean(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "mañana").ToString()) == true)
                    chkmañana.Checked = true;
                else
                    chkmañana.Checked = false;
                if (Convert.ToBoolean(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "tarde").ToString()) == true)
                    chktarde.Checked = true;
                else
                    chktarde.Checked = false;
                if (Convert.ToBoolean(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Primaria").ToString()) == true)
                    rbtnPrimaria.Checked = true;
                else
                    rbtnPrimaria.Checked = false;
                if (Convert.ToBoolean(gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Secundaria").ToString()) == true)
                    rbtnSecundaria.Checked = true;
                else
                    rbtnSecundaria.Checked = false;
                this.Bandera = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null || chkmañana.Checked == true || chktarde.Checked == true)
            {
                DialogResult mensaje = MessageBox.Show("¿Realmente deseas cancelar?", "SGA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (mensaje == DialogResult.OK)
                {
                    Limpiar();
                }
            }
            else
            Limpiar();
        }
    }
}
