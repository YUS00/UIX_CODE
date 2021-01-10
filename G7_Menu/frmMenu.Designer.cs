namespace G7_Menu
{
    partial class frmMenu
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
            this.swtDescOpcio = new LibreriaClases.SWTextbox();
            this.lblDescOpcio = new System.Windows.Forms.Label();
            this.lblEnsamblat = new System.Windows.Forms.Label();
            this.swtEnsamblat = new LibreriaClases.SWTextbox();
            this.lblClasse = new System.Windows.Forms.Label();
            this.swtClasse = new LibreriaClases.SWTextbox();
            this.lblNivell = new System.Windows.Forms.Label();
            this.swtNivell = new LibreriaClases.SWTextbox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.swtFoto = new LibreriaClases.SWTextbox();
            this.lblColor = new System.Windows.Forms.Label();
            this.swtColor = new LibreriaClases.SWTextbox();
            this.SuspendLayout();
            // 
            // swtDescOpcio
            // 
            this.swtDescOpcio.Campo_obligatorio = false;
            this.swtDescOpcio.CampoBBDD = "descOpcio";
            this.swtDescOpcio.ForeignKey = false;
            this.swtDescOpcio.Location = new System.Drawing.Point(185, 112);
            this.swtDescOpcio.Name = "swtDescOpcio";
            this.swtDescOpcio.Size = new System.Drawing.Size(155, 22);
            this.swtDescOpcio.TabIndex = 15;
            this.swtDescOpcio.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Texto;
            // 
            // lblDescOpcio
            // 
            this.lblDescOpcio.AutoSize = true;
            this.lblDescOpcio.BackColor = System.Drawing.Color.Transparent;
            this.lblDescOpcio.ForeColor = System.Drawing.Color.White;
            this.lblDescOpcio.Location = new System.Drawing.Point(63, 115);
            this.lblDescOpcio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescOpcio.Name = "lblDescOpcio";
            this.lblDescOpcio.Size = new System.Drawing.Size(94, 17);
            this.lblDescOpcio.TabIndex = 36;
            this.lblDescOpcio.Text = "DESCRIPCIÓ:";
            // 
            // lblEnsamblat
            // 
            this.lblEnsamblat.AutoSize = true;
            this.lblEnsamblat.BackColor = System.Drawing.Color.Transparent;
            this.lblEnsamblat.ForeColor = System.Drawing.Color.White;
            this.lblEnsamblat.Location = new System.Drawing.Point(63, 171);
            this.lblEnsamblat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnsamblat.Name = "lblEnsamblat";
            this.lblEnsamblat.Size = new System.Drawing.Size(95, 17);
            this.lblEnsamblat.TabIndex = 38;
            this.lblEnsamblat.Text = "ENSAMBLAT:";
            // 
            // swtEnsamblat
            // 
            this.swtEnsamblat.Campo_obligatorio = false;
            this.swtEnsamblat.CampoBBDD = "ensamblat";
            this.swtEnsamblat.ForeignKey = false;
            this.swtEnsamblat.Location = new System.Drawing.Point(185, 168);
            this.swtEnsamblat.Name = "swtEnsamblat";
            this.swtEnsamblat.Size = new System.Drawing.Size(155, 22);
            this.swtEnsamblat.TabIndex = 37;
            this.swtEnsamblat.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Perzonalizado;
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.BackColor = System.Drawing.Color.Transparent;
            this.lblClasse.ForeColor = System.Drawing.Color.White;
            this.lblClasse.Location = new System.Drawing.Point(92, 223);
            this.lblClasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(65, 17);
            this.lblClasse.TabIndex = 40;
            this.lblClasse.Text = "CLASSE:";
            // 
            // swtClasse
            // 
            this.swtClasse.Campo_obligatorio = false;
            this.swtClasse.CampoBBDD = "classe";
            this.swtClasse.ForeignKey = false;
            this.swtClasse.Location = new System.Drawing.Point(185, 220);
            this.swtClasse.Name = "swtClasse";
            this.swtClasse.Size = new System.Drawing.Size(155, 22);
            this.swtClasse.TabIndex = 39;
            this.swtClasse.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Perzonalizado;
            // 
            // lblNivell
            // 
            this.lblNivell.AutoSize = true;
            this.lblNivell.BackColor = System.Drawing.Color.Transparent;
            this.lblNivell.ForeColor = System.Drawing.Color.White;
            this.lblNivell.Location = new System.Drawing.Point(479, 115);
            this.lblNivell.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNivell.Name = "lblNivell";
            this.lblNivell.Size = new System.Drawing.Size(59, 17);
            this.lblNivell.TabIndex = 42;
            this.lblNivell.Text = "NIVELL:";
            // 
            // swtNivell
            // 
            this.swtNivell.Campo_obligatorio = false;
            this.swtNivell.CampoBBDD = "nivell";
            this.swtNivell.ForeignKey = false;
            this.swtNivell.Location = new System.Drawing.Point(576, 112);
            this.swtNivell.Name = "swtNivell";
            this.swtNivell.Size = new System.Drawing.Size(155, 22);
            this.swtNivell.TabIndex = 41;
            this.swtNivell.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Numero;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.BackColor = System.Drawing.Color.Transparent;
            this.lblFoto.ForeColor = System.Drawing.Color.White;
            this.lblFoto.Location = new System.Drawing.Point(487, 171);
            this.lblFoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(51, 17);
            this.lblFoto.TabIndex = 44;
            this.lblFoto.Text = "FOTO:";
            // 
            // swtFoto
            // 
            this.swtFoto.Campo_obligatorio = false;
            this.swtFoto.CampoBBDD = "foto";
            this.swtFoto.ForeignKey = false;
            this.swtFoto.Location = new System.Drawing.Point(576, 168);
            this.swtFoto.Name = "swtFoto";
            this.swtFoto.Size = new System.Drawing.Size(155, 22);
            this.swtFoto.TabIndex = 43;
            this.swtFoto.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Perzonalizado;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.BackColor = System.Drawing.Color.Transparent;
            this.lblColor.ForeColor = System.Drawing.Color.White;
            this.lblColor.Location = new System.Drawing.Point(477, 223);
            this.lblColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(61, 17);
            this.lblColor.TabIndex = 46;
            this.lblColor.Text = "COLOR:";
            // 
            // swtColor
            // 
            this.swtColor.Campo_obligatorio = false;
            this.swtColor.CampoBBDD = "backgroundColor";
            this.swtColor.ForeignKey = false;
            this.swtColor.Location = new System.Drawing.Point(576, 220);
            this.swtColor.Name = "swtColor";
            this.swtColor.Size = new System.Drawing.Size(155, 22);
            this.swtColor.TabIndex = 45;
            this.swtColor.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Texto;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 558);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.swtColor);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.swtFoto);
            this.Controls.Add(this.lblNivell);
            this.Controls.Add(this.swtNivell);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.swtClasse);
            this.Controls.Add(this.lblEnsamblat);
            this.Controls.Add(this.swtEnsamblat);
            this.Controls.Add(this.lblDescOpcio);
            this.Controls.Add(this.swtDescOpcio);
            this.Name = "frmMenu";
            this.Taula = "MenuOptions";
            this.Text = "frmMenu";
            this.Controls.SetChildIndex(this.swtDescOpcio, 0);
            this.Controls.SetChildIndex(this.lblDescOpcio, 0);
            this.Controls.SetChildIndex(this.swtEnsamblat, 0);
            this.Controls.SetChildIndex(this.lblEnsamblat, 0);
            this.Controls.SetChildIndex(this.swtClasse, 0);
            this.Controls.SetChildIndex(this.lblClasse, 0);
            this.Controls.SetChildIndex(this.swtNivell, 0);
            this.Controls.SetChildIndex(this.lblNivell, 0);
            this.Controls.SetChildIndex(this.swtFoto, 0);
            this.Controls.SetChildIndex(this.lblFoto, 0);
            this.Controls.SetChildIndex(this.swtColor, 0);
            this.Controls.SetChildIndex(this.lblColor, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibreriaClases.SWTextbox swtDescOpcio;
        private System.Windows.Forms.Label lblDescOpcio;
        private System.Windows.Forms.Label lblEnsamblat;
        private LibreriaClases.SWTextbox swtEnsamblat;
        private System.Windows.Forms.Label lblClasse;
        private LibreriaClases.SWTextbox swtClasse;
        private System.Windows.Forms.Label lblNivell;
        private LibreriaClases.SWTextbox swtNivell;
        private System.Windows.Forms.Label lblFoto;
        private LibreriaClases.SWTextbox swtFoto;
        private System.Windows.Forms.Label lblColor;
        private LibreriaClases.SWTextbox swtColor;
    }
}