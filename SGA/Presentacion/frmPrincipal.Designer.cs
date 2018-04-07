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
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnAlumnos = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCalificaciones = new System.Windows.Forms.PictureBox();
            this.lblCalificaciones = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ToolTipMenu = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Calificacion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.calificacionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.planDeClasesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluacionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Trabajadores = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.funcionariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.rolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disponibilidadDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargaAcademicaDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMatricula)).BeginInit();
            this.Matricula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalificaciones)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Calificacion.SuspendLayout();
            this.Trabajadores.SuspendLayout();
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
            this.panel1.Controls.Add(this.lblCalificaciones);
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
            this.verMatriculadosToolStripMenuItem.Click += new System.EventHandler(this.verMatriculadosToolStripMenuItem_Click);
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
            this.btnFuncionarios.ContextMenuStrip = this.Trabajadores;
            this.btnFuncionarios.Image = global::Presentacion.Properties.Resources.businessmen;
            this.btnFuncionarios.Location = new System.Drawing.Point(351, 25);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(59, 58);
            this.btnFuncionarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFuncionarios.TabIndex = 16;
            this.btnFuncionarios.TabStop = false;
            this.ToolTipMenu.SetToolTip(this.btnFuncionarios, "Funcionarios");
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
            this.btnCalificaciones.ContextMenuStrip = this.Calificacion;
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
            // lblCalificaciones
            // 
            this.lblCalificaciones.AutoSize = true;
            this.lblCalificaciones.Depth = 0;
            this.lblCalificaciones.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCalificaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCalificaciones.Location = new System.Drawing.Point(493, 3);
            this.lblCalificaciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCalificaciones.Name = "lblCalificaciones";
            this.lblCalificaciones.Size = new System.Drawing.Size(105, 19);
            this.lblCalificaciones.TabIndex = 13;
            this.lblCalificaciones.Text = "Calificaciones";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 200.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(369, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(686, 322);
            this.label1.TabIndex = 3;
            this.label1.Text = "SGA";
            // 
            // Calificacion
            // 
            this.Calificacion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calificacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evaluacionesToolStripMenuItem1,
            this.planDeClasesToolStripMenuItem1,
            this.calificacionesToolStripMenuItem1});
            this.Calificacion.Name = "Matricula";
            this.Calificacion.Size = new System.Drawing.Size(160, 70);
            // 
            // calificacionesToolStripMenuItem1
            // 
            this.calificacionesToolStripMenuItem1.Name = "calificacionesToolStripMenuItem1";
            this.calificacionesToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.calificacionesToolStripMenuItem1.Text = "Calificaciones";
            this.calificacionesToolStripMenuItem1.Click += new System.EventHandler(this.calificacionesToolStripMenuItem1_Click);
            // 
            // planDeClasesToolStripMenuItem1
            // 
            this.planDeClasesToolStripMenuItem1.Name = "planDeClasesToolStripMenuItem1";
            this.planDeClasesToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.planDeClasesToolStripMenuItem1.Text = "Plan de Clases";
            this.planDeClasesToolStripMenuItem1.Click += new System.EventHandler(this.planDeClasesToolStripMenuItem1_Click);
            // 
            // evaluacionesToolStripMenuItem1
            // 
            this.evaluacionesToolStripMenuItem1.Name = "evaluacionesToolStripMenuItem1";
            this.evaluacionesToolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.evaluacionesToolStripMenuItem1.Text = "Evaluaciones";
            this.evaluacionesToolStripMenuItem1.Click += new System.EventHandler(this.evaluacionesToolStripMenuItem1_Click);
            // 
            // Trabajadores
            // 
            this.Trabajadores.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Trabajadores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionariosToolStripMenuItem1,
            this.usuariosToolStripMenuItem2});
            this.Trabajadores.Name = "Matricula";
            this.Trabajadores.Size = new System.Drawing.Size(149, 48);
            // 
            // funcionariosToolStripMenuItem1
            // 
            this.funcionariosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disponibilidadDocenteToolStripMenuItem,
            this.cargaAcademicaDocenteToolStripMenuItem,
            this.gestionDocenteToolStripMenuItem});
            this.funcionariosToolStripMenuItem1.Name = "funcionariosToolStripMenuItem1";
            this.funcionariosToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.funcionariosToolStripMenuItem1.Text = "Funcionarios";
            // 
            // usuariosToolStripMenuItem2
            // 
            this.usuariosToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rolToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.usuariosToolStripMenuItem2.Name = "usuariosToolStripMenuItem2";
            this.usuariosToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.usuariosToolStripMenuItem2.Text = "Usuarios";
            // 
            // rolToolStripMenuItem
            // 
            this.rolToolStripMenuItem.Name = "rolToolStripMenuItem";
            this.rolToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rolToolStripMenuItem.Text = "Rol";
            this.rolToolStripMenuItem.Click += new System.EventHandler(this.rolToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // disponibilidadDocenteToolStripMenuItem
            // 
            this.disponibilidadDocenteToolStripMenuItem.Name = "disponibilidadDocenteToolStripMenuItem";
            this.disponibilidadDocenteToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.disponibilidadDocenteToolStripMenuItem.Text = "Disponibilidad Docente";
            this.disponibilidadDocenteToolStripMenuItem.Click += new System.EventHandler(this.disponibilidadDocenteToolStripMenuItem_Click);
            // 
            // cargaAcademicaDocenteToolStripMenuItem
            // 
            this.cargaAcademicaDocenteToolStripMenuItem.Name = "cargaAcademicaDocenteToolStripMenuItem";
            this.cargaAcademicaDocenteToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.cargaAcademicaDocenteToolStripMenuItem.Text = "Carga Academica Docente";
            this.cargaAcademicaDocenteToolStripMenuItem.Click += new System.EventHandler(this.cargaAcademicaDocenteToolStripMenuItem_Click);
            // 
            // gestionDocenteToolStripMenuItem
            // 
            this.gestionDocenteToolStripMenuItem.Name = "gestionDocenteToolStripMenuItem";
            this.gestionDocenteToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.gestionDocenteToolStripMenuItem.Text = "Gestion Docente";
            this.gestionDocenteToolStripMenuItem.Click += new System.EventHandler(this.gestionDocenteToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 653);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colegio Buen Samaritano";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMatricula)).EndInit();
            this.Matricula.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalificaciones)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Calificacion.ResumeLayout(false);
            this.Trabajadores.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btnCalificaciones;
        private MaterialSkin.Controls.MaterialLabel lblCalificaciones;
        private System.Windows.Forms.PictureBox btnAlumnos;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.PictureBox btnFuncionarios;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ToolTip ToolTipMenu;
        private System.Windows.Forms.PictureBox btnMatricula;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ContextMenuStrip Matricula;
        private System.Windows.Forms.ToolStripMenuItem nuevaMatriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMatriculadosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip Calificacion;
        private System.Windows.Forms.ToolStripMenuItem evaluacionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem planDeClasesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem calificacionesToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip Trabajadores;
        private System.Windows.Forms.ToolStripMenuItem funcionariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem disponibilidadDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargaAcademicaDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDocenteToolStripMenuItem;
    }
}