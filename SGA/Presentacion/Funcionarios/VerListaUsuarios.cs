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

namespace Presentacion.Funcionarios
{
    public partial class VerListaUsuarios : Form
    {
        public VerListaUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();
        }
        public int usuarioId;
        public string Usuario;
        public string Nombres;
        public string Contrasenia;
        public int RolId;
        public string Descripcion;
        public bool activo;
        public int editar;
        private void VerListaUsuarios_Load(object sender, EventArgs e)
        {

        }

        void CargarUsuarios()
        {
            try
            {
                NUsuario n = new NUsuario();
                List<EUsuarios> listaU = n.ListaUsuarios();
                var newLista = (from i in listaU
                                select new
                                {
                                    i.UsuarioID,
                                    i.Usuario,
                                    i.FuncionarioID,
                                    i.FuncionarioName,
                                    i.FuncionarioLastName,
                                    i.Rol.RolId,
                                    i.Rol.Descripcion,
                                    i.Activo
                                }).ToList();
                dataGridView1.DataSource = newLista;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].HeaderText = "Nombres";
                dataGridView1.Columns[4].HeaderText = "Apellidos";
                dataGridView1.Columns[5].Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            usuarioId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["UsuarioId"].Value.ToString());
            Usuario = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Usuario"].Value.ToString();
            Nombres = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["FuncionarioName"].Value.ToString();
            Descripcion = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Descripcion"].Value.ToString();
            RolId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["RolId"].Value.ToString());
            if (Convert.ToBoolean(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Activo"].Value.ToString()) == true)
                activo = true;
            else
                activo = false;
            editar = 1;
            DialogResult = DialogResult.OK;

        }
    }
}
