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
    public partial class Roles : MaterialForm
    {
        public Roles()
        {
            InitializeComponent();
            EstiloMenu x = new EstiloMenu();
            x.AplicarEstilo(this);
        }
        public int Bandera = 0;
        public int Rolid;
        private void Roles_Load(object sender, EventArgs e)
        {
            CargarRol();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        void CargarRol()
        {
            try
            {
                NRol n = new NRol();
                List<ERol> lista = n.ListaRol();
                dataGridView1.DataSource = lista;
                dataGridView1.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        void Limpiar()
        {
            Bandera = 0;
            chkadministrador.Checked = false;
            chkcalificaciones.Checked = false;
            chkFuncionarios.Checked = false;
            chkmatricula.Checked = false;
            txtdescripcion.Clear();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Bandera == 0)
                {
                    //Guardar
                    ERol rol = new ERol();
                    NRol n = new NRol();
                    rol.Descripcion = txtdescripcion.Text;
                    rol.Matricula = Convert.ToBoolean(chkmatricula.Checked ? 1 : 0);
                    rol.Administracion = Convert.ToBoolean(chkadministrador.Checked ? 1 : 0);
                    rol.Calificaciones = Convert.ToBoolean(chkcalificaciones.Checked ? 1 : 0);
                    rol.Funcionarios = Convert.ToBoolean(chkFuncionarios.Checked ? 1 : 0);
                    n.IngresarRol(rol);
                    MessageBox.Show("Rol creado con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    CargarRol();
                }
                if (Bandera == 1)
                {
                    //Modificar
                    ERol rol = new ERol();
                    NRol n = new NRol();
                    rol.RolId = Rolid;
                    rol.Descripcion = txtdescripcion.Text;
                    rol.Matricula = Convert.ToBoolean(chkmatricula.Checked ? 1 : 0);
                    rol.Administracion = Convert.ToBoolean(chkadministrador.Checked ? 1 : 0);
                    rol.Calificaciones = Convert.ToBoolean(chkcalificaciones.Checked ? 1 : 0);
                    rol.Funcionarios = Convert.ToBoolean(chkFuncionarios.Checked ? 1 : 0);
                    n.ModificarRol(rol);
                    MessageBox.Show("Rol Modificado con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    CargarRol();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                try
                {
                    Rolid = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["RolId"].Value.ToString());
                    txtdescripcion.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Descripcion"].Value.ToString();
                    if (Convert.ToBoolean(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Matricula"].Value.ToString()) == true)
                        chkmatricula.Checked = true;
                    else
                        chkmatricula.Checked = false;
                    if (Convert.ToBoolean(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Administracion"].Value.ToString()) == true)
                        chkadministrador.Checked = true;
                    else
                        chkadministrador.Checked = false;
                    if (Convert.ToBoolean(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Funcionarios"].Value.ToString()) == true)
                        chkFuncionarios.Checked = true;
                    else
                        chkFuncionarios.Checked = false;
                    if (Convert.ToBoolean(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Calificaciones"].Value.ToString()) == true)
                        chkcalificaciones.Checked = true;
                    else
                        chkcalificaciones.Checked = false;
                    Bandera = 1;
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            else
                MessageBox.Show("No hay registros que seleccionar", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (chkadministrador.Checked || chkcalificaciones.Checked || chkFuncionarios.Checked || chkmatricula.Checked)
            {
                DialogResult mensaje = MessageBox.Show("¿Realmente desea cancelar?", "SGA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (mensaje == DialogResult.OK)
                {
                    Limpiar();
                    CargarRol();
                }
            }
            else
                Limpiar();
                CargarRol();
        }
    }
}
