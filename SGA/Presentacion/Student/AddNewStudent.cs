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
            dtpFechaNacimiento.Value = DateTime.Today;
            chkactivo.Visible = false;
            chkcancelado.Visible = false;
            CargarOcupaciones();
            OcupacionMadre();
        }

        public int Bandera = 0;
        public int DocumentoID;
        private void AddNewStudent_Load(object sender, EventArgs e)
        {
            
            
        }

        void CargarOcupaciones()
        {
            NOcupaciones n = new NOcupaciones();
            List<EOcupaciones> listaOcupaciones = n.ListaOcupaciones();
            cbmOcupacionPadre.DisplayMember = "Ocupacion";
            cbmOcupacionPadre.ValueMember = "OcupacionId";
            cbmOcupacionPadre.DataSource = listaOcupaciones;
        }
        void OcupacionMadre()
        {
            NOcupaciones n = new NOcupaciones();
            List<EOcupaciones> listaOcupaciones = n.ListaOcupaciones();
            cbmOcupacionMadre.DisplayMember = "Ocupacion";
            cbmOcupacionMadre.ValueMember = "OcupacionId";
            cbmOcupacionMadre.DataSource = listaOcupaciones;
        }


        void Limpiar()
        {
            txtApellidoAlumno.Clear();
            txtcedulaMadre.Clear();
            txtcedulaP.Clear();
            txtCodigoMined.Clear();
            txtdomicilio.Clear();
            txtelPadre.Clear();
            txtemailMadre.Clear();
            txtemailPadre.Clear();
            txtnombreAlumno.Clear();
            txtnombreMadre.Clear();
            txtnombrePadre.Clear();
            txttelMadre.Clear();
            txttelefonoTutor.Clear();
            txtxTutorName.Clear();
            txtcedulaTutor.Clear();
            cbmParentezco.Text = "Seleccione un Parentezco";
            cbmOcupacionMadre.Text = "Seleccione una Ocupación";
            cbmOcupacionPadre.Text = "Seleccione una Ocupación";
            chkactivo.Visible = false;
            chkcancelado.Visible = false;
            chkcartaTraslado.Checked = false;
            chkcertificadoNotas.Checked = false;
            chkCertificadoSalud.Checked = false;
            chkpartidaNacimiento.Checked = false;
            chktarjetaVacunas.Checked = false;
            pictureEdit1.Image = Presentacion.Properties.Resources.user1;
            dtpFechaNacimiento.Value = DateTime.Today;
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
                txtxTutorName.Text = txtnombrePadre.Text;
                txtcedulaTutor.Text = txtcedulaP.Text;
                txttelefonoTutor.Text = txtelPadre.Text;
                cbmParentezco.Text = "Padre";
                checkBox2.Checked = false;
            }
            else
            {
                txtcedulaTutor.Clear();
                txttelefonoTutor.Clear();
                txtxTutorName.Clear();
                cbmParentezco.Text = "Seleccione un Parentezco";
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                txtxTutorName.Text = txtnombreMadre.Text;
                txtcedulaTutor.Text = txtcedulaMadre.Text;
                txttelefonoTutor.Text = txttelMadre.Text;
                cbmParentezco.Text = "Madre";
                checkBox1.Checked = false;
            }
            else
            {
                txtcedulaTutor.Clear();
                txttelefonoTutor.Clear();
                txtxTutorName.Clear();
                cbmParentezco.Text = "Seleccione un Parentezco";
            }
        }
        
        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                //Alumno
                if (Bandera == 0)
                {
                    EAlumnos alumno = new EAlumnos();
                    alumno.Nombres = txtnombreAlumno.Text;
                    alumno.Apellidos = txtApellidoAlumno.Text;
                    alumno.Sexo = rbtnMasculino.Checked ? "M" : "F";
                    alumno.FechaNacimiento = Convert.ToDateTime(dtpFechaNacimiento.Value);
                    alumno.Direccion = txtdomicilio.Text;
                    alumno.CodigoMined = Convert.ToInt32(txtCodigoMined.Text);
                    //Parentezco
                    alumno.NombreTutor = txtxTutorName.Text;
                    alumno.CedulaTutor = txtcedulaTutor.Text;
                    alumno.TelefonoTutor = txttelefonoTutor.Text;
                    alumno.ParentezcoAlumno = cbmParentezco.Text;
                    //Padres
                    EPadres_Tutor padres = new EPadres_Tutor();
                    padres.NOMBRE_PADRE = txtnombrePadre.Text;
                    padres.CEDULA_PADRE = txtcedulaP.Text;
                    padres.TELEFONO_PADRE = txtelPadre.Text;
                    padres.EMAIL_PADRE = txtemailPadre.Text;
                    padres.OCUPACION_PADRE = cbmOcupacionPadre.Text;
                    padres.NOMBRE_MADRE = txtnombreMadre.Text;
                    padres.CEDULA_MADRE = txtcedulaMadre.Text;
                    padres.TELEFONO_MADRE = txttelMadre.Text;
                    padres.EMAIL_MADRE = txtemailMadre.Text;
                    padres.OCUPACION_MADRE = cbmOcupacionMadre.Text;
                    //Documentos
                    EDocuemntosAlumnos documentos = new EDocuemntosAlumnos();
                    documentos.PARTIDA_DE_NACIMINETO = chkpartidaNacimiento.Checked ? "SI" : "NO";
                    documentos.CERTIFICADO_NOTAS = chkcertificadoNotas.Checked ? "SI" : "NO";
                    documentos.TARJETA_VACUNA = chktarjetaVacunas.Checked ? "SI" : "NO";
                    documentos.CARTA_TRASLADO = chkcartaTraslado.Checked ? "SI" : "NO";
                    documentos.CERTIFICADO_DE_SALUD = chkCertificadoSalud.Checked ? "SI" : "NO";
                    //convertir foto
                    MemoryStream ms = new MemoryStream();
                    pictureEdit1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] foto = ms.GetBuffer();
                    documentos.FOTO = foto;
                    NAlumno n = new NAlumno();
                    n.IngresarAlumno(alumno, padres, documentos);
                    MessageBox.Show("Alumno Guardado con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpiar
                    Limpiar();
                }
                if (Bandera == 1)
                {
                    EAlumnos alumno = new EAlumnos();
                    alumno.AlumnoId = Convert.ToInt32(txtnombreAlumno.Tag);
                    alumno.Nombres = txtnombreAlumno.Text;
                    alumno.Apellidos = txtApellidoAlumno.Text;
                    alumno.Sexo = rbtnMasculino.Checked ? "M" : "F";
                    alumno.FechaNacimiento = Convert.ToDateTime(dtpFechaNacimiento.Value);
                    alumno.Direccion = txtdomicilio.Text;
                    alumno.CodigoMined = Convert.ToInt32(txtCodigoMined.Text);
                    alumno.Activo = Convert.ToBoolean(chkactivo.Checked ? 1 : 0);
                    //Parentezco
                    alumno.NombreTutor = txtxTutorName.Text;
                    alumno.CedulaTutor = txtcedulaTutor.Text;
                    alumno.TelefonoTutor = txttelefonoTutor.Text;
                    alumno.ParentezcoAlumno = cbmParentezco.Text;
                    //Padres
                    EPadres_Tutor padres = new EPadres_Tutor();
                    padres.NOMBRE_PADRE = txtnombrePadre.Text;
                    padres.CEDULA_PADRE = txtcedulaP.Text;
                    padres.TELEFONO_PADRE = txtelPadre.Text;
                    padres.EMAIL_PADRE = txtemailPadre.Text;
                    padres.OCUPACION_PADRE = cbmOcupacionPadre.Text;
                    padres.NOMBRE_MADRE = txtnombreMadre.Text;
                    padres.CEDULA_MADRE = txtcedulaMadre.Text;
                    padres.TELEFONO_MADRE = txttelMadre.Text;
                    padres.EMAIL_MADRE = txtemailMadre.Text;
                    padres.OCUPACION_MADRE = cbmOcupacionMadre.Text;
                    //Documentos
                    EDocuemntosAlumnos documentos = new EDocuemntosAlumnos();
                    documentos.PARTIDA_DE_NACIMINETO = chkpartidaNacimiento.Checked ? "SI" : "NO";
                    documentos.CERTIFICADO_NOTAS = chkcertificadoNotas.Checked ? "SI" : "NO";
                    documentos.TARJETA_VACUNA = chktarjetaVacunas.Checked ? "SI" : "NO";
                    documentos.CARTA_TRASLADO = chkcartaTraslado.Checked ? "SI" : "NO";
                    documentos.CERTIFICADO_DE_SALUD = chkCertificadoSalud.Checked ? "SI" : "NO";
                    //convertir foto
                    MemoryStream ms = new MemoryStream();
                    pictureEdit1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] foto = ms.GetBuffer();
                    documentos.FOTO = foto;
                    NAlumno n = new NAlumno();
                    n.ModificarAlumno(alumno, padres, documentos);
                    MessageBox.Show("Alumno Modificado con exito", "SGA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "SGA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (txtnombreAlumno.Text != "")
            {
                DialogResult mensaje = MessageBox.Show("¿Estas seguro de cancelar la edicion de este registro?", "SGA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (mensaje == DialogResult.OK)
                {
                    Limpiar();
                }
            }
        }

        private void AddNewStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void txtelPadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txttelMadre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
