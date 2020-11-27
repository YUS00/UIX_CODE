namespace unix_code
{
    partial class FormDataSetPrueba
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_Actualizar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.swTextbox1 = new LibreriaClases.SWTextbox();
            this.uixCombobox1 = new LibreriaControles.UIXCombobox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(761, 248);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(54, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 2;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Location = new System.Drawing.Point(482, 417);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(82, 23);
            this.btn_Actualizar.TabIndex = 3;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = true;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(588, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // swTextbox1
            // 
            this.swTextbox1.Campo_obligatorio = false;
            this.swTextbox1.CampoBBDD = "idAgency";
            this.swTextbox1.ForeignKey = false;
            this.swTextbox1.Location = new System.Drawing.Point(715, 52);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.Size = new System.Drawing.Size(100, 22);
            this.swTextbox1.TabIndex = 5;
            this.swTextbox1.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Texto;
            // 
            // uixCombobox1
            // 
            this.uixCombobox1.CampID = "idagency";
            this.uixCombobox1.CampMostrar = "codeagency";
            this.uixCombobox1.ControlId = "swTextbox1";
            this.uixCombobox1.FormattingEnabled = true;
            this.uixCombobox1.Location = new System.Drawing.Point(588, 52);
            this.uixCombobox1.Name = "uixCombobox1";
            this.uixCombobox1.Size = new System.Drawing.Size(121, 24);
            this.uixCombobox1.TabIndex = 6;
            // 
            // FormDataSetPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 488);
            this.Controls.Add(this.uixCombobox1);
            this.Controls.Add(this.swTextbox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDataSetPrueba";
            this.Text = "FormDataSetPrueba";
            this.Load += new System.EventHandler(this.FormDataSetPrueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_Actualizar;
        private System.Windows.Forms.Button button2;
        private LibreriaClases.SWTextbox swTextbox1;
        private LibreriaControles.UIXCombobox uixCombobox1;
    }
}