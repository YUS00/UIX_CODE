namespace unix_code
{
    partial class Acces_bbdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acces_bbdd));
            this.actDades_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.codi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codiBox = new System.Windows.Forms.TextBox();
            this.agenciaBox = new System.Windows.Forms.TextBox();
            this.MostrarDades_btn = new System.Windows.Forms.Button();
            this.txtExecuta = new System.Windows.Forms.TextBox();
            this.btnExecuta = new System.Windows.Forms.Button();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.cerrarsesion_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCombo = new System.Windows.Forms.TextBox();
            this.uixCombobox1 = new LibreriaControles.UIXCombobox();
            this.llencaAplicacions1 = new LibreriaClases.LlencaAplicacions();
            this.class11 = new Controls.Class1();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // actDades_btn
            // 
            this.actDades_btn.Location = new System.Drawing.Point(575, 460);
            this.actDades_btn.Margin = new System.Windows.Forms.Padding(4);
            this.actDades_btn.Name = "actDades_btn";
            this.actDades_btn.Size = new System.Drawing.Size(132, 28);
            this.actDades_btn.TabIndex = 16;
            this.actDades_btn.Text = "Actualitzar Dades";
            this.actDades_btn.UseVisualStyleBackColor = true;
            this.actDades_btn.Click += new System.EventHandler(this.actDades_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(343, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accés a Dades";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.Indigo;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(51, 102);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(877, 161);
            this.dataGridView.TabIndex = 26;
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
            // 
            // codi
            // 
            this.codi.AutoSize = true;
            this.codi.BackColor = System.Drawing.Color.Transparent;
            this.codi.ForeColor = System.Drawing.Color.White;
            this.codi.Location = new System.Drawing.Point(52, 338);
            this.codi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codi.Name = "codi";
            this.codi.Size = new System.Drawing.Size(45, 17);
            this.codi.TabIndex = 27;
            this.codi.Text = "CODI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 396);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "AGENCIA:";
            // 
            // codiBox
            // 
            this.codiBox.Location = new System.Drawing.Point(169, 336);
            this.codiBox.Margin = new System.Windows.Forms.Padding(4);
            this.codiBox.Name = "codiBox";
            this.codiBox.Size = new System.Drawing.Size(132, 22);
            this.codiBox.TabIndex = 30;
            this.codiBox.Tag = "CodeAgency";
            // 
            // agenciaBox
            // 
            this.agenciaBox.Location = new System.Drawing.Point(169, 394);
            this.agenciaBox.Margin = new System.Windows.Forms.Padding(4);
            this.agenciaBox.Name = "agenciaBox";
            this.agenciaBox.Size = new System.Drawing.Size(239, 22);
            this.agenciaBox.TabIndex = 31;
            this.agenciaBox.Tag = "DescAgency";
            // 
            // MostrarDades_btn
            // 
            this.MostrarDades_btn.Location = new System.Drawing.Point(235, 460);
            this.MostrarDades_btn.Margin = new System.Windows.Forms.Padding(4);
            this.MostrarDades_btn.Name = "MostrarDades_btn";
            this.MostrarDades_btn.Size = new System.Drawing.Size(132, 28);
            this.MostrarDades_btn.TabIndex = 15;
            this.MostrarDades_btn.Text = "Mostrar Dades";
            this.MostrarDades_btn.UseVisualStyleBackColor = true;
            this.MostrarDades_btn.Click += new System.EventHandler(this.MostrarDades_Click);
            // 
            // txtExecuta
            // 
            this.txtExecuta.Location = new System.Drawing.Point(169, 273);
            this.txtExecuta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExecuta.Multiline = true;
            this.txtExecuta.Name = "txtExecuta";
            this.txtExecuta.Size = new System.Drawing.Size(481, 45);
            this.txtExecuta.TabIndex = 33;
            // 
            // btnExecuta
            // 
            this.btnExecuta.Location = new System.Drawing.Point(399, 460);
            this.btnExecuta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExecuta.Name = "btnExecuta";
            this.btnExecuta.Size = new System.Drawing.Size(151, 37);
            this.btnExecuta.TabIndex = 34;
            this.btnExecuta.Text = "Executa sentencia";
            this.btnExecuta.UseVisualStyleBackColor = true;
            this.btnExecuta.Click += new System.EventHandler(this.btnExecuta_Click);
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.BackColor = System.Drawing.Color.Transparent;
            this.lblConsulta.ForeColor = System.Drawing.Color.White;
            this.lblConsulta.Location = new System.Drawing.Point(52, 283);
            this.lblConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(89, 17);
            this.lblConsulta.TabIndex = 35;
            this.lblConsulta.Text = "SENTENCIA:";
            // 
            // cerrarsesion_btn
            // 
            this.cerrarsesion_btn.BackColor = System.Drawing.Color.Black;
            this.cerrarsesion_btn.FlatAppearance.BorderSize = 2;
            this.cerrarsesion_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarsesion_btn.Font = new System.Drawing.Font("Arial", 8.25F);
            this.cerrarsesion_btn.ForeColor = System.Drawing.Color.White;
            this.cerrarsesion_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cerrarsesion_btn.Location = new System.Drawing.Point(833, 505);
            this.cerrarsesion_btn.Margin = new System.Windows.Forms.Padding(0);
            this.cerrarsesion_btn.Name = "cerrarsesion_btn";
            this.cerrarsesion_btn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cerrarsesion_btn.Size = new System.Drawing.Size(117, 33);
            this.cerrarsesion_btn.TabIndex = 37;
            this.cerrarsesion_btn.Text = "Cerrar sesion";
            this.cerrarsesion_btn.UseVisualStyleBackColor = false;
            this.cerrarsesion_btn.Click += new System.EventHandler(this.cerrarsesion_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCombo
            // 
            this.txtCombo.Location = new System.Drawing.Point(807, 333);
            this.txtCombo.Name = "txtCombo";
            this.txtCombo.Size = new System.Drawing.Size(100, 22);
            this.txtCombo.TabIndex = 41;
            // 
            // uixCombobox1
            // 
            this.uixCombobox1.CampID = "iduser";
            this.uixCombobox1.CampMostrar = "codeuser";
            this.uixCombobox1.ControlId = "txtCombo";
            this.uixCombobox1.FormattingEnabled = true;
            this.uixCombobox1.Location = new System.Drawing.Point(657, 336);
            this.uixCombobox1.Name = "uixCombobox1";
            this.uixCombobox1.Size = new System.Drawing.Size(121, 24);
            this.uixCombobox1.TabIndex = 42;
            // 
            // llencaAplicacions1
            // 
            this.llencaAplicacions1.Classe = "ClasseColors.dll";
            this.llencaAplicacions1.Form = "ClasseColors.frmBlau";
            this.llencaAplicacions1.Location = new System.Drawing.Point(766, 380);
            this.llencaAplicacions1.Name = "llencaAplicacions1";
            this.llencaAplicacions1.Size = new System.Drawing.Size(75, 23);
            this.llencaAplicacions1.TabIndex = 38;
            this.llencaAplicacions1.Text = "llencaAplicacions1";
            this.llencaAplicacions1.UseVisualStyleBackColor = true;
            // 
            // class11
            // 
            this.class11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("class11.BackgroundImage")));
            this.class11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.class11.Location = new System.Drawing.Point(913, 15);
            this.class11.Margin = new System.Windows.Forms.Padding(4);
            this.class11.Name = "class11";
            this.class11.Size = new System.Drawing.Size(33, 25);
            this.class11.TabIndex = 36;
            this.class11.UseVisualStyleBackColor = true;
            // 
            // Acces_bbdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 549);
            this.Controls.Add(this.uixCombobox1);
            this.Controls.Add(this.txtCombo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.llencaAplicacions1);
            this.Controls.Add(this.cerrarsesion_btn);
            this.Controls.Add(this.class11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.btnExecuta);
            this.Controls.Add(this.txtExecuta);
            this.Controls.Add(this.agenciaBox);
            this.Controls.Add(this.codiBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codi);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.actDades_btn);
            this.Controls.Add(this.MostrarDades_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Acces_bbdd";
            this.Text = "Acces_bbdd";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button actDades_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label codi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codiBox;
        private System.Windows.Forms.TextBox agenciaBox;
        private System.Windows.Forms.Button MostrarDades_btn;
        private System.Windows.Forms.TextBox txtExecuta;
        private System.Windows.Forms.Button btnExecuta;
        private System.Windows.Forms.Label lblConsulta;
        private Controls.Class1 class11;
        private System.Windows.Forms.Button cerrarsesion_btn;
        private LibreriaClases.LlencaAplicacions llencaAplicacions1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCombo;
        private LibreriaControles.UIXCombobox uixCombobox1;
    }
}