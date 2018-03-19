﻿namespace Presentacion.Funcionarios
{
    partial class docenteAsignatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(docenteAsignatura));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.chkmañana = new MaterialSkin.Controls.MaterialCheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkdomingo = new MaterialSkin.Controls.MaterialCheckBox();
            this.chksabado = new MaterialSkin.Controls.MaterialCheckBox();
            this.chknocturno = new MaterialSkin.Controls.MaterialCheckBox();
            this.chktarde = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.MateriaDocente = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eDITARToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rbtnPrimaria = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnSecundaria = new MaterialSkin.Controls.MaterialRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            this.MateriaDocente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gridControl1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(12, 84);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(540, 180);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 267);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(161, 180);
            this.listBox1.TabIndex = 4;
            // 
            // chkmañana
            // 
            this.chkmañana.AutoSize = true;
            this.chkmañana.Depth = 0;
            this.chkmañana.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkmañana.Location = new System.Drawing.Point(21, 30);
            this.chkmañana.Margin = new System.Windows.Forms.Padding(0);
            this.chkmañana.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkmañana.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkmañana.Name = "chkmañana";
            this.chkmañana.Ripple = true;
            this.chkmañana.Size = new System.Drawing.Size(80, 30);
            this.chkmañana.TabIndex = 5;
            this.chkmañana.Text = "Mañana";
            this.chkmañana.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkdomingo);
            this.groupBox1.Controls.Add(this.chksabado);
            this.groupBox1.Controls.Add(this.chknocturno);
            this.groupBox1.Controls.Add(this.chktarde);
            this.groupBox1.Controls.Add(this.chkmañana);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(194, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 188);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Disponibilidad";
            // 
            // chkdomingo
            // 
            this.chkdomingo.AutoSize = true;
            this.chkdomingo.Depth = 0;
            this.chkdomingo.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkdomingo.Location = new System.Drawing.Point(21, 150);
            this.chkdomingo.Margin = new System.Windows.Forms.Padding(0);
            this.chkdomingo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkdomingo.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkdomingo.Name = "chkdomingo";
            this.chkdomingo.Ripple = true;
            this.chkdomingo.Size = new System.Drawing.Size(85, 30);
            this.chkdomingo.TabIndex = 9;
            this.chkdomingo.Text = "Domingo";
            this.chkdomingo.UseVisualStyleBackColor = true;
            // 
            // chksabado
            // 
            this.chksabado.AutoSize = true;
            this.chksabado.Depth = 0;
            this.chksabado.Font = new System.Drawing.Font("Roboto", 10F);
            this.chksabado.Location = new System.Drawing.Point(21, 120);
            this.chksabado.Margin = new System.Windows.Forms.Padding(0);
            this.chksabado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chksabado.MouseState = MaterialSkin.MouseState.HOVER;
            this.chksabado.Name = "chksabado";
            this.chksabado.Ripple = true;
            this.chksabado.Size = new System.Drawing.Size(76, 30);
            this.chksabado.TabIndex = 8;
            this.chksabado.Text = "Sábado";
            this.chksabado.UseVisualStyleBackColor = true;
            // 
            // chknocturno
            // 
            this.chknocturno.AutoSize = true;
            this.chknocturno.Depth = 0;
            this.chknocturno.Font = new System.Drawing.Font("Roboto", 10F);
            this.chknocturno.Location = new System.Drawing.Point(21, 90);
            this.chknocturno.Margin = new System.Windows.Forms.Padding(0);
            this.chknocturno.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chknocturno.MouseState = MaterialSkin.MouseState.HOVER;
            this.chknocturno.Name = "chknocturno";
            this.chknocturno.Ripple = true;
            this.chknocturno.Size = new System.Drawing.Size(87, 30);
            this.chknocturno.TabIndex = 7;
            this.chknocturno.Text = "Nocturno";
            this.chknocturno.UseVisualStyleBackColor = true;
            // 
            // chktarde
            // 
            this.chktarde.AutoSize = true;
            this.chktarde.Depth = 0;
            this.chktarde.Font = new System.Drawing.Font("Roboto", 10F);
            this.chktarde.Location = new System.Drawing.Point(21, 60);
            this.chktarde.Margin = new System.Windows.Forms.Padding(0);
            this.chktarde.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chktarde.MouseState = MaterialSkin.MouseState.HOVER;
            this.chktarde.Name = "chktarde";
            this.chktarde.Ripple = true;
            this.chktarde.Size = new System.Drawing.Size(66, 30);
            this.chktarde.TabIndex = 6;
            this.chktarde.Text = "Tarde";
            this.chktarde.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Blue;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Image = ((System.Drawing.Image)(resources.GetObject("btnIngresar.Image")));
            this.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresar.Location = new System.Drawing.Point(538, 298);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(103, 38);
            this.btnIngresar.TabIndex = 47;
            this.btnIngresar.Text = "Guardar";
            this.btnIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
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
            this.btncancelar.Location = new System.Drawing.Point(538, 358);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(103, 38);
            this.btncancelar.TabIndex = 48;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.ContextMenuStrip = this.MateriaDocente;
            this.gridControl2.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl2.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gridControl2.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl2.Location = new System.Drawing.Point(558, 84);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(539, 180);
            this.gridControl2.TabIndex = 49;
            this.toolTip1.SetToolTip(this.gridControl2, "Click derecho +Opciones");
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // MateriaDocente
            // 
            this.MateriaDocente.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MateriaDocente.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eDITARToolStripMenuItem1,
            this.eliminarToolStripMenuItem});
            this.MateriaDocente.Name = "contextMenuStrip1";
            this.MateriaDocente.Size = new System.Drawing.Size(123, 48);
            // 
            // eDITARToolStripMenuItem1
            // 
            this.eDITARToolStripMenuItem1.Image = global::Presentacion.Properties.Resources.edit;
            this.eDITARToolStripMenuItem1.Name = "eDITARToolStripMenuItem1";
            this.eDITARToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.eDITARToolStripMenuItem1.Text = "Editar";
            this.eDITARToolStripMenuItem1.Click += new System.EventHandler(this.eDITARToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = global::Presentacion.Properties.Resources.delete__1_;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click_1);
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // rbtnPrimaria
            // 
            this.rbtnPrimaria.AutoSize = true;
            this.rbtnPrimaria.Depth = 0;
            this.rbtnPrimaria.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtnPrimaria.Location = new System.Drawing.Point(351, 297);
            this.rbtnPrimaria.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnPrimaria.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnPrimaria.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnPrimaria.Name = "rbtnPrimaria";
            this.rbtnPrimaria.Ripple = true;
            this.rbtnPrimaria.Size = new System.Drawing.Size(81, 30);
            this.rbtnPrimaria.TabIndex = 50;
            this.rbtnPrimaria.TabStop = true;
            this.rbtnPrimaria.Text = "Primaria";
            this.rbtnPrimaria.UseVisualStyleBackColor = true;
            // 
            // rbtnSecundaria
            // 
            this.rbtnSecundaria.AutoSize = true;
            this.rbtnSecundaria.Depth = 0;
            this.rbtnSecundaria.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtnSecundaria.Location = new System.Drawing.Point(351, 348);
            this.rbtnSecundaria.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnSecundaria.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnSecundaria.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnSecundaria.Name = "rbtnSecundaria";
            this.rbtnSecundaria.Ripple = true;
            this.rbtnSecundaria.Size = new System.Drawing.Size(98, 30);
            this.rbtnSecundaria.TabIndex = 51;
            this.rbtnSecundaria.TabStop = true;
            this.rbtnSecundaria.Text = "Secundaria";
            this.rbtnSecundaria.UseVisualStyleBackColor = true;
            // 
            // docenteAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 459);
            this.Controls.Add(this.rbtnSecundaria);
            this.Controls.Add(this.rbtnPrimaria);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.gridControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "docenteAsignatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Docente Asignatura";
            this.Load += new System.EventHandler(this.docenteAsignatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            this.MateriaDocente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ListBox listBox1;
        private MaterialSkin.Controls.MaterialCheckBox chkmañana;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialCheckBox chktarde;
        private MaterialSkin.Controls.MaterialCheckBox chknocturno;
        private MaterialSkin.Controls.MaterialCheckBox chkdomingo;
        private MaterialSkin.Controls.MaterialCheckBox chksabado;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btncancelar;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.ContextMenuStrip MateriaDocente;
        private System.Windows.Forms.ToolStripMenuItem eDITARToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private MaterialSkin.Controls.MaterialRadioButton rbtnPrimaria;
        private MaterialSkin.Controls.MaterialRadioButton rbtnSecundaria;
    }
}