using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Entidades;
using Negocio;
using System.IO;

namespace Presentacion.Student
{
    public partial class Buscar : MaterialForm
    {
        List<EAlumnos> lista = new List<EAlumnos>();
        NAlumno nalu = new NAlumno();

        public Buscar()
        {
            InitializeComponent();
            EstiloMenu x = new EstiloMenu();
            x.AplicarEstilo(this);
        }
       

        private void btnNuevoFuncionario_Click(object sender, EventArgs e)
        {
            
        }

        private void txtbuscaralumno_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //gridControl1.DataSource = null;
                //var fil = (
                //    from a in lista
                //    where a.AlumnoId.ToString().ToLower().StartsWith(txtbuscaralumno.Text.ToLower()) || a.Nombres.ToLower().StartsWith(txtbuscaralumno.Text.ToLower())
                //    select a
                //    ).ToList();
                //gridControl1.DataSource = fil;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

     

        private void Buscar_Load(object sender, EventArgs e)
        {

            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            //dataGridView1.Columns[6].Visible = false
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;
            dataGridView1.Columns[16].Visible = false;
            dataGridView1.Columns[17].Visible = false;
            dataGridView1.Columns[18].Visible = false;
            dataGridView1.Columns[19].Visible = false;
            dataGridView1.Columns[20].Visible = false;
            dataGridView1.Columns[21].Visible = false;
            dataGridView1.Columns[22].Visible = false;
            dataGridView1.Columns[23].Visible = false;
            dataGridView1.Columns[24].Visible = false;
            dataGridView1.Columns[25].Visible = false;
            dataGridView1.Columns[26].Visible = false;
            dataGridView1.Columns[27].Visible = false;
        }

      

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbuscaralumno.Text != "")
                {
                    NAlumno n = new NAlumno();

                    EAlumnos alumno = n.ListaAlumnos(new EAlumnos() { AlumnoId = Convert.ToInt32(txtbuscaralumno.Text) });
                    if (alumno.AlumnoId != 0)
                    {
                        dataGridView1.Rows.Add(alumno.AlumnoId, alumno.Nombres, alumno.Apellidos, alumno.Sexo, alumno.FechaNacimiento,
                        alumno.Direccion, alumno.CodigoMined, alumno.Activo, alumno.DOCUMENTO_ALUMNO_ID, alumno.PARTIDA_DE_NACIMINETO,
                        alumno.CERTIFICADO_NOTAS, alumno.TARJETA_VACUNA, alumno.CARTA_TRASLADO, alumno.CERTIFICADO_DE_SALUD, alumno.FOTO,
                        alumno.ID_PARENTEZCO, alumno.NOMBRE_PADRE, alumno.CEDULA_PADRE, alumno.TELEFONO_PADRE, alumno.EMAIL_PADRE,
                        alumno.OCUPACION_PADRE, alumno.NOMBRE_MADRE, alumno.CEDULA_MADRE, alumno.TELEFONO_MADRE, alumno.EMAIL_MADRE,
                        alumno.OCUPACION_MADRE, alumno.NombreTutor,alumno.CedulaTutor,alumno.TelefonoTutor,alumno.ParentezcoAlumno);
                    }
                    else
                    {
                        MessageBox.Show("Este Estudiante no existe","SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    //Ver Usuarios
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            txtbuscaralumno.Text = "";
            dataGridView1.Rows.Clear();
        }

        private void btningresar_Click_1(object sender, EventArgs e)
        {
            AddNewStudent a = new AddNewStudent();
            a.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewStudent estudiante = new AddNewStudent();
                estudiante.Text = "Editar Estudiante";
                estudiante.txtnombreAlumno.Tag = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
                estudiante.txtnombreAlumno.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                estudiante.txtApellidoAlumno.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                //Sexo
                if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString() == "M")
                    estudiante.rbtnMasculino.Checked = true;
                else
                    estudiante.rbtnFemenino.Checked = true;
                estudiante.dtpFechaNacimiento.Value = Convert.ToDateTime(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString());
                estudiante.txtdomicilio.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
                estudiante.txtCodigoMined.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
                // ACTIVO 
                if (Convert.ToBoolean(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value.ToString()) == true)
                    estudiante.chkactivo.Checked = true;
                else
                    estudiante.chkcancelado.Checked = true;

                // DOcumentoID
                //  estudiante.DocumentoID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value.ToString());
                //Chekbos Documentos
                if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[9].Value.ToString() == "SI")
                    estudiante.chkpartidaNacimiento.Checked = true;
                if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[10].Value.ToString() == "SI")
                    estudiante.chkcertificadoNotas.Checked = true;
                if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[11].Value.ToString() == "SI")
                    estudiante.chktarjetaVacunas.Checked = true;
                if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[12].Value.ToString() == "SI")
                    estudiante.chkcartaTraslado.Checked = true;
                if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[13].Value.ToString() == "SI")
                    estudiante.chkCertificadoSalud.Checked = true;
                //FOTO 
                //convertir Imagen 
                byte[] imagenBuffer = (byte[])dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[14].Value;
                MemoryStream ms = new MemoryStream(imagenBuffer);
                estudiante.pictureEdit1.Image = Image.FromStream(ms);
                // ID PARENTEZCO
                //estudiante.txtnombrePadre.Tag = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[15].Value.ToString();
                estudiante.txtnombrePadre.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[16].Value.ToString();
                estudiante.txtcedulaP.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[17].Value.ToString();
                estudiante.txtelPadre.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[18].Value.ToString();
                estudiante.txtemailPadre.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[19].Value.ToString();
                estudiante.cbmOcupacionPadre.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[20].Value.ToString();
                estudiante.txtnombreMadre.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[21].Value.ToString();
                estudiante.txtcedulaMadre.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[22].Value.ToString();
                estudiante.txttelMadre.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[23].Value.ToString();
                estudiante.txtemailMadre.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[24].Value.ToString();
                estudiante.cbmOcupacionMadre.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[25].Value.ToString();
                //ChkTutor
                var Padre = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[16].Value.ToString();
                var Tutor = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[26].Value.ToString();
                if (Padre == Tutor)
                    estudiante.checkBox1.Checked = true;
                else if (Padre != Tutor)
                    estudiante.checkBox2.Checked = true;
                else
                {
                    estudiante.txtxTutorName.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[26].Value.ToString();
                    estudiante.txtcedulaTutor.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[27].Value.ToString();
                    estudiante.txttelefonoTutor.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[28].Value.ToString();
                    estudiante.cbmParentezco.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[29].Value.ToString();
                }
                estudiante.Bandera = 1;
                estudiante.chkactivo.Visible = true;
                estudiante.chkcancelado.Visible = true;
                estudiante.ShowDialog();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
