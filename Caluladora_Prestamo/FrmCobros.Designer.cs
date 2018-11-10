namespace Caluladora_Prestamo
{
    partial class FrmCobros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCobros));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnProcesar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.TxtBuscar = new textBoxAutoexplicativo.txtAutoexplicativo();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCelular = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DgvCobros = new System.Windows.Forms.DataGridView();
            this.TxtNoCuota = new System.Windows.Forms.TextBox();
            this.TxtFechaPago = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TxtCuota = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtPendiente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtHechos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCobros)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnCliente);
            this.groupBox1.Location = new System.Drawing.Point(28, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 532);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnProcesar
            // 
            this.BtnProcesar.Font = new System.Drawing.Font("Sitka Small", 13.8F);
            this.BtnProcesar.Location = new System.Drawing.Point(650, 715);
            this.BtnProcesar.Name = "BtnProcesar";
            this.BtnProcesar.Size = new System.Drawing.Size(211, 62);
            this.BtnProcesar.TabIndex = 47;
            this.BtnProcesar.Text = "Procesar pago";
            this.BtnProcesar.UseVisualStyleBackColor = true;
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
            this.BtnSalir.Location = new System.Drawing.Point(39, 706);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(91, 81);
            this.BtnSalir.TabIndex = 48;
            this.BtnSalir.UseVisualStyleBackColor = true;
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
            this.BtnLimpiar.Location = new System.Drawing.Point(173, 706);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(91, 81);
            this.BtnLimpiar.TabIndex = 49;
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TxtBuscar.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.TxtBuscar.Location = new System.Drawing.Point(881, 70);
            this.TxtBuscar.Multiline = true;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(153, 50);
            this.TxtBuscar.TabIndex = 88;
            this.TxtBuscar.TextoVacio = "Buscar...";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCodigo.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.TxtCodigo.Location = new System.Drawing.Point(56, 75);
            this.TxtCodigo.Multiline = true;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.Size = new System.Drawing.Size(108, 50);
            this.TxtCodigo.TabIndex = 86;
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
            this.BtnCliente.Location = new System.Drawing.Point(282, 27);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(91, 81);
            this.BtnCliente.TabIndex = 87;
            this.BtnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnCliente.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label1.Location = new System.Drawing.Point(39, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 85;
            this.label1.Text = "Codigo Cliente:";
            // 
            // TxtNombres
            // 
            this.TxtNombres.BackColor = System.Drawing.SystemColors.Window;
            this.TxtNombres.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.TxtNombres.Location = new System.Drawing.Point(59, 157);
            this.TxtNombres.Multiline = true;
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.ReadOnly = true;
            this.TxtNombres.Size = new System.Drawing.Size(342, 50);
            this.TxtNombres.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label2.Location = new System.Drawing.Point(40, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = "Nombres:";
            // 
            // TxtCelular
            // 
            this.TxtCelular.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCelular.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.TxtCelular.Location = new System.Drawing.Point(56, 449);
            this.TxtCelular.Multiline = true;
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.ReadOnly = true;
            this.TxtCelular.Size = new System.Drawing.Size(342, 50);
            this.TxtCelular.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label3.Location = new System.Drawing.Point(40, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 79;
            this.label3.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label4.Location = new System.Drawing.Point(40, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 83;
            this.label4.Text = "Celular:";
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.BackColor = System.Drawing.SystemColors.Window;
            this.TxtApellidos.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.TxtApellidos.Location = new System.Drawing.Point(59, 261);
            this.TxtApellidos.Multiline = true;
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.ReadOnly = true;
            this.TxtApellidos.Size = new System.Drawing.Size(342, 50);
            this.TxtApellidos.TabIndex = 80;
            // 
            // TxtCedula
            // 
            this.TxtCedula.BackColor = System.Drawing.SystemColors.Window;
            this.TxtCedula.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.TxtCedula.Location = new System.Drawing.Point(59, 350);
            this.TxtCedula.Multiline = true;
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.ReadOnly = true;
            this.TxtCedula.Size = new System.Drawing.Size(342, 50);
            this.TxtCedula.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label7.Location = new System.Drawing.Point(40, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 81;
            this.label7.Text = "Cedula:";
            // 
            // DgvCobros
            // 
            this.DgvCobros.AllowUserToAddRows = false;
            this.DgvCobros.AllowUserToDeleteRows = false;
            this.DgvCobros.AllowUserToResizeColumns = false;
            this.DgvCobros.AllowUserToResizeRows = false;
            this.DgvCobros.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DgvCobros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCobros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCobros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCobros.Location = new System.Drawing.Point(559, 139);
            this.DgvCobros.Name = "DgvCobros";
            this.DgvCobros.ReadOnly = true;
            this.DgvCobros.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.DgvCobros.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCobros.RowTemplate.Height = 24;
            this.DgvCobros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCobros.Size = new System.Drawing.Size(475, 257);
            this.DgvCobros.TabIndex = 76;
            // 
            // TxtNoCuota
            // 
            this.TxtNoCuota.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.TxtNoCuota.Location = new System.Drawing.Point(279, 553);
            this.TxtNoCuota.Multiline = true;
            this.TxtNoCuota.Name = "TxtNoCuota";
            this.TxtNoCuota.Size = new System.Drawing.Size(119, 50);
            this.TxtNoCuota.TabIndex = 75;
            // 
            // TxtFechaPago
            // 
            this.TxtFechaPago.BackColor = System.Drawing.SystemColors.Window;
            this.TxtFechaPago.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.TxtFechaPago.Location = new System.Drawing.Point(629, 553);
            this.TxtFechaPago.Multiline = true;
            this.TxtFechaPago.Name = "TxtFechaPago";
            this.TxtFechaPago.ReadOnly = true;
            this.TxtFechaPago.Size = new System.Drawing.Size(119, 50);
            this.TxtFechaPago.TabIndex = 74;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(429, 553);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(194, 35);
            this.label14.TabIndex = 73;
            this.label14.Text = "Fecha de pago:";
            // 
            // TxtCuota
            // 
            this.TxtCuota.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.TxtCuota.Location = new System.Drawing.Point(279, 631);
            this.TxtCuota.Multiline = true;
            this.TxtCuota.Name = "TxtCuota";
            this.TxtCuota.Size = new System.Drawing.Size(119, 50);
            this.TxtCuota.TabIndex = 72;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(28, 632);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(248, 35);
            this.label13.TabIndex = 71;
            this.label13.Text = "Total a cobrar RD$:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(28, 553);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(251, 35);
            this.label12.TabIndex = 70;
            this.label12.Text = "No. Cuotas a pagar:";
            // 
            // TxtTotal
            // 
            this.TxtTotal.BackColor = System.Drawing.SystemColors.Window;
            this.TxtTotal.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.TxtTotal.Location = new System.Drawing.Point(939, 699);
            this.TxtTotal.Multiline = true;
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(84, 34);
            this.TxtTotal.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(657, 698);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(287, 35);
            this.label10.TabIndex = 68;
            this.label10.Text = "Monto Pendiente RD$:";
            // 
            // TxtPendiente
            // 
            this.TxtPendiente.BackColor = System.Drawing.SystemColors.Window;
            this.TxtPendiente.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.TxtPendiente.Location = new System.Drawing.Point(303, 699);
            this.TxtPendiente.Multiline = true;
            this.TxtPendiente.Name = "TxtPendiente";
            this.TxtPendiente.ReadOnly = true;
            this.TxtPendiente.Size = new System.Drawing.Size(58, 34);
            this.TxtPendiente.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 695);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(283, 35);
            this.label9.TabIndex = 66;
            this.label9.Text = "No. Pagos pendientes:";
            // 
            // TxtHechos
            // 
            this.TxtHechos.BackColor = System.Drawing.SystemColors.Window;
            this.TxtHechos.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.TxtHechos.Location = new System.Drawing.Point(593, 699);
            this.TxtHechos.Multiline = true;
            this.TxtHechos.Name = "TxtHechos";
            this.TxtHechos.ReadOnly = true;
            this.TxtHechos.Size = new System.Drawing.Size(58, 34);
            this.TxtHechos.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(367, 698);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 35);
            this.label8.TabIndex = 64;
            this.label8.Text = "No. Pagos hechos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(468, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 35);
            this.label6.TabIndex = 63;
            this.label6.Text = "Detalle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1023, 35);
            this.label5.TabIndex = 62;
            this.label5.Text = "________________________________________________________________________";
            // 
            // FrmCobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1079, 783);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtNombres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCelular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtApellidos);
            this.Controls.Add(this.TxtCedula);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DgvCobros);
            this.Controls.Add(this.TxtNoCuota);
            this.Controls.Add(this.TxtFechaPago);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TxtCuota);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtPendiente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtHechos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnProcesar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCobros";
            this.Text = "Cobros";
            this.Load += new System.EventHandler(this.FrmCobros_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCobros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnProcesar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Button BtnLimpiar;
        private textBoxAutoexplicativo.txtAutoexplicativo TxtBuscar;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCelular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DgvCobros;
        private System.Windows.Forms.TextBox TxtNoCuota;
        private System.Windows.Forms.TextBox TxtFechaPago;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtCuota;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtPendiente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtHechos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}