﻿namespace Presentacion.Funcionarios
{
    partial class Users
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
            this.txtusuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtcontrasenia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbmRol = new System.Windows.Forms.ComboBox();
            this.txtFuncionario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btningresar = new System.Windows.Forms.Button();
            this.chkEditar = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkactivo = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkCancelado = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            this.txtusuario.Depth = 0;
            this.txtusuario.Hint = "Usuario";
            this.txtusuario.Location = new System.Drawing.Point(40, 194);
            this.txtusuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PasswordChar = '\0';
            this.txtusuario.SelectedText = "";
            this.txtusuario.SelectionLength = 0;
            this.txtusuario.SelectionStart = 0;
            this.txtusuario.Size = new System.Drawing.Size(255, 23);
            this.txtusuario.TabIndex = 0;
            this.txtusuario.UseSystemPasswordChar = false;
            // 
            // txtcontrasenia
            // 
            this.txtcontrasenia.Depth = 0;
            this.txtcontrasenia.Hint = "Contraseña";
            this.txtcontrasenia.Location = new System.Drawing.Point(40, 235);
            this.txtcontrasenia.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcontrasenia.Name = "txtcontrasenia";
            this.txtcontrasenia.PasswordChar = '*';
            this.txtcontrasenia.SelectedText = "";
            this.txtcontrasenia.SelectionLength = 0;
            this.txtcontrasenia.SelectionStart = 0;
            this.txtcontrasenia.Size = new System.Drawing.Size(255, 23);
            this.txtcontrasenia.TabIndex = 1;
            this.txtcontrasenia.UseSystemPasswordChar = false;
            // 
            // cbmRol
            // 
            this.cbmRol.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmRol.FormattingEnabled = true;
            this.cbmRol.Location = new System.Drawing.Point(40, 283);
            this.cbmRol.Name = "cbmRol";
            this.cbmRol.Size = new System.Drawing.Size(255, 24);
            this.cbmRol.TabIndex = 8;
            this.cbmRol.Text = "Seleccione un Rol";
            // 
            // txtFuncionario
            // 
            this.txtFuncionario.Depth = 0;
            this.txtFuncionario.Hint = "Usuario";
            this.txtFuncionario.Location = new System.Drawing.Point(40, 148);
            this.txtFuncionario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.PasswordChar = '\0';
            this.txtFuncionario.SelectedText = "";
            this.txtFuncionario.SelectionLength = 0;
            this.txtFuncionario.SelectionStart = 0;
            this.txtFuncionario.Size = new System.Drawing.Size(255, 23);
            this.txtFuncionario.TabIndex = 9;
            this.txtFuncionario.UseSystemPasswordChar = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(22, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "Ver Usuarios";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Image = global::Presentacion.Properties.Resources.delete;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.Location = new System.Drawing.Point(192, 364);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(103, 38);
            this.btncancelar.TabIndex = 7;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.UseVisualStyleBackColor = false;
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
            this.btningresar.Location = new System.Drawing.Point(40, 364);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(103, 38);
            this.btningresar.TabIndex = 6;
            this.btningresar.Text = "Guardar";
            this.btningresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // chkEditar
            // 
            this.chkEditar.AutoSize = true;
            this.chkEditar.Depth = 0;
            this.chkEditar.Enabled = false;
            this.chkEditar.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkEditar.Location = new System.Drawing.Point(261, 75);
            this.chkEditar.Margin = new System.Windows.Forms.Padding(0);
            this.chkEditar.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkEditar.Name = "chkEditar";
            this.chkEditar.Ripple = true;
            this.chkEditar.Size = new System.Drawing.Size(66, 30);
            this.chkEditar.TabIndex = 12;
            this.chkEditar.Text = "Editar";
            this.chkEditar.UseVisualStyleBackColor = true;
            // 
            // chkactivo
            // 
            this.chkactivo.AutoSize = true;
            this.chkactivo.Depth = 0;
            this.chkactivo.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkactivo.Location = new System.Drawing.Point(61, 320);
            this.chkactivo.Margin = new System.Windows.Forms.Padding(0);
            this.chkactivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkactivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkactivo.Name = "chkactivo";
            this.chkactivo.Ripple = true;
            this.chkactivo.Size = new System.Drawing.Size(69, 30);
            this.chkactivo.TabIndex = 13;
            this.chkactivo.Text = "Activo";
            this.chkactivo.UseVisualStyleBackColor = true;
            // 
            // chkCancelado
            // 
            this.chkCancelado.AutoSize = true;
            this.chkCancelado.Depth = 0;
            this.chkCancelado.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkCancelado.Location = new System.Drawing.Point(181, 320);
            this.chkCancelado.Margin = new System.Windows.Forms.Padding(0);
            this.chkCancelado.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkCancelado.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkCancelado.Name = "chkCancelado";
            this.chkCancelado.Ripple = true;
            this.chkCancelado.Size = new System.Drawing.Size(95, 30);
            this.chkCancelado.TabIndex = 14;
            this.chkCancelado.Text = "Cancelado";
            this.chkCancelado.UseVisualStyleBackColor = true;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 414);
            this.Controls.Add(this.chkCancelado);
            this.Controls.Add(this.chkactivo);
            this.Controls.Add(this.chkEditar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.cbmRol);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtcontrasenia);
            this.Controls.Add(this.txtusuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtusuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtcontrasenia;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.ComboBox cbmRol;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFuncionario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private MaterialSkin.Controls.MaterialCheckBox chkEditar;
        private MaterialSkin.Controls.MaterialCheckBox chkactivo;
        private MaterialSkin.Controls.MaterialCheckBox chkCancelado;
    }
}