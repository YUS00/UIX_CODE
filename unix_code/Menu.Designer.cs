namespace unix_code
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.class11 = new Controls.Class1();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cerrarsesion_btn = new System.Windows.Forms.Button();
            this.tbl = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.class11);
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 37);
            this.panel1.TabIndex = 4;
            // 
            // class11
            // 
            this.class11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("class11.BackgroundImage")));
            this.class11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.class11.Location = new System.Drawing.Point(913, 6);
            this.class11.Margin = new System.Windows.Forms.Padding(4);
            this.class11.Name = "class11";
            this.class11.Size = new System.Drawing.Size(33, 25);
            this.class11.TabIndex = 13;
            this.class11.UseVisualStyleBackColor = true;
            this.class11.Click += new System.EventHandler(this.class11_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Arial", 8.25F);
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(100, 11);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(68, 16);
            this.labelUsername.TabIndex = 7;
            this.labelUsername.Text = "------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "WELCOME";
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
            this.cerrarsesion_btn.TabIndex = 5;
            this.cerrarsesion_btn.Text = "Cerrar sesion";
            this.cerrarsesion_btn.UseVisualStyleBackColor = false;
            this.cerrarsesion_btn.Click += new System.EventHandler(this.cerrarsesion_btn_Click_1);
            // 
            // tbl
            // 
            this.tbl.BackColor = System.Drawing.Color.Transparent;
            this.tbl.ColumnCount = 3;
            this.tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tbl.Location = new System.Drawing.Point(182, 215);
            this.tbl.Name = "tbl";
            this.tbl.RowCount = 2;
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl.Size = new System.Drawing.Size(542, 219);
            this.tbl.TabIndex = 6;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 549);
            this.Controls.Add(this.tbl);
            this.Controls.Add(this.cerrarsesion_btn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUsername;
        private Controls.Class1 class11;
        private System.Windows.Forms.Button cerrarsesion_btn;
        private System.Windows.Forms.TableLayoutPanel tbl;
    }
}