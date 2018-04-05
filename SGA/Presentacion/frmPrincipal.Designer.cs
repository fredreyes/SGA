﻿namespace Presentacion
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
            this.btnMatricula = new System.Windows.Forms.PictureBox();
            this.Matricula = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevaMatriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMatriculadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnFuncionarios = new System.Windows.Forms.PictureBox();
            this.Funcionarios = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.funcionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónFuncionariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaAcademicaDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAlumnos = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCalificaciones = new System.Windows.Forms.PictureBox();
            this.Calificaciones = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.calificacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planDeClasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ToolTipMenu = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMatricula)).BeginInit();
            this.Matricula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFuncionarios)).BeginInit();
            this.Funcionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalificaciones)).BeginInit();
            this.Calificaciones.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnMatricula);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.btnFuncionarios);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.btnAlumnos);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.btnCalificaciones);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 92);
            this.panel1.TabIndex = 0;
            // 
            // btnMatricula
            // 
            this.btnMatricula.ContextMenuStrip = this.Matricula;
            this.btnMatricula.Image = global::Presentacion.Properties.Resources.ordenador;
            this.btnMatricula.Location = new System.Drawing.Point(45, 25);
            this.btnMatricula.Name = "btnMatricula";
            this.btnMatricula.Size = new System.Drawing.Size(59, 58);
            this.btnMatricula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMatricula.TabIndex = 18;
            this.btnMatricula.TabStop = false;
            this.ToolTipMenu.SetToolTip(this.btnMatricula, "Matricula");
            this.btnMatricula.Click += new System.EventHandler(this.pictureBox6_Click);
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
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(41, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(72, 19);
            this.materialLabel4.TabIndex = 19;
            this.materialLabel4.Text = "Matricula";
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.ContextMenuStrip = this.Funcionarios;
            this.btnFuncionarios.Image = global::Presentacion.Properties.Resources.businessmen;
            this.btnFuncionarios.Location = new System.Drawing.Point(351, 25);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(59, 58);
            this.btnFuncionarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFuncionarios.TabIndex = 16;
            this.btnFuncionarios.TabStop = false;
            this.ToolTipMenu.SetToolTip(this.btnFuncionarios, "Funcionarios");
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
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolesToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(332, 3);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(96, 19);
            this.materialLabel3.TabIndex = 17;
            this.materialLabel3.Text = "Funcionarios";
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Image = global::Presentacion.Properties.Resources.reading;
            this.btnAlumnos.Location = new System.Drawing.Point(208, 25);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(59, 58);
            this.btnAlumnos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAlumnos.TabIndex = 14;
            this.btnAlumnos.TabStop = false;
            this.ToolTipMenu.SetToolTip(this.btnAlumnos, "Alumnos");
            this.btnAlumnos.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(204, 3);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(69, 19);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Alumnos";
            // 
            // btnCalificaciones
            // 
            this.btnCalificaciones.ContextMenuStrip = this.Calificaciones;
            this.btnCalificaciones.Image = global::Presentacion.Properties.Resources.evaluation1;
            this.btnCalificaciones.Location = new System.Drawing.Point(517, 25);
            this.btnCalificaciones.Name = "btnCalificaciones";
            this.btnCalificaciones.Size = new System.Drawing.Size(59, 58);
            this.btnCalificaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCalificaciones.TabIndex = 6;
            this.btnCalificaciones.TabStop = false;
            this.ToolTipMenu.SetToolTip(this.btnCalificaciones, "Calificaciones");
            this.btnCalificaciones.Click += new System.EventHandler(this.pictureBox1_Click_1);
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
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(493, 3);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(105, 19);
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
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(17, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(111, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Administración";
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
            // ToolTipMenu
            // 
            this.ToolTipMenu.IsBalloon = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.btnMatricula)).EndInit();
            this.Matricula.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFuncionarios)).EndInit();
            this.Funcionarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalificaciones)).EndInit();
            this.Calificaciones.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btnCalificaciones;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.PictureBox btnAlumnos;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox btnFuncionarios;
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
        private System.Windows.Forms.PictureBox btnMatricula;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ContextMenuStrip Matricula;
        private System.Windows.Forms.ToolStripMenuItem nuevaMatriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMatriculadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
    }
}