namespace Presentacion.Funcionarios
{
    partial class Funcionarios
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
            this.btnNuevoFuncionario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnexportar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 143);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(640, 281);
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
            // btnNuevoFuncionario
            // 
            this.btnNuevoFuncionario.Depth = 0;
            this.btnNuevoFuncionario.Location = new System.Drawing.Point(12, 82);
            this.btnNuevoFuncionario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNuevoFuncionario.Name = "btnNuevoFuncionario";
            this.btnNuevoFuncionario.Primary = true;
            this.btnNuevoFuncionario.Size = new System.Drawing.Size(156, 37);
            this.btnNuevoFuncionario.TabIndex = 1;
            this.btnNuevoFuncionario.Text = "Nuevo Funcionario";
            this.btnNuevoFuncionario.UseVisualStyleBackColor = true;
            this.btnNuevoFuncionario.Click += new System.EventHandler(this.btnNuevoFuncionario_Click);
            // 
            // btnexportar
            // 
            this.btnexportar.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexportar.Appearance.Options.UseFont = true;
            this.btnexportar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.btnexportar.ImageUri.Uri = "ExportToXLSX";
            this.btnexportar.Location = new System.Drawing.Point(545, 81);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(107, 37);
            this.btnexportar.TabIndex = 2;
            this.btnexportar.Text = "Exportar";
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 448);
            this.Controls.Add(this.btnexportar);
            this.Controls.Add(this.btnNuevoFuncionario);
            this.Controls.Add(this.gridControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Funcionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionarios";
            this.Load += new System.EventHandler(this.Funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private MaterialSkin.Controls.MaterialRaisedButton btnNuevoFuncionario;
        private DevExpress.XtraEditors.SimpleButton btnexportar;
    }
}