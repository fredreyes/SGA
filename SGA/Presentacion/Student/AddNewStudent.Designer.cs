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
            this.txtdomicilio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCodigoMined = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpFechaNacimiento = new DevExpress.XtraEditors.DateEdit();
            this.rbtnFemenino = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnMasculino = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtApellidoAlumno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtnombreAlumno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txttutorTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txttutorName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.txtcedulaMadre = new System.Windows.Forms.MaskedTextBox();
            this.txttelMadre = new System.Windows.Forms.MaskedTextBox();
            this.txtemailMadre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtnombreMadre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtApellidoMadre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtOcupacionMadre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtocupacionPadre = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ocupacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtcedulaP = new System.Windows.Forms.MaskedTextBox();
            this.txtelPadre = new System.Windows.Forms.MaskedTextBox();
            this.txtemailPadre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtapellidoPadre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtnombrePadre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.chkpartidaNacimiento = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkcertificadoNotas = new MaterialSkin.Controls.MaterialCheckBox();
            this.chktarjetaVacunas = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkCertificadoSalud = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkcartaTraslado = new MaterialSkin.Controls.MaterialCheckBox();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaNacimiento.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaNacimiento.Properties)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPane1.Location = new System.Drawing.Point(-2, 65);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2,
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
            this.groupBox1.Controls.Add(this.txtdomicilio);
            this.groupBox1.Controls.Add(this.txtCodigoMined);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.dtpFechaNacimiento);
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
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(261, 215);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(128, 18);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Fecha Nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.EditValue = null;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(203, 256);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaNacimiento.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(279, 20);
            this.dtpFechaNacimiento.TabIndex = 6;
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Depth = 0;
            this.rbtnFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
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
            this.rbtnMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
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
            this.tabNavigationPage2.Controls.Add(this.groupBox4);
            this.tabNavigationPage2.Controls.Add(this.groupBox3);
            this.tabNavigationPage2.Controls.Add(this.groupBox2);
            this.tabNavigationPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(751, 375);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txttutorTelefono);
            this.groupBox4.Controls.Add(this.txttutorName);
            this.groupBox4.Location = new System.Drawing.Point(15, 294);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(706, 66);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tutor";
            // 
            // txttutorTelefono
            // 
            this.txttutorTelefono.BeepOnError = true;
            this.txttutorTelefono.Location = new System.Drawing.Point(393, 30);
            this.txttutorTelefono.Mask = "0000-0000";
            this.txttutorTelefono.Name = "txttutorTelefono";
            this.txttutorTelefono.Size = new System.Drawing.Size(279, 24);
            this.txttutorTelefono.TabIndex = 14;
            // 
            // txttutorName
            // 
            this.txttutorName.Depth = 0;
            this.txttutorName.Hint = "Nombres";
            this.txttutorName.Location = new System.Drawing.Point(68, 31);
            this.txttutorName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txttutorName.Name = "txttutorName";
            this.txttutorName.PasswordChar = '\0';
            this.txttutorName.SelectedText = "";
            this.txttutorName.SelectionLength = 0;
            this.txttutorName.SelectionStart = 0;
            this.txttutorName.Size = new System.Drawing.Size(279, 23);
            this.txttutorName.TabIndex = 14;
            this.txttutorName.UseSystemPasswordChar = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.txtcedulaMadre);
            this.groupBox3.Controls.Add(this.txttelMadre);
            this.groupBox3.Controls.Add(this.txtemailMadre);
            this.groupBox3.Controls.Add(this.txtnombreMadre);
            this.groupBox3.Controls.Add(this.txtApellidoMadre);
            this.groupBox3.Controls.Add(this.txtOcupacionMadre);
            this.groupBox3.Location = new System.Drawing.Point(418, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 281);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Madre";
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
            this.txtcedulaMadre.Location = new System.Drawing.Point(6, 196);
            this.txtcedulaMadre.Mask = ">###-######-####L";
            this.txtcedulaMadre.Name = "txtcedulaMadre";
            this.txtcedulaMadre.Size = new System.Drawing.Size(279, 24);
            this.txtcedulaMadre.TabIndex = 14;
            // 
            // txttelMadre
            // 
            this.txttelMadre.BeepOnError = true;
            this.txttelMadre.Location = new System.Drawing.Point(6, 159);
            this.txttelMadre.Mask = "0000-0000";
            this.txttelMadre.Name = "txttelMadre";
            this.txttelMadre.Size = new System.Drawing.Size(279, 24);
            this.txttelMadre.TabIndex = 13;
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
            // txtApellidoMadre
            // 
            this.txtApellidoMadre.Depth = 0;
            this.txtApellidoMadre.Hint = "Apellidos ";
            this.txtApellidoMadre.Location = new System.Drawing.Point(6, 78);
            this.txtApellidoMadre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApellidoMadre.Name = "txtApellidoMadre";
            this.txtApellidoMadre.PasswordChar = '\0';
            this.txtApellidoMadre.SelectedText = "";
            this.txtApellidoMadre.SelectionLength = 0;
            this.txtApellidoMadre.SelectionStart = 0;
            this.txtApellidoMadre.Size = new System.Drawing.Size(279, 23);
            this.txtApellidoMadre.TabIndex = 13;
            this.txtApellidoMadre.UseSystemPasswordChar = false;
            // 
            // txtOcupacionMadre
            // 
            this.txtOcupacionMadre.Depth = 0;
            this.txtOcupacionMadre.Hint = "Ocupación";
            this.txtOcupacionMadre.Location = new System.Drawing.Point(6, 119);
            this.txtOcupacionMadre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtOcupacionMadre.Name = "txtOcupacionMadre";
            this.txtOcupacionMadre.PasswordChar = '\0';
            this.txtOcupacionMadre.SelectedText = "";
            this.txtOcupacionMadre.SelectionLength = 0;
            this.txtOcupacionMadre.SelectionStart = 0;
            this.txtOcupacionMadre.Size = new System.Drawing.Size(279, 23);
            this.txtOcupacionMadre.TabIndex = 14;
            this.txtOcupacionMadre.UseSystemPasswordChar = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtocupacionPadre);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.txtcedulaP);
            this.groupBox2.Controls.Add(this.txtelPadre);
            this.groupBox2.Controls.Add(this.txtemailPadre);
            this.groupBox2.Controls.Add(this.txtapellidoPadre);
            this.groupBox2.Controls.Add(this.txtnombrePadre);
            this.groupBox2.Location = new System.Drawing.Point(15, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 282);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Padre";
            // 
            // txtocupacionPadre
            // 
            this.txtocupacionPadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtocupacionPadre.ContextMenuStrip = this.contextMenuStrip1;
            this.txtocupacionPadre.Location = new System.Drawing.Point(21, 120);
            this.txtocupacionPadre.Name = "txtocupacionPadre";
            this.txtocupacionPadre.Size = new System.Drawing.Size(279, 24);
            this.txtocupacionPadre.TabIndex = 15;
            this.txtocupacionPadre.Text = "Ocupaciones";
            this.txtocupacionPadre.MouseLeave += new System.EventHandler(this.txtocupacionPadre_MouseLeave);
            this.txtocupacionPadre.MouseHover += new System.EventHandler(this.txtocupacionPadre_MouseHover);
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
            // txtelPadre
            // 
            this.txtelPadre.BeepOnError = true;
            this.txtelPadre.Location = new System.Drawing.Point(21, 159);
            this.txtelPadre.Mask = "0000-0000";
            this.txtelPadre.Name = "txtelPadre";
            this.txtelPadre.Size = new System.Drawing.Size(279, 24);
            this.txtelPadre.TabIndex = 12;
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
            // txtapellidoPadre
            // 
            this.txtapellidoPadre.Depth = 0;
            this.txtapellidoPadre.Hint = "Apellidos ";
            this.txtapellidoPadre.Location = new System.Drawing.Point(21, 78);
            this.txtapellidoPadre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtapellidoPadre.Name = "txtapellidoPadre";
            this.txtapellidoPadre.PasswordChar = '\0';
            this.txtapellidoPadre.SelectedText = "";
            this.txtapellidoPadre.SelectionLength = 0;
            this.txtapellidoPadre.SelectionStart = 0;
            this.txtapellidoPadre.Size = new System.Drawing.Size(279, 23);
            this.txtapellidoPadre.TabIndex = 2;
            this.txtapellidoPadre.UseSystemPasswordChar = false;
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
            this.tabNavigationPage3.Controls.Add(this.chkCertificadoSalud);
            this.tabNavigationPage3.Controls.Add(this.chkcartaTraslado);
            this.tabNavigationPage3.Controls.Add(this.chktarjetaVacunas);
            this.tabNavigationPage3.Controls.Add(this.chkcertificadoNotas);
            this.tabNavigationPage3.Controls.Add(this.chkpartidaNacimiento);
            this.tabNavigationPage3.Controls.Add(this.pictureEdit1);
            this.tabNavigationPage3.Controls.Add(this.btnGuardar);
            this.tabNavigationPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(751, 375);
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageUri.Uri = "SaveAll";
            this.btnGuardar.Location = new System.Drawing.Point(437, 286);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 44);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // chkpartidaNacimiento
            // 
            this.chkpartidaNacimiento.AutoSize = true;
            this.chkpartidaNacimiento.Depth = 0;
            this.chkpartidaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
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
            // chkcertificadoNotas
            // 
            this.chkcertificadoNotas.AutoSize = true;
            this.chkcertificadoNotas.Depth = 0;
            this.chkcertificadoNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
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
            // chktarjetaVacunas
            // 
            this.chktarjetaVacunas.AutoSize = true;
            this.chktarjetaVacunas.Depth = 0;
            this.chktarjetaVacunas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
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
            // chkCertificadoSalud
            // 
            this.chkCertificadoSalud.AutoSize = true;
            this.chkCertificadoSalud.Depth = 0;
            this.chkCertificadoSalud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
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
            this.chkcartaTraslado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
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
            this.Load += new System.EventHandler(this.AddNewStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaNacimiento.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaNacimiento.Properties)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabNavigationPage3.ResumeLayout(false);
            this.tabNavigationPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtnombreAlumno;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApellidoAlumno;
        private DevExpress.XtraEditors.DateEdit dtpFechaNacimiento;
        private MaterialSkin.Controls.MaterialRadioButton rbtnFemenino;
        private MaterialSkin.Controls.MaterialRadioButton rbtnMasculino;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtdomicilio;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigoMined;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtapellidoPadre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtnombrePadre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtemailPadre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtemailMadre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtnombreMadre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApellidoMadre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtOcupacionMadre;
        private System.Windows.Forms.MaskedTextBox txtelPadre;
        private System.Windows.Forms.MaskedTextBox txttelMadre;
        private System.Windows.Forms.MaskedTextBox txtcedulaP;
        private System.Windows.Forms.MaskedTextBox txtcedulaMadre;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox txttutorTelefono;
        private MaterialSkin.Controls.MaterialSingleLineTextField txttutorName;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ocupacionesToolStripMenuItem;
        private System.Windows.Forms.TextBox txtocupacionPadre;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private MaterialSkin.Controls.MaterialCheckBox chkCertificadoSalud;
        private MaterialSkin.Controls.MaterialCheckBox chkcartaTraslado;
        private MaterialSkin.Controls.MaterialCheckBox chktarjetaVacunas;
        private MaterialSkin.Controls.MaterialCheckBox chkcertificadoNotas;
        private MaterialSkin.Controls.MaterialCheckBox chkpartidaNacimiento;
    }
}