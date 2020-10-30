using System;
using System.Data;
using System.Windows.Forms;

namespace unix_code
{
    public partial class Login : Form

    {


        public Login()
        {
            InitializeComponent();
        }
        int attempt = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox2.Hide();
            progressBar1.Hide();
            label3.Hide();
            timer1.Enabled = false;
            labelUsername.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = textBox1.Text;
            string password = textBox2.Text;
            string query = "Select * from Users " + " where codeuser = '" + textBox1.Text + "' AND password ='" + textBox2.Text + "'";

            BaseDatos.DataBase BD = new BaseDatos.DataBase();

            DataSet dades = BD.PortarPerConsulta(query);
            int registres = dades.Tables[0].Rows.Count;
            if (registres > 0)
            {
                attempt = 0;
                this.WindowState = FormWindowState.Normal;
                String user = textBox1.Text;
                pictureBox2.Show(); progressBar1.Show();
                label3.Show(); lblUser.Hide();
                lblPassword.Hide(); textBox1.Hide();
                textBox2.Hide(); button1.Hide();
                forgotpass_lbl.Hide();
                labelUsername.Text = username;
                labelUsername.Show();
                timer1.Enabled = true;

            }
            else if (attempt++ == 2)
            {
                textBox2.Clear();
                Amenaza amenaza = new Amenaza();
                amenaza.Show();
                this.Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                MessageBox.Show("IDENTITY CONFIRMED");
                Menu menu = new Menu(textBox1.Text);
                menu.Show();
                this.Hide();
            }
        }
    }
}
