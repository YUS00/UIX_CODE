using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaUserControls
{
    public partial class ControlLlencaApplicacions: UserControl
    {
        public ControlLlencaApplicacions()
        {
            InitializeComponent();
        }


        public String LabelText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

        public String Picture
        {
            get { return pctBox.ImageLocation; }
            set { pctBox.ImageLocation = value; }
        }

        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

    }
}
