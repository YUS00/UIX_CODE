using System;
using System.Windows.Forms;

namespace unix_code
{
    public partial class Splash : Libreria_BaseForms.BaseFormVentana
    {
        public Splash()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgressBar1.Value += 1;

            if (circularProgressBar1.Value == 100)
            {
                timer1.Enabled = false;
                timer1.Stop();
                Login fm2 = new Login();
                fm2.Show();
                this.Hide();
            }
        }
        private void Splash_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Minimum = 1;
            circularProgressBar1.Maximum = 100;
            circularProgressBar1.Value = 1;
            timer1.Enabled = true;
            timer1.Interval = 100;
        }
    }
}
