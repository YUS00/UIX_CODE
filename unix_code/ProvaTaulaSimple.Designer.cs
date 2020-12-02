namespace UnixCode
{
    partial class ProvaTaulaSimple
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.swTextbox1 = new LibreriaClases.SWTextbox();
            this.swTextbox2 = new LibreriaClases.SWTextbox();
            this.cmbRank = new LibreriaControles.UIXCombobox();
            this.lblRank = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new LibreriaControles.UIXCombobox();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.cmbSpecies = new LibreriaControles.UIXCombobox();
            this.lblPlanet = new System.Windows.Forms.Label();
            this.cmbPlanet = new LibreriaControles.UIXCombobox();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(47, 157);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(89, 17);
            this.lblUsername.TabIndex = 31;
            this.lblUsername.Text = "USERNAME:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.BackColor = System.Drawing.Color.Transparent;
            this.lblCode.ForeColor = System.Drawing.Color.White;
            this.lblCode.Location = new System.Drawing.Point(47, 99);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(51, 17);
            this.lblCode.TabIndex = 30;
            this.lblCode.Text = "CODE:";
            // 
            // swTextbox1
            // 
            this.swTextbox1.Campo_obligatorio = false;
            this.swTextbox1.CampoBBDD = "CodeUser";
            this.swTextbox1.ForeignKey = false;
            this.swTextbox1.Location = new System.Drawing.Point(145, 99);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.Size = new System.Drawing.Size(177, 22);
            this.swTextbox1.TabIndex = 32;
            this.swTextbox1.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Texto;
            // 
            // swTextbox2
            // 
            this.swTextbox2.Campo_obligatorio = false;
            this.swTextbox2.CampoBBDD = "UserName";
            this.swTextbox2.ForeignKey = false;
            this.swTextbox2.Location = new System.Drawing.Point(145, 157);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.Size = new System.Drawing.Size(177, 22);
            this.swTextbox2.TabIndex = 33;
            this.swTextbox2.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Texto;
            // 
            // cmbRank
            // 
            this.cmbRank.CampID = "idUserRank";
            this.cmbRank.CampMostrar = "DescRank";
            this.cmbRank.CampoBBDD = "idUserRank";
            this.cmbRank.ControlId = null;
            this.cmbRank.FormattingEnabled = true;
            this.cmbRank.Location = new System.Drawing.Point(145, 218);
            this.cmbRank.Name = "cmbRank";
            this.cmbRank.Size = new System.Drawing.Size(121, 24);
            this.cmbRank.TabIndex = 34;
            this.cmbRank.TaulaForanea = "UserRanks";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.BackColor = System.Drawing.Color.Transparent;
            this.lblRank.ForeColor = System.Drawing.Color.White;
            this.lblRank.Location = new System.Drawing.Point(49, 221);
            this.lblRank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(50, 17);
            this.lblRank.TabIndex = 35;
            this.lblRank.Text = "RANK:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(420, 104);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(89, 17);
            this.lblCategory.TabIndex = 37;
            this.lblCategory.Text = "CATEGORY:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.CampID = "idUserCategory";
            this.cmbCategory.CampMostrar = "DescCategory";
            this.cmbCategory.CampoBBDD = "idUserCategory";
            this.cmbCategory.ControlId = null;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(516, 101);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 24);
            this.cmbCategory.TabIndex = 36;
            this.cmbCategory.TaulaForanea = "UserCategories";
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.BackColor = System.Drawing.Color.Transparent;
            this.lblSpecies.ForeColor = System.Drawing.Color.White;
            this.lblSpecies.Location = new System.Drawing.Point(420, 162);
            this.lblSpecies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(69, 17);
            this.lblSpecies.TabIndex = 39;
            this.lblSpecies.Text = "SPECIES:";
            // 
            // cmbSpecies
            // 
            this.cmbSpecies.CampID = "idSpecie";
            this.cmbSpecies.CampMostrar = "DescSpecie";
            this.cmbSpecies.CampoBBDD = "idSpecie";
            this.cmbSpecies.ControlId = null;
            this.cmbSpecies.FormattingEnabled = true;
            this.cmbSpecies.Location = new System.Drawing.Point(516, 159);
            this.cmbSpecies.Name = "cmbSpecies";
            this.cmbSpecies.Size = new System.Drawing.Size(121, 24);
            this.cmbSpecies.TabIndex = 38;
            this.cmbSpecies.TaulaForanea = "Species";
            // 
            // lblPlanet
            // 
            this.lblPlanet.AutoSize = true;
            this.lblPlanet.BackColor = System.Drawing.Color.Transparent;
            this.lblPlanet.ForeColor = System.Drawing.Color.White;
            this.lblPlanet.Location = new System.Drawing.Point(420, 225);
            this.lblPlanet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlanet.Name = "lblPlanet";
            this.lblPlanet.Size = new System.Drawing.Size(66, 17);
            this.lblPlanet.TabIndex = 41;
            this.lblPlanet.Text = "PLANET:";
            // 
            // cmbPlanet
            // 
            this.cmbPlanet.CampID = "idPlanet";
            this.cmbPlanet.CampMostrar = "DescPlanet";
            this.cmbPlanet.CampoBBDD = "idPlanet";
            this.cmbPlanet.ControlId = null;
            this.cmbPlanet.FormattingEnabled = true;
            this.cmbPlanet.Location = new System.Drawing.Point(516, 222);
            this.cmbPlanet.Name = "cmbPlanet";
            this.cmbPlanet.Size = new System.Drawing.Size(121, 24);
            this.cmbPlanet.TabIndex = 40;
            this.cmbPlanet.TaulaForanea = "Planets";
            // 
            // ProvaTaulaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 575);
            this.Controls.Add(this.lblPlanet);
            this.Controls.Add(this.cmbPlanet);
            this.Controls.Add(this.lblSpecies);
            this.Controls.Add(this.cmbSpecies);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.cmbRank);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.swTextbox1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblCode);
            this.Name = "ProvaTaulaSimple";
            this.Taula = "Users";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.lblCode, 0);
            this.Controls.SetChildIndex(this.lblUsername, 0);
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.Controls.SetChildIndex(this.swTextbox2, 0);
            this.Controls.SetChildIndex(this.cmbRank, 0);
            this.Controls.SetChildIndex(this.lblRank, 0);
            this.Controls.SetChildIndex(this.cmbCategory, 0);
            this.Controls.SetChildIndex(this.lblCategory, 0);
            this.Controls.SetChildIndex(this.cmbSpecies, 0);
            this.Controls.SetChildIndex(this.lblSpecies, 0);
            this.Controls.SetChildIndex(this.cmbPlanet, 0);
            this.Controls.SetChildIndex(this.lblPlanet, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblCode;
        private LibreriaClases.SWTextbox swTextbox1;
        private LibreriaClases.SWTextbox swTextbox2;
        private LibreriaControles.UIXCombobox cmbRank;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label lblCategory;
        private LibreriaControles.UIXCombobox cmbCategory;
        private System.Windows.Forms.Label lblSpecies;
        private LibreriaControles.UIXCombobox cmbSpecies;
        private System.Windows.Forms.Label lblPlanet;
        private LibreriaControles.UIXCombobox cmbPlanet;
    }
}