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
            this.txtaula = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtcpacidad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtvacantes = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chkconfirmar = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnguardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtaula
            // 
            this.txtaula.Depth = 0;
            this.txtaula.Hint = "Aula";
            this.txtaula.Location = new System.Drawing.Point(42, 97);
            this.txtaula.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtaula.Name = "txtaula";
            this.txtaula.PasswordChar = '\0';
            this.txtaula.SelectedText = "";
            this.txtaula.SelectionLength = 0;
            this.txtaula.SelectionStart = 0;
            this.txtaula.Size = new System.Drawing.Size(237, 23);
            this.txtaula.TabIndex = 0;
            this.txtaula.UseSystemPasswordChar = false;
            // 
            // txtcpacidad
            // 
            this.txtcpacidad.Depth = 0;
            this.txtcpacidad.Hint = "Capacidad";
            this.txtcpacidad.Location = new System.Drawing.Point(42, 155);
            this.txtcpacidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcpacidad.Name = "txtcpacidad";
            this.txtcpacidad.PasswordChar = '\0';
            this.txtcpacidad.SelectedText = "";
            this.txtcpacidad.SelectionLength = 0;
            this.txtcpacidad.SelectionStart = 0;
            this.txtcpacidad.Size = new System.Drawing.Size(237, 23);
            this.txtcpacidad.TabIndex = 1;
            this.txtcpacidad.UseSystemPasswordChar = false;
            this.txtcpacidad.TextChanged += new System.EventHandler(this.txtcpacidad_TextChanged);
            // 
            // txtvacantes
            // 
            this.txtvacantes.Depth = 0;
            this.txtvacantes.Hint = "Vacantes Libres";
            this.txtvacantes.Location = new System.Drawing.Point(42, 220);
            this.txtvacantes.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtvacantes.Name = "txtvacantes";
            this.txtvacantes.PasswordChar = '\0';
            this.txtvacantes.SelectedText = "";
            this.txtvacantes.SelectionLength = 0;
            this.txtvacantes.SelectionStart = 0;
            this.txtvacantes.Size = new System.Drawing.Size(237, 23);
            this.txtvacantes.TabIndex = 2;
            this.txtvacantes.UseSystemPasswordChar = false;
            // 
            // chkconfirmar
            // 
            this.chkconfirmar.AutoSize = true;
            this.chkconfirmar.Depth = 0;
            this.chkconfirmar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkconfirmar.Location = new System.Drawing.Point(112, 268);
            this.chkconfirmar.Margin = new System.Windows.Forms.Padding(0);
            this.chkconfirmar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkconfirmar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkconfirmar.Name = "chkconfirmar";
            this.chkconfirmar.Ripple = true;
            this.chkconfirmar.Size = new System.Drawing.Size(92, 30);
            this.chkconfirmar.TabIndex = 4;
            this.chkconfirmar.Text = "Confirmar";
            this.chkconfirmar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Depth = 0;
            this.btnguardar.Location = new System.Drawing.Point(112, 323);
            this.btnguardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Primary = true;
            this.btnguardar.Size = new System.Drawing.Size(89, 36);
            this.btnguardar.TabIndex = 5;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // AgregarAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 371);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.chkconfirmar);
            this.Controls.Add(this.txtvacantes);
            this.Controls.Add(this.txtcpacidad);
            this.Controls.Add(this.txtaula);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AgregarAula";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Aula";
            this.Load += new System.EventHandler(this.AgregarAula_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtaula;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtcpacidad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtvacantes;
        private MaterialSkin.Controls.MaterialCheckBox chkconfirmar;
        private MaterialSkin.Controls.MaterialRaisedButton btnguardar;
    }
}