namespace ComandaCR
{
    partial class InterfazComanda
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Comanda1 = new ComandaCR.Comanda();
            this.swtCodeOrder = new LibreriaClases.SWTextbox();
            this.lblCodeOrder = new System.Windows.Forms.Label();
            this.btnDisplayReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.DisplayToolbar = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(703, 179);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.DisplayStatusBar = false;
            this.crystalReportViewer2.DisplayToolbar = false;
            this.crystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer2.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.Size = new System.Drawing.Size(703, 179);
            this.crystalReportViewer2.TabIndex = 1;
            this.crystalReportViewer2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // swtCodeOrder
            // 
            this.swtCodeOrder.Campo_obligatorio = false;
            this.swtCodeOrder.CampoBBDD = null;
            this.swtCodeOrder.ForeignKey = false;
            this.swtCodeOrder.Location = new System.Drawing.Point(266, 98);
            this.swtCodeOrder.Name = "swtCodeOrder";
            this.swtCodeOrder.Size = new System.Drawing.Size(143, 22);
            this.swtCodeOrder.TabIndex = 3;
            this.swtCodeOrder.tb_txtpermitido = LibreriaClases.SWTextbox.tb_parametros.Numero;
            // 
            // lblCodeOrder
            // 
            this.lblCodeOrder.AutoSize = true;
            this.lblCodeOrder.ForeColor = System.Drawing.Color.Gold;
            this.lblCodeOrder.Location = new System.Drawing.Point(146, 101);
            this.lblCodeOrder.Name = "lblCodeOrder";
            this.lblCodeOrder.Size = new System.Drawing.Size(105, 17);
            this.lblCodeOrder.TabIndex = 4;
            this.lblCodeOrder.Text = "ORDER CODE:";
            // 
            // btnDisplayReport
            // 
            this.btnDisplayReport.Location = new System.Drawing.Point(440, 90);
            this.btnDisplayReport.Name = "btnDisplayReport";
            this.btnDisplayReport.Size = new System.Drawing.Size(152, 38);
            this.btnDisplayReport.TabIndex = 5;
            this.btnDisplayReport.Text = "CHECK REPORT";
            this.btnDisplayReport.UseVisualStyleBackColor = true;
            this.btnDisplayReport.Click += new System.EventHandler(this.btnDisplayReport_Click);
            // 
            // InterfazComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 179);
            this.Controls.Add(this.btnDisplayReport);
            this.Controls.Add(this.lblCodeOrder);
            this.Controls.Add(this.swtCodeOrder);
            this.Controls.Add(this.crystalReportViewer2);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "InterfazComanda";
            this.Text = "InterfazComanda";
            this.Controls.SetChildIndex(this.crystalReportViewer1, 0);
            this.Controls.SetChildIndex(this.crystalReportViewer2, 0);
            this.Controls.SetChildIndex(this.swtCodeOrder, 0);
            this.Controls.SetChildIndex(this.lblCodeOrder, 0);
            this.Controls.SetChildIndex(this.btnDisplayReport, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private Comanda Comanda1;
        private LibreriaClases.SWTextbox swtCodeOrder;
        private System.Windows.Forms.Label lblCodeOrder;
        private System.Windows.Forms.Button btnDisplayReport;
    }
}