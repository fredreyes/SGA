namespace Presentacion.Otros
{
    partial class Turnos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtncancelar = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnActivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkeditar = new MaterialSkin.Controls.MaterialCheckBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.txtObservacion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTurno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.rbtncancelar);
            this.groupBox1.Controls.Add(this.rbtnActivo);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Controls.Add(this.chkeditar);
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtObservacion);
            this.groupBox1.Controls.Add(this.txtTurno);
            this.groupBox1.Location = new System.Drawing.Point(0, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 330);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbtncancelar
            // 
            this.rbtncancelar.AutoSize = true;
            this.rbtncancelar.Depth = 0;
            this.rbtncancelar.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtncancelar.Location = new System.Drawing.Point(169, 164);
            this.rbtncancelar.Margin = new System.Windows.Forms.Padding(0);
            this.rbtncancelar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtncancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtncancelar.Name = "rbtncancelar";
            this.rbtncancelar.Ripple = true;
            this.rbtncancelar.Size = new System.Drawing.Size(83, 30);
            this.rbtncancelar.TabIndex = 14;
            this.rbtncancelar.TabStop = true;
            this.rbtncancelar.Text = "Cancelar";
            this.rbtncancelar.UseVisualStyleBackColor = true;
            // 
            // rbtnActivo
            // 
            this.rbtnActivo.AutoSize = true;
            this.rbtnActivo.Depth = 0;
            this.rbtnActivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtnActivo.Location = new System.Drawing.Point(29, 164);
            this.rbtnActivo.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnActivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnActivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnActivo.Name = "rbtnActivo";
            this.rbtnActivo.Ripple = true;
            this.rbtnActivo.Size = new System.Drawing.Size(68, 30);
            this.rbtnActivo.TabIndex = 13;
            this.rbtnActivo.TabStop = true;
            this.rbtnActivo.Text = "Activo";
            this.rbtnActivo.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(288, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.exportarToolStripMenuItem,
            this.exportarPDFToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportarToolStripMenuItem.Text = "Exportar XLS";
            this.exportarToolStripMenuItem.Click += new System.EventHandler(this.exportarToolStripMenuItem_Click);
            // 
            // exportarPDFToolStripMenuItem
            // 
            this.exportarPDFToolStripMenuItem.Name = "exportarPDFToolStripMenuItem";
            this.exportarPDFToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportarPDFToolStripMenuItem.Text = "Exportar PDF";
            this.exportarPDFToolStripMenuItem.Click += new System.EventHandler(this.exportarPDFToolStripMenuItem_Click);
            // 
            // chkeditar
            // 
            this.chkeditar.AutoSize = true;
            this.chkeditar.Depth = 0;
            this.chkeditar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkeditar.Location = new System.Drawing.Point(216, 54);
            this.chkeditar.Margin = new System.Windows.Forms.Padding(0);
            this.chkeditar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkeditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkeditar.Name = "chkeditar";
            this.chkeditar.Ripple = true;
            this.chkeditar.Size = new System.Drawing.Size(66, 30);
            this.chkeditar.TabIndex = 11;
            this.chkeditar.Text = "Editar";
            this.chkeditar.UseVisualStyleBackColor = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 244);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(270, 149);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ImageUri.Uri = "Save";
            this.btnGuardar.Location = new System.Drawing.Point(110, 202);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 32);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Depth = 0;
            this.txtObservacion.Hint = "Observación";
            this.txtObservacion.Location = new System.Drawing.Point(49, 129);
            this.txtObservacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.PasswordChar = '\0';
            this.txtObservacion.SelectedText = "";
            this.txtObservacion.SelectionLength = 0;
            this.txtObservacion.SelectionStart = 0;
            this.txtObservacion.Size = new System.Drawing.Size(214, 23);
            this.txtObservacion.TabIndex = 8;
            this.txtObservacion.UseSystemPasswordChar = false;
            // 
            // txtTurno
            // 
            this.txtTurno.Depth = 0;
            this.txtTurno.Hint = "Turno";
            this.txtTurno.Location = new System.Drawing.Point(49, 87);
            this.txtTurno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.PasswordChar = '\0';
            this.txtTurno.SelectedText = "";
            this.txtTurno.SelectionLength = 0;
            this.txtTurno.SelectionStart = 0;
            this.txtTurno.Size = new System.Drawing.Size(214, 23);
            this.txtTurno.TabIndex = 7;
            this.txtTurno.UseSystemPasswordChar = false;
            // 
            // Turnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 469);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Turnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turnos";
            this.Load += new System.EventHandler(this.Turnos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarPDFToolStripMenuItem;
        private MaterialSkin.Controls.MaterialCheckBox chkeditar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtObservacion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTurno;
        private MaterialSkin.Controls.MaterialRadioButton rbtncancelar;
        private MaterialSkin.Controls.MaterialRadioButton rbtnActivo;
    }
}