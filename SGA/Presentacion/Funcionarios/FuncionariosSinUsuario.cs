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
    public partial class FuncionariosSinUsuario : Form
    {
        public FuncionariosSinUsuario()
        {
            InitializeComponent();
            cargarFuncionario();
        }
        public int FuncionarioID;
        public string FuncionarioName;

        private void FuncionariosSinUsuario_Load(object sender, EventArgs e)
        {

        }
        void cargarFuncionario()
        {
            NFuncionario n = new NFuncionario();
            List<EFuncionarios> lista = n.ListaFuncionariosSinUsuario();
            var newLista = (from i in lista
                            select new
                            {
                                i.FuncionarioId,
                                i.Nombres,
                                i.Apellidos,
                                i.Telefono,
                                i.Cargo
                            }).ToList();
            dataGridView1.DataSource = newLista;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount > 0)
                {
                    FuncionarioID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["FuncionarioId"].Value.ToString());
                    FuncionarioName = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Nombres"].Value.ToString();
                    DialogResult = DialogResult.OK;
                }
                else
                    MessageBox.Show("No hay registros que seleccionar", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
