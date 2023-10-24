namespace PalindromoApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.PalabraTextBox = new System.Windows.Forms.TextBox();
            this.VerificarPalindromo = new System.Windows.Forms.Button();
            this.ResultadoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PalabraTextBox
            // 
            this.PalabraTextBox.Location = new System.Drawing.Point(12, 12);
            this.PalabraTextBox.Name = "PalabraTextBox";
            this.PalabraTextBox.Size = new System.Drawing.Size(200, 20);
            this.PalabraTextBox.TabIndex = 0;
            // 
            // VerificarPalindromo
            // 
            this.VerificarPalindromo.Location = new System.Drawing.Point(12, 38);
            this.VerificarPalindromo.Name = "VerificarPalindromo";
            this.VerificarPalindromo.Size = new System.Drawing.Size(200, 23);
            this.VerificarPalindromo.TabIndex = 1;
            this.VerificarPalindromo.Text = "Verificar si es palíndromo";
            this.VerificarPalindromo.UseVisualStyleBackColor = true;
            this.VerificarPalindromo.Click += new System.EventHandler(this.VerificarPalindromo_Click);
            // 
            // ResultadoLabel
            // 
            this.ResultadoLabel.AutoSize = true;
            this.ResultadoLabel.Location = new System.Drawing.Point(12, 74);
            this.ResultadoLabel.Name = "ResultadoLabel";
            this.ResultadoLabel.Size = new System.Drawing.Size(0, 13);
            this.ResultadoLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 101);
            this.Controls.Add(this.ResultadoLabel);
            this.Controls.Add(this.VerificarPalindromo);
            this.Controls.Add(this.PalabraTextBox);
            this.Name = "Form1";
            this.Text = "Verificador de Palíndromos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PalabraTextBox;
        private System.Windows.Forms.Button VerificarPalindromo;
        private System.Windows.Forms.Label ResultadoLabel;
    }
}
