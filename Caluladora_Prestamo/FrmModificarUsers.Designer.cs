namespace Caluladora_Prestamo
{
    partial class FrmModificarUsers
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
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCelular = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Sitka Small", 13.8F);
            this.BtnLimpiar.Location = new System.Drawing.Point(611, 156);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(149, 62);
            this.BtnLimpiar.TabIndex = 35;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Sitka Small", 13.8F);
            this.BtnGuardar.Location = new System.Drawing.Point(611, 54);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(149, 62);
            this.BtnGuardar.TabIndex = 34;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Sitka Small", 13.8F);
            this.BtnSalir.Location = new System.Drawing.Point(611, 262);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(149, 62);
            this.BtnSalir.TabIndex = 33;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(170, 274);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(386, 141);
            this.TxtDireccion.TabIndex = 32;
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(170, 24);
            this.TxtNombres.Multiline = true;
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(386, 34);
            this.TxtNombres.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 35);
            this.label5.TabIndex = 31;
            this.label5.Text = "Direccio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 35);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nombres:";
            // 
            // TxtCelular
            // 
            this.TxtCelular.Location = new System.Drawing.Point(170, 207);
            this.TxtCelular.Multiline = true;
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(386, 34);
            this.TxtCelular.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 35);
            this.label2.TabIndex = 25;
            this.label2.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 35);
            this.label4.TabIndex = 29;
            this.label4.Text = "Celular:";
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(170, 84);
            this.TxtApellidos.Multiline = true;
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(386, 34);
            this.TxtApellidos.TabIndex = 26;
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(170, 146);
            this.TxtCedula.Multiline = true;
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(386, 34);
            this.TxtCedula.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 35);
            this.label3.TabIndex = 27;
            this.label3.Text = "Cedula:";
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Location = new System.Drawing.Point(-1, 438);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.RowTemplate.Height = 24;
            this.DgvUsuarios.Size = new System.Drawing.Size(789, 329);
            this.DgvUsuarios.TabIndex = 36;
            // 
            // FrmModificarUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 767);
            this.Controls.Add(this.DgvUsuarios);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtNombres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCelular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.label3);
            this.Name = "FrmModificarUsers";
            this.Text = "Modificar usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtCelular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvUsuarios;
    }
}