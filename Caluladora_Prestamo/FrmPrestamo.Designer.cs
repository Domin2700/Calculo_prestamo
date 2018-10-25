namespace Caluladora_Prestamo
{
    partial class FrmPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrestamo));
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCelular = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtCodigoPrestamo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtFechaPrestamo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ListDetalle = new System.Windows.Forms.ListView();
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbPagoXdia = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbMonto = new System.Windows.Forms.ComboBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.RdbSemanal = new System.Windows.Forms.RadioButton();
            this.RdbMensual = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(157, 84);
            this.TxtNombres.Multiline = true;
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.ReadOnly = true;
            this.TxtNombres.Size = new System.Drawing.Size(348, 34);
            this.TxtNombres.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos:";
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(157, 148);
            this.TxtApellidos.Multiline = true;
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.ReadOnly = true;
            this.TxtApellidos.Size = new System.Drawing.Size(348, 34);
            this.TxtApellidos.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cedula:";
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(157, 214);
            this.TxtCedula.Multiline = true;
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.ReadOnly = true;
            this.TxtCedula.Size = new System.Drawing.Size(348, 34);
            this.TxtCedula.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 35);
            this.label4.TabIndex = 6;
            this.label4.Text = "Celular:";
            // 
            // TxtCelular
            // 
            this.TxtCelular.Location = new System.Drawing.Point(157, 274);
            this.TxtCelular.Multiline = true;
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.ReadOnly = true;
            this.TxtCelular.Size = new System.Drawing.Size(348, 34);
            this.TxtCelular.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 35);
            this.label5.TabIndex = 8;
            this.label5.Text = "Direccio:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(157, 335);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.ReadOnly = true;
            this.TxtDireccion.Size = new System.Drawing.Size(348, 141);
            this.TxtDireccion.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtCodigo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TxtDireccion);
            this.groupBox1.Controls.Add(this.TxtNombres);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtCelular);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtApellidos);
            this.groupBox1.Controls.Add(this.TxtCedula);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(22, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 531);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(223, 26);
            this.TxtCodigo.Multiline = true;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.Size = new System.Drawing.Size(106, 34);
            this.TxtCodigo.TabIndex = 11;
            this.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 35);
            this.label12.TabIndex = 10;
            this.label12.Text = "Codigo Cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.TxtCodigoPrestamo);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.TxtFechaPrestamo);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.ListDetalle);
            this.groupBox2.Controls.Add(this.TxtMonto);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.CmbPagoXdia);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CmbMonto);
            this.groupBox2.Location = new System.Drawing.Point(568, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 637);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // TxtCodigoPrestamo
            // 
            this.TxtCodigoPrestamo.Location = new System.Drawing.Point(235, 299);
            this.TxtCodigoPrestamo.Multiline = true;
            this.TxtCodigoPrestamo.Name = "TxtCodigoPrestamo";
            this.TxtCodigoPrestamo.ReadOnly = true;
            this.TxtCodigoPrestamo.Size = new System.Drawing.Size(108, 35);
            this.TxtCodigoPrestamo.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 298);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(227, 35);
            this.label14.TabIndex = 10;
            this.label14.Text = "Codigo Prestamo:";
            // 
            // TxtFechaPrestamo
            // 
            this.TxtFechaPrestamo.Location = new System.Drawing.Point(218, 252);
            this.TxtFechaPrestamo.Multiline = true;
            this.TxtFechaPrestamo.Name = "TxtFechaPrestamo";
            this.TxtFechaPrestamo.ReadOnly = true;
            this.TxtFechaPrestamo.Size = new System.Drawing.Size(125, 35);
            this.TxtFechaPrestamo.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 252);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(215, 35);
            this.label13.TabIndex = 8;
            this.label13.Text = "Fecha Prestamo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(329, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "________________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 35);
            this.label8.TabIndex = 6;
            this.label8.Text = "Resumen Prestamo";
            // 
            // ListDetalle
            // 
            this.ListDetalle.Location = new System.Drawing.Point(6, 389);
            this.ListDetalle.Name = "ListDetalle";
            this.ListDetalle.Size = new System.Drawing.Size(351, 238);
            this.ListDetalle.TabIndex = 5;
            this.ListDetalle.UseCompatibleStateImageBehavior = false;
            // 
            // TxtMonto
            // 
            this.TxtMonto.Location = new System.Drawing.Point(203, 155);
            this.TxtMonto.Multiline = true;
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.ReadOnly = true;
            this.TxtMonto.Size = new System.Drawing.Size(140, 35);
            this.TxtMonto.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 35);
            this.label9.TabIndex = 5;
            this.label9.Text = "No. de cuotas:";
            // 
            // CmbPagoXdia
            // 
            this.CmbPagoXdia.FormattingEnabled = true;
            this.CmbPagoXdia.Location = new System.Drawing.Point(235, 214);
            this.CmbPagoXdia.Name = "CmbPagoXdia";
            this.CmbPagoXdia.Size = new System.Drawing.Size(108, 24);
            this.CmbPagoXdia.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 35);
            this.label7.TabIndex = 3;
            this.label7.Text = "Pago por dia RD$:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 35);
            this.label6.TabIndex = 2;
            this.label6.Text = "Monto RD$:";
            // 
            // CmbMonto
            // 
            this.CmbMonto.FormattingEnabled = true;
            this.CmbMonto.Location = new System.Drawing.Point(175, 112);
            this.CmbMonto.Name = "CmbMonto";
            this.CmbMonto.Size = new System.Drawing.Size(168, 24);
            this.CmbMonto.TabIndex = 0;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Sitka Small", 13.8F);
            this.BtnSalir.Location = new System.Drawing.Point(19, 674);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(149, 62);
            this.BtnSalir.TabIndex = 13;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Sitka Small", 13.8F);
            this.BtnGuardar.Location = new System.Drawing.Point(202, 674);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(149, 62);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Sitka Small", 13.8F);
            this.BtnCalcular.Location = new System.Drawing.Point(387, 674);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(149, 62);
            this.BtnCalcular.TabIndex = 16;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            // 
            // BtnCliente
            // 
            this.BtnCliente.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnCliente.Image")));
            this.BtnCliente.Location = new System.Drawing.Point(22, 12);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(145, 91);
            this.BtnCliente.TabIndex = 17;
            this.BtnCliente.Text = "Listar clientes";
            this.BtnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnCliente.UseVisualStyleBackColor = true;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(823, 67);
            this.TxtBuscar.Multiline = true;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(88, 36);
            this.TxtBuscar.TabIndex = 46;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(493, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(331, 35);
            this.label16.TabIndex = 45;
            this.label16.Text = "Buscar cliente por codigo:";
            // 
            // RdbSemanal
            // 
            this.RdbSemanal.AutoSize = true;
            this.RdbSemanal.Font = new System.Drawing.Font("Sitka Small", 10.2F);
            this.RdbSemanal.Location = new System.Drawing.Point(45, 12);
            this.RdbSemanal.Name = "RdbSemanal";
            this.RdbSemanal.Size = new System.Drawing.Size(106, 29);
            this.RdbSemanal.TabIndex = 1;
            this.RdbSemanal.TabStop = true;
            this.RdbSemanal.Text = "Semanal";
            this.RdbSemanal.UseVisualStyleBackColor = true;
            // 
            // RdbMensual
            // 
            this.RdbMensual.AutoSize = true;
            this.RdbMensual.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbMensual.Location = new System.Drawing.Point(170, 12);
            this.RdbMensual.Name = "RdbMensual";
            this.RdbMensual.Size = new System.Drawing.Size(107, 29);
            this.RdbMensual.TabIndex = 0;
            this.RdbMensual.TabStop = true;
            this.RdbMensual.Text = "Mensual";
            this.RdbMensual.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(70, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(226, 35);
            this.label11.TabIndex = 24;
            this.label11.Text = "Tipo de prestamo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RdbSemanal);
            this.groupBox3.Controls.Add(this.RdbMensual);
            this.groupBox3.Location = new System.Drawing.Point(18, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 47);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // FrmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 748);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.BtnCliente);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPrestamo";
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.FrmPrestamo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCelular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView ListDetalle;
        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CmbPagoXdia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbMonto;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtFechaPrestamo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtCodigoPrestamo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton RdbMensual;
        private System.Windows.Forms.RadioButton RdbSemanal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
    }
}