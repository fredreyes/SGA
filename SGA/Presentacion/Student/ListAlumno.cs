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

namespace Presentacion.Student
{
    public partial class ListAlumno : MaterialForm
    {
        public ListAlumno()
        {
            InitializeComponent();
            EstiloMenu x = new EstiloMenu();
            x.AplicarEstilo(this);
        }
        public int id;
        public string nombre;
        public string sexo;
        public string apellido;
        public string direccion;


        private void ListAlumno_Load(object sender, EventArgs e)
        {
            CargaAlumno();
        }
        void CargaAlumno()
        {
            try
            {
                NAlumno n = new NAlumno();
                List<EAlumnos> lista = n.ListaAlumnoMatricula();
                gridControl1.DataSource = lista;
                gridView1.Columns[3].Visible = false;
                gridView1.Columns[4].Visible = false;
                gridView1.Columns[5].Visible = false;
                //gridView1.Columns[6].Visible = false;
                gridView1.Columns[7].Visible = false;
                gridView1.Columns[8].Visible = false;
                gridView1.Columns[9].Visible = false;
                gridView1.Columns[10].Visible = false;
                gridView1.Columns[11].Visible = false;
                gridView1.Columns[12].Visible = false;
                gridView1.Columns[13].Visible = false;
                gridView1.Columns[14].Visible = false;
                gridView1.Columns[15].Visible = false;
                gridView1.Columns[16].Visible = false;
                gridView1.Columns[17].Visible = false;
                gridView1.Columns[18].Visible = false;
                gridView1.Columns[19].Visible = false;
                gridView1.Columns[20].Visible = false;
                gridView1.Columns[21].Visible = false;
                gridView1.Columns[22].Visible = false;
                gridView1.Columns[23].Visible = false;
                gridView1.Columns[24].Visible = false;
                gridView1.Columns[25].Visible = false;
                gridView1.Columns[26].Visible = false;
                gridView1.Columns[27].Visible = false;
                gridView1.Columns[28].Visible = false;
                gridView1.Columns[29].Visible = false;
                gridView1.Columns[30].Visible = false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "AlumnoId").ToString());
                nombre = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Nombres").ToString();
                apellido = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Apellidos").ToString();
                direccion = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Direccion").ToString();
                if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Sexo").ToString() == "M")
                    sexo = "M";
                else
                    sexo = "F";
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
