namespace G7_Orders
{
    partial class InterfazEDI
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
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.lsbLectura = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(42, 70);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(105, 23);
            this.btnSelectFile.TabIndex = 11;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // lsbLectura
            // 
            this.lsbLectura.FormattingEnabled = true;
            this.lsbLectura.ItemHeight = 16;
            this.lsbLectura.Location = new System.Drawing.Point(42, 151);
            this.lsbLectura.Name = "lsbLectura";
            this.lsbLectura.Size = new System.Drawing.Size(301, 180);
            this.lsbLectura.TabIndex = 12;
            // 
            // InterfazEDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 625);
            this.Controls.Add(this.lsbLectura);
            this.Controls.Add(this.btnSelectFile);
            this.Name = "InterfazEDI";
            this.Text = "InterfazEDI";
            this.Controls.SetChildIndex(this.btnSelectFile, 0);
            this.Controls.SetChildIndex(this.lsbLectura, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.ListBox lsbLectura;
    }
}