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
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1);
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
            this.BtnCliente = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CmbNoCuota = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RdbDiario = new System.Windows.Forms.RadioButton();
            this.RdbMensual = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtFechaPrestamo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ListDetalle = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.CmbPagoXdia = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmbMonto = new System.Windows.Forms.ComboBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.TxtBuscar = new textBoxAutoexplicativo.txtAutoexplicativo();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtNombres
            // 
            this.TxtNombres.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNombres.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.TxtNombres.Location = new System.Drawing.Point(26, 125);
            this.TxtNombres.Multiline = true;
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.ReadOnly = true;
            this.TxtNombres.Size = new System.Drawing.Size(342, 50);
            this.TxtNombres.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label1.Location = new System.Drawing.Point(7, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label2.Location = new System.Drawing.Point(7, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellidos:";
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.BackColor = System.Drawing.SystemColors.Window;
            this.TxtApellidos.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.TxtApellidos.Location = new System.Drawing.Point(26, 229);
            this.TxtApellidos.Multiline = true;
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.ReadOnly = true;
            this.TxtApellidos.Size = new System.Drawing.Size(342, 50);
            this.TxtApellidos.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label3.Location = new System.Drawing.Point(7, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cedula:";
            // 
            // TxtCedula
            // 
            this.TxtCedula.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCedula.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.TxtCedula.Location = new System.Drawing.Point(26, 318);
            this.TxtCedula.Multiline = true;
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.ReadOnly = true;
            this.TxtCedula.Size = new System.Drawing.Size(342, 50);
            this.TxtCedula.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label4.Location = new System.Drawing.Point(7, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Celular:";
            // 
            // TxtCelular
            // 
            this.TxtCelular.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCelular.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.TxtCelular.Location = new System.Drawing.Point(23, 417);
            this.TxtCelular.Multiline = true;
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.ReadOnly = true;
            this.TxtCelular.Size = new System.Drawing.Size(342, 50);
            this.TxtCelular.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label5.Location = new System.Drawing.Point(13, 495);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Direccio:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BackColor = System.Drawing.SystemColors.Window;
            this.TxtDireccion.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.TxtDireccion.Location = new System.Drawing.Point(26, 515);
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.ReadOnly = true;
            this.TxtDireccion.Size = new System.Drawing.Size(342, 212);
            this.TxtDireccion.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtCodigo);
            this.groupBox1.Controls.Add(this.BtnCliente);
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 738);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCodigo.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.TxtCodigo.Location = new System.Drawing.Point(23, 43);
            this.TxtCodigo.Multiline = true;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.Size = new System.Drawing.Size(108, 50);
            this.TxtCodigo.TabIndex = 11;
            this.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnCliente
            // 
            this.BtnCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCliente.BackgroundImage")));
            this.BtnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnCliente.FlatAppearance.BorderSize = 0;
            this.BtnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCliente.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente.Location = new System.Drawing.Point(277, 26);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(91, 81);
            this.BtnCliente.TabIndex = 17;
            this.BtnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnCliente.UseVisualStyleBackColor = true;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label12.Location = new System.Drawing.Point(6, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 17);
            this.label12.TabIndex = 10;
            this.label12.Text = "Codigo Cliente:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CmbNoCuota);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.TxtBuscar);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.TxtFechaPrestamo);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.ListDetalle);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.CmbPagoXdia);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CmbMonto);
            this.groupBox2.Location = new System.Drawing.Point(440, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 819);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // CmbNoCuota
            // 
            this.CmbNoCuota.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbNoCuota.FormattingEnabled = true;
            this.CmbNoCuota.Location = new System.Drawing.Point(228, 239);
            this.CmbNoCuota.Name = "CmbNoCuota";
            this.CmbNoCuota.Size = new System.Drawing.Size(108, 34);
            this.CmbNoCuota.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 409);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(309, 20);
            this.label10.TabIndex = 48;
            this.label10.Text = "______________________________";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(309, 20);
            this.label15.TabIndex = 47;
            this.label15.Text = "______________________________";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RdbDiario);
            this.groupBox3.Controls.Add(this.RdbMensual);
            this.groupBox3.Location = new System.Drawing.Point(16, 119);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 47);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // RdbDiario
            // 
            this.RdbDiario.AutoSize = true;
            this.RdbDiario.Font = new System.Drawing.Font("Sitka Small", 10.2F);
            this.RdbDiario.Location = new System.Drawing.Point(45, 12);
            this.RdbDiario.Name = "RdbDiario";
            this.RdbDiario.Size = new System.Drawing.Size(86, 29);
            this.RdbDiario.TabIndex = 1;
            this.RdbDiario.TabStop = true;
            this.RdbDiario.Text = "Diario";
            this.RdbDiario.UseVisualStyleBackColor = true;
            this.RdbDiario.CheckedChanged += new System.EventHandler(this.RdbDiario_CheckedChanged);
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
            this.RdbMensual.CheckedChanged += new System.EventHandler(this.RdbMensual_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(55, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(226, 35);
            this.label11.TabIndex = 24;
            this.label11.Text = "Tipo de prestamo";
            // 
            // TxtFechaPrestamo
            // 
            this.TxtFechaPrestamo.BackColor = System.Drawing.SystemColors.Window;
            this.TxtFechaPrestamo.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold);
            this.TxtFechaPrestamo.Location = new System.Drawing.Point(228, 356);
            this.TxtFechaPrestamo.Multiline = true;
            this.TxtFechaPrestamo.Name = "TxtFechaPrestamo";
            this.TxtFechaPrestamo.ReadOnly = true;
            this.TxtFechaPrestamo.Size = new System.Drawing.Size(139, 50);
            this.TxtFechaPrestamo.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 356);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(215, 35);
            this.label13.TabIndex = 8;
            this.label13.Text = "Fecha Prestamo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 35);
            this.label8.TabIndex = 6;
            this.label8.Text = "Resumen Prestamo";
            // 
            // ListDetalle
            // 
            this.ListDetalle.Font = new System.Drawing.Font("Calisto MT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListDetalle.FullRowSelect = true;
            listViewItem5.StateImageIndex = 0;
            this.ListDetalle.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5});
            this.ListDetalle.Location = new System.Drawing.Point(16, 462);
            this.ListDetalle.Name = "ListDetalle";
            this.ListDetalle.Size = new System.Drawing.Size(394, 328);
            this.ListDetalle.TabIndex = 5;
            this.ListDetalle.UseCompatibleStateImageBehavior = false;
            this.ListDetalle.View = System.Windows.Forms.View.List;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 35);
            this.label9.TabIndex = 5;
            this.label9.Text = "No. de cuotas:";
            // 
            // CmbPagoXdia
            // 
            this.CmbPagoXdia.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPagoXdia.FormattingEnabled = true;
            this.CmbPagoXdia.Location = new System.Drawing.Point(241, 295);
            this.CmbPagoXdia.Name = "CmbPagoXdia";
            this.CmbPagoXdia.Size = new System.Drawing.Size(95, 34);
            this.CmbPagoXdia.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 35);
            this.label7.TabIndex = 3;
            this.label7.Text = "Pago por dia RD$:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 35);
            this.label6.TabIndex = 2;
            this.label6.Text = "Monto RD$:";
            // 
            // CmbMonto
            // 
            this.CmbMonto.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbMonto.FormattingEnabled = true;
            this.CmbMonto.Location = new System.Drawing.Point(228, 180);
            this.CmbMonto.Name = "CmbMonto";
            this.CmbMonto.Size = new System.Drawing.Size(108, 34);
            this.CmbMonto.TabIndex = 0;
            this.CmbMonto.SelectedIndexChanged += new System.EventHandler(this.CmbMonto_SelectedIndexChanged);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSalir.BackgroundImage")));
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Sitka Small", 13.8F);
            this.BtnSalir.Location = new System.Drawing.Point(7, 756);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(91, 81);
            this.BtnSalir.TabIndex = 13;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.BackgroundImage")));
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Sitka Small", 13.8F);
            this.BtnGuardar.Location = new System.Drawing.Point(234, 756);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(91, 81);
            this.BtnGuardar.TabIndex = 14;
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCalcular.BackgroundImage")));
            this.BtnCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnCalcular.FlatAppearance.BorderSize = 0;
            this.BtnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcular.Font = new System.Drawing.Font("Sitka Small", 13.8F);
            this.BtnCalcular.Location = new System.Drawing.Point(331, 756);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(91, 81);
            this.BtnCalcular.TabIndex = 16;
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.BackgroundImage")));
            this.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Sitka Small", 13.8F);
            this.BtnLimpiar.Location = new System.Drawing.Point(122, 756);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(91, 81);
            this.BtnLimpiar.TabIndex = 18;
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TxtBuscar.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.TxtBuscar.Location = new System.Drawing.Point(16, 20);
            this.TxtBuscar.Multiline = true;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(126, 50);
            this.TxtBuscar.TabIndex = 19;
            this.TxtBuscar.TextoVacio = "Buscar...";
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // FrmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(891, 843);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(909, 890);
            this.MinimumSize = new System.Drawing.Size(909, 890);
            this.Name = "FrmPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos";
            this.Activated += new System.EventHandler(this.FrmPrestamo_Activated);
            this.Load += new System.EventHandler(this.FrmPrestamo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView ListDetalle;
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
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.RadioButton RdbMensual;
        private System.Windows.Forms.RadioButton RdbDiario;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button BtnLimpiar;
        private textBoxAutoexplicativo.txtAutoexplicativo TxtBuscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CmbNoCuota;
    }
}