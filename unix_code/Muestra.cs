using System;

namespace unix_code
{
    public partial class Muestra : Libreria_BaseForms.BaseForms
    {
        public Muestra(String user)
        {
            InitializeComponent();
            String username = user;
            labelUsername.Text = username;
        }
        private void cerrarsesion_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form3 = new Login();
            form3.Show();
        }
    }
}
