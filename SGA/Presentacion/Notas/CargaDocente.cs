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
            CargarCicloEscolar();
        }
        public int GRADOID;
        public int AsignaturaID ;
        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            GrupoPrimaria.Visible = false;
            GrupoSencudaria.Visible = true;
        }

        private void materialCheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnPrimaria_CheckedChanged(object sender, EventArgs e)
        {
            GrupoPrimaria.Visible = true;
            GrupoSencudaria.Visible = false;
        }

        private void CargaDocente_Load(object sender, EventArgs e)
        {
        }

        void CargarCicloEscolar()
        {
            Nciclo n = new Nciclo();
            List<CicloEscolar> lista = n.ListaCicloEscolar().Where(x=> x.Activo == true).ToList();
            comboBox1.DataSource = lista;
            comboBox1.DisplayMember = "ciclo";
            comboBox1.ValueMember = "CicloEscolarId";
        }

         void CargarAsignaturas()
        {
            try
            {
                NPlanClase n = new NPlanClase();
                List<EplanClase> lista = n.BuscarAsignaturaGrado(GRADOID);
                var NuevaLista = (from i in lista
                                  select new
                                  {
                                      i.Asignatura.AsignaturaId,
                                      i.Asignatura.Asignatura
                                  }).ToList();
                listBox1.DataSource = NuevaLista;
                listBox1.DisplayMember = "Asignatura";
                listBox1.ValueMember = "AsignaturaId";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        void CargarDocente()
        {
            try
            {
                NPlanClase n = new NPlanClase();
                List<EMateriasDocentes> lista = n.BuscarDocentePorAsignatura(AsignaturaID);
                var NuevaLista = (from i in lista
                                  select new
                                  {
                                      i.Funcionario.FuncionarioId,
                                      i.Funcionario.Nombres,
                                      i.Funcionario.Apellidos,
                                      i.Asignatura.Asignatura
                                  }).ToList();
                listBox2.DataSource = NuevaLista;
                listBox2.DisplayMember = "Nombres";
                listBox2.ValueMember = "FuncionarioId";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void chkPrimero_CheckedChanged(object sender, EventArgs e)
        {
            GRADOID = 1;
            CargarAsignaturas();
        }

        private void chkSegundo_CheckedChanged(object sender, EventArgs e)
        {
            GRADOID = 2;
            CargarAsignaturas();
        }

        private void materialCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            GRADOID = 3;
            CargarAsignaturas();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {  
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            AsignaturaID = Convert.ToInt32(listBox1.SelectedValue.ToString());
            CargarDocente();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                ECargaDocente cd = new ECargaDocente();
                NCargaDocente n = new NCargaDocente();

                cd.AsingaturaId = AsignaturaID;
                cd.CicloEscolarID = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                cd.FuncionarioId = Convert.ToInt32(listBox2.SelectedValue.ToString());
                cd.GradoId = GRADOID;
                n.IngresarCargaDocente(cd);
                MessageBox.Show("Guardado");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
