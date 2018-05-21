namespace Presentacion.Student
{
    partial class Buscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscar));
            this.txtbuscaralumno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimeFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.rbtnFemenino = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnMasculino = new MaterialSkin.Controls.MaterialRadioButton();
            this.txtapellidos = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtnombres = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtcarnet = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Presentacion.WaitFormGlobal), true, true);
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbuscaralumno
            // 
            this.txtbuscaralumno.Depth = 0;
            this.txtbuscaralumno.Hint = "Buscar por Carnet";
            this.txtbuscaralumno.Location = new System.Drawing.Point(95, 87);
            this.txtbuscaralumno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtbuscaralumno.Name = "txtbuscaralumno";
            this.txtbuscaralumno.PasswordChar = '\0';
            this.txtbuscaralumno.SelectedText = "";
            this.txtbuscaralumno.SelectionLength = 0;
            this.txtbuscaralumno.SelectionStart = 0;
            this.txtbuscaralumno.Size = new System.Drawing.Size(279, 23);
            this.txtbuscaralumno.TabIndex = 2;
            this.txtbuscaralumno.UseSystemPasswordChar = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(110, 26);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = global::Presentacion.Properties.Resources.edit;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(243, 130);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(103, 38);
            this.btncancelar.TabIndex = 45;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
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
            this.btnBuscar.Location = new System.Drawing.Point(110, 130);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 38);
            this.btnBuscar.TabIndex = 44;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.dateTimeFechaNacimiento);
            this.groupBox1.Controls.Add(this.rbtnFemenino);
            this.groupBox1.Controls.Add(this.rbtnMasculino);
            this.groupBox1.Controls.Add(this.txtapellidos);
            this.groupBox1.Controls.Add(this.txtnombres);
            this.groupBox1.Controls.Add(this.txtcarnet);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 238);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Busqueda";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(163, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 57;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(133, 134);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(131, 19);
            this.materialLabel1.TabIndex = 56;
            this.materialLabel1.Text = "Fecha Nacimiento";
            // 
            // dateTimeFechaNacimiento
            // 
            this.dateTimeFechaNacimiento.Location = new System.Drawing.Point(68, 162);
            this.dateTimeFechaNacimiento.Name = "dateTimeFechaNacimiento";
            this.dateTimeFechaNacimiento.Size = new System.Drawing.Size(279, 26);
            this.dateTimeFechaNacimiento.TabIndex = 55;
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Depth = 0;
            this.rbtnFemenino.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtnFemenino.Location = new System.Drawing.Point(191, 98);
            this.rbtnFemenino.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnFemenino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnFemenino.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Ripple = true;
            this.rbtnFemenino.Size = new System.Drawing.Size(90, 30);
            this.rbtnFemenino.TabIndex = 54;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Depth = 0;
            this.rbtnMasculino.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtnMasculino.Location = new System.Drawing.Point(89, 98);
            this.rbtnMasculino.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnMasculino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnMasculino.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Ripple = true;
            this.rbtnMasculino.Size = new System.Drawing.Size(93, 30);
            this.rbtnMasculino.TabIndex = 53;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // txtapellidos
            // 
            this.txtapellidos.Depth = 0;
            this.txtapellidos.Hint = "Apellidos";
            this.txtapellidos.Location = new System.Drawing.Point(207, 63);
            this.txtapellidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.PasswordChar = '\0';
            this.txtapellidos.SelectedText = "";
            this.txtapellidos.SelectionLength = 0;
            this.txtapellidos.SelectionStart = 0;
            this.txtapellidos.Size = new System.Drawing.Size(176, 23);
            this.txtapellidos.TabIndex = 52;
            this.txtapellidos.UseSystemPasswordChar = false;
            // 
            // txtnombres
            // 
            this.txtnombres.Depth = 0;
            this.txtnombres.Hint = "Nombres";
            this.txtnombres.Location = new System.Drawing.Point(6, 63);
            this.txtnombres.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.PasswordChar = '\0';
            this.txtnombres.SelectedText = "";
            this.txtnombres.SelectionLength = 0;
            this.txtnombres.SelectionStart = 0;
            this.txtnombres.Size = new System.Drawing.Size(176, 23);
            this.txtnombres.TabIndex = 51;
            this.txtnombres.UseSystemPasswordChar = false;
            // 
            // txtcarnet
            // 
            this.txtcarnet.Depth = 0;
            this.txtcarnet.Hint = "Carnet";
            this.txtcarnet.Location = new System.Drawing.Point(108, 25);
            this.txtcarnet.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcarnet.Name = "txtcarnet";
            this.txtcarnet.PasswordChar = '\0';
            this.txtcarnet.SelectedText = "";
            this.txtcarnet.SelectionLength = 0;
            this.txtcarnet.SelectionStart = 0;
            this.txtcarnet.Size = new System.Drawing.Size(176, 23);
            this.txtcarnet.TabIndex = 50;
            this.txtcarnet.UseSystemPasswordChar = false;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 444);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtbuscaralumno);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Buscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumno";
            this.Load += new System.EventHandler(this.Buscar_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField txtbuscaralumno;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtapellidos;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtnombres;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtcarnet;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dateTimeFechaNacimiento;
        private MaterialSkin.Controls.MaterialRadioButton rbtnFemenino;
        private MaterialSkin.Controls.MaterialRadioButton rbtnMasculino;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}