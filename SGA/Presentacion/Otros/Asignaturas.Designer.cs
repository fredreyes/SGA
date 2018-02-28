namespace Presentacion.Otros
{
    partial class Asignaturas
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
            this.rbtnCancelar = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnactivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.chkEditar = new MaterialSkin.Controls.MaterialCheckBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtasignatura = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btningresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnCancelar
            // 
            this.rbtnCancelar.AutoSize = true;
            this.rbtnCancelar.Depth = 0;
            this.rbtnCancelar.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtnCancelar.Location = new System.Drawing.Point(124, 115);
            this.rbtnCancelar.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnCancelar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnCancelar.Name = "rbtnCancelar";
            this.rbtnCancelar.Ripple = true;
            this.rbtnCancelar.Size = new System.Drawing.Size(83, 30);
            this.rbtnCancelar.TabIndex = 17;
            this.rbtnCancelar.TabStop = true;
            this.rbtnCancelar.Text = "Cancelar";
            this.rbtnCancelar.UseVisualStyleBackColor = true;
            // 
            // rbtnactivo
            // 
            this.rbtnactivo.AutoSize = true;
            this.rbtnactivo.Checked = true;
            this.rbtnactivo.Depth = 0;
            this.rbtnactivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtnactivo.Location = new System.Drawing.Point(10, 116);
            this.rbtnactivo.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnactivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnactivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnactivo.Name = "rbtnactivo";
            this.rbtnactivo.Ripple = true;
            this.rbtnactivo.Size = new System.Drawing.Size(68, 30);
            this.rbtnactivo.TabIndex = 16;
            this.rbtnactivo.TabStop = true;
            this.rbtnactivo.Text = "Activo";
            this.rbtnactivo.UseVisualStyleBackColor = true;
            // 
            // chkEditar
            // 
            this.chkEditar.AutoSize = true;
            this.chkEditar.Depth = 0;
            this.chkEditar.Enabled = false;
            this.chkEditar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkEditar.Location = new System.Drawing.Point(242, 116);
            this.chkEditar.Margin = new System.Windows.Forms.Padding(0);
            this.chkEditar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkEditar.Name = "chkEditar";
            this.chkEditar.Ripple = true;
            this.chkEditar.Size = new System.Drawing.Size(66, 30);
            this.chkEditar.TabIndex = 14;
            this.chkEditar.Text = "Editar";
            this.chkEditar.UseVisualStyleBackColor = true;
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Location = new System.Drawing.Point(10, 149);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(298, 139);
            this.gridControl1.TabIndex = 13;
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
            // txtasignatura
            // 
            this.txtasignatura.Depth = 0;
            this.txtasignatura.Hint = "Nombre Asignatura";
            this.txtasignatura.Location = new System.Drawing.Point(37, 78);
            this.txtasignatura.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtasignatura.Name = "txtasignatura";
            this.txtasignatura.PasswordChar = '\0';
            this.txtasignatura.SelectedText = "";
            this.txtasignatura.SelectionLength = 0;
            this.txtasignatura.SelectionStart = 0;
            this.txtasignatura.Size = new System.Drawing.Size(251, 23);
            this.txtasignatura.TabIndex = 12;
            this.txtasignatura.UseSystemPasswordChar = false;
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
            this.btncancelar.Location = new System.Drawing.Point(183, 334);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(103, 38);
            this.btncancelar.TabIndex = 37;
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
            this.btningresar.Location = new System.Drawing.Point(26, 334);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(103, 38);
            this.btningresar.TabIndex = 36;
            this.btningresar.Text = "Guardar";
            this.btningresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // Asignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(322, 375);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.rbtnCancelar);
            this.Controls.Add(this.rbtnactivo);
            this.Controls.Add(this.chkEditar);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtasignatura);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Asignaturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Asignaturas";
            this.Load += new System.EventHandler(this.Asignaturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRadioButton rbtnCancelar;
        private MaterialSkin.Controls.MaterialRadioButton rbtnactivo;
        private MaterialSkin.Controls.MaterialCheckBox chkEditar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtasignatura;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}