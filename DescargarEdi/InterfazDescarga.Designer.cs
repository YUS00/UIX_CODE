namespace DescargarEdi
{
    partial class InterfazDescarga
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
            this.btnDownload = new System.Windows.Forms.Button();
            this.dtgFiles = new System.Windows.Forms.DataGridView();
            this.txbSelectedFile = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(142, 178);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(134, 40);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.TabStop = false;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // dtgFiles
            // 
            this.dtgFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFiles.Location = new System.Drawing.Point(476, 74);
            this.dtgFiles.Name = "dtgFiles";
            this.dtgFiles.RowHeadersWidth = 51;
            this.dtgFiles.RowTemplate.Height = 24;
            this.dtgFiles.Size = new System.Drawing.Size(240, 248);
            this.dtgFiles.TabIndex = 2;
            // 
            // txbSelectedFile
            // 
            this.txbSelectedFile.Location = new System.Drawing.Point(94, 117);
            this.txbSelectedFile.Name = "txbSelectedFile";
            this.txbSelectedFile.Size = new System.Drawing.Size(227, 22);
            this.txbSelectedFile.TabIndex = 3;
            // 
            // InterfazDescarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbSelectedFile);
            this.Controls.Add(this.dtgFiles);
            this.Controls.Add(this.btnDownload);
            this.Name = "InterfazDescarga";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InterfazDescarga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.DataGridView dtgFiles;
        private System.Windows.Forms.TextBox txbSelectedFile;
    }
}

