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

namespace Presentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ErrorProvider x = new ErrorProvider();
            if (txtusuario.Text == "")
                    x.SetError(txtusuario, "Ingrese el nombre de usuario");
            else if (txtpasword.Text.Trim() == "")
            {
                x.SetError(txtpasword, "Ingrese la contraseña");
            }
            else
            {
                try
                {
                    NUsuario negocioUsuario = new NUsuario();
                    EUsuarios user = new EUsuarios();
                    user.Usuario = txtusuario.Text;
                    user.Password = txtpasword.Text;
                    EUsuarios Usuario = negocioUsuario.Login(user);
                    if (Usuario != null)
                    {
                        Global.Users = Usuario;
                        frmPrincipal menu = new frmPrincipal();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrecta");
                        txtpasword.Clear();
                        txtusuario.Focus();
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
