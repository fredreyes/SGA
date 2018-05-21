namespace Presentacion.Matricula
{
    partial class BoletaMatricula
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BoletaMatriculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosBoletaMatricula = new Presentacion.Matricula.DatosBoletaMatricula();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BoletaMatriculaTableAdapter = new Presentacion.Matricula.DatosBoletaMatriculaTableAdapters.BoletaMatriculaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BoletaMatriculaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosBoletaMatricula)).BeginInit();
            this.SuspendLayout();
            // 
            // BoletaMatriculaBindingSource
            // 
            this.BoletaMatriculaBindingSource.DataMember = "BoletaMatricula";
            this.BoletaMatriculaBindingSource.DataSource = this.DatosBoletaMatricula;
            // 
            // DatosBoletaMatricula
            // 
            this.DatosBoletaMatricula.DataSetName = "DatosBoletaMatricula";
            this.DatosBoletaMatricula.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DatosMatricula";
            reportDataSource1.Value = this.BoletaMatriculaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.Matricula.BoletadeMatricula.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(806, 354);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // BoletaMatriculaTableAdapter
            // 
            this.BoletaMatriculaTableAdapter.ClearBeforeFill = true;
            // 
            // BoletaMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 354);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BoletaMatricula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boleta Matricula";
            this.Load += new System.EventHandler(this.BoletaMatricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BoletaMatriculaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosBoletaMatricula)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BoletaMatriculaBindingSource;
        private DatosBoletaMatricula DatosBoletaMatricula;
        private DatosBoletaMatriculaTableAdapters.BoletaMatriculaTableAdapter BoletaMatriculaTableAdapter;
    }
}