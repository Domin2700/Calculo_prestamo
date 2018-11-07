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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTarifas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RdbMensual = new System.Windows.Forms.RadioButton();
            this.RdbSemanal = new System.Windows.Forms.RadioButton();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.DgvTarifas = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.TxtMonto = new textBoxAutoexplicativo.txtAutoexplicativo();
            this.TxtCuota = new textBoxAutoexplicativo.txtAutoexplicativo();
            this.TxtNoCuota = new textBoxAutoexplicativo.txtAutoexplicativo();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTarifas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EpError)).BeginInit();
            this.SuspendLayout();
            // 
            // RdbMensual
            // 
            this.RdbMensual.AutoSize = true;
            this.RdbMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.RdbMensual.Location = new System.Drawing.Point(47, 48);
            this.RdbMensual.Name = "RdbMensual";
            this.RdbMensual.Size = new System.Drawing.Size(82, 21);
            this.RdbMensual.TabIndex = 6;
            this.RdbMensual.TabStop = true;
            this.RdbMensual.Text = "Mensual";
            this.RdbMensual.UseVisualStyleBackColor = true;
            // 
            // RdbSemanal
            // 
            this.RdbSemanal.AutoSize = true;
            this.RdbSemanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.RdbSemanal.Location = new System.Drawing.Point(47, 21);
            this.RdbSemanal.Name = "RdbSemanal";
            this.RdbSemanal.Size = new System.Drawing.Size(84, 21);
            this.RdbSemanal.TabIndex = 5;
            this.RdbSemanal.TabStop = true;
            this.RdbSemanal.Text = "Semanal";
            this.RdbSemanal.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSalir.BackgroundImage")));
            this.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Sitka Small", 13.8F);
            this.BtnSalir.Location = new System.Drawing.Point(14, 12);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(70, 68);
            this.BtnSalir.TabIndex = 11;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGuardar.BackgroundImage")));
            this.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Sitka Small", 13.8F);
            this.BtnGuardar.Location = new System.Drawing.Point(385, 10);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(61, 73);
            this.BtnGuardar.TabIndex = 7;
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLimpiar.BackgroundImage")));
            this.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnLimpiar.FlatAppearance.BorderSize = 0;
            this.BtnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("Sitka Small", 13.8F);
            this.BtnLimpiar.Location = new System.Drawing.Point(316, 16);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(51, 64);
            this.BtnLimpiar.TabIndex = 9;
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnActualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnActualizar.BackgroundImage")));
            this.BtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnActualizar.FlatAppearance.BorderSize = 0;
            this.BtnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Sitka Small", 13.8F);
            this.BtnActualizar.Location = new System.Drawing.Point(235, 12);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(63, 73);
            this.BtnActualizar.TabIndex = 8;
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Visible = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // DgvTarifas
            // 
            this.DgvTarifas.AllowUserToAddRows = false;
            this.DgvTarifas.AllowUserToDeleteRows = false;
            this.DgvTarifas.AllowUserToResizeColumns = false;
            this.DgvTarifas.AllowUserToResizeRows = false;
            this.DgvTarifas.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTarifas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTarifas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Borrar});
            this.DgvTarifas.Location = new System.Drawing.Point(5, 274);
            this.DgvTarifas.Name = "DgvTarifas";
            this.DgvTarifas.ReadOnly = true;
            this.DgvTarifas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTarifas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvTarifas.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.DgvTarifas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvTarifas.RowTemplate.Height = 24;
            this.DgvTarifas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTarifas.Size = new System.Drawing.Size(471, 224);
            this.DgvTarifas.TabIndex = 10;
            this.DgvTarifas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTarifas_CellClick);
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Editar.Description = "Editar";
            this.Editar.FillWeight = 22F;
            this.Editar.HeaderText = "";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.MinimumWidth = 25;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.Width = 25;
            // 
            // Borrar
            // 
            this.Borrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Borrar.Description = "Borrar";
            this.Borrar.FillWeight = 22F;
            this.Borrar.HeaderText = "";
            this.Borrar.Image = ((System.Drawing.Image)(resources.GetObject("Borrar.Image")));
            this.Borrar.MinimumWidth = 25;
            this.Borrar.Name = "Borrar";
            this.Borrar.ReadOnly = true;
            this.Borrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Borrar.Width = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbSemanal);
            this.groupBox1.Controls.Add(this.RdbMensual);
            this.groupBox1.Location = new System.Drawing.Point(280, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 84);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // EpError
            // 
            this.EpError.ContainerControl = this;
            // 
            // TxtMonto
            // 
            this.TxtMonto.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TxtMonto.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.TxtMonto.Location = new System.Drawing.Point(25, 107);
            this.TxtMonto.Multiline = true;
            this.TxtMonto.Name = "TxtMonto";
            this.TxtMonto.Size = new System.Drawing.Size(170, 55);
            this.TxtMonto.TabIndex = 47;
            this.TxtMonto.TextoVacio = "Monto RD$";
            // 
            // TxtCuota
            // 
            this.TxtCuota.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TxtCuota.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.TxtCuota.Location = new System.Drawing.Point(25, 190);
            this.TxtCuota.Multiline = true;
            this.TxtCuota.Name = "TxtCuota";
            this.TxtCuota.Size = new System.Drawing.Size(170, 55);
            this.TxtCuota.TabIndex = 48;
            this.TxtCuota.TextoVacio = "Cuota RD$ ";
            this.TxtCuota.TextChanged += new System.EventHandler(this.txtAutoexplicativo1_TextChanged);
            // 
            // TxtNoCuota
            // 
            this.TxtNoCuota.ColorTextoVacio = System.Drawing.Color.Gray;
            this.TxtNoCuota.Font = new System.Drawing.Font("Calisto MT", 19.8F, System.Drawing.FontStyle.Bold);
            this.TxtNoCuota.Location = new System.Drawing.Point(276, 107);
            this.TxtNoCuota.Multiline = true;
            this.TxtNoCuota.Name = "TxtNoCuota";
            this.TxtNoCuota.Size = new System.Drawing.Size(170, 55);
            this.TxtNoCuota.TabIndex = 49;
            this.TxtNoCuota.TextoVacio = "No. Cuotas";
            // 
            // FrmTarifas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(482, 503);
            this.Controls.Add(this.TxtNoCuota);
            this.Controls.Add(this.TxtCuota);
            this.Controls.Add(this.TxtMonto);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DgvTarifas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(500, 550);
            this.MinimumSize = new System.Drawing.Size(500, 550);
            this.Name = "FrmTarifas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarifas";
            this.Load += new System.EventHandler(this.FrmTarifas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTarifas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EpError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton RdbMensual;
        private System.Windows.Forms.RadioButton RdbSemanal;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.DataGridView DgvTarifas;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Borrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider EpError;
        private textBoxAutoexplicativo.txtAutoexplicativo TxtCuota;
        private textBoxAutoexplicativo.txtAutoexplicativo TxtMonto;
        private textBoxAutoexplicativo.txtAutoexplicativo TxtNoCuota;
    }
}