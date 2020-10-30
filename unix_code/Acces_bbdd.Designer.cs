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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.codi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codiBox = new System.Windows.Forms.TextBox();
            this.agenciaBox = new System.Windows.Forms.TextBox();
            this.MostrarDades_btn = new System.Windows.Forms.Button();
            this.class11 = new Controls.Class1();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // actDades_btn
            // 
            this.actDades_btn.Location = new System.Drawing.Point(690, 394);
            this.actDades_btn.Name = "actDades_btn";
            this.actDades_btn.Size = new System.Drawing.Size(99, 23);
            this.actDades_btn.TabIndex = 16;
            this.actDades_btn.Text = "Actualitzar Dades";
            this.actDades_btn.UseVisualStyleBackColor = true;
            this.actDades_btn.Click += new System.EventHandler(this.actDades_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(85, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 91);
            this.panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(255, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accés a Dades";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.Indigo;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(128, 144);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(658, 131);
            this.dataGridView.TabIndex = 26;
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
            // 
            // codi
            // 
            this.codi.AutoSize = true;
            this.codi.BackColor = System.Drawing.Color.Transparent;
            this.codi.ForeColor = System.Drawing.Color.White;
            this.codi.Location = new System.Drawing.Point(125, 356);
            this.codi.Name = "codi";
            this.codi.Size = new System.Drawing.Size(36, 13);
            this.codi.TabIndex = 27;
            this.codi.Text = "CODI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(125, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "AGENCIA:";
            // 
            // codiBox
            // 
            this.codiBox.Location = new System.Drawing.Point(197, 354);
            this.codiBox.Name = "codiBox";
            this.codiBox.Size = new System.Drawing.Size(100, 20);
            this.codiBox.TabIndex = 30;
            this.codiBox.Tag = "CodeAgency";
            // 
            // agenciaBox
            // 
            this.agenciaBox.Location = new System.Drawing.Point(197, 396);
            this.agenciaBox.Name = "agenciaBox";
            this.agenciaBox.Size = new System.Drawing.Size(180, 20);
            this.agenciaBox.TabIndex = 31;
            this.agenciaBox.Tag = "DescAgency";
            // 
            // MostrarDades_btn
            // 
            this.MostrarDades_btn.Location = new System.Drawing.Point(690, 365);
            this.MostrarDades_btn.Name = "MostrarDades_btn";
            this.MostrarDades_btn.Size = new System.Drawing.Size(99, 23);
            this.MostrarDades_btn.TabIndex = 15;
            this.MostrarDades_btn.Text = "Mostrar Dades";
            this.MostrarDades_btn.UseVisualStyleBackColor = true;
            this.MostrarDades_btn.Click += new System.EventHandler(this.MostrarDades_Click);
            // 
            // class11
            // 
            this.class11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("class11.BackgroundImage")));
            this.class11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.class11.Location = new System.Drawing.Point(873, 3);
            this.class11.Name = "class11";
            this.class11.Size = new System.Drawing.Size(27, 25);
            this.class11.TabIndex = 34;
            this.class11.UseVisualStyleBackColor = true;
            // 
            // Acces_bbdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 479);
            this.Controls.Add(this.class11);
            this.Controls.Add(this.agenciaBox);
            this.Controls.Add(this.codiBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.codi);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.actDades_btn);
            this.Controls.Add(this.MostrarDades_btn);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Acces_bbdd";
            this.Text = "Acces_bbdd";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button actDades_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label codi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codiBox;
        private System.Windows.Forms.TextBox agenciaBox;
        private System.Windows.Forms.Button MostrarDades_btn;
        private Controls.Class1 class11;
    }
}