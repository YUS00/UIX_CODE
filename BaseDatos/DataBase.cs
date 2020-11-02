using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.AccessControl;
using System.Configuration;

namespace BaseDatos
{
    public class DataBase
    {
        private SqlConnection conn;
        string query;
        public DataSet dts = new DataSet();



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

            ConnectionStringSettings conf = ConfigurationManager.ConnectionStrings["securecore"];

            if (conf != null)
            {
                String connectionString = conf.ConnectionString;
                conn = new SqlConnection(connectionString);
                conn.Open();
            }
            

        }

        public DataSet PortarTaula(String nomTaula)
        {
            Connectar();
            SqlDataAdapter adapter;
            query = "select * from " + nomTaula;
            adapter = new SqlDataAdapter(query, conn);
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
            adapter.Update(dts.Tables[0]);
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

        public void Executa()
        {
            String cons = "INSERT INTO Agencies VALUES('Code', 'Desc')";
            Connectar();
            SqlCommand cmd = new SqlCommand(cons, conn);
            cmd.ExecuteNonQuery();
         
            conn.Close();
        }
        public void Executa(String consulta)
        {
            
            Connectar();
            SqlCommand cmd = new SqlCommand(consulta, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

    }
}
