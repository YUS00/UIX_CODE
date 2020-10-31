using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.AccessControl;

namespace BaseDatos
{
    public class DataBase
    {
        string connectionString;
        private SqlConnection conn;
        string query;
        DataSet dts;            
        
        private String connectionString = "Data Source=DESKTOP-8FAQTCN\\SQLEXPRESS;Initial Catalog=SecureCore;Persist Security Info=True;User ID=sa;Password=1234";


        //private void Traerdatos()
        //{
        //    string cnx;
        //    cnx = "Data Source=DESKTOP-8FAQTCN\\SQLEXPRESS;Initial Catalog=SecureCore;Persist Security Info=True;User ID=sa;Password=1234";
        //    conn = new SqlConnection(cnx);
        //    SqlDataAdapter adapter;
        //    adapter = new SqlDataAdapter(query, conn);
        //    conn.Open();
        //    adapter.Fill(dts, "Agencies");
        //    dataGridView.DataSource = dts.Tables[0];
        //    conn.Close();
        //    agenciaBox.DataBindings.Add("Text", dts.Tables[0], agenciaBox.Tag.ToString());
        //    codiBox.DataBindings.Add("Text", dts.Tables[0], codiBox.Tag.ToString());

        //}

        private void Connectar()
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
        }

        public DataSet PortarTaula(String nomTaula)
        {
            Connectar();
            SqlDataAdapter adapter;
            string query;
            query = "select * from " + nomTaula;
            adapter = new SqlDataAdapter(query, conn);
            DataSet dts = new DataSet();
            adapter.Fill(dts, nomTaula);
            conn.Close();
            return dts;
        }
        public void Actualizar()
        {
            Connectar();
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adapter);
            DataSet dts = new DataSet();
            adapter.Update(dts.Tables["Agencies"]);
            conn.Close();
        }

        public DataSet PortarPerConsulta(String consulta)
        {
            Connectar();
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(consulta, conn);
            DataSet dts = new DataSet();
            adapter.Fill(dts);
            conn.Close();
            return dts;
        }

        public DataSet PortarPerConsulta(String consulta, String nomDataTable)
        {
            Connectar();
            SqlDataAdapter adapter;
            adapter = new SqlDataAdapter(consulta, conn);
            DataSet dts = new DataSet();
            adapter.Fill(dts, nomDataTable);
            conn.Close();
            return dts;
        }
        //public void Data_binding()
        //{
        //    foreach (Control ctr in )
        //}
    }
}
