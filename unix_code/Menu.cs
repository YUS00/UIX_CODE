using System;
using System.Windows.Forms;

namespace unix_code


{
    public partial class Menu : Form
    {
        public Menu(String user)
        {
            InitializeComponent();
            String username = user;
            labelUsername.Text = username;
            //this.WindowState = FormWindowState.Maximized;

        }

        private void Menu_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Muestra Muestra = new Muestra(labelUsername.Text);
            Muestra.Show();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Acces_bbdd basebbdd = new Acces_bbdd();
            basebbdd.Show();
            this.Hide();
        }
        private void cerrarsesion_btn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login Login = new Login();
            Login.Show();
        }
    }
}
