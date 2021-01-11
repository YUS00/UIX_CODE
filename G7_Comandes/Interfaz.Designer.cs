namespace G7_Comandes
{
    partial class Interfaz
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
            this.button1 = new System.Windows.Forms.Button();
            this.lsbLectura = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "SELECT EDI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lsbLectura
            // 
            this.lsbLectura.FormattingEnabled = true;
            this.lsbLectura.ItemHeight = 16;
            this.lsbLectura.Location = new System.Drawing.Point(309, 104);
            this.lsbLectura.Name = "lsbLectura";
            this.lsbLectura.Size = new System.Drawing.Size(233, 148);
            this.lsbLectura.TabIndex = 1;
            // 
            // Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 314);
            this.Controls.Add(this.lsbLectura);
            this.Controls.Add(this.button1);
            this.Name = "Interfaz";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.lsbLectura, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lsbLectura;
    }
}

