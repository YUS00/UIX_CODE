namespace unix_code
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.forgotpass_lbl = new System.Windows.Forms.Label();
            this.class11 = new Controls.Class1();
            this.swTextbox1 = new LibreriaClases.SWTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Arial", 8.25F);
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(221, 311);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(45, 16);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "USER";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Arial", 8.25F);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(221, 358);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(87, 16);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "PASSWORD";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(344, 303);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(344, 358);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(285, 22);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 412);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(376, 134);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 50F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(127, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 94);
            this.label1.TabIndex = 6;
            this.label1.Text = "UXPIUS CODE";
            // 
            // forgotpass_lbl
            // 
            this.forgotpass_lbl.AutoSize = true;
            this.forgotpass_lbl.BackColor = System.Drawing.Color.Transparent;
            this.forgotpass_lbl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Underline);
            this.forgotpass_lbl.ForeColor = System.Drawing.Color.Blue;
            this.forgotpass_lbl.Location = new System.Drawing.Point(401, 469);
            this.forgotpass_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forgotpass_lbl.Name = "forgotpass_lbl";
            this.forgotpass_lbl.Size = new System.Drawing.Size(160, 16);
            this.forgotpass_lbl.TabIndex = 7;
            this.forgotpass_lbl.Text = "FORGOT PASSWORD?";
            // 
            // class11
            // 
            this.class11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("class11.BackgroundImage")));
            this.class11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.class11.Location = new System.Drawing.Point(913, 15);
            this.class11.Margin = new System.Windows.Forms.Padding(4);
            this.class11.Name = "class11";
            this.class11.Size = new System.Drawing.Size(33, 25);
            this.class11.TabIndex = 12;
            this.class11.UseVisualStyleBackColor = true;
            this.class11.Click += new System.EventHandler(this.class11_Click);
            // 
            // swTextbox1
            // 
            this.swTextbox1.Campo_obligatorio = true;
            this.swTextbox1.CampoBBDD = null;
            this.swTextbox1.ForeignKey = false;
            this.swTextbox1.Location = new System.Drawing.Point(746, 174);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.Size = new System.Drawing.Size(100, 22);
            this.swTextbox1.TabIndex = 13;
            this.swTextbox1.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Texto;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 549);
            this.Controls.Add(this.swTextbox1);
            this.Controls.Add(this.class11);
            this.Controls.Add(this.forgotpass_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label forgotpass_lbl;
        private Controls.Class1 class11;
        private LibreriaClases.SWTextbox swTextbox1;
    }
}