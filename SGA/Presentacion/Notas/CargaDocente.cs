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

namespace Presentacion.Notas
{
    public partial class CargaDocente : Form
    {
        public CargaDocente()
        {
            InitializeComponent();
        }
        
        public int AsignaturaID;
        private void CargaDocente_Load(object sender, EventArgs e)
        {
            CargarGrado();
            CargarTurno();
        }

        void CargarGrado()
        {
            NGrado n = new NGrado();
            List<EGrados> lista = n.ListaGrados();
            cbmGrados.DisplayMember = "Grado";
            cbmGrados.ValueMember = "GradoId";
            cbmGrados.DataSource = lista;
        }
        void CargarTurno()
        {
            NTurnos n = new NTurnos();
            List<ETurnos> lista = n.ListaTurnos();
            cbmTurno.DisplayMember = "Turno";
            cbmTurno.ValueMember = "TurnoID";
            cbmTurno.DataSource = lista;
        }

         void CargarAsignaturas()
        {
            
        }

        void CargarDocente()
        {
            try
            {
                NPlanClase ndocente = new NPlanClase();
                List<EMateriasDocentes> lista = ndocente.BuscarDocentePorAsignatura(AsignaturaID);
                var NuevaLista = (from i in lista
                                  select new
                                  {
                                      i.Funcionario.FuncionarioId,
                                      i.Funcionario.Nombres,
                                      i.Funcionario.Apellidos,
                                      i.Asignatura.Asignatura
                                  }).ToList();
                listBox2.DisplayMember = "Nombres";
                listBox2.ValueMember = "FuncionarioId";
                listBox2.DataSource = NuevaLista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {  
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox1.Items.Count > 0)
                {
                    AsignaturaID = Convert.ToInt32(listBox1.SelectedValue.ToString());
                    CargarDocente();
                }
                else
                    MessageBox.Show("No hay datos que seleccionar", "SGA", MessageBoxButtons.OK);
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
                ECargaDocente cd = new ECargaDocente();
                NCargaDocente n = new NCargaDocente();
                cd.AsingaturaId = AsignaturaID;
                cd.FuncionarioId = Convert.ToInt32(listBox2.SelectedValue.ToString());
                cd.GradoId = Convert.ToInt32(cbmGrados.SelectedValue.ToString());
                cd.TurnoId = Convert.ToInt32(cbmTurno.SelectedValue.ToString());
                n.IngresarCargaDocente(cd);
                MessageBox.Show("Guardado");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void cbmGrados_SelectedValueChanged(object sender, EventArgs e)
        {
            // GRADOID = Convert.ToInt32((cbmGrados.SelectedValue.ToString()));
            
        }

        private void cbmGrados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmGrados.SelectedValue.ToString() != null)
            {
                int id = Convert.ToInt32(cbmGrados.SelectedValue.ToString());
                NPlanClase nplan = new NPlanClase();
                nplan.CargarAsignaturaPorGrado(id,listBox1);
                listBox1.DisplayMember = "Asignatura";
                listBox1.ValueMember = "AsignaturaId";
            }
        }

        private void cbmGrados_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
