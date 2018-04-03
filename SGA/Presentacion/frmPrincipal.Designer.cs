namespace Presentacion
{
    partial class frmPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Funcionarios = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónFuncionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaAcademicaDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Calificaciones = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.calificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planDeClasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.ToolTipMenu = new System.Windows.Forms.ToolTip(this.components);
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Matricula = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevaMatriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMatriculadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.Funcionarios.SuspendLayout();
            this.Calificaciones.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Matricula.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 92);
            this.panel1.TabIndex = 0;
            // 
            // Funcionarios
            // 
            this.Funcionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Funcionarios.Depth = 0;
            this.Funcionarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionariosToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.Funcionarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.Funcionarios.Name = "materialContextMenuStrip1";
            this.Funcionarios.Size = new System.Drawing.Size(143, 48);
            // 
            // funcionariosToolStripMenuItem
            // 
            this.funcionariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.docentesToolStripMenuItem,
            this.gestiónFuncionariosToolStripMenuItem,
            this.cargaAcademicaDocentesToolStripMenuItem});
            this.funcionariosToolStripMenuItem.Name = "funcionariosToolStripMenuItem";
            this.funcionariosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.funcionariosToolStripMenuItem.Text = "Funcionarios";
            this.funcionariosToolStripMenuItem.Click += new System.EventHandler(this.funcionariosToolStripMenuItem_Click);
            // 
            // docentesToolStripMenuItem
            // 
            this.docentesToolStripMenuItem.Name = "docentesToolStripMenuItem";
            this.docentesToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.docentesToolStripMenuItem.Text = "Docentes";
            this.docentesToolStripMenuItem.Click += new System.EventHandler(this.docentesToolStripMenuItem_Click);
            // 
            // gestiónFuncionariosToolStripMenuItem
            // 
            this.gestiónFuncionariosToolStripMenuItem.Name = "gestiónFuncionariosToolStripMenuItem";
            this.gestiónFuncionariosToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.gestiónFuncionariosToolStripMenuItem.Text = "Gestión Funcionarios";
            this.gestiónFuncionariosToolStripMenuItem.Click += new System.EventHandler(this.gestiónFuncionariosToolStripMenuItem_Click);
            // 
            // cargaAcademicaDocentesToolStripMenuItem
            // 
            this.cargaAcademicaDocentesToolStripMenuItem.Name = "cargaAcademicaDocentesToolStripMenuItem";
            this.cargaAcademicaDocentesToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.cargaAcademicaDocentesToolStripMenuItem.Text = "Carga Academica Docentes";
            this.cargaAcademicaDocentesToolStripMenuItem.Click += new System.EventHandler(this.cargaAcademicaDocentesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(332, 3);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(94, 18);
            this.materialLabel3.TabIndex = 17;
            this.materialLabel3.Text = "Funcionarios";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(204, 3);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(66, 18);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Alumnos";
            // 
            // Calificaciones
            // 
            this.Calificaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Calificaciones.Depth = 0;
            this.Calificaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calificacionesToolStripMenuItem,
            this.evaluacionesToolStripMenuItem,
            this.planDeClasesToolStripMenuItem});
            this.Calificaciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.Calificaciones.Name = "Calificaciones";
            this.Calificaciones.Size = new System.Drawing.Size(150, 70);
            // 
            // calificacionesToolStripMenuItem
            // 
            this.calificacionesToolStripMenuItem.Name = "calificacionesToolStripMenuItem";
            this.calificacionesToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.calificacionesToolStripMenuItem.Text = "Calificaciones";
            this.calificacionesToolStripMenuItem.Click += new System.EventHandler(this.calificacionesToolStripMenuItem_Click);
            // 
            // evaluacionesToolStripMenuItem
            // 
            this.evaluacionesToolStripMenuItem.Name = "evaluacionesToolStripMenuItem";
            this.evaluacionesToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.evaluacionesToolStripMenuItem.Text = "Evaluaciones";
            this.evaluacionesToolStripMenuItem.Click += new System.EventHandler(this.evaluacionesToolStripMenuItem_Click);
            // 
            // planDeClasesToolStripMenuItem
            // 
            this.planDeClasesToolStripMenuItem.Name = "planDeClasesToolStripMenuItem";
            this.planDeClasesToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.planDeClasesToolStripMenuItem.Text = "Plan de Clases";
            this.planDeClasesToolStripMenuItem.Click += new System.EventHandler(this.planDeClasesToolStripMenuItem_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(493, 3);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(100, 18);
            this.materialLabel5.TabIndex = 13;
            this.materialLabel5.Text = "Calificaciones";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.materialLabel2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(1068, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 87);
            this.panel2.TabIndex = 2;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(17, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(105, 18);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Administración";
            // 
            // ToolTipMenu
            // 
            this.ToolTipMenu.IsBalloon = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(41, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(68, 18);
            this.materialLabel4.TabIndex = 19;
            this.materialLabel4.Text = "Matricula";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Presentacion.Properties.Resources.university;
            this.pictureBox2.Location = new System.Drawing.Point(210, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.ContextMenuStrip = this.Matricula;
            this.pictureBox6.Image = global::Presentacion.Properties.Resources.ordenador;
            this.pictureBox6.Location = new System.Drawing.Point(45, 25);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(59, 58);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            this.ToolTipMenu.SetToolTip(this.pictureBox6, "Funcionarios");
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.ContextMenuStrip = this.Funcionarios;
            this.pictureBox5.Image = global::Presentacion.Properties.Resources.businessmen;
            this.pictureBox5.Location = new System.Drawing.Point(351, 25);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(59, 58);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            this.ToolTipMenu.SetToolTip(this.pictureBox5, "Funcionarios");
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Presentacion.Properties.Resources.reading;
            this.pictureBox4.Location = new System.Drawing.Point(208, 25);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(59, 58);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            this.ToolTipMenu.SetToolTip(this.pictureBox4, "Alumnos");
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.Calificaciones;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.evaluation1;
            this.pictureBox1.Location = new System.Drawing.Point(517, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.ToolTipMenu.SetToolTip(this.pictureBox1, "Calificaciones");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Presentacion.Properties.Resources.settings;
            this.pictureBox3.Location = new System.Drawing.Point(44, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.ToolTipMenu.SetToolTip(this.pictureBox3, "Mantenimiento");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Matricula
            // 
            this.Matricula.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Matricula.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaMatriculaToolStripMenuItem,
            this.verMatriculadosToolStripMenuItem});
            this.Matricula.Name = "Matricula";
            this.Matricula.Size = new System.Drawing.Size(173, 48);
            // 
            // nuevaMatriculaToolStripMenuItem
            // 
            this.nuevaMatriculaToolStripMenuItem.Name = "nuevaMatriculaToolStripMenuItem";
            this.nuevaMatriculaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.nuevaMatriculaToolStripMenuItem.Text = "Nueva Matricula";
            this.nuevaMatriculaToolStripMenuItem.Click += new System.EventHandler(this.nuevaMatriculaToolStripMenuItem_Click);
            // 
            // verMatriculadosToolStripMenuItem
            // 
            this.verMatriculadosToolStripMenuItem.Name = "verMatriculadosToolStripMenuItem";
            this.verMatriculadosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.verMatriculadosToolStripMenuItem.Text = "Ver Matriculados";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 653);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colegio Buen Samaritano";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Funcionarios.ResumeLayout(false);
            this.Calificaciones.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Matricula.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialContextMenuStrip Funcionarios;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónFuncionariosToolStripMenuItem;
        private MaterialSkin.Controls.MaterialContextMenuStrip Calificaciones;
        private System.Windows.Forms.ToolStripMenuItem calificacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluacionesToolStripMenuItem;
        private System.Windows.Forms.ToolTip ToolTipMenu;
        private System.Windows.Forms.ToolStripMenuItem planDeClasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaAcademicaDocentesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox6;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ContextMenuStrip Matricula;
        private System.Windows.Forms.ToolStripMenuItem nuevaMatriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMatriculadosToolStripMenuItem;
    }
}