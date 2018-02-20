namespace Presentacion.Otros
{
    partial class AgregarGrado
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
            this.chk3 = new MaterialSkin.Controls.MaterialCheckBox();
            this.chk2 = new MaterialSkin.Controls.MaterialCheckBox();
            this.chk1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkmodificar = new MaterialSkin.Controls.MaterialCheckBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtxgrado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.rbtnactivo = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtncancelar = new MaterialSkin.Controls.MaterialRadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            this.btncancelar.Location = new System.Drawing.Point(203, 240);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(103, 38);
            this.btncancelar.TabIndex = 35;
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
            this.btningresar.Location = new System.Drawing.Point(46, 240);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(103, 38);
            this.btningresar.TabIndex = 34;
            this.btningresar.Text = "Guardar";
            this.btningresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Depth = 0;
            this.chk3.Font = new System.Drawing.Font("Roboto", 10F);
            this.chk3.Location = new System.Drawing.Point(50, 203);
            this.chk3.Margin = new System.Windows.Forms.Padding(0);
            this.chk3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chk3.MouseState = MaterialSkin.MouseState.HOVER;
            this.chk3.Name = "chk3";
            this.chk3.Ripple = true;
            this.chk3.Size = new System.Drawing.Size(99, 30);
            this.chk3.TabIndex = 33;
            this.chk3.Text = "Secundaria";
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Depth = 0;
            this.chk2.Font = new System.Drawing.Font("Roboto", 10F);
            this.chk2.Location = new System.Drawing.Point(50, 166);
            this.chk2.Margin = new System.Windows.Forms.Padding(0);
            this.chk2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chk2.MouseState = MaterialSkin.MouseState.HOVER;
            this.chk2.Name = "chk2";
            this.chk2.Ripple = true;
            this.chk2.Size = new System.Drawing.Size(82, 30);
            this.chk2.TabIndex = 32;
            this.chk2.Text = "Primaria";
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Depth = 0;
            this.chk1.Font = new System.Drawing.Font("Roboto", 10F);
            this.chk1.Location = new System.Drawing.Point(50, 136);
            this.chk1.Margin = new System.Windows.Forms.Padding(0);
            this.chk1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chk1.MouseState = MaterialSkin.MouseState.HOVER;
            this.chk1.Name = "chk1";
            this.chk1.Ripple = true;
            this.chk1.Size = new System.Drawing.Size(101, 30);
            this.chk1.TabIndex = 31;
            this.chk1.Text = "Pre-Escolar";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // chkmodificar
            // 
            this.chkmodificar.AutoSize = true;
            this.chkmodificar.Depth = 0;
            this.chkmodificar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkmodificar.Location = new System.Drawing.Point(240, 112);
            this.chkmodificar.Margin = new System.Windows.Forms.Padding(0);
            this.chkmodificar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkmodificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkmodificar.Name = "chkmodificar";
            this.chkmodificar.Ripple = true;
            this.chkmodificar.Size = new System.Drawing.Size(66, 30);
            this.chkmodificar.TabIndex = 30;
            this.chkmodificar.Text = "Editar";
            this.chkmodificar.UseVisualStyleBackColor = true;
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Location = new System.Drawing.Point(21, 300);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(310, 150);
            this.gridControl1.TabIndex = 29;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick_1);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // txtxgrado
            // 
            this.txtxgrado.Depth = 0;
            this.txtxgrado.Hint = "Grado";
            this.txtxgrado.Location = new System.Drawing.Point(64, 86);
            this.txtxgrado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtxgrado.Name = "txtxgrado";
            this.txtxgrado.PasswordChar = '\0';
            this.txtxgrado.SelectedText = "";
            this.txtxgrado.SelectionLength = 0;
            this.txtxgrado.SelectionStart = 0;
            this.txtxgrado.Size = new System.Drawing.Size(226, 23);
            this.txtxgrado.TabIndex = 27;
            this.txtxgrado.UseSystemPasswordChar = false;
            // 
            // rbtnactivo
            // 
            this.rbtnactivo.AutoSize = true;
            this.rbtnactivo.Depth = 0;
            this.rbtnactivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtnactivo.Location = new System.Drawing.Point(222, 165);
            this.rbtnactivo.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnactivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnactivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnactivo.Name = "rbtnactivo";
            this.rbtnactivo.Ripple = true;
            this.rbtnactivo.Size = new System.Drawing.Size(68, 30);
            this.rbtnactivo.TabIndex = 36;
            this.rbtnactivo.TabStop = true;
            this.rbtnactivo.Text = "Activo";
            this.rbtnactivo.UseVisualStyleBackColor = true;
            // 
            // rbtncancelar
            // 
            this.rbtncancelar.AutoSize = true;
            this.rbtncancelar.Depth = 0;
            this.rbtncancelar.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtncancelar.Location = new System.Drawing.Point(222, 202);
            this.rbtncancelar.Margin = new System.Windows.Forms.Padding(0);
            this.rbtncancelar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtncancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtncancelar.Name = "rbtncancelar";
            this.rbtncancelar.Ripple = true;
            this.rbtncancelar.Size = new System.Drawing.Size(94, 30);
            this.rbtncancelar.TabIndex = 37;
            this.rbtncancelar.TabStop = true;
            this.rbtncancelar.Text = "Cancelado";
            this.rbtncancelar.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // AgregarGrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 462);
            this.Controls.Add(this.rbtncancelar);
            this.Controls.Add(this.rbtnactivo);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.chk3);
            this.Controls.Add(this.chk2);
            this.Controls.Add(this.chk1);
            this.Controls.Add(this.chkmodificar);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.txtxgrado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarGrado";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grados";
            this.Load += new System.EventHandler(this.AgregarGrado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btningresar;
        private MaterialSkin.Controls.MaterialCheckBox chk3;
        private MaterialSkin.Controls.MaterialCheckBox chk2;
        private MaterialSkin.Controls.MaterialCheckBox chk1;
        private MaterialSkin.Controls.MaterialCheckBox chkmodificar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtxgrado;
        private MaterialSkin.Controls.MaterialRadioButton rbtnactivo;
        private MaterialSkin.Controls.MaterialRadioButton rbtncancelar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
    }
}