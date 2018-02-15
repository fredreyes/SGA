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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtcolegio = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbmDepartmento = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.chkeditar = new MaterialSkin.Controls.MaterialCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(27, 230);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(341, 162);
            this.gridControl1.TabIndex = 0;
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
            this.cbmDepartmento.Location = new System.Drawing.Point(54, 117);
            this.cbmDepartmento.Name = "cbmDepartmento";
            this.cbmDepartmento.Size = new System.Drawing.Size(279, 23);
            this.cbmDepartmento.TabIndex = 2;
            this.cbmDepartmento.Text = "Seleccione un Departamento";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(148, 193);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = true;
            this.btnGuardar.Size = new System.Drawing.Size(86, 31);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // chkeditar
            // 
            this.chkeditar.AutoSize = true;
            this.chkeditar.Depth = 0;
            this.chkeditar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkeditar.Location = new System.Drawing.Point(267, 155);
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
            // Colegios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 404);
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
    }
}