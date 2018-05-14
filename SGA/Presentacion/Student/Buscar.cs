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
using DevExpress.XtraSplashScreen;

namespace Presentacion.Student
{
    public partial class Buscar : MaterialForm
    {
        List<EAlumnos> lista = new List<EAlumnos>();
        NAlumno nalu = new NAlumno();
        //Variables
        #region Variables
        public string direccion;
        public int codigoMined;
        public bool activo;
        public int documetoID;
        public string partida;
        public string notas;
        public string vacuna;
        public string traslado;
        public string salud;
        public byte[] foto;
        public int IdParentezto;
        public string NombrePadre;
        public string CedulaPadre;
        public string TelefonoPadre;
        public string EmailPadre;
        public string OcupacionPadre;
        public string NombreMadre;
        public string CedulaMadre;
        public string TelefonoMadre;
        public string EmailMadre;
        public string OcupacionMadre;
        public string NombreTutor;
        public string CedulaTutor;
        public string TelefonoTutor;
        public string ParentezcoAlumno;
        #endregion
        public Buscar()
        {
            InitializeComponent();
            EstiloMenu x = new EstiloMenu();
            x.AplicarEstilo(this);
        }
        public void CargarSplash()
        {
            SplashScreenManager.ShowForm(typeof(WaitFormGlobal));
        }
        public void CloseSplash()
        {
            SplashScreenManager.CloseForm();
        }
        private void Buscar_Load(object sender, EventArgs e)
        {

        }
        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbuscaralumno.Text != "")
                {
                    #region PasarDatos
                    NAlumno n = new NAlumno();
                    EAlumnos alumno = n.ListaAlumnos(new EAlumnos() { AlumnoId = Convert.ToInt32(txtbuscaralumno.Text) });
                    if (alumno.AlumnoId != 0)
                    {
                        txtcarnet.Text = alumno.AlumnoId.ToString();
                        txtnombres.Text = alumno.Nombres;
                        txtapellidos.Text = alumno.Apellidos;
                        if (alumno.Sexo == "M")
                        {
                            rbtnMasculino.Checked = true;
                        }
                        else
                        rbtnFemenino.Checked = true;
                        dateTimeFechaNacimiento.Value = alumno.FechaNacimiento;
                        direccion = alumno.Direccion;
                        codigoMined = alumno.CodigoMined;
                        activo = alumno.Activo;
                        documetoID = alumno.DOCUMENTO_ALUMNO_ID;
                        partida = alumno.PARTIDA_DE_NACIMINETO;
                        notas = alumno.CERTIFICADO_NOTAS;
                        vacuna = alumno.TARJETA_VACUNA;
                        traslado = alumno.CARTA_TRASLADO;
                        salud = alumno.CERTIFICADO_DE_SALUD;
                        foto = alumno.FOTO;
                        IdParentezto = alumno.ID_PARENTEZCO;
                        NombrePadre = alumno.NOMBRE_PADRE;
                        CedulaPadre = alumno.CEDULA_PADRE;
                        TelefonoPadre = alumno.TELEFONO_PADRE;
                        EmailPadre = alumno.EMAIL_PADRE;
                        OcupacionPadre = alumno.OCUPACION_PADRE;
                        NombreMadre = alumno.NOMBRE_MADRE;
                        CedulaMadre = alumno.CEDULA_MADRE;
                        TelefonoMadre = alumno.TELEFONO_MADRE;
                        EmailMadre = alumno.EMAIL_MADRE;
                        OcupacionMadre = alumno.OCUPACION_MADRE;
                        NombreTutor = alumno.NombreTutor;
                        CedulaTutor = alumno.CedulaTutor;
                        TelefonoTutor = alumno.TelefonoTutor;
                        ParentezcoAlumno = alumno.ParentezcoAlumno;
                        #endregion
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
        private void btncancelar_Click(object sender, EventArgs e)
        {
           // txtbuscaralumno.Text = "";
            txtapellidos.Clear();
            txtcarnet.Clear();
            txtnombres.Clear();
            dateTimeFechaNacimiento.Value = DateTime.Today;
            rbtnFemenino.Checked = false;
            rbtnMasculino.Checked = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CargarSplash();
            AddNewStudent estudiante = new AddNewStudent();
            estudiante.Text = "Editar Estudiante";
            estudiante.txtnombreAlumno.Tag = txtcarnet.Text;
            estudiante.txtnombreAlumno.Text = txtnombres.Text;
            estudiante.txtApellidoAlumno.Text = txtapellidos.Text;
            //Sexo
            if (rbtnMasculino.Checked == true)
                estudiante.rbtnMasculino.Checked = true;
            else
                estudiante.rbtnFemenino.Checked = true;
            estudiante.dtpFechaNacimiento.Value = dateTimeFechaNacimiento.Value;
            estudiante.txtdomicilio.Text = direccion;
            estudiante.txtCodigoMined.Text = codigoMined.ToString();
            //// ACTIVO 
            if (activo == true)
               estudiante.chkactivo.Checked = true;
            else
                estudiante.chkcancelado.Checked = true;
            // DOcumentoID
            //  estudiante.DocumentoID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value.ToString());
            //Chekbos Documentos
            if (partida == "SI")
                estudiante.chkpartidaNacimiento.Checked = true;
            if (notas == "SI")
                estudiante.chkcertificadoNotas.Checked = true;
            if (vacuna == "SI")
                estudiante.chktarjetaVacunas.Checked = true;
            if (traslado == "SI")
                estudiante.chkcartaTraslado.Checked = true;
            if (salud == "SI")
                estudiante.chkCertificadoSalud.Checked = true;
            //FOTO 
            //convertir Imagen 
            byte[] imagenBuffer = (foto);
            MemoryStream ms = new MemoryStream(imagenBuffer);
            estudiante.pictureEdit1.Image = Image.FromStream(ms);
            estudiante.txtnombrePadre.Text = NombrePadre;
            estudiante.txtcedulaP.Text = CedulaPadre;
            estudiante.txtelPadre.Text = TelefonoPadre;
            estudiante.txtemailPadre.Text = EmailPadre;
            estudiante.txtnombrePadre.Text = NombrePadre;
            estudiante.txtcedulaP.Text = CedulaPadre;
            estudiante.txtelPadre.Text = TelefonoPadre;
            estudiante.txtemailPadre.Text = EmailPadre;
            estudiante.cbmOcupacionPadre.Text = OcupacionPadre;
            estudiante.txtnombreMadre.Text = NombreMadre;
            estudiante.txtcedulaMadre.Text = CedulaMadre;
            estudiante.txttelMadre.Text = TelefonoMadre;
            estudiante.txtemailMadre.Text = EmailMadre;
            estudiante.cbmOcupacionMadre.Text = OcupacionMadre;
            //ChkTutor
            if (NombrePadre == NombreTutor)
                estudiante.checkBox1.Checked = true;
            else if (NombrePadre != NombreTutor)
                estudiante.checkBox2.Checked = true;
            else
            {
                estudiante.txtxTutorName.Text = NombreTutor;
                estudiante.txtcedulaTutor.Text = CedulaTutor;
                estudiante.txttelefonoTutor.Text = TelefonoTutor;
                estudiante.cbmParentezco.Text = ParentezcoAlumno;
            }
            estudiante.Bandera = 1;
            estudiante.chkactivo.Visible = true;
            estudiante.chkcancelado.Visible = true;
            estudiante.ShowDialog();
            btncancelar.PerformClick();
        }
    }
}
