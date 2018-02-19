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
            this.components = new System.ComponentModel.Container();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btningresar = new System.Windows.Forms.Button();
            this.rbtncancelar = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnActivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.chkeditar = new MaterialSkin.Controls.MaterialCheckBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtObservacion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTurno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            this.btncancelar.Location = new System.Drawing.Point(170, 224);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(103, 38);
            this.btncancelar.TabIndex = 24;
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
            this.btningresar.Location = new System.Drawing.Point(13, 224);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(103, 38);
            this.btningresar.TabIndex = 23;
            this.btningresar.Text = "Guardar";
            this.btningresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click_1);
            // 
            // rbtncancelar
            // 
            this.rbtncancelar.AutoSize = true;
            this.rbtncancelar.Depth = 0;
            this.rbtncancelar.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtncancelar.Location = new System.Drawing.Point(170, 144);
            this.rbtncancelar.Margin = new System.Windows.Forms.Padding(0);
            this.rbtncancelar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtncancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtncancelar.Name = "rbtncancelar";
            this.rbtncancelar.Ripple = true;
            this.rbtncancelar.Size = new System.Drawing.Size(83, 30);
            this.rbtncancelar.TabIndex = 22;
            this.rbtncancelar.TabStop = true;
            this.rbtncancelar.Text = "Cancelar";
            this.rbtncancelar.UseVisualStyleBackColor = true;
            // 
            // rbtnActivo
            // 
            this.rbtnActivo.AutoSize = true;
            this.rbtnActivo.Depth = 0;
            this.rbtnActivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtnActivo.Location = new System.Drawing.Point(50, 144);
            this.rbtnActivo.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnActivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnActivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnActivo.Name = "rbtnActivo";
            this.rbtnActivo.Ripple = true;
            this.rbtnActivo.Size = new System.Drawing.Size(68, 30);
            this.rbtnActivo.TabIndex = 21;
            this.rbtnActivo.TabStop = true;
            this.rbtnActivo.Text = "Activo";
            this.rbtnActivo.UseVisualStyleBackColor = true;
            // 
            // chkeditar
            // 
            this.chkeditar.AutoSize = true;
            this.chkeditar.Depth = 0;
            this.chkeditar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkeditar.Location = new System.Drawing.Point(112, 174);
            this.chkeditar.Margin = new System.Windows.Forms.Padding(0);
            this.chkeditar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkeditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkeditar.Name = "chkeditar";
            this.chkeditar.Ripple = true;
            this.chkeditar.Size = new System.Drawing.Size(66, 30);
            this.chkeditar.TabIndex = 20;
            this.chkeditar.Text = "Editar";
            this.chkeditar.UseVisualStyleBackColor = true;
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Location = new System.Drawing.Point(12, 287);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(270, 146);
            this.gridControl1.TabIndex = 19;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick_1);
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
            // txtObservacion
            // 
            this.txtObservacion.Depth = 0;
            this.txtObservacion.Hint = "Observación";
            this.txtObservacion.Location = new System.Drawing.Point(50, 118);
            this.txtObservacion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.PasswordChar = '\0';
            this.txtObservacion.SelectedText = "";
            this.txtObservacion.SelectionLength = 0;
            this.txtObservacion.SelectionStart = 0;
            this.txtObservacion.Size = new System.Drawing.Size(214, 23);
            this.txtObservacion.TabIndex = 18;
            this.txtObservacion.UseSystemPasswordChar = false;
            // 
            // txtTurno
            // 
            this.txtTurno.Depth = 0;
            this.txtTurno.Hint = "Turno";
            this.txtTurno.Location = new System.Drawing.Point(50, 77);
            this.txtTurno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.PasswordChar = '\0';
            this.txtTurno.SelectedText = "";
            this.txtTurno.SelectionLength = 0;
            this.txtTurno.SelectionStart = 0;
            this.txtTurno.Size = new System.Drawing.Size(214, 23);
            this.txtTurno.TabIndex = 17;
            this.txtTurno.UseSystemPasswordChar = false;
            // 
            // Turnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 448);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.rbtncancelar);
            this.Controls.Add(this.rbtnActivo);
            this.Controls.Add(this.chkeditar);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.txtTurno);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Turnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turnos";
            this.Load += new System.EventHandler(this.Turnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btningresar;
        private MaterialSkin.Controls.MaterialRadioButton rbtncancelar;
        private MaterialSkin.Controls.MaterialRadioButton rbtnActivo;
        private MaterialSkin.Controls.MaterialCheckBox chkeditar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtObservacion;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTurno;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}