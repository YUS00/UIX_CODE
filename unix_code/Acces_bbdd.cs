using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace unix_code
{
    public partial class Acces_bbdd : Form
    {
        BaseDatos.DataBase dades = new BaseDatos.DataBase();
        public Acces_bbdd()
        {
            InitializeComponent();
        }
        private SqlConnection conn;
        private string query = "select * from agencies";
        DataSet dts = new DataSet();
        private void MostrarDades_Click(object sender, EventArgs e)
        {
            dts = dades.PortarTaula("Agencies");
            dataGridView.DataSource = dts.Tables[0];
            agenciaBox.DataBindings.Add("Text", dts.Tables[0], agenciaBox.Tag.ToString());
            codiBox.DataBindings.Add("Text", dts.Tables[0], codiBox.Tag.ToString());
        }
        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            codiBox.Text = dataGridView.SelectedRows[0].Cells["CodeAgency"].Value.ToString();
            agenciaBox.Text = dataGridView.SelectedRows[0].Cells["DescAgency"].Value.ToString();
        }

        private void actDades_btn_Click(object sender, EventArgs e)
        {
            dades.Actualizar();
        }

        private void btnExecuta_Click(object sender, EventArgs e)
        {
            String consulta = txtExecuta.Text.ToString();
            dades.Executa(consulta);
        }

        private void cerrarsesion_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form3 = new Login();
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet dtss = dades.PortarPerConsulta("select * from users");
            uixCombobox1.DataSource = dtss.Tables[0];
            uixCombobox1.ValueMember = uixCombobox1.CampID;
            uixCombobox1.DisplayMember = uixCombobox1.CampMostrar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controlLlencaApplicacions1.LabelText = "hola";
            controlLlencaApplicacions1.Picture = Application.StartupPath + "/assets/cloud.png";
            controlLlencaApplicacions1.BackgroundColor = Color.Blue;
            controlLlencaApplicacions1.ClasseObrir = "ClasseColors.dll";
            controlLlencaApplicacions1.FormObrir = "ClasseColors.frmBlau";
        }
    }
}