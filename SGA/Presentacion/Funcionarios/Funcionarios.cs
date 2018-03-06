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
namespace Presentacion.Funcionarios
{
    public partial class Funcionarios : MaterialForm
    {
        public Funcionarios()
        {
            InitializeComponent();
            EstiloMenu x = new EstiloMenu();
            x.AplicarEstilo(this);
        }

        public void Funcionarios_Load(object sender, EventArgs e)
        {
            try
            {
                CargarFuncionarios();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                try
                {
                    exportarArchivos exp = new exportarArchivos();
                    exp.ExportarExcel(gridControl1, "Funcionarios");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("No hay registros que exportar","ADVERTENCIA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnNuevoFuncionario_Click(object sender, EventArgs e)
        {
            AgregarFuncionario a = new AgregarFuncionario();
            a.ShowDialog();
           
        }
 public  void CargarFuncionarios()
        {
            try
            {
                NFuncionario n = new NFuncionario();
                List<EFuncionarios> l = n.ListaFuncionarios();
                var lista = (from i in l
                             select new
                             {
                                 i.FuncionarioId,
                                 i.Nombres,
                                 i.Apellidos,
                                 i.Cedula,
                                 i.Telefono,
                                 i.Cargo,
                                 i.Ocupacion.Ocupacion,
                                 i.Ocupacion.OcupacionId,
                                 i.FechaNacimiento,
                                 i.Foto,
                                 i.Sexo,
                                 i.Activo,
                                 i.Email
                             }
                             ).ToList();
                gridControl1.DataSource = lista;
                gridView1.BestFitColumns();
                //Columnas no visibles
                gridView1.Columns[0].Visible = false;
                gridView1.Columns[7].Visible = false;
                gridView1.Columns[8].Visible = false;
                gridView1.Columns[9].Visible = false;
                gridView1.Columns[12].Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            AgregarFuncionario agregarFuncionaroio = new AgregarFuncionario();
            agregarFuncionaroio.txtnombres.Tag = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FuncionarioId").ToString());
            agregarFuncionaroio.txtnombres.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Nombres").ToString();
            agregarFuncionaroio.txtapellido.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Apellidos").ToString();
            agregarFuncionaroio.txtcedula.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Cedula").ToString();
            agregarFuncionaroio.txttelefono.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Telefono").ToString();
            agregarFuncionaroio.txtcargo.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Cargo").ToString();
            agregarFuncionaroio.dateFechaNac.EditValue = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "FechaNacimiento").ToString();
            agregarFuncionaroio.txtemail.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Email").ToString();
            agregarFuncionaroio.cbmOcupacion.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Ocupacion").ToString();
            //Sexo
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Sexo").ToString() == "M")
            {
                agregarFuncionaroio.rbtnMasculino.Checked = true;
            }            
            else
            {
                agregarFuncionaroio.rbtnFemenino.Checked = true;
            }

            //Activo o Cancelado
            if (Convert.ToBoolean(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Activo").ToString()) == true)
                agregarFuncionaroio.chkactivo.Checked = true;
            else
                agregarFuncionaroio.chkcancelar.Checked = true;

            //convertir Imagen 
            byte[] imagenBuffer = (byte[])gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Foto");
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer);
            agregarFuncionaroio.pictureFoto.Image = Image.FromStream(ms);
            agregarFuncionaroio.Text = "Editar Funcionario";
            agregarFuncionaroio.chkactivo.Visible = true;
            agregarFuncionaroio.chkcancelar.Visible = true;
            agregarFuncionaroio.Bandera = 1;
            this.Hide();
            agregarFuncionaroio.ShowDialog();
        }
    }
}
