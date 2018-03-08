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
using System.IO;

namespace Presentacion.Student
{
    public partial class AddNewStudent : MaterialForm
    {
        public AddNewStudent()
        {
            InitializeComponent();
            EstiloMenu x = new EstiloMenu();
            x.AplicarEstilo(this);

        }

        private void AddNewStudent_Load(object sender, EventArgs e)
        {
            dtpFechaNacimiento.EditValue = DateTime.Today;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {
                    }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txttutorName.Text = txtnombrePadre.Text;
                txttutorTelefono.Text = txtelPadre.Text;    
            }
            else
            {
                txttutorName.Clear();
                txttutorTelefono.Clear();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txttutorName.Text = txtnombreMadre.Text;
                txttutorTelefono.Text = txttelMadre.Text;
            }
            else
            {
                txttutorName.Clear();
                txttutorTelefono.Clear();
            }
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            
        }

        private void ocupacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionarios.Ocupaciones o = new Funcionarios.Ocupaciones();
            if (o.ShowDialog() == DialogResult.OK)
            {
             //   txtocupacionPadre.Text = o.ocupacion;
            }
        }

        private void txtocupacionPadre_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void txtocupacionPadre_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Alumno
                EAlumnos alumno = new EAlumnos();
                alumno.Nombres = txtnombreAlumno.Text;
                alumno.Apellidos = txtApellidoAlumno.Text;
                alumno.Sexo = rbtnMasculino.Checked ? "M" : "F";
                alumno.FechaNacimiento = Convert.ToDateTime(dtpFechaNacimiento.EditValue);
                alumno.Direccion = txtdomicilio.Text;
                alumno.CodigoMined = Convert.ToInt32(txtCodigoMined.Text);
                //Padres
                EPadres_Tutor padres = new EPadres_Tutor();
                padres.NOMBRE_PADRE = txtnombrePadre.Text;
                padres.CEDULA_PADRE = txtcedulaP.Text;
                padres.TELEFONO_PADRE = txtelPadre.Text;
                padres.EMAIL_PADRE = txtemailPadre.Text;
                padres.OCUPACION_PADRE = txtocupacionPadre.Text;
                padres.NOMBRE_MADRE = txtnombreMadre.Text;
                padres.CEDULA_MADRE = txtcedulaMadre.Text;
                padres.TELEFONO_MADRE = txttelMadre.Text;
                padres.EMAIL_MADRE = txtemailMadre.Text;
                padres.OCUPACION_MADRE = txtOcupacionMadre.Text;
                padres.NOMBRE_TUTOR = txttutorName.Text;
                padres.TELEFONO_TUTOR = txttutorTelefono.Text;
                //Documentos
                EDocuemntosAlumnos documentos = new EDocuemntosAlumnos();
                documentos.PARTIDA_DE_NACIMINETO = chkpartidaNacimiento.Checked ? "SI" : "NO";
                documentos.CERTIFICADO_NOTAS = chkcertificadoNotas.Checked ? "SI": "NO";
                documentos.TARJETA_VACUNA = chktarjetaVacunas.Checked ? "SI" : "NO";
                documentos.CARTA_TRASLADO = chkcartaTraslado.Checked ? "SI" : "NO";
                documentos.CERTIFICADO_DE_SALUD = chkCertificadoSalud.Checked ? "SI" : "NO";
                //convertir foto
                MemoryStream ms = new MemoryStream();
                pictureEdit1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] foto = ms.GetBuffer();
                documentos.FOTO = foto;
                NAlumno n = new NAlumno();
                n.IngresarAlumno(alumno,padres,documentos);
                 MessageBox.Show("Alumno Guardado con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Limpiar

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
