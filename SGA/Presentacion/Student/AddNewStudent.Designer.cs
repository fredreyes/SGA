namespace Presentacion.Student
{
    partial class AddNewStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkcancelado = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkactivo = new MaterialSkin.Controls.MaterialCheckBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtdomicilio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCodigoMined = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.rbtnFemenino = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnMasculino = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtApellidoAlumno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtnombreAlumno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txttelMadre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbmOcupacionMadre = new System.Windows.Forms.ComboBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.txtcedulaMadre = new System.Windows.Forms.MaskedTextBox();
            this.txtemailMadre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtnombreMadre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtelPadre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbmOcupacionPadre = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtcedulaP = new System.Windows.Forms.MaskedTextBox();
            this.txtemailPadre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtnombrePadre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btningresar = new System.Windows.Forms.Button();
            this.chkCertificadoSalud = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkcartaTraslado = new MaterialSkin.Controls.MaterialCheckBox();
            this.chktarjetaVacunas = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkcertificadoNotas = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkpartidaNacimiento = new MaterialSkin.Controls.MaterialCheckBox();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ocupacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabNavigationPage4 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txttelefonoTutor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtxTutorName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtcedulaTutor = new System.Windows.Forms.MaskedTextBox();
            this.cbmParentezco = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tabNavigationPage4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Controls.Add(this.tabNavigationPage4);
            this.tabPane1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane1.Location = new System.Drawing.Point(-2, 65);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
            this.tabNavigationPage4,
            this.tabNavigationPage3});
            this.tabPane1.RegularSize = new System.Drawing.Size(769, 420);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(769, 420);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Appearance.BackColor = System.Drawing.Color.White;
            this.tabNavigationPage1.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage1.Caption = "Datos Alumnos";
            this.tabNavigationPage1.Controls.Add(this.groupBox1);
            this.tabNavigationPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(751, 375);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkcancelado);
            this.groupBox1.Controls.Add(this.chkactivo);
            this.groupBox1.Controls.Add(this.dtpFechaNacimiento);
            this.groupBox1.Controls.Add(this.txtdomicilio);
            this.groupBox1.Controls.Add(this.txtCodigoMined);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.rbtnFemenino);
            this.groupBox1.Controls.Add(this.rbtnMasculino);
            this.groupBox1.Controls.Add(this.txtApellidoAlumno);
            this.groupBox1.Controls.Add(this.txtnombreAlumno);
            this.groupBox1.Location = new System.Drawing.Point(20, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(669, 349);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkcancelado
            // 
            this.chkcancelado.AutoSize = true;
            this.chkcancelado.Depth = 0;
            this.chkcancelado.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkcancelado.Location = new System.Drawing.Point(384, 316);
            this.chkcancelado.Margin = new System.Windows.Forms.Padding(0);
            this.chkcancelado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkcancelado.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkcancelado.Name = "chkcancelado";
            this.chkcancelado.Ripple = true;
            this.chkcancelado.Size = new System.Drawing.Size(79, 30);
            this.chkcancelado.TabIndex = 12;
            this.chkcancelado.Text = "Inactivo";
            this.chkcancelado.UseVisualStyleBackColor = true;
            // 
            // chkactivo
            // 
            this.chkactivo.AutoSize = true;
            this.chkactivo.Depth = 0;
            this.chkactivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkactivo.Location = new System.Drawing.Point(231, 316);
            this.chkactivo.Margin = new System.Windows.Forms.Padding(0);
            this.chkactivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkactivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkactivo.Name = "chkactivo";
            this.chkactivo.Ripple = true;
            this.chkactivo.Size = new System.Drawing.Size(69, 30);
            this.chkactivo.TabIndex = 11;
            this.chkactivo.Text = "Activo";
            this.chkactivo.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(186, 252);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(277, 24);
            this.dtpFechaNacimiento.TabIndex = 10;
            // 
            // txtdomicilio
            // 
            this.txtdomicilio.Depth = 0;
            this.txtdomicilio.Hint = "Domicilio";
            this.txtdomicilio.Location = new System.Drawing.Point(356, 99);
            this.txtdomicilio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtdomicilio.Name = "txtdomicilio";
            this.txtdomicilio.PasswordChar = '\0';
            this.txtdomicilio.SelectedText = "";
            this.txtdomicilio.SelectionLength = 0;
            this.txtdomicilio.SelectionStart = 0;
            this.txtdomicilio.Size = new System.Drawing.Size(279, 23);
            this.txtdomicilio.TabIndex = 9;
            this.txtdomicilio.UseSystemPasswordChar = false;
            // 
            // txtCodigoMined
            // 
            this.txtCodigoMined.Depth = 0;
            this.txtCodigoMined.Hint = "Codigo MINED";
            this.txtCodigoMined.Location = new System.Drawing.Point(21, 99);
            this.txtCodigoMined.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigoMined.Name = "txtCodigoMined";
            this.txtCodigoMined.PasswordChar = '\0';
            this.txtCodigoMined.SelectedText = "";
            this.txtCodigoMined.SelectionLength = 0;
            this.txtCodigoMined.SelectionStart = 0;
            this.txtCodigoMined.Size = new System.Drawing.Size(279, 23);
            this.txtCodigoMined.TabIndex = 8;
            this.txtCodigoMined.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(261, 215);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(131, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Fecha Nacimiento";
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Depth = 0;
            this.rbtnFemenino.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtnFemenino.Location = new System.Drawing.Point(356, 155);
            this.rbtnFemenino.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnFemenino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnFemenino.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Ripple = true;
            this.rbtnFemenino.Size = new System.Drawing.Size(90, 30);
            this.rbtnFemenino.TabIndex = 5;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Depth = 0;
            this.rbtnMasculino.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtnMasculino.Location = new System.Drawing.Point(224, 155);
            this.rbtnMasculino.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnMasculino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnMasculino.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Ripple = true;
            this.rbtnMasculino.Size = new System.Drawing.Size(93, 30);
            this.rbtnMasculino.TabIndex = 4;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // txtApellidoAlumno
            // 
            this.txtApellidoAlumno.Depth = 0;
            this.txtApellidoAlumno.Hint = "Apellidos Alumno";
            this.txtApellidoAlumno.Location = new System.Drawing.Point(356, 38);
            this.txtApellidoAlumno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApellidoAlumno.Name = "txtApellidoAlumno";
            this.txtApellidoAlumno.PasswordChar = '\0';
            this.txtApellidoAlumno.SelectedText = "";
            this.txtApellidoAlumno.SelectionLength = 0;
            this.txtApellidoAlumno.SelectionStart = 0;
            this.txtApellidoAlumno.Size = new System.Drawing.Size(279, 23);
            this.txtApellidoAlumno.TabIndex = 2;
            this.txtApellidoAlumno.UseSystemPasswordChar = false;
            // 
            // txtnombreAlumno
            // 
            this.txtnombreAlumno.Depth = 0;
            this.txtnombreAlumno.Hint = "Nombre Alumno";
            this.txtnombreAlumno.Location = new System.Drawing.Point(21, 38);
            this.txtnombreAlumno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtnombreAlumno.Name = "txtnombreAlumno";
            this.txtnombreAlumno.PasswordChar = '\0';
            this.txtnombreAlumno.SelectedText = "";
            this.txtnombreAlumno.SelectionLength = 0;
            this.txtnombreAlumno.SelectionStart = 0;
            this.txtnombreAlumno.Size = new System.Drawing.Size(279, 23);
            this.txtnombreAlumno.TabIndex = 1;
            this.txtnombreAlumno.UseSystemPasswordChar = false;
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Appearance.BackColor = System.Drawing.Color.White;
            this.tabNavigationPage2.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage2.Caption = "Datos Padres";
            this.tabNavigationPage2.Controls.Add(this.groupBox3);
            this.tabNavigationPage2.Controls.Add(this.groupBox2);
            this.tabNavigationPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(751, 375);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txttelMadre);
            this.groupBox3.Controls.Add(this.cbmOcupacionMadre);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.txtcedulaMadre);
            this.groupBox3.Controls.Add(this.txtemailMadre);
            this.groupBox3.Controls.Add(this.txtnombreMadre);
            this.groupBox3.Location = new System.Drawing.Point(418, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 281);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Madre";
            // 
            // txttelMadre
            // 
            this.txttelMadre.Depth = 0;
            this.txttelMadre.Hint = "Teléfono";
            this.txttelMadre.Location = new System.Drawing.Point(7, 142);
            this.txttelMadre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txttelMadre.Name = "txttelMadre";
            this.txttelMadre.PasswordChar = '\0';
            this.txttelMadre.SelectedText = "";
            this.txttelMadre.SelectionLength = 0;
            this.txttelMadre.SelectionStart = 0;
            this.txttelMadre.Size = new System.Drawing.Size(278, 23);
            this.txttelMadre.TabIndex = 21;
            this.txttelMadre.UseSystemPasswordChar = false;
            this.txttelMadre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelMadre_KeyPress);
            // 
            // cbmOcupacionMadre
            // 
            this.cbmOcupacionMadre.FormattingEnabled = true;
            this.cbmOcupacionMadre.Location = new System.Drawing.Point(6, 95);
            this.cbmOcupacionMadre.Name = "cbmOcupacionMadre";
            this.cbmOcupacionMadre.Size = new System.Drawing.Size(279, 26);
            this.cbmOcupacionMadre.TabIndex = 20;
            this.cbmOcupacionMadre.Text = "Seleccione una Ocupación";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(114, 259);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(62, 22);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Tutor";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // txtcedulaMadre
            // 
            this.txtcedulaMadre.Location = new System.Drawing.Point(6, 185);
            this.txtcedulaMadre.Mask = ">###-######-####L";
            this.txtcedulaMadre.Name = "txtcedulaMadre";
            this.txtcedulaMadre.Size = new System.Drawing.Size(279, 24);
            this.txtcedulaMadre.TabIndex = 14;
            // 
            // txtemailMadre
            // 
            this.txtemailMadre.Depth = 0;
            this.txtemailMadre.Hint = "E-Mail";
            this.txtemailMadre.Location = new System.Drawing.Point(6, 226);
            this.txtemailMadre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtemailMadre.Name = "txtemailMadre";
            this.txtemailMadre.PasswordChar = '\0';
            this.txtemailMadre.SelectedText = "";
            this.txtemailMadre.SelectionLength = 0;
            this.txtemailMadre.SelectionStart = 0;
            this.txtemailMadre.Size = new System.Drawing.Size(279, 23);
            this.txtemailMadre.TabIndex = 17;
            this.txtemailMadre.UseSystemPasswordChar = false;
            // 
            // txtnombreMadre
            // 
            this.txtnombreMadre.Depth = 0;
            this.txtnombreMadre.Hint = "Nombres";
            this.txtnombreMadre.Location = new System.Drawing.Point(6, 38);
            this.txtnombreMadre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtnombreMadre.Name = "txtnombreMadre";
            this.txtnombreMadre.PasswordChar = '\0';
            this.txtnombreMadre.SelectedText = "";
            this.txtnombreMadre.SelectionLength = 0;
            this.txtnombreMadre.SelectionStart = 0;
            this.txtnombreMadre.Size = new System.Drawing.Size(279, 23);
            this.txtnombreMadre.TabIndex = 12;
            this.txtnombreMadre.UseSystemPasswordChar = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtelPadre);
            this.groupBox2.Controls.Add(this.cbmOcupacionPadre);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.txtcedulaP);
            this.groupBox2.Controls.Add(this.txtemailPadre);
            this.groupBox2.Controls.Add(this.txtnombrePadre);
            this.groupBox2.Location = new System.Drawing.Point(15, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 282);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Padre";
            // 
            // txtelPadre
            // 
            this.txtelPadre.Depth = 0;
            this.txtelPadre.Hint = "Teléfono";
            this.txtelPadre.Location = new System.Drawing.Point(21, 144);
            this.txtelPadre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtelPadre.Name = "txtelPadre";
            this.txtelPadre.PasswordChar = '\0';
            this.txtelPadre.SelectedText = "";
            this.txtelPadre.SelectionLength = 0;
            this.txtelPadre.SelectionStart = 0;
            this.txtelPadre.Size = new System.Drawing.Size(279, 23);
            this.txtelPadre.TabIndex = 20;
            this.txtelPadre.UseSystemPasswordChar = false;
            this.txtelPadre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtelPadre_KeyPress);
            // 
            // cbmOcupacionPadre
            // 
            this.cbmOcupacionPadre.FormattingEnabled = true;
            this.cbmOcupacionPadre.Location = new System.Drawing.Point(21, 96);
            this.cbmOcupacionPadre.Name = "cbmOcupacionPadre";
            this.cbmOcupacionPadre.Size = new System.Drawing.Size(279, 26);
            this.cbmOcupacionPadre.TabIndex = 19;
            this.cbmOcupacionPadre.Text = "Seleccione una Ocupación";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(113, 256);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 22);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Tutor";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtcedulaP
            // 
            this.txtcedulaP.Location = new System.Drawing.Point(21, 186);
            this.txtcedulaP.Mask = ">###-######-####L";
            this.txtcedulaP.Name = "txtcedulaP";
            this.txtcedulaP.Size = new System.Drawing.Size(279, 24);
            this.txtcedulaP.TabIndex = 13;
            // 
            // txtemailPadre
            // 
            this.txtemailPadre.Depth = 0;
            this.txtemailPadre.Hint = "E-Mail";
            this.txtemailPadre.Location = new System.Drawing.Point(21, 226);
            this.txtemailPadre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtemailPadre.Name = "txtemailPadre";
            this.txtemailPadre.PasswordChar = '\0';
            this.txtemailPadre.SelectedText = "";
            this.txtemailPadre.SelectionLength = 0;
            this.txtemailPadre.SelectionStart = 0;
            this.txtemailPadre.Size = new System.Drawing.Size(279, 23);
            this.txtemailPadre.TabIndex = 11;
            this.txtemailPadre.UseSystemPasswordChar = false;
            // 
            // txtnombrePadre
            // 
            this.txtnombrePadre.Depth = 0;
            this.txtnombrePadre.Hint = "Nombres";
            this.txtnombrePadre.Location = new System.Drawing.Point(21, 38);
            this.txtnombrePadre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtnombrePadre.Name = "txtnombrePadre";
            this.txtnombrePadre.PasswordChar = '\0';
            this.txtnombrePadre.SelectedText = "";
            this.txtnombrePadre.SelectionLength = 0;
            this.txtnombrePadre.SelectionStart = 0;
            this.txtnombrePadre.Size = new System.Drawing.Size(279, 23);
            this.txtnombrePadre.TabIndex = 1;
            this.txtnombrePadre.UseSystemPasswordChar = false;
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Appearance.BackColor = System.Drawing.Color.White;
            this.tabNavigationPage3.Appearance.Options.UseBackColor = true;
            this.tabNavigationPage3.Caption = "Documentos";
            this.tabNavigationPage3.Controls.Add(this.btncancelar);
            this.tabNavigationPage3.Controls.Add(this.btningresar);
            this.tabNavigationPage3.Controls.Add(this.chkCertificadoSalud);
            this.tabNavigationPage3.Controls.Add(this.chkcartaTraslado);
            this.tabNavigationPage3.Controls.Add(this.chktarjetaVacunas);
            this.tabNavigationPage3.Controls.Add(this.chkcertificadoNotas);
            this.tabNavigationPage3.Controls.Add(this.chkpartidaNacimiento);
            this.tabNavigationPage3.Controls.Add(this.pictureEdit1);
            this.tabNavigationPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(751, 375);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Image = global::Presentacion.Properties.Resources.delete;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(509, 275);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(103, 38);
            this.btncancelar.TabIndex = 46;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.Color.Blue;
            this.btningresar.FlatAppearance.BorderSize = 0;
            this.btningresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btningresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btningresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresar.ForeColor = System.Drawing.Color.White;
            this.btningresar.Image = global::Presentacion.Properties.Resources.save;
            this.btningresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btningresar.Location = new System.Drawing.Point(373, 275);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(103, 38);
            this.btningresar.TabIndex = 45;
            this.btningresar.Text = "Guardar";
            this.btningresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // chkCertificadoSalud
            // 
            this.chkCertificadoSalud.AutoSize = true;
            this.chkCertificadoSalud.Depth = 0;
            this.chkCertificadoSalud.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkCertificadoSalud.Location = new System.Drawing.Point(41, 251);
            this.chkCertificadoSalud.Margin = new System.Windows.Forms.Padding(0);
            this.chkCertificadoSalud.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkCertificadoSalud.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkCertificadoSalud.Name = "chkCertificadoSalud";
            this.chkCertificadoSalud.Ripple = true;
            this.chkCertificadoSalud.Size = new System.Drawing.Size(154, 30);
            this.chkCertificadoSalud.TabIndex = 12;
            this.chkCertificadoSalud.Text = "Certificado de Salud";
            this.chkCertificadoSalud.UseVisualStyleBackColor = true;
            // 
            // chkcartaTraslado
            // 
            this.chkcartaTraslado.AutoSize = true;
            this.chkcartaTraslado.Depth = 0;
            this.chkcartaTraslado.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkcartaTraslado.Location = new System.Drawing.Point(41, 206);
            this.chkcartaTraslado.Margin = new System.Windows.Forms.Padding(0);
            this.chkcartaTraslado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkcartaTraslado.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkcartaTraslado.Name = "chkcartaTraslado";
            this.chkcartaTraslado.Ripple = true;
            this.chkcartaTraslado.Size = new System.Drawing.Size(139, 30);
            this.chkcartaTraslado.TabIndex = 11;
            this.chkcartaTraslado.Text = "Carta de Traslado";
            this.chkcartaTraslado.UseVisualStyleBackColor = true;
            // 
            // chktarjetaVacunas
            // 
            this.chktarjetaVacunas.AutoSize = true;
            this.chktarjetaVacunas.Depth = 0;
            this.chktarjetaVacunas.Font = new System.Drawing.Font("Roboto", 10F);
            this.chktarjetaVacunas.Location = new System.Drawing.Point(41, 166);
            this.chktarjetaVacunas.Margin = new System.Windows.Forms.Padding(0);
            this.chktarjetaVacunas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chktarjetaVacunas.MouseState = MaterialSkin.MouseState.HOVER;
            this.chktarjetaVacunas.Name = "chktarjetaVacunas";
            this.chktarjetaVacunas.Ripple = true;
            this.chktarjetaVacunas.Size = new System.Drawing.Size(141, 30);
            this.chktarjetaVacunas.TabIndex = 10;
            this.chktarjetaVacunas.Text = "Tarjeta de Vacuna";
            this.chktarjetaVacunas.UseVisualStyleBackColor = true;
            // 
            // chkcertificadoNotas
            // 
            this.chkcertificadoNotas.AutoSize = true;
            this.chkcertificadoNotas.Depth = 0;
            this.chkcertificadoNotas.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkcertificadoNotas.Location = new System.Drawing.Point(41, 121);
            this.chkcertificadoNotas.Margin = new System.Windows.Forms.Padding(0);
            this.chkcertificadoNotas.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkcertificadoNotas.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkcertificadoNotas.Name = "chkcertificadoNotas";
            this.chkcertificadoNotas.Ripple = true;
            this.chkcertificadoNotas.Size = new System.Drawing.Size(163, 30);
            this.chkcertificadoNotas.TabIndex = 9;
            this.chkcertificadoNotas.Text = "Certificados de Notas";
            this.chkcertificadoNotas.UseVisualStyleBackColor = true;
            // 
            // chkpartidaNacimiento
            // 
            this.chkpartidaNacimiento.AutoSize = true;
            this.chkpartidaNacimiento.Depth = 0;
            this.chkpartidaNacimiento.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkpartidaNacimiento.Location = new System.Drawing.Point(41, 77);
            this.chkpartidaNacimiento.Margin = new System.Windows.Forms.Padding(0);
            this.chkpartidaNacimiento.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkpartidaNacimiento.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkpartidaNacimiento.Name = "chkpartidaNacimiento";
            this.chkpartidaNacimiento.Ripple = true;
            this.chkpartidaNacimiento.Size = new System.Drawing.Size(167, 30);
            this.chkpartidaNacimiento.TabIndex = 8;
            this.chkpartidaNacimiento.Text = "Partida de Nacimiento";
            this.chkpartidaNacimiento.UseVisualStyleBackColor = true;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = global::Presentacion.Properties.Resources.user1;
            this.pictureEdit1.Location = new System.Drawing.Point(400, 87);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Always;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Size = new System.Drawing.Size(170, 161);
            this.pictureEdit1.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ocupacionesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(144, 26);
            // 
            // ocupacionesToolStripMenuItem
            // 
            this.ocupacionesToolStripMenuItem.Name = "ocupacionesToolStripMenuItem";
            this.ocupacionesToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.ocupacionesToolStripMenuItem.Text = "Ocupaciones";
            this.ocupacionesToolStripMenuItem.Click += new System.EventHandler(this.ocupacionesToolStripMenuItem_Click);
            // 
            // tabNavigationPage4
            // 
            this.tabNavigationPage4.Caption = "Alumno Tutor";
            this.tabNavigationPage4.Controls.Add(this.groupBox5);
            this.tabNavigationPage4.Name = "tabNavigationPage4";
            this.tabNavigationPage4.Size = new System.Drawing.Size(751, 375);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbmParentezco);
            this.groupBox5.Controls.Add(this.txtcedulaTutor);
            this.groupBox5.Controls.Add(this.txttelefonoTutor);
            this.groupBox5.Controls.Add(this.txtxTutorName);
            this.groupBox5.Location = new System.Drawing.Point(188, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(326, 282);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos Tutor";
            // 
            // txttelefonoTutor
            // 
            this.txttelefonoTutor.Depth = 0;
            this.txttelefonoTutor.Hint = "Teléfono";
            this.txttelefonoTutor.Location = new System.Drawing.Point(21, 137);
            this.txttelefonoTutor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txttelefonoTutor.Name = "txttelefonoTutor";
            this.txttelefonoTutor.PasswordChar = '\0';
            this.txttelefonoTutor.SelectedText = "";
            this.txttelefonoTutor.SelectionLength = 0;
            this.txttelefonoTutor.SelectionStart = 0;
            this.txttelefonoTutor.Size = new System.Drawing.Size(279, 23);
            this.txttelefonoTutor.TabIndex = 20;
            this.txttelefonoTutor.UseSystemPasswordChar = false;
            // 
            // txtxTutorName
            // 
            this.txtxTutorName.Depth = 0;
            this.txtxTutorName.Hint = "Nombres";
            this.txtxTutorName.Location = new System.Drawing.Point(21, 38);
            this.txtxTutorName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtxTutorName.Name = "txtxTutorName";
            this.txtxTutorName.PasswordChar = '\0';
            this.txtxTutorName.SelectedText = "";
            this.txtxTutorName.SelectionLength = 0;
            this.txtxTutorName.SelectionStart = 0;
            this.txtxTutorName.Size = new System.Drawing.Size(279, 23);
            this.txtxTutorName.TabIndex = 1;
            this.txtxTutorName.UseSystemPasswordChar = false;
            // 
            // txtcedulaTutor
            // 
            this.txtcedulaTutor.Location = new System.Drawing.Point(21, 84);
            this.txtcedulaTutor.Mask = ">###-######-####L";
            this.txtcedulaTutor.Name = "txtcedulaTutor";
            this.txtcedulaTutor.Size = new System.Drawing.Size(279, 22);
            this.txtcedulaTutor.TabIndex = 21;
            // 
            // cbmParentezco
            // 
            this.cbmParentezco.FormattingEnabled = true;
            this.cbmParentezco.Items.AddRange(new object[] {
            "Padre",
            "Madre",
            "Hermano(a)",
            "Tio(a)",
            "Abuelo(a)",
            "Primo(a)",
            "Padrino",
            "Madrina"});
            this.cbmParentezco.Location = new System.Drawing.Point(21, 202);
            this.cbmParentezco.Name = "cbmParentezco";
            this.cbmParentezco.Size = new System.Drawing.Size(279, 24);
            this.cbmParentezco.TabIndex = 22;
            this.cbmParentezco.Text = "Seleccione un Parentezco";
            // 
            // AddNewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 487);
            this.Controls.Add(this.tabPane1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Estudiante";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddNewStudent_FormClosed);
            this.Load += new System.EventHandler(this.AddNewStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabNavigationPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabNavigationPage3.ResumeLayout(false);
            this.tabNavigationPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabNavigationPage4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ocupacionesToolStripMenuItem;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtnombreAlumno;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtApellidoAlumno;
        public MaterialSkin.Controls.MaterialRadioButton rbtnFemenino;
        public MaterialSkin.Controls.MaterialRadioButton rbtnMasculino;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtdomicilio;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtCodigoMined;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtnombrePadre;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtemailPadre;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtemailMadre;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtnombreMadre;
        public System.Windows.Forms.MaskedTextBox txtcedulaP;
        public System.Windows.Forms.MaskedTextBox txtcedulaMadre;
        public System.Windows.Forms.CheckBox checkBox2;
        public System.Windows.Forms.CheckBox checkBox1;
        public DevExpress.XtraEditors.PictureEdit pictureEdit1;
        public MaterialSkin.Controls.MaterialCheckBox chkCertificadoSalud;
        public MaterialSkin.Controls.MaterialCheckBox chkcartaTraslado;
        public MaterialSkin.Controls.MaterialCheckBox chktarjetaVacunas;
        public MaterialSkin.Controls.MaterialCheckBox chkcertificadoNotas;
        public MaterialSkin.Controls.MaterialCheckBox chkpartidaNacimiento;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        public MaterialSkin.Controls.MaterialCheckBox chkcancelado;
        public MaterialSkin.Controls.MaterialCheckBox chkactivo;
        public System.Windows.Forms.ComboBox cbmOcupacionPadre;
        public System.Windows.Forms.ComboBox cbmOcupacionMadre;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtelPadre;
        public MaterialSkin.Controls.MaterialSingleLineTextField txttelMadre;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage4;
        private System.Windows.Forms.GroupBox groupBox5;
        public MaterialSkin.Controls.MaterialSingleLineTextField txttelefonoTutor;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtxTutorName;
        public System.Windows.Forms.MaskedTextBox txtcedulaTutor;
        public System.Windows.Forms.ComboBox cbmParentezco;
    }
}