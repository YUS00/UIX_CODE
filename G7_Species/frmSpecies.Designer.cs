namespace G7_Species
{
    partial class frmSpecies
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
            this.swtDescSpecie = new LibreriaClases.SWTextbox();
            this.swtCodeSpecie = new LibreriaClases.SWTextbox();
            this.lblCodeSpecie = new System.Windows.Forms.Label();
            this.lblDescSpecie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // swtDescSpecie
            // 
            this.swtDescSpecie.Campo_obligatorio = false;
            this.swtDescSpecie.CampoBBDD = "DescSpecie";
            this.swtDescSpecie.ForeignKey = false;
            this.swtDescSpecie.Location = new System.Drawing.Point(173, 171);
            this.swtDescSpecie.Name = "swtDescSpecie";
            this.swtDescSpecie.Size = new System.Drawing.Size(195, 22);
            this.swtDescSpecie.TabIndex = 16;
            this.swtDescSpecie.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Texto;
            // 
            // swtCodeSpecie
            // 
            this.swtCodeSpecie.Campo_obligatorio = false;
            this.swtCodeSpecie.CampoBBDD = "CodeSpecie";
            this.swtCodeSpecie.ForeignKey = false;
            this.swtCodeSpecie.Location = new System.Drawing.Point(173, 108);
            this.swtCodeSpecie.Name = "swtCodeSpecie";
            this.swtCodeSpecie.Size = new System.Drawing.Size(195, 22);
            this.swtCodeSpecie.TabIndex = 17;
            this.swtCodeSpecie.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Texto;
            // 
            // lblCodeSpecie
            // 
            this.lblCodeSpecie.AutoSize = true;
            this.lblCodeSpecie.BackColor = System.Drawing.Color.Transparent;
            this.lblCodeSpecie.ForeColor = System.Drawing.Color.White;
            this.lblCodeSpecie.Location = new System.Drawing.Point(94, 111);
            this.lblCodeSpecie.Name = "lblCodeSpecie";
            this.lblCodeSpecie.Size = new System.Drawing.Size(55, 17);
            this.lblCodeSpecie.TabIndex = 18;
            this.lblCodeSpecie.Text = "CODE: ";
            // 
            // lblDescSpecie
            // 
            this.lblDescSpecie.AutoSize = true;
            this.lblDescSpecie.BackColor = System.Drawing.Color.Transparent;
            this.lblDescSpecie.ForeColor = System.Drawing.Color.White;
            this.lblDescSpecie.Location = new System.Drawing.Point(51, 174);
            this.lblDescSpecie.Name = "lblDescSpecie";
            this.lblDescSpecie.Size = new System.Drawing.Size(98, 17);
            this.lblDescSpecie.TabIndex = 19;
            this.lblDescSpecie.Text = "DESCRIPCIO: ";
            // 
            // frmSpecies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 558);
            this.Controls.Add(this.lblDescSpecie);
            this.Controls.Add(this.lblCodeSpecie);
            this.Controls.Add(this.swtCodeSpecie);
            this.Controls.Add(this.swtDescSpecie);
            this.Name = "frmSpecies";
            this.Taula = "Species";
            this.Text = "frmSpecies";
            this.Controls.SetChildIndex(this.swtDescSpecie, 0);
            this.Controls.SetChildIndex(this.swtCodeSpecie, 0);
            this.Controls.SetChildIndex(this.lblCodeSpecie, 0);
            this.Controls.SetChildIndex(this.lblDescSpecie, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibreriaClases.SWTextbox swtDescSpecie;
        private LibreriaClases.SWTextbox swtCodeSpecie;
        private System.Windows.Forms.Label lblCodeSpecie;
        private System.Windows.Forms.Label lblDescSpecie;
    }
}