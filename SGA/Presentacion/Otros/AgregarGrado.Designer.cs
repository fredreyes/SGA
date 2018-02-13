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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnagregar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtxgrado = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarXLSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.chkmodificar = new MaterialSkin.Controls.MaterialCheckBox();
            this.chk1 = new MaterialSkin.Controls.MaterialCheckBox();
            this.chk2 = new MaterialSkin.Controls.MaterialCheckBox();
            this.chk3 = new MaterialSkin.Controls.MaterialCheckBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.chk3);
            this.groupBox1.Controls.Add(this.chk2);
            this.groupBox1.Controls.Add(this.chk1);
            this.groupBox1.Controls.Add(this.chkmodificar);
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Controls.Add(this.txtxgrado);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Location = new System.Drawing.Point(1, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 401);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnagregar
            // 
            this.btnagregar.Depth = 0;
            this.btnagregar.Location = new System.Drawing.Point(114, 188);
            this.btnagregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Primary = true;
            this.btnagregar.Size = new System.Drawing.Size(109, 33);
            this.btnagregar.TabIndex = 11;
            this.btnagregar.Text = "Guardar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtxgrado
            // 
            this.txtxgrado.Depth = 0;
            this.txtxgrado.Hint = "Grado";
            this.txtxgrado.Location = new System.Drawing.Point(46, 53);
            this.txtxgrado.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtxgrado.Name = "txtxgrado";
            this.txtxgrado.PasswordChar = '\0';
            this.txtxgrado.SelectedText = "";
            this.txtxgrado.SelectionLength = 0;
            this.txtxgrado.SelectionStart = 0;
            this.txtxgrado.Size = new System.Drawing.Size(226, 23);
            this.txtxgrado.TabIndex = 6;
            this.txtxgrado.UseSystemPasswordChar = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(328, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.exportarXLSToolStripMenuItem,
            this.exportarPDFToolStripMenuItem});
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
            // exportarXLSToolStripMenuItem
            // 
            this.exportarXLSToolStripMenuItem.Name = "exportarXLSToolStripMenuItem";
            this.exportarXLSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportarXLSToolStripMenuItem.Text = "Exportar XLS";
            // 
            // exportarPDFToolStripMenuItem
            // 
            this.exportarPDFToolStripMenuItem.Name = "exportarPDFToolStripMenuItem";
            this.exportarPDFToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exportarPDFToolStripMenuItem.Text = "Exportar PDF";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(11, 236);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(310, 150);
            this.gridControl1.TabIndex = 14;
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
            // chkmodificar
            // 
            this.chkmodificar.AutoSize = true;
            this.chkmodificar.Depth = 0;
            this.chkmodificar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkmodificar.Location = new System.Drawing.Point(229, 88);
            this.chkmodificar.Margin = new System.Windows.Forms.Padding(0);
            this.chkmodificar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkmodificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkmodificar.Name = "chkmodificar";
            this.chkmodificar.Ripple = true;
            this.chkmodificar.Size = new System.Drawing.Size(66, 30);
            this.chkmodificar.TabIndex = 15;
            this.chkmodificar.Text = "Editar";
            this.chkmodificar.UseVisualStyleBackColor = true;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Depth = 0;
            this.chk1.Font = new System.Drawing.Font("Roboto", 10F);
            this.chk1.Location = new System.Drawing.Point(46, 88);
            this.chk1.Margin = new System.Windows.Forms.Padding(0);
            this.chk1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chk1.MouseState = MaterialSkin.MouseState.HOVER;
            this.chk1.Name = "chk1";
            this.chk1.Ripple = true;
            this.chk1.Size = new System.Drawing.Size(101, 30);
            this.chk1.TabIndex = 16;
            this.chk1.Text = "Pre-Escolar";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Depth = 0;
            this.chk2.Font = new System.Drawing.Font("Roboto", 10F);
            this.chk2.Location = new System.Drawing.Point(46, 118);
            this.chk2.Margin = new System.Windows.Forms.Padding(0);
            this.chk2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chk2.MouseState = MaterialSkin.MouseState.HOVER;
            this.chk2.Name = "chk2";
            this.chk2.Ripple = true;
            this.chk2.Size = new System.Drawing.Size(82, 30);
            this.chk2.TabIndex = 17;
            this.chk2.Text = "Primaria";
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Depth = 0;
            this.chk3.Font = new System.Drawing.Font("Roboto", 10F);
            this.chk3.Location = new System.Drawing.Point(46, 155);
            this.chk3.Margin = new System.Windows.Forms.Padding(0);
            this.chk3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chk3.MouseState = MaterialSkin.MouseState.HOVER;
            this.chk3.Name = "chk3";
            this.chk3.Ripple = true;
            this.chk3.Size = new System.Drawing.Size(99, 30);
            this.chk3.TabIndex = 18;
            this.chk3.Text = "Secundaria";
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // AgregarGrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 462);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarGrado";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grados";
            this.Load += new System.EventHandler(this.AgregarGrado_Load);
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
        private MaterialSkin.Controls.MaterialRaisedButton btnagregar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtxgrado;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarXLSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarPDFToolStripMenuItem;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MaterialSkin.Controls.MaterialCheckBox chkmodificar;
        private MaterialSkin.Controls.MaterialCheckBox chk3;
        private MaterialSkin.Controls.MaterialCheckBox chk2;
        private MaterialSkin.Controls.MaterialCheckBox chk1;
    }
}