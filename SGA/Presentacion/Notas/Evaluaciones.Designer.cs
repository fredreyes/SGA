namespace Presentacion.Notas
{
    partial class Evaluaciones
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.calendarControl1 = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.txtobservaciones = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbmciclo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Primer Parcial",
            "Segundo Parcial",
            "Tercer Parcial",
            "Cuarto Parcial"});
            this.listBox1.Location = new System.Drawing.Point(280, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(110, 84);
            this.listBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(329, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 148);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MES";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PARCIAL";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "OBSERVACION";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CICLO";
            this.Column4.Name = "Column4";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageUri.Uri = "SortAsc";
            this.simpleButton1.Location = new System.Drawing.Point(426, 136);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(96, 36);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Agregar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // calendarControl1
            // 
            this.calendarControl1.AllowAnimatedContentChange = true;
            this.calendarControl1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarControl1.Location = new System.Drawing.Point(12, 83);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.Size = new System.Drawing.Size(262, 227);
            this.calendarControl1.TabIndex = 5;
            // 
            // txtobservaciones
            // 
            this.txtobservaciones.Depth = 0;
            this.txtobservaciones.Hint = "Observaciones";
            this.txtobservaciones.Location = new System.Drawing.Point(426, 107);
            this.txtobservaciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtobservaciones.Name = "txtobservaciones";
            this.txtobservaciones.PasswordChar = '\0';
            this.txtobservaciones.SelectedText = "";
            this.txtobservaciones.SelectionLength = 0;
            this.txtobservaciones.SelectionStart = 0;
            this.txtobservaciones.Size = new System.Drawing.Size(255, 23);
            this.txtobservaciones.TabIndex = 6;
            this.txtobservaciones.UseSystemPasswordChar = false;
            // 
            // cbmciclo
            // 
            this.cbmciclo.FormattingEnabled = true;
            this.cbmciclo.Items.AddRange(new object[] {
            "Ciclo 2018"});
            this.cbmciclo.Location = new System.Drawing.Point(426, 72);
            this.cbmciclo.Name = "cbmciclo";
            this.cbmciclo.Size = new System.Drawing.Size(121, 21);
            this.cbmciclo.TabIndex = 7;
            // 
            // Evaluaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 338);
            this.Controls.Add(this.cbmciclo);
            this.Controls.Add(this.txtobservaciones);
            this.Controls.Add(this.calendarControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Name = "Evaluaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluaciones";
            this.Load += new System.EventHandler(this.Evaluaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.Controls.CalendarControl calendarControl1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtobservaciones;
        private System.Windows.Forms.ComboBox cbmciclo;
    }
}