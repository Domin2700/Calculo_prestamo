﻿namespace Caluladora_Prestamo
{
    partial class FomMantenimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FomMantenimientos));
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.BtnTarfa = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.Font = new System.Drawing.Font("Sitka Small", 13.8F);
            this.BtnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("BtnUsuarios.Image")));
            this.BtnUsuarios.Location = new System.Drawing.Point(88, 120);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(304, 271);
            this.BtnUsuarios.TabIndex = 0;
            this.BtnUsuarios.Text = "Usuarios";
            this.BtnUsuarios.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnUsuarios.UseVisualStyleBackColor = true;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // BtnTarfa
            // 
            this.BtnTarfa.Font = new System.Drawing.Font("Sitka Small", 13.8F);
            this.BtnTarfa.Image = ((System.Drawing.Image)(resources.GetObject("BtnTarfa.Image")));
            this.BtnTarfa.Location = new System.Drawing.Point(526, 120);
            this.BtnTarfa.Name = "BtnTarfa";
            this.BtnTarfa.Size = new System.Drawing.Size(304, 271);
            this.BtnTarfa.TabIndex = 1;
            this.BtnTarfa.Text = "Tarifas";
            this.BtnTarfa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnTarfa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnTarfa.UseVisualStyleBackColor = true;
            this.BtnTarfa.Click += new System.EventHandler(this.BtnTarfa_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Sitka Small", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(320, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(284, 50);
            this.label16.TabIndex = 46;
            this.label16.Text = "Mantenimiento";
            // 
            // BtnSalir
            // 
            this.BtnSalir.Font = new System.Drawing.Font("Sitka Small", 13.8F);
            this.BtnSalir.Location = new System.Drawing.Point(399, 452);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(149, 62);
            this.BtnSalir.TabIndex = 47;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FomMantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 526);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.BtnTarfa);
            this.Controls.Add(this.BtnUsuarios);
            this.Name = "FomMantenimientos";
            this.Text = "Mantenimientos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnUsuarios;
        private System.Windows.Forms.Button BtnTarfa;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button BtnSalir;
    }
}