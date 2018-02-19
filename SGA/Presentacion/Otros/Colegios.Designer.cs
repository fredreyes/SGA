namespace Presentacion.Otros
{
    partial class Colegios
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtcolegio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbmDepartmento = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.chkeditar = new MaterialSkin.Controls.MaterialCheckBox();
            this.txttelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.brncancelar = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Location = new System.Drawing.Point(27, 230);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(332, 162);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 26);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // txtcolegio
            // 
            this.txtcolegio.Depth = 0;
            this.txtcolegio.Hint = "Nombre Colegio";
            this.txtcolegio.Location = new System.Drawing.Point(54, 76);
            this.txtcolegio.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcolegio.Name = "txtcolegio";
            this.txtcolegio.PasswordChar = '\0';
            this.txtcolegio.SelectedText = "";
            this.txtcolegio.SelectionLength = 0;
            this.txtcolegio.SelectionStart = 0;
            this.txtcolegio.Size = new System.Drawing.Size(279, 23);
            this.txtcolegio.TabIndex = 1;
            this.txtcolegio.UseSystemPasswordChar = false;
            // 
            // cbmDepartmento
            // 
            this.cbmDepartmento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmDepartmento.FormattingEnabled = true;
            this.cbmDepartmento.Location = new System.Drawing.Point(54, 138);
            this.cbmDepartmento.Name = "cbmDepartmento";
            this.cbmDepartmento.Size = new System.Drawing.Size(279, 23);
            this.cbmDepartmento.TabIndex = 2;
            this.cbmDepartmento.Text = "Seleccione un Departamento";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Red;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(54, 193);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(86, 31);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // chkeditar
            // 
            this.chkeditar.AutoSize = true;
            this.chkeditar.Depth = 0;
            this.chkeditar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkeditar.Location = new System.Drawing.Point(313, 164);
            this.chkeditar.Margin = new System.Windows.Forms.Padding(0);
            this.chkeditar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkeditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkeditar.Name = "chkeditar";
            this.chkeditar.Ripple = true;
            this.chkeditar.Size = new System.Drawing.Size(66, 30);
            this.chkeditar.TabIndex = 4;
            this.chkeditar.Text = "Editar";
            this.chkeditar.UseVisualStyleBackColor = true;
            // 
            // txttelefono
            // 
            this.txttelefono.Depth = 0;
            this.txttelefono.Hint = "Telefono Colegio";
            this.txttelefono.Location = new System.Drawing.Point(54, 105);
            this.txttelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.PasswordChar = '\0';
            this.txttelefono.SelectedText = "";
            this.txttelefono.SelectionLength = 0;
            this.txttelefono.SelectionStart = 0;
            this.txttelefono.Size = new System.Drawing.Size(279, 23);
            this.txttelefono.TabIndex = 5;
            this.txttelefono.UseSystemPasswordChar = false;
            // 
            // brncancelar
            // 
            this.brncancelar.Depth = 0;
            this.brncancelar.Location = new System.Drawing.Point(224, 193);
            this.brncancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.brncancelar.Name = "brncancelar";
            this.brncancelar.Primary = true;
            this.brncancelar.Size = new System.Drawing.Size(86, 31);
            this.brncancelar.TabIndex = 6;
            this.brncancelar.Text = "Cancelar";
            this.brncancelar.UseVisualStyleBackColor = true;
            this.brncancelar.Click += new System.EventHandler(this.brncancelar_Click);
            // 
            // Colegios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 404);
            this.Controls.Add(this.brncancelar);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.chkeditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbmDepartmento);
            this.Controls.Add(this.txtcolegio);
            this.Controls.Add(this.gridControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Colegios";
            this.Text = "Colegios";
            this.Load += new System.EventHandler(this.Colegios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtcolegio;
        private System.Windows.Forms.ComboBox cbmDepartmento;
        private MaterialSkin.Controls.MaterialRaisedButton btnGuardar;
        private MaterialSkin.Controls.MaterialCheckBox chkeditar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txttelefono;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private MaterialSkin.Controls.MaterialRaisedButton brncancelar;
    }
}