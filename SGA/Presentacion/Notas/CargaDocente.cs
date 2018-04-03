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
        
        public int AsignaturaID;
        
        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            GrupoPrimaria.Visible = false;
            GrupoSencudaria.Visible = true;
        }

        private void rbtnPrimaria_CheckedChanged(object sender, EventArgs e)
        {
            GrupoPrimaria.Visible = true;
            GrupoSencudaria.Visible = false;
        }

        private void CargaDocente_Load(object sender, EventArgs e)
        {
            CargarGrado();
        }

        void CargarGrado()
        {
            NGrado n = new NGrado();
            List<EGrados> lista = n.ListaGrados().Where(x => x.Tipo == "P").ToList();
            cbmGrados.DisplayMember = "Grado";
            cbmGrados.ValueMember = "GradoId";
            cbmGrados.DataSource = lista;
            NGrado nGrado = new NGrado();
            List<EGrados> listaSecundaria = n.ListaGrados().Where(x => x.Tipo == "S").ToList();
            cbmAnio.DisplayMember = "Grado";
            cbmAnio.ValueMember = "GradoId";
            cbmAnio.DataSource = listaSecundaria;
        }

        void CargarCicloEscolar()
        {
            Nciclo n = new Nciclo();
            List<CicloEscolar> lista = n.ListaCicloEscolar().Where(x=> x.Activo == true).ToList();
            comboBox1.DisplayMember = "ciclo";
            comboBox1.ValueMember = "CicloEscolarId";
            comboBox1.DataSource = lista;
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
                cd.CicloEscolarID = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                cd.FuncionarioId = Convert.ToInt32(listBox2.SelectedValue.ToString());
                if (rbtnPrimaria.Checked)
                    cd.GradoId = Convert.ToInt32(cbmGrados.SelectedValue.ToString());
                if (rbtnSecundaria.Checked)
                    cd.GradoId = Convert.ToInt32(cbmAnio.SelectedValue.ToString());
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
                //var NuevaLista = (from i in lista
                //                  select new
                //                  {
                //                      i.Asignatura.AsignaturaId,
                //                      i.Asignatura.Asignatura
                //                  }).ToList();
                ////listBox1.DataSource = NuevaLista;
                listBox1.DisplayMember = "Asignatura";
                listBox1.ValueMember = "AsignaturaId";
                //if (cbmaereolinea.SelectedValue.ToString() != null)
                //{
                //    int id = Convert.ToInt32(cbmaereolinea.SelectedValue.ToString());
                //    NVuelo nvuelos = new NVuelo();
                //    nvuelos.CargarAvion(id, cbmavion);
                //    cbmavion.DisplayMember = "modelo";
                //    cbmavion.ValueMember = "id_avion";
                //    NAereopuerto naereo = new NAereopuerto();
                //    nvuelos.CargarAereopuertos(id, cbmdestino);
                //    cbmdestino.DisplayMember = "Nombre_aereopuerto";
                //    cbmdestino.ValueMember = "Id_aereopuerto";

                //}

            }
        }

        private void cbmGrados_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
