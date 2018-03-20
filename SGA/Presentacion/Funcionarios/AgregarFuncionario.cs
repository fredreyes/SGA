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
using System.IO;

namespace Presentacion.Funcionarios
{
    public partial class AgregarFuncionario : MaterialForm
    {
        public AgregarFuncionario()
        {
            InitializeComponent();
            EstiloMenu x = new EstiloMenu();
            x.AplicarEstilo(this);
            CargarOcupaciones();
            chkactivo.Visible = false;
            chkcancelar.Visible = false;
        }

        public int Bandera = 0;
        private void AgregarFuncionario_Load(object sender, EventArgs e)
        {
            
        }
        void Limpiar()
        {
            txtnombres.Clear();
            txtapellido.Clear();
            txtcargo.Clear();
            txtcedula.Clear();
            txtemail.Clear();
            txttelefono.Clear();
            cbmOcupacion.Text = "Seleccione una Ocupación";
            rbtnFemenino.Checked = false;
            rbtnMasculino.Checked = false;
            pictureFoto.Image = Properties.Resources.users;
            CargarOcupaciones();
            chkcancelar.Checked = false;
            chkactivo.Checked = false;
            chkactivo.Visible = false;
            chkcancelar.Visible = false;
            chkisDocente.Checked = false;
            dateFechaNac.Value = DateTime.Today;
        }

        void CargarOcupaciones()
        {
            try
            {
                NOcupaciones n = new NOcupaciones();
                List<EOcupaciones> lista = n.ListaOcupaciones();
                cbmOcupacion.DataSource = lista;
                cbmOcupacion.DisplayMember = "Ocupacion";
                cbmOcupacion.ValueMember = "OcupacionId";
                cbmOcupacion.Text = "Seleccione una Ocupación";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                EFuncionarios funcionario = new EFuncionarios();
                NFuncionario n = new NFuncionario();
                MemoryStream ms = new MemoryStream();
                pictureFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] picture = ms.GetBuffer();
                if (Bandera == 0)
                {
                    funcionario.Nombres = txtnombres.Text;
                    funcionario.Apellidos = txtapellido.Text;
                    funcionario.Cedula = txtcedula.Text;
                    funcionario.Sexo = rbtnMasculino.Checked ? "M" : "F";
                    funcionario.FechaNacimiento = Convert.ToDateTime(dateFechaNac.Value);
                    funcionario.Telefono = txttelefono.Text;
                    funcionario.Cargo = txtcargo.Text;
                    funcionario.Ocupacion.OcupacionId = Convert.ToInt32(cbmOcupacion.SelectedValue.ToString());
                    funcionario.Email = txtemail.Text;
                    funcionario.Foto = picture;
                    funcionario.IsDocenet = Convert.ToBoolean(chkisDocente.Checked ? 1 : 0);
                    n.IngresarFuncionario(funcionario);
                    MessageBox.Show("Funcionario ingresado con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    DialogResult mensaje = MessageBox.Show("¿Desea Ingresar otro Registro?", "SGA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (mensaje == DialogResult.Cancel)
                    {
                        this.Close();
                        Funcionarios x = new Funcionarios();
                        x.Show();
                    }
                }
                if (Bandera == 1)
                {
                    funcionario.FuncionarioId = Convert.ToInt32(txtnombres.Tag);
                    funcionario.Nombres = txtnombres.Text;
                    funcionario.Apellidos = txtapellido.Text;
                    funcionario.Cedula = txtcedula.Text;
                    funcionario.Sexo = rbtnMasculino.Checked ? "M" : "F";
                    funcionario.FechaNacimiento = Convert.ToDateTime(dateFechaNac.Value);
                    funcionario.Telefono = txttelefono.Text;
                    funcionario.Cargo = txtcargo.Text;
                    funcionario.Ocupacion.OcupacionId = Convert.ToInt32(cbmOcupacion.SelectedValue.ToString());
                    funcionario.Email = txtemail.Text;
                    funcionario.Foto = picture;
                    funcionario.Activo = Convert.ToBoolean(chkactivo.Checked ? 1 : 0);
                    funcionario.IsDocenet = Convert.ToBoolean(chkisDocente.Checked ? 1 : 0);
                    n.ModificarFuncionario(funcionario);
                    MessageBox.Show("Funcionario Modificado con exito","SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    this.Close();
                    Funcionarios x = new Funcionarios();
                    x.Show();
                    
             
                }
            }
            catch (Exception ex)
            {

                 MessageBox.Show( ex.Message);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnombres.Text != "" || txtapellido.Text != "")
                {
                    DialogResult mensaje = MessageBox.Show("¿Deseas cancelar la edición de este registro?", "SGA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (mensaje == DialogResult.OK)
                    {
                        Limpiar();
                    }
                }
                else
                    Limpiar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void chkactivo_CheckedChanged(object sender, EventArgs e)
        {
            chkcancelar.Checked = false;
        }

        private void chkcancelar_CheckedChanged(object sender, EventArgs e)
        {
            chkactivo.Checked = false;
        }
    }
}
