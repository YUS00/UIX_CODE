using System;
using System.Data;
using System.Windows.Forms;

namespace unix_code
{
    public partial class Login : Libreria_BaseForms.BaseFormVentana
    {
        public Login()
        {
            InitializeComponent();
        }
        int attempt = 0;
        private void Login_Load(object sender, EventArgs e)
        {
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
                Modelos.User.setUserName(user);
                LoginCarga lg = new LoginCarga(user);
                lg.Show();
                this.Hide();
            }
            else if (attempt++ == 2)
            {
                textBox2.Clear();
                Amenaza amenaza = new Amenaza();
                amenaza.Show();
                this.Hide();
            }
        }

        
    }
}
