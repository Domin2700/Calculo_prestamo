namespace Caluladora_Prestamo
{
    partial class FmrPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmrPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPrestamoToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.jToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1095, 303);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Menu";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // nuevoPrestamoToolStripMenuItem
            // 
            this.nuevoPrestamoToolStripMenuItem.Font = new System.Drawing.Font("Sitka Small", 13.8F);
            this.nuevoPrestamoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoPrestamoToolStripMenuItem.Image")));
            this.nuevoPrestamoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nuevoPrestamoToolStripMenuItem.Name = "nuevoPrestamoToolStripMenuItem";
            this.nuevoPrestamoToolStripMenuItem.Size = new System.Drawing.Size(268, 295);
            this.nuevoPrestamoToolStripMenuItem.Text = "Nuevo Prestamo";
            this.nuevoPrestamoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.nuevoPrestamoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.nuevoPrestamoToolStripMenuItem.Click += new System.EventHandler(this.nuevoPrestamoToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Font = new System.Drawing.Font("Sitka Small", 13.8F);
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(268, 295);
            this.clientesToolStripMenuItem.Text = "Cobrar";
            this.clientesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.Font = new System.Drawing.Font("Sitka Small", 13.8F);
            this.mantenimientoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoToolStripMenuItem.Image")));
            this.mantenimientoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(268, 295);
            this.mantenimientoToolStripMenuItem.Text = "Nuevo Cliente";
            this.mantenimientoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.mantenimientoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem_Click);
            // 
            // jToolStripMenuItem
            // 
            this.jToolStripMenuItem.Font = new System.Drawing.Font("Sitka Small", 13.8F);
            this.jToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("jToolStripMenuItem.Image")));
            this.jToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.jToolStripMenuItem.Name = "jToolStripMenuItem";
            this.jToolStripMenuItem.Size = new System.Drawing.Size(268, 295);
            this.jToolStripMenuItem.Text = "Mantenimiento";
            this.jToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // FmrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1095, 706);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Sitka Small", 13.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FmrPrincipal";
            this.Text = "Calculadora de prestamos";
            this.Load += new System.EventHandler(this.FmrPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jToolStripMenuItem;
    }
}

