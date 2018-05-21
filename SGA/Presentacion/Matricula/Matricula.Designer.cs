namespace Presentacion.Matricula
{
    partial class Matricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Matricula));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rbtnFememino = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnMasculino = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtdireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtApellido = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkPrimerIngreso = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkrepitente = new MaterialSkin.Controls.MaterialCheckBox();
            this.groupBoxColegio = new System.Windows.Forms.GroupBox();
            this.cbmColegio = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbmTurnos = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCapacidad = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.cbmGrados = new System.Windows.Forms.ComboBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxColegio.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.rbtnFememino);
            this.groupBox1.Controls.Add(this.rbtnMasculino);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Alumno";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Gold;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(64, 262);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 38);
            this.btnBuscar.TabIndex = 45;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rbtnFememino
            // 
            this.rbtnFememino.AutoSize = true;
            this.rbtnFememino.Depth = 0;
            this.rbtnFememino.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtnFememino.Location = new System.Drawing.Point(116, 219);
            this.rbtnFememino.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnFememino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnFememino.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnFememino.Name = "rbtnFememino";
            this.rbtnFememino.Ripple = true;
            this.rbtnFememino.Size = new System.Drawing.Size(90, 30);
            this.rbtnFememino.TabIndex = 8;
            this.rbtnFememino.TabStop = true;
            this.rbtnFememino.Text = "Femenino";
            this.rbtnFememino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Depth = 0;
            this.rbtnMasculino.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtnMasculino.Location = new System.Drawing.Point(6, 219);
            this.rbtnMasculino.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnMasculino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnMasculino.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Ripple = true;
            this.rbtnMasculino.Size = new System.Drawing.Size(93, 30);
            this.rbtnMasculino.TabIndex = 7;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(7, 189);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(42, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Sexo";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(7, 141);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(73, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Dirección";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Depth = 0;
            this.txtdireccion.Hint = "";
            this.txtdireccion.Location = new System.Drawing.Point(6, 163);
            this.txtdireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.PasswordChar = '\0';
            this.txtdireccion.SelectedText = "";
            this.txtdireccion.SelectionLength = 0;
            this.txtdireccion.SelectionStart = 0;
            this.txtdireccion.Size = new System.Drawing.Size(194, 23);
            this.txtdireccion.TabIndex = 4;
            this.txtdireccion.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(7, 83);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(72, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Apellidos";
            // 
            // txtApellido
            // 
            this.txtApellido.Depth = 0;
            this.txtApellido.Hint = "";
            this.txtApellido.Location = new System.Drawing.Point(6, 105);
            this.txtApellido.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PasswordChar = '\0';
            this.txtApellido.SelectedText = "";
            this.txtApellido.SelectionLength = 0;
            this.txtApellido.SelectionStart = 0;
            this.txtApellido.Size = new System.Drawing.Size(194, 23);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(7, 35);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(71, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Nombres";
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.Blue;
            this.txtNombre.Hint = "";
            this.txtNombre.Location = new System.Drawing.Point(6, 57);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(194, 23);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkPrimerIngreso);
            this.groupBox2.Controls.Add(this.chkrepitente);
            this.groupBox2.Controls.Add(this.groupBoxColegio);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(257, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 196);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Matricula";
            // 
            // chkPrimerIngreso
            // 
            this.chkPrimerIngreso.AutoSize = true;
            this.chkPrimerIngreso.Depth = 0;
            this.chkPrimerIngreso.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkPrimerIngreso.Location = new System.Drawing.Point(324, 141);
            this.chkPrimerIngreso.Margin = new System.Windows.Forms.Padding(0);
            this.chkPrimerIngreso.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkPrimerIngreso.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkPrimerIngreso.Name = "chkPrimerIngreso";
            this.chkPrimerIngreso.Ripple = true;
            this.chkPrimerIngreso.Size = new System.Drawing.Size(202, 30);
            this.chkPrimerIngreso.TabIndex = 3;
            this.chkPrimerIngreso.Text = "Proveniente de Otro Colegio";
            this.chkPrimerIngreso.UseVisualStyleBackColor = true;
            this.chkPrimerIngreso.CheckedChanged += new System.EventHandler(this.chkPrimerIngreso_CheckedChanged);
            // 
            // chkrepitente
            // 
            this.chkrepitente.AutoSize = true;
            this.chkrepitente.Depth = 0;
            this.chkrepitente.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkrepitente.Location = new System.Drawing.Point(183, 141);
            this.chkrepitente.Margin = new System.Windows.Forms.Padding(0);
            this.chkrepitente.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkrepitente.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkrepitente.Name = "chkrepitente";
            this.chkrepitente.Ripple = true;
            this.chkrepitente.Size = new System.Drawing.Size(89, 30);
            this.chkrepitente.TabIndex = 2;
            this.chkrepitente.Text = "Repitente";
            this.chkrepitente.UseVisualStyleBackColor = true;
            // 
            // groupBoxColegio
            // 
            this.groupBoxColegio.Controls.Add(this.cbmColegio);
            this.groupBoxColegio.Location = new System.Drawing.Point(401, 16);
            this.groupBoxColegio.Name = "groupBoxColegio";
            this.groupBoxColegio.Size = new System.Drawing.Size(190, 112);
            this.groupBoxColegio.TabIndex = 2;
            this.groupBoxColegio.TabStop = false;
            this.groupBoxColegio.Text = "Seleccionar Colegio";
            this.groupBoxColegio.Visible = false;
            // 
            // cbmColegio
            // 
            this.cbmColegio.FormattingEnabled = true;
            this.cbmColegio.Location = new System.Drawing.Point(6, 41);
            this.cbmColegio.Name = "cbmColegio";
            this.cbmColegio.Size = new System.Drawing.Size(163, 24);
            this.cbmColegio.TabIndex = 1;
            this.cbmColegio.Text = "Seleccione un Colegio";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.cbmTurnos);
            this.groupBox4.Location = new System.Drawing.Point(230, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(165, 112);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Turno";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(6, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 38);
            this.button1.TabIndex = 46;
            this.button1.Text = "Mostrar Capacidad";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbmTurnos
            // 
            this.cbmTurnos.FormattingEnabled = true;
            this.cbmTurnos.Location = new System.Drawing.Point(11, 22);
            this.cbmTurnos.Name = "cbmTurnos";
            this.cbmTurnos.Size = new System.Drawing.Size(148, 24);
            this.cbmTurnos.TabIndex = 48;
            this.cbmTurnos.Text = "Seleccione un Turno";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.lblCapacidad);
            this.groupBox3.Controls.Add(this.materialLabel5);
            this.groupBox3.Controls.Add(this.cbmGrados);
            this.groupBox3.Location = new System.Drawing.Point(19, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 122);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grados";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(37, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // lblCapacidad
            // 
            this.lblCapacidad.AutoSize = true;
            this.lblCapacidad.Depth = 0;
            this.lblCapacidad.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCapacidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCapacidad.Location = new System.Drawing.Point(128, 92);
            this.lblCapacidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCapacidad.Name = "lblCapacidad";
            this.lblCapacidad.Size = new System.Drawing.Size(0, 19);
            this.lblCapacidad.TabIndex = 47;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(34, 69);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(154, 19);
            this.materialLabel5.TabIndex = 46;
            this.materialLabel5.Text = "Capacidad Disponible";
            // 
            // cbmGrados
            // 
            this.cbmGrados.FormattingEnabled = true;
            this.cbmGrados.Location = new System.Drawing.Point(17, 22);
            this.cbmGrados.Name = "cbmGrados";
            this.cbmGrados.Size = new System.Drawing.Size(163, 24);
            this.cbmGrados.TabIndex = 0;
            this.cbmGrados.Text = "Seleccione un Grado";
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
            this.btningresar.Location = new System.Drawing.Point(520, 315);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(110, 39);
            this.btningresar.TabIndex = 48;
            this.btningresar.Text = "Matricular";
            this.btningresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // Matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 396);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Matricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matricula";
            this.Load += new System.EventHandler(this.Matricula_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxColegio.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtdireccion;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApellido;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialRadioButton rbtnFememino;
        private MaterialSkin.Controls.MaterialRadioButton rbtnMasculino;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbmGrados;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialCheckBox chkrepitente;
        private System.Windows.Forms.GroupBox groupBoxColegio;
        private System.Windows.Forms.ComboBox cbmColegio;
        private System.Windows.Forms.Button btnBuscar;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel lblCapacidad;
        private System.Windows.Forms.Button btningresar;
        private MaterialSkin.Controls.MaterialCheckBox chkPrimerIngreso;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cbmTurnos;
        private System.Windows.Forms.Button button1;
    }
}