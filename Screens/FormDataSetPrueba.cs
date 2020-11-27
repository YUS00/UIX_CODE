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

namespace Screens
{
    public partial class FormDataSetPrueba : Form
    {
        public FormDataSetPrueba()
        {
            InitializeComponent();
        }

        #region variables globales

        private SqlConnection conn;
        private string query;
        DataSet dts;



        #endregion

        #region Metodos

        private void FormDataSetPrueba_Load(object sender, EventArgs e)
        {
            LLevarDatos();
        }

        private void LLevarDatos()
        {

            SqlDataAdapter adapter;
            dts = new DataSet();

            query = "select * from Agencies";
            adapter = new SqlDataAdapter(query, conn);
            conn.Open();

            adapter.Fill(dts, "Agencies");
            dataGridView1.DataSource = dts.Tables["Agencies"];

            conn.Close();

        }

        #endregion


    }
}
