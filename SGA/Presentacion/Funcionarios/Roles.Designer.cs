namespace Presentacion.Funcionarios
{
    partial class Roles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roles));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkcalificaciones = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkFuncionarios = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkadministrador = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkmatricula = new MaterialSkin.Controls.MaterialCheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btningresar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkcalificaciones);
            this.groupBox1.Controls.Add(this.chkFuncionarios);
            this.groupBox1.Controls.Add(this.chkadministrador);
            this.groupBox1.Controls.Add(this.chkmatricula);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permisos";
            // 
            // chkcalificaciones
            // 
            this.chkcalificaciones.AutoSize = true;
            this.chkcalificaciones.Depth = 0;
            this.chkcalificaciones.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkcalificaciones.Location = new System.Drawing.Point(422, 33);
            this.chkcalificaciones.Margin = new System.Windows.Forms.Padding(0);
            this.chkcalificaciones.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkcalificaciones.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkcalificaciones.Name = "chkcalificaciones";
            this.chkcalificaciones.Ripple = true;
            this.chkcalificaciones.Size = new System.Drawing.Size(117, 30);
            this.chkcalificaciones.TabIndex = 3;
            this.chkcalificaciones.Text = "Calificaciones";
            this.chkcalificaciones.UseVisualStyleBackColor = true;
            // 
            // chkFuncionarios
            // 
            this.chkFuncionarios.AutoSize = true;
            this.chkFuncionarios.Depth = 0;
            this.chkFuncionarios.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkFuncionarios.Location = new System.Drawing.Point(282, 33);
            this.chkFuncionarios.Margin = new System.Windows.Forms.Padding(0);
            this.chkFuncionarios.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkFuncionarios.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkFuncionarios.Name = "chkFuncionarios";
            this.chkFuncionarios.Ripple = true;
            this.chkFuncionarios.Size = new System.Drawing.Size(110, 30);
            this.chkFuncionarios.TabIndex = 2;
            this.chkFuncionarios.Text = "Funcionarios";
            this.chkFuncionarios.UseVisualStyleBackColor = true;
            // 
            // chkadministrador
            // 
            this.chkadministrador.AutoSize = true;
            this.chkadministrador.Depth = 0;
            this.chkadministrador.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkadministrador.Location = new System.Drawing.Point(139, 33);
            this.chkadministrador.Margin = new System.Windows.Forms.Padding(0);
            this.chkadministrador.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkadministrador.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkadministrador.Name = "chkadministrador";
            this.chkadministrador.Ripple = true;
            this.chkadministrador.Size = new System.Drawing.Size(124, 30);
            this.chkadministrador.TabIndex = 1;
            this.chkadministrador.Text = "Administración";
            this.chkadministrador.UseVisualStyleBackColor = true;
            // 
            // chkmatricula
            // 
            this.chkmatricula.AutoSize = true;
            this.chkmatricula.Depth = 0;
            this.chkmatricula.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkmatricula.Location = new System.Drawing.Point(17, 33);
            this.chkmatricula.Margin = new System.Windows.Forms.Padding(0);
            this.chkmatricula.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkmatricula.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkmatricula.Name = "chkmatricula";
            this.chkmatricula.Ripple = true;
            this.chkmatricula.Size = new System.Drawing.Size(88, 30);
            this.chkmatricula.TabIndex = 0;
            this.chkmatricula.Text = "Matricula";
            this.chkmatricula.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 166);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 134);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
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
            this.btningresar.Location = new System.Drawing.Point(151, 177);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(124, 39);
            this.btningresar.TabIndex = 49;
            this.btningresar.Text = "Guardar Rol";
            this.btningresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(301, 177);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(103, 38);
            this.btncancelar.TabIndex = 50;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 417);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Roles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Roles";
            this.Load += new System.EventHandler(this.Roles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialCheckBox chkcalificaciones;
        private MaterialSkin.Controls.MaterialCheckBox chkFuncionarios;
        private MaterialSkin.Controls.MaterialCheckBox chkadministrador;
        private MaterialSkin.Controls.MaterialCheckBox chkmatricula;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Button btncancelar;
    }
}