using System;
using System.Windows.Forms;

namespace Libreria_BaseForms
{
    public partial class BaseForms : Form
    {
        public BaseForms()
        {
            InitializeComponent();
            this.labelUsername.Text = Modelos.User.getUserName();
        }

        private void class11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
