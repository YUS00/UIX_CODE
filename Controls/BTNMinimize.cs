using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Controls
{
    public class BTNMinimize: Button
    {

        public BTNMinimize()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTNMinimize));
            this.SuspendLayout();
            // 
            // BTNMinimize
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Click += new System.EventHandler(this.BTNMinimize_Click);
            this.ResumeLayout(false);

        }

        public void BTNMinimize_Click(object sender, EventArgs e)
        {
            Form fm = this.FindForm();
            fm.WindowState = FormWindowState.Minimized;
        }
    }
}
