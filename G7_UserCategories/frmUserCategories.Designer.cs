namespace G7_UserCategories
{
    partial class frmUserCategories
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblCodeCategory = new System.Windows.Forms.Label();
            this.lblDescCategory = new System.Windows.Forms.Label();
            this.lblAccessLevel = new System.Windows.Forms.Label();
            this.swtCodeCategory = new LibreriaClases.SWTextbox();
            this.swtDescCategory = new LibreriaClases.SWTextbox();
            this.swtAccessLevel = new LibreriaClases.SWTextbox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(187, 424);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(819, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(744, 380);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(114, 23);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "New Register";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(899, 380);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblCodeCategory
            // 
            this.lblCodeCategory.AutoSize = true;
            this.lblCodeCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblCodeCategory.ForeColor = System.Drawing.Color.White;
            this.lblCodeCategory.Location = new System.Drawing.Point(145, 125);
            this.lblCodeCategory.Name = "lblCodeCategory";
            this.lblCodeCategory.Size = new System.Drawing.Size(45, 17);
            this.lblCodeCategory.TabIndex = 27;
            this.lblCodeCategory.Text = "CODI:";
            // 
            // lblDescCategory
            // 
            this.lblDescCategory.AutoSize = true;
            this.lblDescCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblDescCategory.ForeColor = System.Drawing.Color.White;
            this.lblDescCategory.Location = new System.Drawing.Point(94, 179);
            this.lblDescCategory.Name = "lblDescCategory";
            this.lblDescCategory.Size = new System.Drawing.Size(98, 17);
            this.lblDescCategory.TabIndex = 28;
            this.lblDescCategory.Text = "DESCRIPCIÓ: ";
            // 
            // lblAccessLevel
            // 
            this.lblAccessLevel.AutoSize = true;
            this.lblAccessLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblAccessLevel.ForeColor = System.Drawing.Color.White;
            this.lblAccessLevel.Location = new System.Drawing.Point(69, 237);
            this.lblAccessLevel.Name = "lblAccessLevel";
            this.lblAccessLevel.Size = new System.Drawing.Size(121, 17);
            this.lblAccessLevel.TabIndex = 29;
            this.lblAccessLevel.Text = "NIVELL D\'ACCÉS:";
            // 
            // swtCodeCategory
            // 
            this.swtCodeCategory.Campo_obligatorio = false;
            this.swtCodeCategory.CampoBBDD = "CodeCategory";
            this.swtCodeCategory.ForeignKey = false;
            this.swtCodeCategory.Location = new System.Drawing.Point(243, 119);
            this.swtCodeCategory.Name = "swtCodeCategory";
            this.swtCodeCategory.Size = new System.Drawing.Size(180, 22);
            this.swtCodeCategory.TabIndex = 30;
            this.swtCodeCategory.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Texto;
            // 
            // swtDescCategory
            // 
            this.swtDescCategory.Campo_obligatorio = false;
            this.swtDescCategory.CampoBBDD = "DescCategory";
            this.swtDescCategory.ForeignKey = false;
            this.swtDescCategory.Location = new System.Drawing.Point(243, 174);
            this.swtDescCategory.Name = "swtDescCategory";
            this.swtDescCategory.Size = new System.Drawing.Size(180, 22);
            this.swtDescCategory.TabIndex = 31;
            this.swtDescCategory.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Texto;
            // 
            // swtAccessLevel
            // 
            this.swtAccessLevel.Campo_obligatorio = false;
            this.swtAccessLevel.CampoBBDD = "AccessLevel";
            this.swtAccessLevel.ForeignKey = false;
            this.swtAccessLevel.Location = new System.Drawing.Point(243, 232);
            this.swtAccessLevel.Name = "swtAccessLevel";
            this.swtAccessLevel.Size = new System.Drawing.Size(180, 22);
            this.swtAccessLevel.TabIndex = 32;
            this.swtAccessLevel.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Numero;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(620, 380);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmUserCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 607);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.swtAccessLevel);
            this.Controls.Add(this.swtDescCategory);
            this.Controls.Add(this.swtCodeCategory);
            this.Controls.Add(this.lblAccessLevel);
            this.Controls.Add(this.lblDescCategory);
            this.Controls.Add(this.lblCodeCategory);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmUserCategories";
            this.Text = "frmUserCategories";
            this.Load += new System.EventHandler(this.frmUserCategories_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.lblCodeCategory, 0);
            this.Controls.SetChildIndex(this.lblDescCategory, 0);
            this.Controls.SetChildIndex(this.lblAccessLevel, 0);
            this.Controls.SetChildIndex(this.swtCodeCategory, 0);
            this.Controls.SetChildIndex(this.swtDescCategory, 0);
            this.Controls.SetChildIndex(this.swtAccessLevel, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblCodeCategory;
        private System.Windows.Forms.Label lblDescCategory;
        private System.Windows.Forms.Label lblAccessLevel;
        private LibreriaClases.SWTextbox swtCodeCategory;
        private LibreriaClases.SWTextbox swtDescCategory;
        private LibreriaClases.SWTextbox swtAccessLevel;
        private System.Windows.Forms.Button btnDelete;
    }
}