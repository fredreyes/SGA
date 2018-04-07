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
namespace Presentacion.Matricula
{
    public partial class VerListaMatriculados : Form
    {
        public VerListaMatriculados()
        {
            InitializeComponent();
            cargarMatricula();
        }
        public int MatriculaId;
        private void VerListaMatriculados_Load(object sender, EventArgs e)
        {

        }
        void cargarMatricula()
        {
            try
            {
                NMatricula n = new NMatricula();
                List<EMatricula> lista = n.ListaMatriculas();
                var nuevaLista = (from i in lista
                                  select new
                                  {
                                      i.MatriculaId,
                                      i.FechaMatricula,
                                      i.Alumnos.AlumnoId,
                                      i.Alumnos.Nombres,
                                      i.Ciclo.ciclo,
                                      i.Grados.Grado,
                                      i.seccion,
                                      i.Turno.Turno,
                                      i.Repitente
                                  }).ToList();
                gridControl1.DataSource = nuevaLista;
                gridView1.Columns[1].Group();
                gridView1.BestFitColumns();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void generarBoletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                BoletaMatricula bmatricula = new BoletaMatricula();
                bmatricula.MatriculaID = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MatriculaId").ToString());
                bmatricula.ShowDialog();
            }
            catch (Exception ex)
             {

                throw ex;
            }
        }
    }
}
