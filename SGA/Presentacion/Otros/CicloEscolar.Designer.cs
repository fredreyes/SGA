namespace Presentacion.Otros
{
    partial class CicloEscolar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkEditar = new MaterialSkin.Controls.MaterialCheckBox();
            this.rbrncancelar = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnactivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btningresar = new System.Windows.Forms.Button();
            this.datefin = new DevExpress.XtraEditors.DateEdit();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dateinicio = new DevExpress.XtraEditors.DateEdit();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtciclo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datefin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datefin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateinicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateinicio.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkEditar);
            this.groupBox1.Controls.Add(this.rbrncancelar);
            this.groupBox1.Controls.Add(this.rbtnactivo);
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.btningresar);
            this.groupBox1.Controls.Add(this.datefin);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.dateinicio);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.txtciclo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ciclos";
            // 
            // chkEditar
            // 
            this.chkEditar.AutoSize = true;
            this.chkEditar.Depth = 0;
            this.chkEditar.Enabled = false;
            this.chkEditar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkEditar.Location = new System.Drawing.Point(231, 9);
            this.chkEditar.Margin = new System.Windows.Forms.Padding(0);
            this.chkEditar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkEditar.Name = "chkEditar";
            this.chkEditar.Ripple = true;
            this.chkEditar.Size = new System.Drawing.Size(66, 30);
            this.chkEditar.TabIndex = 41;
            this.chkEditar.Text = "Editar";
            this.chkEditar.UseVisualStyleBackColor = true;
            // 
            // rbrncancelar
            // 
            this.rbrncancelar.AutoSize = true;
            this.rbrncancelar.Depth = 0;
            this.rbrncancelar.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbrncancelar.Location = new System.Drawing.Point(110, 158);
            this.rbrncancelar.Margin = new System.Windows.Forms.Padding(0);
            this.rbrncancelar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbrncancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbrncancelar.Name = "rbrncancelar";
            this.rbrncancelar.Ripple = true;
            this.rbrncancelar.Size = new System.Drawing.Size(83, 30);
            this.rbrncancelar.TabIndex = 40;
            this.rbrncancelar.TabStop = true;
            this.rbrncancelar.Text = "Cancelar";
            this.rbrncancelar.UseVisualStyleBackColor = true;
            // 
            // rbtnactivo
            // 
            this.rbtnactivo.AutoSize = true;
            this.rbtnactivo.Depth = 0;
            this.rbtnactivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtnactivo.Location = new System.Drawing.Point(26, 157);
            this.rbtnactivo.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnactivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnactivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnactivo.Name = "rbtnactivo";
            this.rbtnactivo.Ripple = true;
            this.rbtnactivo.Size = new System.Drawing.Size(68, 30);
            this.rbtnactivo.TabIndex = 39;
            this.rbtnactivo.TabStop = true;
            this.rbtnactivo.Text = "Activo";
            this.rbtnactivo.UseVisualStyleBackColor = true;
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
            this.btncancelar.Location = new System.Drawing.Point(211, 109);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(103, 38);
            this.btncancelar.TabIndex = 38;
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
            this.btningresar.Location = new System.Drawing.Point(211, 51);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(103, 38);
            this.btningresar.TabIndex = 37;
            this.btningresar.Text = "Guardar";
            this.btningresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // datefin
            // 
            this.datefin.EditValue = null;
            this.datefin.Location = new System.Drawing.Point(26, 132);
            this.datefin.Name = "datefin";
            this.datefin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datefin.Properties.Appearance.Options.UseFont = true;
            this.datefin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datefin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datefin.Size = new System.Drawing.Size(167, 22);
            this.datefin.TabIndex = 4;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(26, 109);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(73, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Fecha Fin";
            // 
            // dateinicio
            // 
            this.dateinicio.EditValue = null;
            this.dateinicio.Location = new System.Drawing.Point(26, 84);
            this.dateinicio.Name = "dateinicio";
            this.dateinicio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateinicio.Properties.Appearance.Options.UseFont = true;
            this.dateinicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateinicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateinicio.Size = new System.Drawing.Size(167, 22);
            this.dateinicio.TabIndex = 2;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(26, 61);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(90, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Fecha Inicio";
            // 
            // txtciclo
            // 
            this.txtciclo.Depth = 0;
            this.txtciclo.Hint = "2018";
            this.txtciclo.Location = new System.Drawing.Point(26, 31);
            this.txtciclo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtciclo.Name = "txtciclo";
            this.txtciclo.PasswordChar = '\0';
            this.txtciclo.SelectedText = "";
            this.txtciclo.SelectionLength = 0;
            this.txtciclo.SelectionStart = 0;
            this.txtciclo.Size = new System.Drawing.Size(167, 23);
            this.txtciclo.TabIndex = 0;
            this.txtciclo.UseSystemPasswordChar = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridControl1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 152);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registros";
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 18);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(315, 131);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // CicloEscolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 432);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CicloEscolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ciclo Escolar";
            this.Load += new System.EventHandler(this.CicloEscolar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datefin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datefin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateinicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateinicio.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateEdit datefin;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private DevExpress.XtraEditors.DateEdit dateinicio;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtciclo;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Button btncancelar;
        private MaterialSkin.Controls.MaterialRadioButton rbrncancelar;
        private MaterialSkin.Controls.MaterialRadioButton rbtnactivo;
        private MaterialSkin.Controls.MaterialCheckBox chkEditar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}