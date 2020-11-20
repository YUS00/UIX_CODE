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

        public Image Picture
        {
            get { return pctBox.Image; }
            set { pctBox.Image = value; }
        }

        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

    }
}
