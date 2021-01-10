namespace G7_Planets
{
    partial class frmPlanets
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
            this.swtCodePlanet = new LibreriaClases.SWTextbox();
            this.swtDescPlanet = new LibreriaClases.SWTextbox();
            this.lblCodePlanet = new System.Windows.Forms.Label();
            this.lblDescPlanet = new System.Windows.Forms.Label();
            this.cbxIdSector = new LibreriaControles.UIXCombobox();
            this.lblSector = new System.Windows.Forms.Label();
            this.lblLongitud = new System.Windows.Forms.Label();
            this.swtLong = new LibreriaClases.SWTextbox();
            this.lblLat = new System.Windows.Forms.Label();
            this.swtLat = new LibreriaClases.SWTextbox();
            this.lblParsecs = new System.Windows.Forms.Label();
            this.swTextbox2 = new LibreriaClases.SWTextbox();
            this.lblIdNatives = new System.Windows.Forms.Label();
            this.cbxIdNatives = new LibreriaControles.UIXCombobox();
            this.lblIdFiliation = new System.Windows.Forms.Label();
            this.cbxIdFiliation = new LibreriaControles.UIXCombobox();
            this.SuspendLayout();
            // 
            // swtCodePlanet
            // 
            this.swtCodePlanet.Campo_obligatorio = false;
            this.swtCodePlanet.CampoBBDD = "CodePlanet";
            this.swtCodePlanet.ForeignKey = false;
            this.swtCodePlanet.Location = new System.Drawing.Point(165, 112);
            this.swtCodePlanet.Name = "swtCodePlanet";
            this.swtCodePlanet.Size = new System.Drawing.Size(153, 22);
            this.swtCodePlanet.TabIndex = 16;
            this.swtCodePlanet.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Texto;
            // 
            // swtDescPlanet
            // 
            this.swtDescPlanet.Campo_obligatorio = false;
            this.swtDescPlanet.CampoBBDD = "DescPlanet";
            this.swtDescPlanet.ForeignKey = false;
            this.swtDescPlanet.Location = new System.Drawing.Point(165, 160);
            this.swtDescPlanet.Name = "swtDescPlanet";
            this.swtDescPlanet.Size = new System.Drawing.Size(153, 22);
            this.swtDescPlanet.TabIndex = 17;
            this.swtDescPlanet.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Texto;
            // 
            // lblCodePlanet
            // 
            this.lblCodePlanet.AutoSize = true;
            this.lblCodePlanet.BackColor = System.Drawing.Color.Transparent;
            this.lblCodePlanet.ForeColor = System.Drawing.Color.White;
            this.lblCodePlanet.Location = new System.Drawing.Point(71, 117);
            this.lblCodePlanet.Name = "lblCodePlanet";
            this.lblCodePlanet.Size = new System.Drawing.Size(55, 17);
            this.lblCodePlanet.TabIndex = 19;
            this.lblCodePlanet.Text = "CODE: ";
            // 
            // lblDescPlanet
            // 
            this.lblDescPlanet.AutoSize = true;
            this.lblDescPlanet.BackColor = System.Drawing.Color.Transparent;
            this.lblDescPlanet.ForeColor = System.Drawing.Color.White;
            this.lblDescPlanet.Location = new System.Drawing.Point(28, 165);
            this.lblDescPlanet.Name = "lblDescPlanet";
            this.lblDescPlanet.Size = new System.Drawing.Size(98, 17);
            this.lblDescPlanet.TabIndex = 20;
            this.lblDescPlanet.Text = "DESCRIPCIO: ";
            // 
            // cbxIdSector
            // 
            this.cbxIdSector.CampID = "idSector";
            this.cbxIdSector.CampMostrar = "DescSector";
            this.cbxIdSector.CampoBBDD = "idSector";
            this.cbxIdSector.ControlId = null;
            this.cbxIdSector.FormattingEnabled = true;
            this.cbxIdSector.Location = new System.Drawing.Point(165, 207);
            this.cbxIdSector.Name = "cbxIdSector";
            this.cbxIdSector.Size = new System.Drawing.Size(121, 24);
            this.cbxIdSector.TabIndex = 21;
            this.cbxIdSector.TaulaForanea = "Sectors";
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.BackColor = System.Drawing.Color.Transparent;
            this.lblSector.ForeColor = System.Drawing.Color.White;
            this.lblSector.Location = new System.Drawing.Point(47, 210);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(69, 17);
            this.lblSector.TabIndex = 22;
            this.lblSector.Text = "SECTOR:";
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.BackColor = System.Drawing.Color.Transparent;
            this.lblLongitud.ForeColor = System.Drawing.Color.White;
            this.lblLongitud.Location = new System.Drawing.Point(32, 256);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(84, 17);
            this.lblLongitud.TabIndex = 24;
            this.lblLongitud.Text = "LONGITUD:";
            // 
            // swtLong
            // 
            this.swtLong.Campo_obligatorio = false;
            this.swtLong.CampoBBDD = "long";
            this.swtLong.ForeignKey = false;
            this.swtLong.Location = new System.Drawing.Point(165, 253);
            this.swtLong.Name = "swtLong";
            this.swtLong.Size = new System.Drawing.Size(153, 22);
            this.swtLong.TabIndex = 23;
            this.swtLong.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Numero;
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.BackColor = System.Drawing.Color.Transparent;
            this.lblLat.ForeColor = System.Drawing.Color.White;
            this.lblLat.Location = new System.Drawing.Point(490, 115);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(70, 17);
            this.lblLat.TabIndex = 26;
            this.lblLat.Text = "LATITUD:";
            // 
            // swtLat
            // 
            this.swtLat.Campo_obligatorio = false;
            this.swtLat.CampoBBDD = "lat";
            this.swtLat.ForeignKey = false;
            this.swtLat.Location = new System.Drawing.Point(617, 112);
            this.swtLat.Name = "swtLat";
            this.swtLat.Size = new System.Drawing.Size(153, 22);
            this.swtLat.TabIndex = 25;
            this.swtLat.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Numero;
            // 
            // lblParsecs
            // 
            this.lblParsecs.AutoSize = true;
            this.lblParsecs.BackColor = System.Drawing.Color.Transparent;
            this.lblParsecs.ForeColor = System.Drawing.Color.White;
            this.lblParsecs.Location = new System.Drawing.Point(484, 163);
            this.lblParsecs.Name = "lblParsecs";
            this.lblParsecs.Size = new System.Drawing.Size(76, 17);
            this.lblParsecs.TabIndex = 28;
            this.lblParsecs.Text = "PARSECS:";
            // 
            // swTextbox2
            // 
            this.swTextbox2.Campo_obligatorio = false;
            this.swTextbox2.CampoBBDD = "parsecs";
            this.swTextbox2.ForeignKey = false;
            this.swTextbox2.Location = new System.Drawing.Point(617, 160);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.Size = new System.Drawing.Size(153, 22);
            this.swTextbox2.TabIndex = 27;
            this.swTextbox2.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Numero;
            // 
            // lblIdNatives
            // 
            this.lblIdNatives.AutoSize = true;
            this.lblIdNatives.BackColor = System.Drawing.Color.Transparent;
            this.lblIdNatives.ForeColor = System.Drawing.Color.White;
            this.lblIdNatives.Location = new System.Drawing.Point(497, 213);
            this.lblIdNatives.Name = "lblIdNatives";
            this.lblIdNatives.Size = new System.Drawing.Size(63, 17);
            this.lblIdNatives.TabIndex = 30;
            this.lblIdNatives.Text = "NADIUS:";
            // 
            // cbxIdNatives
            // 
            this.cbxIdNatives.CampID = "idSpecie";
            this.cbxIdNatives.CampMostrar = "DescSpecie";
            this.cbxIdNatives.CampoBBDD = "idNatives";
            this.cbxIdNatives.ControlId = null;
            this.cbxIdNatives.FormattingEnabled = true;
            this.cbxIdNatives.Location = new System.Drawing.Point(617, 210);
            this.cbxIdNatives.Name = "cbxIdNatives";
            this.cbxIdNatives.Size = new System.Drawing.Size(121, 24);
            this.cbxIdNatives.TabIndex = 29;
            this.cbxIdNatives.TaulaForanea = "Species";
            // 
            // lblIdFiliation
            // 
            this.lblIdFiliation.AutoSize = true;
            this.lblIdFiliation.BackColor = System.Drawing.Color.Transparent;
            this.lblIdFiliation.ForeColor = System.Drawing.Color.White;
            this.lblIdFiliation.Location = new System.Drawing.Point(478, 259);
            this.lblIdFiliation.Name = "lblIdFiliation";
            this.lblIdFiliation.Size = new System.Drawing.Size(82, 17);
            this.lblIdFiliation.TabIndex = 32;
            this.lblIdFiliation.Text = "FIL·LIACIÓ: ";
            // 
            // cbxIdFiliation
            // 
            this.cbxIdFiliation.CampID = "idFiliation";
            this.cbxIdFiliation.CampMostrar = "DescFiliations";
            this.cbxIdFiliation.CampoBBDD = "idFiliation";
            this.cbxIdFiliation.ControlId = null;
            this.cbxIdFiliation.FormattingEnabled = true;
            this.cbxIdFiliation.Location = new System.Drawing.Point(617, 256);
            this.cbxIdFiliation.Name = "cbxIdFiliation";
            this.cbxIdFiliation.Size = new System.Drawing.Size(121, 24);
            this.cbxIdFiliation.TabIndex = 31;
            this.cbxIdFiliation.TaulaForanea = "Filiations";
            // 
            // frmPlanets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 558);
            this.Controls.Add(this.lblIdFiliation);
            this.Controls.Add(this.cbxIdFiliation);
            this.Controls.Add(this.lblIdNatives);
            this.Controls.Add(this.cbxIdNatives);
            this.Controls.Add(this.lblParsecs);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.lblLat);
            this.Controls.Add(this.swtLat);
            this.Controls.Add(this.lblLongitud);
            this.Controls.Add(this.swtLong);
            this.Controls.Add(this.lblSector);
            this.Controls.Add(this.cbxIdSector);
            this.Controls.Add(this.lblDescPlanet);
            this.Controls.Add(this.lblCodePlanet);
            this.Controls.Add(this.swtDescPlanet);
            this.Controls.Add(this.swtCodePlanet);
            this.Name = "frmPlanets";
            this.Taula = "Planets";
            this.Text = "frmPlanets";
            this.Controls.SetChildIndex(this.swtCodePlanet, 0);
            this.Controls.SetChildIndex(this.swtDescPlanet, 0);
            this.Controls.SetChildIndex(this.lblCodePlanet, 0);
            this.Controls.SetChildIndex(this.lblDescPlanet, 0);
            this.Controls.SetChildIndex(this.cbxIdSector, 0);
            this.Controls.SetChildIndex(this.lblSector, 0);
            this.Controls.SetChildIndex(this.swtLong, 0);
            this.Controls.SetChildIndex(this.lblLongitud, 0);
            this.Controls.SetChildIndex(this.swtLat, 0);
            this.Controls.SetChildIndex(this.lblLat, 0);
            this.Controls.SetChildIndex(this.swTextbox2, 0);
            this.Controls.SetChildIndex(this.lblParsecs, 0);
            this.Controls.SetChildIndex(this.cbxIdNatives, 0);
            this.Controls.SetChildIndex(this.lblIdNatives, 0);
            this.Controls.SetChildIndex(this.cbxIdFiliation, 0);
            this.Controls.SetChildIndex(this.lblIdFiliation, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LibreriaClases.SWTextbox swtCodePlanet;
        private LibreriaClases.SWTextbox swtDescPlanet;
        private System.Windows.Forms.Label lblCodePlanet;
        private System.Windows.Forms.Label lblDescPlanet;
        private LibreriaControles.UIXCombobox cbxIdSector;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.Label lblLongitud;
        private LibreriaClases.SWTextbox swtLong;
        private System.Windows.Forms.Label lblLat;
        private LibreriaClases.SWTextbox swtLat;
        private System.Windows.Forms.Label lblParsecs;
        private LibreriaClases.SWTextbox swTextbox2;
        private System.Windows.Forms.Label lblIdNatives;
        private LibreriaControles.UIXCombobox cbxIdNatives;
        private System.Windows.Forms.Label lblIdFiliation;
        private LibreriaControles.UIXCombobox cbxIdFiliation;
    }
}