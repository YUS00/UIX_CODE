using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public class BTNEXIT : Button
    {
        public BTNEXIT()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BTNEXIT));
            this.SuspendLayout();
            // 
            // Class1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Click += new System.EventHandler(this.Class1_Click);
            this.ResumeLayout(false);

        }

        private void Class1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
