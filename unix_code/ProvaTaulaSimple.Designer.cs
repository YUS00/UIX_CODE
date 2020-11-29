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
            this.label2 = new System.Windows.Forms.Label();
            this.codi = new System.Windows.Forms.Label();
            this.swTextbox1 = new LibreriaClases.SWTextbox();
            this.swTextbox2 = new LibreriaClases.SWTextbox();
            this.uixCombobox1 = new LibreriaControles.UIXCombobox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "USERNAME:";
            // 
            // codi
            // 
            this.codi.AutoSize = true;
            this.codi.BackColor = System.Drawing.Color.Transparent;
            this.codi.ForeColor = System.Drawing.Color.White;
            this.codi.Location = new System.Drawing.Point(47, 99);
            this.codi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codi.Name = "codi";
            this.codi.Size = new System.Drawing.Size(45, 17);
            this.codi.TabIndex = 30;
            this.codi.Text = "CODI:";
            // 
            // swTextbox1
            // 
            this.swTextbox1.Campo_obligatorio = false;
            this.swTextbox1.CampoBBDD = "CodeUser";
            this.swTextbox1.ForeignKey = false;
            this.swTextbox1.Location = new System.Drawing.Point(145, 99);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.Size = new System.Drawing.Size(147, 22);
            this.swTextbox1.TabIndex = 32;
            this.swTextbox1.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Numero;
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
            // uixCombobox1
            // 
            this.uixCombobox1.CampID = "idSpecie";
            this.uixCombobox1.CampMostrar = "DescSpecie";
            this.uixCombobox1.CampoBBDD = "idSpecie";
            this.uixCombobox1.ControlId = null;
            this.uixCombobox1.FormattingEnabled = true;
            this.uixCombobox1.Location = new System.Drawing.Point(145, 228);
            this.uixCombobox1.Name = "uixCombobox1";
            this.uixCombobox1.Size = new System.Drawing.Size(121, 24);
            this.uixCombobox1.TabIndex = 34;
            this.uixCombobox1.TaulaForanea = "Species";
            // 
            // ProvaTaulaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 450);
            this.Controls.Add(this.uixCombobox1);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.swTextbox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codi);
            this.Name = "ProvaTaulaSimple";
            this.Taula = "Users";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.codi, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.Controls.SetChildIndex(this.swTextbox2, 0);
            this.Controls.SetChildIndex(this.uixCombobox1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label codi;
        private LibreriaClases.SWTextbox swTextbox1;
        private LibreriaClases.SWTextbox swTextbox2;
        private LibreriaControles.UIXCombobox uixCombobox1;
    }
}