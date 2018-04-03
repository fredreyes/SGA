namespace Presentacion.Otros
{
    partial class AgregarAula
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
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LbxGrado = new System.Windows.Forms.ListBox();
            this.txtvacantes = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtcpacidad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtaula = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chkEditar = new MaterialSkin.Controls.MaterialCheckBox();
            this.rbrncancelar = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnactivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btningresar = new System.Windows.Forms.Button();
            this.cbmTurno = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Location = new System.Drawing.Point(167, 260);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(345, 172);
            this.gridControl1.TabIndex = 21;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 48);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Image = global::Presentacion.Properties.Resources.edit;
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Image = global::Presentacion.Properties.Resources.delete__1_;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // LbxGrado
            // 
            this.LbxGrado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbxGrado.FormattingEnabled = true;
            this.LbxGrado.ItemHeight = 15;
            this.LbxGrado.Location = new System.Drawing.Point(12, 260);
            this.LbxGrado.Name = "LbxGrado";
            this.LbxGrado.Size = new System.Drawing.Size(100, 169);
            this.LbxGrado.TabIndex = 20;
            // 
            // txtvacantes
            // 
            this.txtvacantes.Depth = 0;
            this.txtvacantes.Hint = "Vacantes Libres";
            this.txtvacantes.Location = new System.Drawing.Point(12, 165);
            this.txtvacantes.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtvacantes.Name = "txtvacantes";
            this.txtvacantes.PasswordChar = '\0';
            this.txtvacantes.SelectedText = "";
            this.txtvacantes.SelectionLength = 0;
            this.txtvacantes.SelectionStart = 0;
            this.txtvacantes.Size = new System.Drawing.Size(217, 23);
            this.txtvacantes.TabIndex = 17;
            this.txtvacantes.UseSystemPasswordChar = false;
            // 
            // txtcpacidad
            // 
            this.txtcpacidad.Depth = 0;
            this.txtcpacidad.Hint = "Capacidad";
            this.txtcpacidad.Location = new System.Drawing.Point(12, 121);
            this.txtcpacidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcpacidad.Name = "txtcpacidad";
            this.txtcpacidad.PasswordChar = '\0';
            this.txtcpacidad.SelectedText = "";
            this.txtcpacidad.SelectionLength = 0;
            this.txtcpacidad.SelectionStart = 0;
            this.txtcpacidad.Size = new System.Drawing.Size(217, 23);
            this.txtcpacidad.TabIndex = 16;
            this.txtcpacidad.UseSystemPasswordChar = false;
            this.txtcpacidad.TextChanged += new System.EventHandler(this.txtcpacidad_TextChanged);
            // 
            // txtaula
            // 
            this.txtaula.Depth = 0;
            this.txtaula.Hint = "Aula";
            this.txtaula.Location = new System.Drawing.Point(12, 80);
            this.txtaula.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtaula.Name = "txtaula";
            this.txtaula.PasswordChar = '\0';
            this.txtaula.SelectedText = "";
            this.txtaula.SelectionLength = 0;
            this.txtaula.SelectionStart = 0;
            this.txtaula.Size = new System.Drawing.Size(217, 23);
            this.txtaula.TabIndex = 15;
            this.txtaula.UseSystemPasswordChar = false;
            // 
            // chkEditar
            // 
            this.chkEditar.AutoSize = true;
            this.chkEditar.Depth = 0;
            this.chkEditar.Enabled = false;
            this.chkEditar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkEditar.Location = new System.Drawing.Point(413, 73);
            this.chkEditar.Margin = new System.Windows.Forms.Padding(0);
            this.chkEditar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkEditar.Name = "chkEditar";
            this.chkEditar.Ripple = true;
            this.chkEditar.Size = new System.Drawing.Size(66, 30);
            this.chkEditar.TabIndex = 46;
            this.chkEditar.Text = "Editar";
            this.chkEditar.UseVisualStyleBackColor = true;
            this.chkEditar.Visible = false;
            // 
            // rbrncancelar
            // 
            this.rbrncancelar.AutoSize = true;
            this.rbrncancelar.Depth = 0;
            this.rbrncancelar.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbrncancelar.Location = new System.Drawing.Point(268, 121);
            this.rbrncancelar.Margin = new System.Windows.Forms.Padding(0);
            this.rbrncancelar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbrncancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbrncancelar.Name = "rbrncancelar";
            this.rbrncancelar.Ripple = true;
            this.rbrncancelar.Size = new System.Drawing.Size(83, 30);
            this.rbrncancelar.TabIndex = 45;
            this.rbrncancelar.TabStop = true;
            this.rbrncancelar.Text = "Cancelar";
            this.rbrncancelar.UseVisualStyleBackColor = true;
            // 
            // rbtnactivo
            // 
            this.rbtnactivo.AutoSize = true;
            this.rbtnactivo.Depth = 0;
            this.rbtnactivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtnactivo.Location = new System.Drawing.Point(268, 80);
            this.rbtnactivo.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnactivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnactivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnactivo.Name = "rbtnactivo";
            this.rbtnactivo.Ripple = true;
            this.rbtnactivo.Size = new System.Drawing.Size(68, 30);
            this.rbtnactivo.TabIndex = 44;
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
            this.btncancelar.Location = new System.Drawing.Point(361, 165);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(103, 38);
            this.btncancelar.TabIndex = 43;
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
            this.btningresar.Location = new System.Drawing.Point(248, 165);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(103, 38);
            this.btningresar.TabIndex = 42;
            this.btningresar.Text = "Guardar";
            this.btningresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // cbmTurno
            // 
            this.cbmTurno.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmTurno.FormattingEnabled = true;
            this.cbmTurno.Location = new System.Drawing.Point(12, 204);
            this.cbmTurno.Name = "cbmTurno";
            this.cbmTurno.Size = new System.Drawing.Size(217, 24);
            this.cbmTurno.TabIndex = 47;
            // 
            // AgregarAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 444);
            this.Controls.Add(this.cbmTurno);
            this.Controls.Add(this.chkEditar);
            this.Controls.Add(this.rbrncancelar);
            this.Controls.Add(this.rbtnactivo);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.LbxGrado);
            this.Controls.Add(this.txtvacantes);
            this.Controls.Add(this.txtcpacidad);
            this.Controls.Add(this.txtaula);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarAula";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aulas";
            this.Load += new System.EventHandler(this.AgregarAula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ListBox LbxGrado;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtvacantes;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtcpacidad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtaula;
        private MaterialSkin.Controls.MaterialCheckBox chkEditar;
        private MaterialSkin.Controls.MaterialRadioButton rbrncancelar;
        private MaterialSkin.Controls.MaterialRadioButton rbtnactivo;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbmTurno;
    }
}