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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LbxGrado = new System.Windows.Forms.ListBox();
            this.btnguardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.chkconfirmar = new MaterialSkin.Controls.MaterialCheckBox();
            this.txtvacantes = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtcpacidad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtaula = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarXLSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarPDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Controls.Add(this.LbxGrado);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.chkconfirmar);
            this.groupBox1.Controls.Add(this.txtvacantes);
            this.groupBox1.Controls.Add(this.txtcpacidad);
            this.groupBox1.Controls.Add(this.txtaula);
            this.groupBox1.Location = new System.Drawing.Point(0, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(162, 187);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(330, 172);
            this.gridControl1.TabIndex = 14;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.LbxGrado.Location = new System.Drawing.Point(13, 185);
            this.LbxGrado.Name = "LbxGrado";
            this.LbxGrado.Size = new System.Drawing.Size(100, 169);
            this.LbxGrado.TabIndex = 13;
            // 
            // btnguardar
            // 
            this.btnguardar.Depth = 0;
            this.btnguardar.Location = new System.Drawing.Point(334, 125);
            this.btnguardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Primary = true;
            this.btnguardar.Size = new System.Drawing.Size(89, 36);
            this.btnguardar.TabIndex = 12;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // chkconfirmar
            // 
            this.chkconfirmar.AutoSize = true;
            this.chkconfirmar.Depth = 0;
            this.chkconfirmar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkconfirmar.Location = new System.Drawing.Point(334, 70);
            this.chkconfirmar.Margin = new System.Windows.Forms.Padding(0);
            this.chkconfirmar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkconfirmar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkconfirmar.Name = "chkconfirmar";
            this.chkconfirmar.Ripple = true;
            this.chkconfirmar.Size = new System.Drawing.Size(92, 30);
            this.chkconfirmar.TabIndex = 11;
            this.chkconfirmar.Text = "Confirmar";
            this.chkconfirmar.UseVisualStyleBackColor = true;
            // 
            // txtvacantes
            // 
            this.txtvacantes.Depth = 0;
            this.txtvacantes.Hint = "Vacantes Libres";
            this.txtvacantes.Location = new System.Drawing.Point(12, 155);
            this.txtvacantes.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtvacantes.Name = "txtvacantes";
            this.txtvacantes.PasswordChar = '\0';
            this.txtvacantes.SelectedText = "";
            this.txtvacantes.SelectionLength = 0;
            this.txtvacantes.SelectionStart = 0;
            this.txtvacantes.Size = new System.Drawing.Size(217, 23);
            this.txtvacantes.TabIndex = 10;
            this.txtvacantes.UseSystemPasswordChar = false;
            // 
            // txtcpacidad
            // 
            this.txtcpacidad.Depth = 0;
            this.txtcpacidad.Hint = "Capacidad";
            this.txtcpacidad.Location = new System.Drawing.Point(12, 111);
            this.txtcpacidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcpacidad.Name = "txtcpacidad";
            this.txtcpacidad.PasswordChar = '\0';
            this.txtcpacidad.SelectedText = "";
            this.txtcpacidad.SelectionLength = 0;
            this.txtcpacidad.SelectionStart = 0;
            this.txtcpacidad.Size = new System.Drawing.Size(217, 23);
            this.txtcpacidad.TabIndex = 9;
            this.txtcpacidad.UseSystemPasswordChar = false;
            // 
            // txtaula
            // 
            this.txtaula.Depth = 0;
            this.txtaula.Hint = "Aula";
            this.txtaula.Location = new System.Drawing.Point(12, 70);
            this.txtaula.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtaula.Name = "txtaula";
            this.txtaula.PasswordChar = '\0';
            this.txtaula.SelectedText = "";
            this.txtaula.SelectionLength = 0;
            this.txtaula.SelectionStart = 0;
            this.txtaula.Size = new System.Drawing.Size(217, 23);
            this.txtaula.TabIndex = 8;
            this.txtaula.UseSystemPasswordChar = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 16);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(512, 24);
            this.menuStrip1.TabIndex = 15;
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
            // AgregarAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 440);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarAula";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Aula";
            this.Load += new System.EventHandler(this.AgregarAula_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ListBox LbxGrado;
        private MaterialSkin.Controls.MaterialRaisedButton btnguardar;
        private MaterialSkin.Controls.MaterialCheckBox chkconfirmar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtvacantes;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtcpacidad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtaula;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarXLSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarPDFToolStripMenuItem;
    }
}