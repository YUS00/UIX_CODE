namespace UnixCode
{
    partial class FormBase
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtExecuta = new System.Windows.Forms.TextBox();
            this.codiBox = new System.Windows.Forms.TextBox();
            this.agenciaBox = new System.Windows.Forms.TextBox();
            this.MostrarDades_btn = new System.Windows.Forms.Button();
            this.btnExecuta = new System.Windows.Forms.Button();
            this.actDades_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.uixCombobox1 = new LibreriaControles.UIXCombobox();
            this.txtCombo = new System.Windows.Forms.TextBox();
            this.llencaAplicacions1 = new LibreriaClases.LlencaAplicacions();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.Indigo;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(33, 82);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(877, 161);
            this.dataGridView.TabIndex = 27;
            // 
            // txtExecuta
            // 
            this.txtExecuta.Location = new System.Drawing.Point(33, 262);
            this.txtExecuta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExecuta.Multiline = true;
            this.txtExecuta.Name = "txtExecuta";
            this.txtExecuta.Size = new System.Drawing.Size(481, 45);
            this.txtExecuta.TabIndex = 34;
            // 
            // codiBox
            // 
            this.codiBox.Location = new System.Drawing.Point(33, 332);
            this.codiBox.Margin = new System.Windows.Forms.Padding(4);
            this.codiBox.Name = "codiBox";
            this.codiBox.Size = new System.Drawing.Size(132, 22);
            this.codiBox.TabIndex = 35;
            this.codiBox.Tag = "CodeAgency";
            // 
            // agenciaBox
            // 
            this.agenciaBox.Location = new System.Drawing.Point(33, 386);
            this.agenciaBox.Margin = new System.Windows.Forms.Padding(4);
            this.agenciaBox.Name = "agenciaBox";
            this.agenciaBox.Size = new System.Drawing.Size(239, 22);
            this.agenciaBox.TabIndex = 36;
            this.agenciaBox.Tag = "DescAgency";
            // 
            // MostrarDades_btn
            // 
            this.MostrarDades_btn.Location = new System.Drawing.Point(282, 427);
            this.MostrarDades_btn.Margin = new System.Windows.Forms.Padding(4);
            this.MostrarDades_btn.Name = "MostrarDades_btn";
            this.MostrarDades_btn.Size = new System.Drawing.Size(132, 28);
            this.MostrarDades_btn.TabIndex = 37;
            this.MostrarDades_btn.Text = "Mostrar Dades";
            this.MostrarDades_btn.UseVisualStyleBackColor = true;
            // 
            // btnExecuta
            // 
            this.btnExecuta.Location = new System.Drawing.Point(432, 418);
            this.btnExecuta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExecuta.Name = "btnExecuta";
            this.btnExecuta.Size = new System.Drawing.Size(151, 37);
            this.btnExecuta.TabIndex = 38;
            this.btnExecuta.Text = "Executa sentencia";
            this.btnExecuta.UseVisualStyleBackColor = true;
            // 
            // actDades_btn
            // 
            this.actDades_btn.Location = new System.Drawing.Point(604, 427);
            this.actDades_btn.Margin = new System.Windows.Forms.Padding(4);
            this.actDades_btn.Name = "actDades_btn";
            this.actDades_btn.Size = new System.Drawing.Size(132, 28);
            this.actDades_btn.TabIndex = 39;
            this.actDades_btn.Text = "Actualitzar Dades";
            this.actDades_btn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(604, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // uixCombobox1
            // 
            this.uixCombobox1.CampID = "iduser";
            this.uixCombobox1.CampMostrar = "codeuser";
            this.uixCombobox1.ControlId = "txtCombo";
            this.uixCombobox1.FormattingEnabled = true;
            this.uixCombobox1.Location = new System.Drawing.Point(685, 284);
            this.uixCombobox1.Name = "uixCombobox1";
            this.uixCombobox1.Size = new System.Drawing.Size(121, 24);
            this.uixCombobox1.TabIndex = 43;
            // 
            // txtCombo
            // 
            this.txtCombo.Location = new System.Drawing.Point(836, 286);
            this.txtCombo.Name = "txtCombo";
            this.txtCombo.Size = new System.Drawing.Size(100, 22);
            this.txtCombo.TabIndex = 44;
            // 
            // llencaAplicacions1
            // 
            this.llencaAplicacions1.Classe = "ClasseColors.dll";
            this.llencaAplicacions1.Form = "ClasseColors.frmBlau";
            this.llencaAplicacions1.Location = new System.Drawing.Point(783, 331);
            this.llencaAplicacions1.Name = "llencaAplicacions1";
            this.llencaAplicacions1.Size = new System.Drawing.Size(75, 23);
            this.llencaAplicacions1.TabIndex = 45;
            this.llencaAplicacions1.Text = "llencaAplicacions1";
            this.llencaAplicacions1.UseVisualStyleBackColor = true;
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(963, 479);
            this.Controls.Add(this.llencaAplicacions1);
            this.Controls.Add(this.txtCombo);
            this.Controls.Add(this.uixCombobox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.actDades_btn);
            this.Controls.Add(this.btnExecuta);
            this.Controls.Add(this.MostrarDades_btn);
            this.Controls.Add(this.agenciaBox);
            this.Controls.Add(this.codiBox);
            this.Controls.Add(this.txtExecuta);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormBase";
            this.Controls.SetChildIndex(this.dataGridView, 0);
            this.Controls.SetChildIndex(this.txtExecuta, 0);
            this.Controls.SetChildIndex(this.codiBox, 0);
            this.Controls.SetChildIndex(this.agenciaBox, 0);
            this.Controls.SetChildIndex(this.MostrarDades_btn, 0);
            this.Controls.SetChildIndex(this.btnExecuta, 0);
            this.Controls.SetChildIndex(this.actDades_btn, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.uixCombobox1, 0);
            this.Controls.SetChildIndex(this.txtCombo, 0);
            this.Controls.SetChildIndex(this.llencaAplicacions1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtExecuta;
        private System.Windows.Forms.TextBox codiBox;
        private System.Windows.Forms.TextBox agenciaBox;
        private System.Windows.Forms.Button MostrarDades_btn;
        private System.Windows.Forms.Button btnExecuta;
        private System.Windows.Forms.Button actDades_btn;
        private System.Windows.Forms.Button button1;
        private LibreriaControles.UIXCombobox uixCombobox1;
        private System.Windows.Forms.TextBox txtCombo;
        private LibreriaClases.LlencaAplicacions llencaAplicacions1;
    }
}
