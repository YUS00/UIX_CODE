namespace Libreria_Clases_1
{
    partial class BaseForms
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
            this.BTN_CerrarSession = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_CerrarSession
            // 
            this.BTN_CerrarSession.BackColor = System.Drawing.Color.Black;
            this.BTN_CerrarSession.ForeColor = System.Drawing.Color.White;
            this.BTN_CerrarSession.Location = new System.Drawing.Point(899, 9);
            this.BTN_CerrarSession.Margin = new System.Windows.Forms.Padding(0);
            this.BTN_CerrarSession.Name = "BTN_CerrarSession";
            this.BTN_CerrarSession.Size = new System.Drawing.Size(107, 33);
            this.BTN_CerrarSession.TabIndex = 1;
            this.BTN_CerrarSession.Text = "Cerrar sesión";
            this.BTN_CerrarSession.UseVisualStyleBackColor = false;
            this.BTN_CerrarSession.Click += new System.EventHandler(this.BTN_CerrarSession_Click);
            // 
            // LC_Tematica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::Libreria_Clases_1.Properties.Resources.fondov2;
            this.ClientSize = new System.Drawing.Size(1015, 533);
            this.Controls.Add(this.BTN_CerrarSession);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LC_Tematica";
            this.Text = "lc_Tematica";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTN_CerrarSession;
    }
}