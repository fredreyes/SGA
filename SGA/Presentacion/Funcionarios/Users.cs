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
    public partial class Users : MaterialForm
    {
        public Users()
        {
            InitializeComponent();
            EstiloMenu x = new EstiloMenu();
            x.AplicarEstilo(this);
            cargarRol();
        }
        public int Bandera = 0;

        private void Users_Load(object sender, EventArgs e)
        {
            chkEditar.Visible = false;
        }

        void cargarRol()
        {
            try
            {
                NRol n= new NRol();
                List<ERol> listarol = n.ListaRol();
                cbmRol.DataSource = listarol;
                cbmRol.DisplayMember = "Descripcion";
                cbmRol.ValueMember = "RolId";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FuncionariosSinUsuario FuncionarioUsuario = new FuncionariosSinUsuario();
            if (FuncionarioUsuario.ShowDialog() == DialogResult.OK)
            {
                txtFuncionario.Tag = FuncionarioUsuario.FuncionarioID;
                txtFuncionario.Text = FuncionarioUsuario.FuncionarioName;
            }
        }

        void Limpiar()
        {
            txtcontrasenia.Clear();
            txtFuncionario.Clear();
            txtusuario.Clear();
            cbmRol.Text = "Seleccione un Rol";
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Bandera == 0)
                {
                    EUsuarios user = new EUsuarios();
                    NUsuario n = new NUsuario();
                    user.FuncionarioID = Convert.ToInt32(txtFuncionario.Tag);
                    user.Usuario = txtusuario.Text;
                    user.Password = txtcontrasenia.Text;
                    user.Rol.RolId = Convert.ToInt32(cbmRol.SelectedValue.ToString());
                    n.IngresarUsuario(user);
                    MessageBox.Show("Usuario creado con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                if (Bandera == 1)
                {
                    EUsuarios user = new EUsuarios();
                    NUsuario n = new NUsuario();
                    user.UsuarioID = Convert.ToInt32(txtusuario.Tag);
                    user.Usuario = txtusuario.Text;
                    user.Password = (txtcontrasenia.Text == string.Empty ? "" : txtcontrasenia.Text);
                    user.Rol.RolId = Convert.ToInt32(cbmRol.SelectedValue.ToString());
                    n.ModificarsUsuario(user);
                    MessageBox.Show("Usuario Modificado con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerListaUsuarios listaU = new VerListaUsuarios();
            if (listaU.ShowDialog() == DialogResult.OK)
            {
                txtusuario.Tag = listaU.usuarioId;
                txtusuario.Text = listaU.Usuario;
                txtFuncionario.Text = listaU.Nombres;
                cbmRol.Text = listaU.Descripcion;
                chkEditar.Checked = true;
                if (listaU.activo == true)
                {
                    chkactivo.Checked = true;
                }
                else
                    chkCancelado.Checked = false;
                Bandera =   listaU.editar;
            }
        }
    }
}
