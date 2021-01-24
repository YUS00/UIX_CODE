using System;
using System.Windows.Forms;

namespace Libreria_BaseForms
{
    public partial class BaseFormVentana : Form
    {
        public BaseFormVentana()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
