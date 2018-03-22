namespace Presentacion.Notas
{
    partial class CargaDocente
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
            this.GrupoPrimaria = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnSecundaria = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnPrimaria = new MaterialSkin.Controls.MaterialRadioButton();
            this.GrupoSencudaria = new System.Windows.Forms.GroupBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btningresar = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbmGrados = new System.Windows.Forms.ComboBox();
            this.cbmAnio = new System.Windows.Forms.ComboBox();
            this.GrupoPrimaria.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.GrupoSencudaria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrupoPrimaria
            // 
            this.GrupoPrimaria.Controls.Add(this.cbmGrados);
            this.GrupoPrimaria.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoPrimaria.Location = new System.Drawing.Point(12, 133);
            this.GrupoPrimaria.Name = "GrupoPrimaria";
            this.GrupoPrimaria.Size = new System.Drawing.Size(252, 93);
            this.GrupoPrimaria.TabIndex = 1;
            this.GrupoPrimaria.TabStop = false;
            this.GrupoPrimaria.Text = "Grados";
            this.GrupoPrimaria.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(270, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(169, 164);
            this.listBox1.TabIndex = 2;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnSecundaria);
            this.groupBox3.Controls.Add(this.rbtnPrimaria);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agrupar Por:";
            // 
            // rbtnSecundaria
            // 
            this.rbtnSecundaria.AutoSize = true;
            this.rbtnSecundaria.Depth = 0;
            this.rbtnSecundaria.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtnSecundaria.Location = new System.Drawing.Point(15, 61);
            this.rbtnSecundaria.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnSecundaria.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnSecundaria.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnSecundaria.Name = "rbtnSecundaria";
            this.rbtnSecundaria.Ripple = true;
            this.rbtnSecundaria.Size = new System.Drawing.Size(98, 30);
            this.rbtnSecundaria.TabIndex = 1;
            this.rbtnSecundaria.TabStop = true;
            this.rbtnSecundaria.Text = "Secundaria";
            this.rbtnSecundaria.UseVisualStyleBackColor = true;
            this.rbtnSecundaria.CheckedChanged += new System.EventHandler(this.materialRadioButton2_CheckedChanged);
            // 
            // rbtnPrimaria
            // 
            this.rbtnPrimaria.AutoSize = true;
            this.rbtnPrimaria.Depth = 0;
            this.rbtnPrimaria.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtnPrimaria.Location = new System.Drawing.Point(15, 26);
            this.rbtnPrimaria.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnPrimaria.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnPrimaria.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnPrimaria.Name = "rbtnPrimaria";
            this.rbtnPrimaria.Ripple = true;
            this.rbtnPrimaria.Size = new System.Drawing.Size(81, 30);
            this.rbtnPrimaria.TabIndex = 0;
            this.rbtnPrimaria.TabStop = true;
            this.rbtnPrimaria.Text = "Primaria";
            this.rbtnPrimaria.UseVisualStyleBackColor = true;
            this.rbtnPrimaria.CheckedChanged += new System.EventHandler(this.rbtnPrimaria_CheckedChanged);
            // 
            // GrupoSencudaria
            // 
            this.GrupoSencudaria.Controls.Add(this.cbmAnio);
            this.GrupoSencudaria.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoSencudaria.Location = new System.Drawing.Point(13, 242);
            this.GrupoSencudaria.Name = "GrupoSencudaria";
            this.GrupoSencudaria.Size = new System.Drawing.Size(251, 95);
            this.GrupoSencudaria.TabIndex = 5;
            this.GrupoSencudaria.TabStop = false;
            this.GrupoSencudaria.Text = "Años";
            this.GrupoSencudaria.Visible = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(286, 13);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(112, 19);
            this.materialLabel1.TabIndex = 7;
            this.materialLabel1.Text = "Lista de Clases";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(480, 9);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(149, 19);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Docentes por Clases";
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(464, 35);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(169, 164);
            this.listBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(652, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(687, 9);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(99, 19);
            this.materialLabel3.TabIndex = 11;
            this.materialLabel3.Text = "Ciclo Escolar";
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
            this.btningresar.Location = new System.Drawing.Point(676, 104);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(110, 39);
            this.btningresar.TabIndex = 47;
            this.btningresar.Text = "Asignar";
            this.btningresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(502, 224);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(306, 262);
            this.gridControl1.TabIndex = 48;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // cbmGrados
            // 
            this.cbmGrados.FormattingEnabled = true;
            this.cbmGrados.Location = new System.Drawing.Point(15, 36);
            this.cbmGrados.Name = "cbmGrados";
            this.cbmGrados.Size = new System.Drawing.Size(231, 26);
            this.cbmGrados.TabIndex = 49;
            this.cbmGrados.SelectedIndexChanged += new System.EventHandler(this.cbmGrados_SelectedIndexChanged);
            this.cbmGrados.SelectedValueChanged += new System.EventHandler(this.cbmGrados_SelectedValueChanged);
            this.cbmGrados.TextChanged += new System.EventHandler(this.cbmGrados_TextChanged);
            // 
            // cbmAnio
            // 
            this.cbmAnio.FormattingEnabled = true;
            this.cbmAnio.Location = new System.Drawing.Point(14, 38);
            this.cbmAnio.Name = "cbmAnio";
            this.cbmAnio.Size = new System.Drawing.Size(231, 26);
            this.cbmAnio.TabIndex = 50;
            // 
            // CargaDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 504);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.GrupoSencudaria);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.GrupoPrimaria);
            this.Name = "CargaDocente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CargaDocente";
            this.Load += new System.EventHandler(this.CargaDocente_Load);
            this.GrupoPrimaria.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.GrupoSencudaria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GrupoPrimaria;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialRadioButton rbtnSecundaria;
        private MaterialSkin.Controls.MaterialRadioButton rbtnPrimaria;
        private System.Windows.Forms.GroupBox GrupoSencudaria;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Button btningresar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ComboBox cbmGrados;
        private System.Windows.Forms.ComboBox cbmAnio;
    }
}