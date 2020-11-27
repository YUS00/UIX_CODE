using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace unix_code
{
    public partial class FormDataSetPrueba : Form
    {
        public FormDataSetPrueba()
        {
            InitializeComponent();
        }

        #region variables globales

        private SqlConnection conn; //Variable de conexion hacia la BBDD
        private string query; //Sentencia a traer a la BBDD
        DataSet dts; //Contiene la BBDD fisicamente



        #endregion

        #region Metodos

        private void FormDataSetPrueba_Load(object sender, EventArgs e)
        {
            LLevarDatos();
        }

        private void ConfigurarConexion() //Configura el tipo de conexion hacia la BBDD, para utilizar la string connection del appconfig.
        {
            ConnectionStringSettings conf = ConfigurationManager.ConnectionStrings["securecore"];

            if (conf != null)
            {
                String connectionString = conf.ConnectionString;
                conn = new SqlConnection(connectionString);
            }
        }

        private void LLevarDatos()
        {
            ConfigurarConexion(); //Configura la conexion 
            SqlDataAdapter adapter; 
            dts = new DataSet(); 

            query = "select * from Agencies";
            adapter = new SqlDataAdapter(query, conn); //Se pasa al adaptador la sentencia y la conexion de la BBDD
            conn.Open();

            adapter.Fill(dts, "Agencies"); //Llenamos el adaptador con los datos del DataSet, y con los valores de la tabla asignada.
            dataGridView1.DataSource = dts.Tables["Agencies"]; //Se muestran dichos valores de la tabla concretada en el DataGridView


            //Mostrar el campo de la BBDD del Combobox
            uixCombobox1.DataSource = dts.Tables[0];
            uixCombobox1.ValueMember = uixCombobox1.CampID;
            uixCombobox1.DisplayMember = uixCombobox1.CampMostrar;

            conn.Close();

        }

        private void Actualizar()
        {
            conn.Open();

            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(query, conn); //Se le pasa al nuevo adaptador la query anterior
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adapter); 

            if (dts.HasChanges())
            {
                int resultado = adapter.Update(dts.Tables["Agencies"]);
                MessageBox.Show(resultado.ToString() + " cambios.");
            }

            conn.Close();
        }


        #endregion

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
