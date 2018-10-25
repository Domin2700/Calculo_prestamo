namespace Caluladora_Prestamo
{
    partial class FrmTarifas
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
            this.TxtMonto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCuota = new System.Windows.Forms.TextBox();
            this.TxtNoCuota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RdbMensual = new System.Windows.Forms.RadioButton();
            this.RdbSemanal = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtMonto
            // 
            this.TxtMonto.Location = new System.Drawing.Point(179, 44);
            this.TxtMonto.Multiline = true;
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(118, 34);
            this.TxtMonto.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 35);
            this.label1.TabIndex = 17;
            this.label1.Text = "Monto RD$:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 35);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cuotas RD$:";
            // 
            // TxtCuota
            // 
            this.TxtCuota.Location = new System.Drawing.Point(179, 98);
            this.TxtCuota.Multiline = true;
            this.TxtCuota.Name = "TxtCuota";
            this.TxtCuota.Size = new System.Drawing.Size(118, 34);
            this.TxtCuota.TabIndex = 19;
            // 
            // TxtNoCuota
            // 
            this.TxtNoCuota.Location = new System.Drawing.Point(179, 164);
            this.TxtNoCuota.Multiline = true;
            this.TxtNoCuota.Name = "TxtNoCuota";
            this.TxtNoCuota.Size = new System.Drawing.Size(118, 34);
            this.TxtNoCuota.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 35);
            this.label3.TabIndex = 20;
            this.label3.Text = "No. Cuotas:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbSemanal);
            this.groupBox1.Controls.Add(this.RdbMensual);
            this.groupBox1.Location = new System.Drawing.Point(321, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 101);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 35);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tipo de prestamo";
            // 
            // RdbMensual
            // 
            this.RdbMensual.AutoSize = true;
            this.RdbMensual.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbMensual.Location = new System.Drawing.Point(54, 65);
            this.RdbMensual.Name = "RdbMensual";
            this.RdbMensual.Size = new System.Drawing.Size(107, 29);
            this.RdbMensual.TabIndex = 0;
            this.RdbMensual.TabStop = true;
            this.RdbMensual.Text = "Mensual";
            this.RdbMensual.UseVisualStyleBackColor = true;
            // 
            // RdbSemanal
            // 
            this.RdbSemanal.AutoSize = true;
            this.RdbSemanal.Font = new System.Drawing.Font("Sitka Small", 10.2F);
            this.RdbSemanal.Location = new System.Drawing.Point(54, 21);
            this.RdbSemanal.Name = "RdbSemanal";
            this.RdbSemanal.Size = new System.Drawing.Size(106, 29);
            this.RdbSemanal.TabIndex = 1;
            this.RdbSemanal.TabStop = true;
            this.RdbSemanal.Text = "Semanal";
            this.RdbSemanal.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(530, 193);
            this.dataGridView1.TabIndex = 24;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Sitka Small", 13.8F);
            this.BtnLimpiar.Location = new System.Drawing.Point(202, 434);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(149, 62);
            this.BtnLimpiar.TabIndex = 38;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Sitka Small", 13.8F);
            this.BtnGuardar.Location = new System.Drawing.Point(393, 434);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(149, 62);
            this.BtnGuardar.TabIndex = 37;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Sitka Small", 13.8F);
            this.BtnSalir.Location = new System.Drawing.Point(12, 434);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(149, 62);
            this.BtnSalir.TabIndex = 36;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmTarifas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 508);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtCuota);
            this.Controls.Add(this.TxtNoCuota);
            this.Controls.Add(this.label3);
            this.Name = "FrmTarifas";
            this.Text = "Tarifas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCuota;
        private System.Windows.Forms.TextBox TxtNoCuota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdbSemanal;
        private System.Windows.Forms.RadioButton RdbMensual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnSalir;
    }
}