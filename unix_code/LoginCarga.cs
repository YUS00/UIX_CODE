using System;
using System.Windows.Forms;

namespace unix_code
{
    public partial class LoginCarga : Form
    {
        String username;
        public LoginCarga(String user)
        {
            InitializeComponent();
            username = user;
            lblUsername.Text = username;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                MessageBox.Show("IDENTITY CONFIRMED");
                Menu menu = new Menu(username);
                menu.Show();
                this.Hide();
            }
        }
    }
}
