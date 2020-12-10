using System;
using System.Windows.Forms;

namespace Controls
{
    public class Class1 : Button
    {
        public Class1()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Class1));
            this.SuspendLayout();
            // 
            // Class1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Size = new System.Drawing.Size(35, 26);
            this.Click += new System.EventHandler(this.Class1_Click);
            this.ResumeLayout(false);

        }

        private void Class1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
