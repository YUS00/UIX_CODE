using System;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace unix_code


{
    public partial class Menu : Form
    {
        public Menu(String user)
        {
            InitializeComponent();
            String username = user;
            labelUsername.Text = username;
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
        DataSet dts;
        String form, classe, descripcio, color, foto;
        private void button1_Click_1(object sender, EventArgs e)
        {
            BaseDatos.DataBase bd = new BaseDatos.DataBase();
            String query = "select * from menu";
            dts = bd.CarregarMenu("60");




            foreach (DataRow dr in dts.Tables[0].Rows)
            {
                form = dr["classe"].ToString();
                classe = dr["ensamblat"].ToString();
                descripcio = dr["descOpcio"].ToString();
                color = dr["backgroundColor"].ToString();
                foto = dr["foto"].ToString();

                LibreriaUserControls.ControlLlencaApplicacions btn = new LibreriaUserControls.ControlLlencaApplicacions();
                btn.LabelText = descripcio;
                btn.ClasseObrir = classe;
                btn.FormObrir = form;
                btn.BackgroundColor = Color.FromName(color);
                btn.Picture = foto;

                tbl.Controls.Add(btn);

            }
        }
    }
}
