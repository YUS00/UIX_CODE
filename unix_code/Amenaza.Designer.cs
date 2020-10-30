namespace unix_code
{
    partial class Amenaza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Amenaza));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize1 = new Controls.BTNMinimize();
            this.class11 = new Controls.BTNEXIT();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(133, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(708, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "ENTRAR,NO ME HARE CARGO DE LO QUE PUEDA SUCEDER...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(637, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "SOY EL PROGRAMADOR,COMO VUELVAS A INTENTAR ";
            // 
            // btnMinimize1
            // 
            this.btnMinimize1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize1.BackgroundImage")));
            this.btnMinimize1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize1.Location = new System.Drawing.Point(728, 12);
            this.btnMinimize1.Name = "btnMinimize1";
            this.btnMinimize1.Size = new System.Drawing.Size(27, 25);
            this.btnMinimize1.TabIndex = 38;
            this.btnMinimize1.UseVisualStyleBackColor = true;
            // 
            // class11
            // 
            this.class11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("class11.BackgroundImage")));
            this.class11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.class11.Location = new System.Drawing.Point(761, 12);
            this.class11.Name = "class11";
            this.class11.Size = new System.Drawing.Size(27, 25);
            this.class11.TabIndex = 37;
            this.class11.UseVisualStyleBackColor = true;
            // 
            // Amenaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMinimize1);
            this.Controls.Add(this.class11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Amenaza";
            this.Text = "Amenaza";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Controls.BTNMinimize btnMinimize1;
        private Controls.BTNEXIT class11;
    }
}