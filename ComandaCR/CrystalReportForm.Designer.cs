namespace ComandaCR
{
    partial class CrystalReportForm
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
            this.crvComanda = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvComanda
            // 
            this.crvComanda.ActiveViewIndex = -1;
            this.crvComanda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvComanda.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvComanda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvComanda.Location = new System.Drawing.Point(0, 0);
            this.crvComanda.Name = "crvComanda";
            this.crvComanda.Size = new System.Drawing.Size(800, 450);
            this.crvComanda.TabIndex = 0;
            // 
            // CrystalReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvComanda);
            this.Name = "CrystalReportForm";
            this.Text = "CrystalReportForm";
            this.Load += new System.EventHandler(this.CrystalReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvComanda;
    }
}