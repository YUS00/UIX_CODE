using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
        int index;

        //private void Actualizar()
        //{
        //    conn.Open();
        //    SqlDataAdapter adapter;
        //    adapter = new SqlDataAdapter(query, conn);
        //    SqlCommandBuilder cmdBuilder;
        //    cmdBuilder = new SqlCommandBuilder(adapter);

        //    if (dts.HasChanges())

        //    {
        //        adapter.Update(dts.Tables[0]);
        //    }
        //    conn.Close();
        //}
        private void MostrarDades_Click(object sender, EventArgs e)
        {
            DataSet dts2 = new DataSet();
            dts2 = dades.PortarTaula("Agencies");
            dataGridView.DataSource = dts2.Tables[0];
        }
        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = dataGridView.CurrentRow.Index;
            codiBox.Text = dataGridView.SelectedRows[0].Cells["CodeAgency"].Value.ToString();
            agenciaBox.Text = dataGridView.SelectedRows[0].Cells["DescAgency"].Value.ToString();
        }

        private void actDades_btn_Click(object sender, EventArgs e)
        {
            dades.Actualizar();
        }
        //private void AnadirRegistro()
        //{
        //    if (dataGridView.CurrentRow.Selected && codiBox.Text != "" && agenciaBox.Text != "")
        //    {
        //        //TODO: dataGridView.Rows[ESTO DETERMINA QUE CELDA SE CAMBIA]
        //        dataGridView.Rows[0].Cells[1].Value = codiBox.Text;
        //        dataGridView.Rows[0].Cells[2].Value = agenciaBox.Text;
        //        //dataGridView.CurrentRow.Cells[1].Value = codiBox.Text;
        //        //dataGridView.CurrentRow.Cells[2].Value = agenciaBox.Text;
        //    }
        //    else if (codiBox.Text != "" && agenciaBox.Text != "")
        //    {
        //        DataRow fila = dts.Tables[0].NewRow();
        //        fila[1] = codiBox.Text;
        //        fila[2] = agenciaBox.Text;
        //        dts.Tables[0].Rows.Add(fila);
        //    }
        //    else
        //    {

        //    }
        //}

    }
}