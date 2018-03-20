namespace Presentacion.Funcionarios
{
    partial class AgregarFuncionario
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
            this.txtnombres = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtapellido = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.rbtnMasculino = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnFemenino = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtcedula = new System.Windows.Forms.MaskedTextBox();
            this.txttelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtcargo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtemail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbmOcupacion = new System.Windows.Forms.ComboBox();
            this.chkactivo = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkcancelar = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkisDocente = new MaterialSkin.Controls.MaterialCheckBox();
            this.dateFechaNac = new System.Windows.Forms.DateTimePicker();
            this.pictureFoto = new DevExpress.XtraEditors.PictureEdit();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btningresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombres
            // 
            this.txtnombres.Depth = 0;
            this.txtnombres.Hint = "Nombres";
            this.txtnombres.Location = new System.Drawing.Point(12, 85);
            this.txtnombres.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.PasswordChar = '\0';
            this.txtnombres.SelectedText = "";
            this.txtnombres.SelectionLength = 0;
            this.txtnombres.SelectionStart = 0;
            this.txtnombres.Size = new System.Drawing.Size(272, 23);
            this.txtnombres.TabIndex = 0;
            this.txtnombres.UseSystemPasswordChar = false;
            // 
            // txtapellido
            // 
            this.txtapellido.Depth = 0;
            this.txtapellido.Hint = "Apellidos";
            this.txtapellido.Location = new System.Drawing.Point(12, 120);
            this.txtapellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.PasswordChar = '\0';
            this.txtapellido.SelectedText = "";
            this.txtapellido.SelectionLength = 0;
            this.txtapellido.SelectionStart = 0;
            this.txtapellido.Size = new System.Drawing.Size(272, 23);
            this.txtapellido.TabIndex = 1;
            this.txtapellido.UseSystemPasswordChar = false;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Depth = 0;
            this.rbtnMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtnMasculino.Location = new System.Drawing.Point(12, 200);
            this.rbtnMasculino.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnMasculino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnMasculino.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Ripple = true;
            this.rbtnMasculino.Size = new System.Drawing.Size(93, 30);
            this.rbtnMasculino.TabIndex = 2;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Depth = 0;
            this.rbtnFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtnFemenino.Location = new System.Drawing.Point(151, 200);
            this.rbtnFemenino.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnFemenino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnFemenino.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Ripple = true;
            this.rbtnFemenino.Size = new System.Drawing.Size(90, 30);
            this.rbtnFemenino.TabIndex = 3;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // txtcedula
            // 
            this.txtcedula.BackColor = System.Drawing.Color.White;
            this.txtcedula.Font = new System.Drawing.Font("Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtcedula.Location = new System.Drawing.Point(12, 161);
            this.txtcedula.Mask = ">000-000000-0000L";
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(272, 23);
            this.txtcedula.TabIndex = 5;
            // 
            // txttelefono
            // 
            this.txttelefono.Depth = 0;
            this.txttelefono.Hint = "Teléfono";
            this.txttelefono.Location = new System.Drawing.Point(12, 282);
            this.txttelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.PasswordChar = '\0';
            this.txttelefono.SelectedText = "";
            this.txttelefono.SelectionLength = 0;
            this.txttelefono.SelectionStart = 0;
            this.txttelefono.Size = new System.Drawing.Size(272, 23);
            this.txttelefono.TabIndex = 6;
            this.txttelefono.UseSystemPasswordChar = false;
            // 
            // txtcargo
            // 
            this.txtcargo.Depth = 0;
            this.txtcargo.Hint = "Cargo";
            this.txtcargo.Location = new System.Drawing.Point(12, 311);
            this.txtcargo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.PasswordChar = '\0';
            this.txtcargo.SelectedText = "";
            this.txtcargo.SelectionLength = 0;
            this.txtcargo.SelectionStart = 0;
            this.txtcargo.Size = new System.Drawing.Size(272, 23);
            this.txtcargo.TabIndex = 7;
            this.txtcargo.UseSystemPasswordChar = false;
            // 
            // txtemail
            // 
            this.txtemail.Depth = 0;
            this.txtemail.Hint = "E-Mail";
            this.txtemail.Location = new System.Drawing.Point(12, 349);
            this.txtemail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.SelectedText = "";
            this.txtemail.SelectionLength = 0;
            this.txtemail.SelectionStart = 0;
            this.txtemail.Size = new System.Drawing.Size(272, 23);
            this.txtemail.TabIndex = 10;
            this.txtemail.UseSystemPasswordChar = false;
            // 
            // cbmOcupacion
            // 
            this.cbmOcupacion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmOcupacion.FormattingEnabled = true;
            this.cbmOcupacion.Location = new System.Drawing.Point(12, 386);
            this.cbmOcupacion.Name = "cbmOcupacion";
            this.cbmOcupacion.Size = new System.Drawing.Size(272, 24);
            this.cbmOcupacion.TabIndex = 43;
            this.cbmOcupacion.Text = "Seleccione una Profesión u Ocupación";
            // 
            // chkactivo
            // 
            this.chkactivo.AutoSize = true;
            this.chkactivo.Depth = 0;
            this.chkactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkactivo.Location = new System.Drawing.Point(361, 78);
            this.chkactivo.Margin = new System.Windows.Forms.Padding(0);
            this.chkactivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkactivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkactivo.Name = "chkactivo";
            this.chkactivo.Ripple = true;
            this.chkactivo.Size = new System.Drawing.Size(69, 30);
            this.chkactivo.TabIndex = 46;
            this.chkactivo.Text = "Activo";
            this.chkactivo.UseVisualStyleBackColor = true;
            this.chkactivo.CheckedChanged += new System.EventHandler(this.chkactivo_CheckedChanged);
            // 
            // chkcancelar
            // 
            this.chkcancelar.AutoSize = true;
            this.chkcancelar.Depth = 0;
            this.chkcancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkcancelar.Location = new System.Drawing.Point(476, 78);
            this.chkcancelar.Margin = new System.Windows.Forms.Padding(0);
            this.chkcancelar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkcancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkcancelar.Name = "chkcancelar";
            this.chkcancelar.Ripple = true;
            this.chkcancelar.Size = new System.Drawing.Size(95, 30);
            this.chkcancelar.TabIndex = 47;
            this.chkcancelar.Text = "Cancelado";
            this.chkcancelar.UseVisualStyleBackColor = true;
            this.chkcancelar.CheckedChanged += new System.EventHandler(this.chkcancelar_CheckedChanged);
            // 
            // chkisDocente
            // 
            this.chkisDocente.AutoSize = true;
            this.chkisDocente.Depth = 0;
            this.chkisDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkisDocente.Location = new System.Drawing.Point(424, 304);
            this.chkisDocente.Margin = new System.Windows.Forms.Padding(0);
            this.chkisDocente.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkisDocente.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkisDocente.Name = "chkisDocente";
            this.chkisDocente.Ripple = true;
            this.chkisDocente.Size = new System.Drawing.Size(81, 30);
            this.chkisDocente.TabIndex = 48;
            this.chkisDocente.Text = "Docente";
            this.chkisDocente.UseVisualStyleBackColor = true;
            // 
            // dateFechaNac
            // 
            this.dateFechaNac.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFechaNac.Location = new System.Drawing.Point(13, 250);
            this.dateFechaNac.Name = "dateFechaNac";
            this.dateFechaNac.Size = new System.Drawing.Size(271, 23);
            this.dateFechaNac.TabIndex = 49;
            // 
            // pictureFoto
            // 
            this.pictureFoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureFoto.EditValue = global::Presentacion.Properties.Resources.users;
            this.pictureFoto.Location = new System.Drawing.Point(387, 120);
            this.pictureFoto.Name = "pictureFoto";
            this.pictureFoto.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureFoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureFoto.Properties.ZoomAccelerationFactor = 1D;
            this.pictureFoto.Size = new System.Drawing.Size(147, 151);
            this.pictureFoto.TabIndex = 42;
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
            this.btncancelar.Location = new System.Drawing.Point(485, 375);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(103, 38);
            this.btncancelar.TabIndex = 41;
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
            this.btningresar.Location = new System.Drawing.Point(346, 375);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(103, 38);
            this.btningresar.TabIndex = 40;
            this.btningresar.Text = "Guardar";
            this.btningresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // AgregarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 425);
            this.Controls.Add(this.dateFechaNac);
            this.Controls.Add(this.chkisDocente);
            this.Controls.Add(this.chkcancelar);
            this.Controls.Add(this.chkactivo);
            this.Controls.Add(this.cbmOcupacion);
            this.Controls.Add(this.pictureFoto);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtcargo);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.rbtnFemenino);
            this.Controls.Add(this.rbtnMasculino);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombres);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Funcionario";
            this.Load += new System.EventHandler(this.AgregarFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btningresar;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtnombres;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtapellido;
        public MaterialSkin.Controls.MaterialRadioButton rbtnMasculino;
        public MaterialSkin.Controls.MaterialRadioButton rbtnFemenino;
        public System.Windows.Forms.MaskedTextBox txtcedula;
        public MaterialSkin.Controls.MaterialSingleLineTextField txttelefono;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtcargo;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtemail;
        public DevExpress.XtraEditors.PictureEdit pictureFoto;
        public System.Windows.Forms.ComboBox cbmOcupacion;
        public MaterialSkin.Controls.MaterialCheckBox chkactivo;
        public MaterialSkin.Controls.MaterialCheckBox chkcancelar;
        public MaterialSkin.Controls.MaterialCheckBox chkisDocente;
        public System.Windows.Forms.DateTimePicker dateFechaNac;
    }
}