namespace TextBoxes
{
    partial class Form1
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
            this.txtAutoexplicativo1 = new textBoxAutoexplicativo.txtAutoexplicativo();
            this.SuspendLayout();
            // 
            // txtAutoexplicativo1
            // 
            this.txtAutoexplicativo1.ColorTextoVacio = System.Drawing.Color.Gray;
            this.txtAutoexplicativo1.Location = new System.Drawing.Point(89, 89);
            this.txtAutoexplicativo1.Name = "txtAutoexplicativo1";
            this.txtAutoexplicativo1.Size = new System.Drawing.Size(216, 20);
            this.txtAutoexplicativo1.TabIndex = 0;
            this.txtAutoexplicativo1.TextoVacio = "Buscar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 215);
            this.Controls.Add(this.txtAutoexplicativo1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private textBoxAutoexplicativo.txtAutoexplicativo txtAutoexplicativo1;
    }
}

