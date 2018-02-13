namespace Presentacion
{
    partial class frmPrincipal
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
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement10 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement11 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement8 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement9 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement2,
            this.accordionControlElement6});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.Size = new System.Drawing.Size(260, 526);
            this.accordionControl1.TabIndex = 0;
            this.accordionControl1.Text = "accordionControl1";
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement3,
            this.accordionControlElement4});
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "MATRICULAS";
            this.accordionControlElement1.Click += new System.EventHandler(this.accordionControlElement1_Click);
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement3.Text = "Nueva Matricula";
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement4.Text = "Ver Matriculas";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement10,
            this.accordionControlElement11});
            this.accordionControlElement2.Expanded = true;
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Text = "ESTUDIANTES";
            // 
            // accordionControlElement10
            // 
            this.accordionControlElement10.ImageOptions.Image = global::Presentacion.Properties.Resources.user;
            this.accordionControlElement10.Name = "accordionControlElement10";
            this.accordionControlElement10.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement10.Text = "Nuevo Estudiante";
            this.accordionControlElement10.Click += new System.EventHandler(this.accordionControlElement10_Click);
            // 
            // accordionControlElement11
            // 
            this.accordionControlElement11.ImageOptions.Image = global::Presentacion.Properties.Resources.student;
            this.accordionControlElement11.Name = "accordionControlElement11";
            this.accordionControlElement11.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement11.Text = "Ver Estudiantes";
            this.accordionControlElement11.Click += new System.EventHandler(this.accordionControlElement11_Click);
            // 
            // accordionControlElement6
            // 
            this.accordionControlElement6.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement7});
            this.accordionControlElement6.Name = "accordionControlElement6";
            this.accordionControlElement6.Text = "PANEL DE CONTROL";
            // 
            // accordionControlElement7
            // 
            this.accordionControlElement7.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement8,
            this.accordionControlElement9});
            this.accordionControlElement7.Name = "accordionControlElement7";
            this.accordionControlElement7.Text = "FUNCIONARIOS";
            // 
            // accordionControlElement8
            // 
            this.accordionControlElement8.Name = "accordionControlElement8";
            this.accordionControlElement8.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement8.Text = "Nuevo Funcionario";
            this.accordionControlElement8.Click += new System.EventHandler(this.accordionControlElement8_Click);
            // 
            // accordionControlElement9
            // 
            this.accordionControlElement9.Name = "accordionControlElement9";
            this.accordionControlElement9.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement9.Text = "Ver Funcionarios";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 526);
            this.Controls.Add(this.accordionControl1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colegio Buen Pastor";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement8;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement9;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement10;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement11;
    }
}