namespace G7_Users
{
    partial class Form1
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblCodeUser = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.swtCodeUser = new LibreriaClases.SWTextbox();
            this.swtUsername = new LibreriaClases.SWTextbox();
            this.swtLogin = new LibreriaClases.SWTextbox();
            this.swtPassword = new LibreriaClases.SWTextbox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserRank = new System.Windows.Forms.Label();
            this.cbxUserRank = new LibreriaControles.UIXCombobox();
            this.cbxUserCategory = new LibreriaControles.UIXCombobox();
            this.lblUserCategory = new System.Windows.Forms.Label();
            this.swtPhoto = new LibreriaClases.SWTextbox();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.cbxPlanet = new LibreriaControles.UIXCombobox();
            this.lblPlanet = new System.Windows.Forms.Label();
            this.cbxSpecie = new LibreriaControles.UIXCombobox();
            this.lblSpecie = new System.Windows.Forms.Label();
            this.swtLevel = new LibreriaClases.SWTextbox();
            this.lblLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(433, 295);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(51, 181);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(55, 17);
            this.lblLogin.TabIndex = 39;
            this.lblLogin.Text = "LOGIN:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(13, 123);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(93, 17);
            this.lblUsername.TabIndex = 38;
            this.lblUsername.Text = "USERNAME: ";
            // 
            // lblCodeUser
            // 
            this.lblCodeUser.AutoSize = true;
            this.lblCodeUser.BackColor = System.Drawing.Color.Transparent;
            this.lblCodeUser.ForeColor = System.Drawing.Color.White;
            this.lblCodeUser.Location = new System.Drawing.Point(21, 69);
            this.lblCodeUser.Name = "lblCodeUser";
            this.lblCodeUser.Size = new System.Drawing.Size(85, 17);
            this.lblCodeUser.TabIndex = 37;
            this.lblCodeUser.Text = "CODEUSER";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(712, 295);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 23);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(557, 295);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(114, 23);
            this.btnNew.TabIndex = 35;
            this.btnNew.Text = "New Register";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 324);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(819, 109);
            this.dataGridView1.TabIndex = 34;
            // 
            // swtCodeUser
            // 
            this.swtCodeUser.Campo_obligatorio = false;
            this.swtCodeUser.CampoBBDD = "CodeUser";
            this.swtCodeUser.ForeignKey = false;
            this.swtCodeUser.Location = new System.Drawing.Point(125, 69);
            this.swtCodeUser.Name = "swtCodeUser";
            this.swtCodeUser.Size = new System.Drawing.Size(135, 22);
            this.swtCodeUser.TabIndex = 41;
            this.swtCodeUser.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Texto;
            // 
            // swtUsername
            // 
            this.swtUsername.Campo_obligatorio = false;
            this.swtUsername.CampoBBDD = "UserName";
            this.swtUsername.ForeignKey = false;
            this.swtUsername.Location = new System.Drawing.Point(125, 120);
            this.swtUsername.Name = "swtUsername";
            this.swtUsername.Size = new System.Drawing.Size(135, 22);
            this.swtUsername.TabIndex = 42;
            this.swtUsername.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Texto;
            // 
            // swtLogin
            // 
            this.swtLogin.Campo_obligatorio = false;
            this.swtLogin.CampoBBDD = "Login";
            this.swtLogin.ForeignKey = false;
            this.swtLogin.Location = new System.Drawing.Point(125, 165);
            this.swtLogin.Name = "swtLogin";
            this.swtLogin.Size = new System.Drawing.Size(135, 22);
            this.swtLogin.TabIndex = 43;
            this.swtLogin.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Texto;
            // 
            // swtPassword
            // 
            this.swtPassword.Campo_obligatorio = false;
            this.swtPassword.CampoBBDD = "Password";
            this.swtPassword.ForeignKey = false;
            this.swtPassword.Location = new System.Drawing.Point(125, 213);
            this.swtPassword.Name = "swtPassword";
            this.swtPassword.Size = new System.Drawing.Size(135, 22);
            this.swtPassword.TabIndex = 45;
            this.swtPassword.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Texto;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(14, 231);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(92, 17);
            this.lblPassword.TabIndex = 44;
            this.lblPassword.Text = "PASSWORD:";
            // 
            // lblUserRank
            // 
            this.lblUserRank.AutoSize = true;
            this.lblUserRank.BackColor = System.Drawing.Color.Transparent;
            this.lblUserRank.ForeColor = System.Drawing.Color.White;
            this.lblUserRank.Location = new System.Drawing.Point(320, 69);
            this.lblUserRank.Name = "lblUserRank";
            this.lblUserRank.Size = new System.Drawing.Size(92, 17);
            this.lblUserRank.TabIndex = 46;
            this.lblUserRank.Text = "USER RANK:";
            // 
            // cbxUserRank
            // 
            this.cbxUserRank.CampID = "idUserRank";
            this.cbxUserRank.CampMostrar = "DescRank";
            this.cbxUserRank.CampoBBDD = "idUserRank";
            this.cbxUserRank.ControlId = null;
            this.cbxUserRank.FormattingEnabled = true;
            this.cbxUserRank.Location = new System.Drawing.Point(419, 65);
            this.cbxUserRank.Name = "cbxUserRank";
            this.cbxUserRank.Size = new System.Drawing.Size(137, 24);
            this.cbxUserRank.TabIndex = 47;
            this.cbxUserRank.TaulaForanea = "UserRanks";
            // 
            // cbxUserCategory
            // 
            this.cbxUserCategory.CampID = "idUserCategory";
            this.cbxUserCategory.CampMostrar = "DescCategory";
            this.cbxUserCategory.CampoBBDD = "idUserCategory";
            this.cbxUserCategory.ControlId = null;
            this.cbxUserCategory.FormattingEnabled = true;
            this.cbxUserCategory.Location = new System.Drawing.Point(419, 116);
            this.cbxUserCategory.Name = "cbxUserCategory";
            this.cbxUserCategory.Size = new System.Drawing.Size(137, 24);
            this.cbxUserCategory.TabIndex = 49;
            this.cbxUserCategory.TaulaForanea = "UserCategories";
            // 
            // lblUserCategory
            // 
            this.lblUserCategory.AutoSize = true;
            this.lblUserCategory.BackColor = System.Drawing.Color.Transparent;
            this.lblUserCategory.ForeColor = System.Drawing.Color.White;
            this.lblUserCategory.Location = new System.Drawing.Point(281, 120);
            this.lblUserCategory.Name = "lblUserCategory";
            this.lblUserCategory.Size = new System.Drawing.Size(131, 17);
            this.lblUserCategory.TabIndex = 48;
            this.lblUserCategory.Text = "USER CATEGORY:";
            // 
            // swtPhoto
            // 
            this.swtPhoto.Campo_obligatorio = false;
            this.swtPhoto.CampoBBDD = "Photo";
            this.swtPhoto.ForeignKey = false;
            this.swtPhoto.Location = new System.Drawing.Point(419, 165);
            this.swtPhoto.Name = "swtPhoto";
            this.swtPhoto.Size = new System.Drawing.Size(135, 22);
            this.swtPhoto.TabIndex = 51;
            this.swtPhoto.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Texto;
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoto.ForeColor = System.Drawing.Color.White;
            this.lblPhoto.Location = new System.Drawing.Point(345, 168);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(62, 17);
            this.lblPhoto.TabIndex = 50;
            this.lblPhoto.Text = "PHOTO:";
            // 
            // cbxPlanet
            // 
            this.cbxPlanet.CampID = "idPlanet";
            this.cbxPlanet.CampMostrar = "DescPlanet";
            this.cbxPlanet.CampoBBDD = "idPlanet";
            this.cbxPlanet.ControlId = null;
            this.cbxPlanet.FormattingEnabled = true;
            this.cbxPlanet.Location = new System.Drawing.Point(659, 165);
            this.cbxPlanet.Name = "cbxPlanet";
            this.cbxPlanet.Size = new System.Drawing.Size(137, 24);
            this.cbxPlanet.TabIndex = 53;
            this.cbxPlanet.TaulaForanea = "Planets";
            // 
            // lblPlanet
            // 
            this.lblPlanet.AutoSize = true;
            this.lblPlanet.BackColor = System.Drawing.Color.Transparent;
            this.lblPlanet.ForeColor = System.Drawing.Color.White;
            this.lblPlanet.Location = new System.Drawing.Point(581, 168);
            this.lblPlanet.Name = "lblPlanet";
            this.lblPlanet.Size = new System.Drawing.Size(66, 17);
            this.lblPlanet.TabIndex = 52;
            this.lblPlanet.Text = "PLANET:";
            // 
            // cbxSpecie
            // 
            this.cbxSpecie.CampID = "idSpecie";
            this.cbxSpecie.CampMostrar = "DescSpecie";
            this.cbxSpecie.CampoBBDD = "idSpecie";
            this.cbxSpecie.ControlId = null;
            this.cbxSpecie.FormattingEnabled = true;
            this.cbxSpecie.Location = new System.Drawing.Point(661, 65);
            this.cbxSpecie.Name = "cbxSpecie";
            this.cbxSpecie.Size = new System.Drawing.Size(137, 24);
            this.cbxSpecie.TabIndex = 55;
            this.cbxSpecie.TaulaForanea = "Species";
            // 
            // lblSpecie
            // 
            this.lblSpecie.AutoSize = true;
            this.lblSpecie.BackColor = System.Drawing.Color.Transparent;
            this.lblSpecie.ForeColor = System.Drawing.Color.White;
            this.lblSpecie.Location = new System.Drawing.Point(583, 68);
            this.lblSpecie.Name = "lblSpecie";
            this.lblSpecie.Size = new System.Drawing.Size(60, 17);
            this.lblSpecie.TabIndex = 54;
            this.lblSpecie.Text = "SPECIE:";
            // 
            // swtLevel
            // 
            this.swtLevel.Campo_obligatorio = false;
            this.swtLevel.CampoBBDD = "level";
            this.swtLevel.ForeignKey = false;
            this.swtLevel.Location = new System.Drawing.Point(661, 115);
            this.swtLevel.Name = "swtLevel";
            this.swtLevel.Size = new System.Drawing.Size(135, 22);
            this.swtLevel.TabIndex = 57;
            this.swtLevel.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Texto;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.ForeColor = System.Drawing.Color.White;
            this.lblLevel.Location = new System.Drawing.Point(587, 118);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(55, 17);
            this.lblLevel.TabIndex = 56;
            this.lblLevel.Text = "LEVEL:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 444);
            this.Controls.Add(this.swtLevel);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.cbxSpecie);
            this.Controls.Add(this.lblSpecie);
            this.Controls.Add(this.cbxPlanet);
            this.Controls.Add(this.lblPlanet);
            this.Controls.Add(this.swtPhoto);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.cbxUserCategory);
            this.Controls.Add(this.lblUserCategory);
            this.Controls.Add(this.cbxUserRank);
            this.Controls.Add(this.lblUserRank);
            this.Controls.Add(this.swtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.swtLogin);
            this.Controls.Add(this.swtUsername);
            this.Controls.Add(this.swtCodeUser);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblCodeUser);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.btnNew, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.lblCodeUser, 0);
            this.Controls.SetChildIndex(this.lblUsername, 0);
            this.Controls.SetChildIndex(this.lblLogin, 0);
            this.Controls.SetChildIndex(this.btnDelete, 0);
            this.Controls.SetChildIndex(this.swtCodeUser, 0);
            this.Controls.SetChildIndex(this.swtUsername, 0);
            this.Controls.SetChildIndex(this.swtLogin, 0);
            this.Controls.SetChildIndex(this.lblPassword, 0);
            this.Controls.SetChildIndex(this.swtPassword, 0);
            this.Controls.SetChildIndex(this.lblUserRank, 0);
            this.Controls.SetChildIndex(this.cbxUserRank, 0);
            this.Controls.SetChildIndex(this.lblUserCategory, 0);
            this.Controls.SetChildIndex(this.cbxUserCategory, 0);
            this.Controls.SetChildIndex(this.lblPhoto, 0);
            this.Controls.SetChildIndex(this.swtPhoto, 0);
            this.Controls.SetChildIndex(this.lblPlanet, 0);
            this.Controls.SetChildIndex(this.cbxPlanet, 0);
            this.Controls.SetChildIndex(this.lblSpecie, 0);
            this.Controls.SetChildIndex(this.cbxSpecie, 0);
            this.Controls.SetChildIndex(this.lblLevel, 0);
            this.Controls.SetChildIndex(this.swtLevel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblCodeUser;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LibreriaClases.SWTextbox swtCodeUser;
        private LibreriaClases.SWTextbox swtUsername;
        private LibreriaClases.SWTextbox swtLogin;
        private LibreriaClases.SWTextbox swtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserRank;
        private LibreriaControles.UIXCombobox cbxUserRank;
        private LibreriaControles.UIXCombobox cbxUserCategory;
        private System.Windows.Forms.Label lblUserCategory;
        private LibreriaClases.SWTextbox swtPhoto;
        private System.Windows.Forms.Label lblPhoto;
        private LibreriaControles.UIXCombobox cbxPlanet;
        private System.Windows.Forms.Label lblPlanet;
        private LibreriaControles.UIXCombobox cbxSpecie;
        private System.Windows.Forms.Label lblSpecie;
        private LibreriaClases.SWTextbox swtLevel;
        private System.Windows.Forms.Label lblLevel;
    }
}

