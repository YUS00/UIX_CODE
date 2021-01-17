using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace ComandaCR
{
    public partial class CrystalReportForm : Form
    {
        public CrystalReportForm()
        {
            InitializeComponent();
        }

        BaseDatos.DataBase bd = new BaseDatos.DataBase();
        DataSet dts;

        private void CrystalReportForm_Load(object sender, EventArgs e)
        {
            Comanda comanda = new Comanda();
            String query = "SELECT Agencies.CodeAgency, Planets.DescPlanet, OperationalAreas.CodeOperationalArea, Factories.codeFactory, Factories.DescFactory, Orders.codeOrder, Orders.dateOrder, Priority.DescPriority, OrdersDetail.Quantity, OrdersDetail.DeliveryDate, \"References\".codeReference, \"References\".descReference FROM   ((((SecureCore.dbo.OrdersDetail OrdersDetail INNER JOIN (((SecureCore.dbo.OrderInfo OrderInfo INNER JOIN SecureCore.dbo.Agencies Agencies ON OrderInfo.idAgency=Agencies.idAgency) INNER JOIN SecureCore.dbo.OperationalAreas OperationalAreas ON OrderInfo.idOperationalArea=OperationalAreas.idOperationalArea) INNER JOIN SecureCore.dbo.Orders Orders ON OrderInfo.idOrder=Orders.idOrder) ON OrdersDetail.idOrder=Orders.idOrder) INNER JOIN SecureCore.dbo.Planets Planets ON OrdersDetail.idPlanet=Planets.idPlanet) INNER JOIN SecureCore.dbo.\"References\" \"References\" ON OrdersDetail.idReference=\"References\".idReference) INNER JOIN SecureCore.dbo.Factories Factories ON Orders.IdFactory=Factories.idFactory) INNER JOIN SecureCore.dbo.Priority Priority ON Orders.IdPriority=Priority.idPriority";
            query += " WHERE Orders.idOrder = "+OrderModel.OrderCode+"";



            ParameterFields parameterFields = new ParameterFields();
            ParameterField OrderCodeParameter = new ParameterField();
            OrderCodeParameter.Name = "codeOrder";
            ParameterDiscreteValue val = new ParameterDiscreteValue();
            val.Value = OrderModel.OrderCode;
            OrderCodeParameter.CurrentValues.Add(val);
            parameterFields.Add(OrderCodeParameter);
            crvComanda.ParameterFieldInfo = parameterFields;

            dts = bd.PortarPerConsulta(query);
            comanda.SetDataSource(dts.Tables[0]);
            crvComanda.ReportSource = comanda;
            crvComanda.Refresh();
            
        }
    }
}
