using System.Windows.Forms;


namespace ComandaCR
{
    public partial class InterfazComanda : Form
    {
        public InterfazComanda()
        {
            InitializeComponent();
        }

        private void btnDisplayReport_Click(object sender, System.EventArgs e)
        {
            OrderModel.OrderCode = swtCodeOrder.Text;
            CrystalReportForm crystalReportForm = new CrystalReportForm();
            crystalReportForm.Show();
            //Comanda comanda = new Comanda();
            //crvComanda.ReportSource = comanda.ParameterFields;
            
            //crvComanda.Show();
        }
    }
}
