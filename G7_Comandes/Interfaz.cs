using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace G7_Comandes
{
    public partial class Interfaz : Libreria_BaseForms.BaseFormVentana
    {
        public Interfaz()
        {
            InitializeComponent();
        }

        OpenFileDialog openFile = new OpenFileDialog();
        string line = "";

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //Primera lectura para contar
                String file = openFile.FileName;
                StreamReader srContar = new StreamReader(file);
                int contador = 0;
                while (line != null)
                {
                    line = srContar.ReadLine();
                    contador++;

                    if (line != null)
                    {
                        lsbLectura.Items.Add(line);
                    }
                }

                srContar.Close();

                //Segunda lectura para inicializar el array
                String line2 = "";

                StreamReader srGuardar = new StreamReader(file);
                int indexMatrix = 0;
                contador--;
                String[][] matrix = new string[contador][];

                while (line2 != null)
                {
                    line2 = srGuardar.ReadLine();
                    if (line2 != null)
                    {
                        String[] arrayCompleto = line2.Split('|');
                        //Eliminar el ultimo elemento, que es un string vacio
                        String[] segmentValue = arrayCompleto.Skip(0).Take(arrayCompleto.Length - 1).ToArray();
                        matrix[indexMatrix] = segmentValue;
                        indexMatrix++;
                    }
                }
                srGuardar.Close();

                EDIEntities db;
                db = new EDIEntities();
                String lastCodeOrder = "";
                Orders lastOrder = new Orders();
                int lastOrdersDetailId = 0;
                OrdersDetail lastOrdersDetail = new OrdersDetail();
                String codePriority = "";
                OrderInfo lastOrderInfo = new OrderInfo();

                foreach (var array in matrix)
                {
                    switch (array[0])
                    {
                        case "ORD":
                            codePriority = array[2];
                            Priority priority = db.Priority.FirstOrDefault(p => p.CodePriority == codePriority);
                            Orders order = new Orders
                            {
                                codeOrder = array[1],
                                Priority = priority
                            };
                            lastCodeOrder = array[1];
                            lastOrder = order;

                            break;
                        case "DTM":
                            //Convertir a formato fecha
                            String fecha = array[1];
                            DateTime dateTime = DateTime.ParseExact(fecha, "yyyyMMdd", null);
                            lastOrder.dateOrder = dateTime;
                            break;
                        case "NADMS":
                            String codeAgency = array[2];
                            Agencies agency = db.Agencies.FirstOrDefault(a => a.CodeAgency == codeAgency);
                            String codeOperationalArea = array[1];
                            OperationalAreas operationalArea = db.OperationalAreas.FirstOrDefault(o => o.CodeOperationalArea == codeOperationalArea);
                            OrderInfo orderInfo = new OrderInfo
                            {
                                Agencies = agency,
                                OperationalAreas = operationalArea
                            };
                            lastOrderInfo = orderInfo;
                            break;
                        case "NADMR":
                            String codeFactory = array[1];
                            Factories factory = db.Factories.FirstOrDefault(f => f.codeFactory == codeFactory);
                            lastOrder.Factories = factory;
                            //Ya tenemos el ultimo elemento necesario, añadimos Orders
                            db.Orders.Add(lastOrder);

                            lastOrderInfo.idOrder = lastOrder.idOrder;
                            //Ya tenemos el ultimo elemento necesario, añadimos OrderInfo
                            db.OrderInfo.Add(lastOrderInfo);

                            db.SaveChanges();
                            break;
                        case "LIN":
                            lastOrder = db.Orders.FirstOrDefault(o => o.codeOrder == lastCodeOrder);
                            String codePlanet = array[1];
                            Planets planet = db.Planets.FirstOrDefault(p => p.CodePlanet == codePlanet);
                            String codeReference = array[2];
                            References reference = db.References.FirstOrDefault(r => r.codeReference == codeReference);
                            OrdersDetail ordersDetail = new OrdersDetail
                            {
                                Orders = lastOrder,
                                Planets = planet,
                                References = reference
                            };
                            //db.OrdersDetail.Add(ordersDetail);
                            lastOrdersDetail = ordersDetail;
                            lastOrdersDetailId = ordersDetail.idOrderDetail;
                            //db.SaveChanges();
                            break;
                        case "QTYLIN":
                            //lastOrdersDetail = db.OrdersDetail.FirstOrDefault(o => o.idOrderDetail == lastOrdersDetailId);
                            int cantidad = Convert.ToInt16(array[2]);
                            if (array[1] == "61")
                            {
                                cantidad *= -1;
                            }
                            lastOrdersDetail.Quantity = (short)cantidad;
                            //db.SaveChanges();
                            break;
                        case "DTMLIN":
                            String fechaDelivery = array[1];
                            DateTime dateTimeDelivery = DateTime.ParseExact(fechaDelivery, "yyyyMMdd", null);
                            lastOrdersDetail.DeliveryDate = dateTimeDelivery;
                            db.OrdersDetail.Add(lastOrdersDetail);
                            db.SaveChanges();
                            break;
                        default:
                            Console.WriteLine("Default case");
                            break;
                    }
                }

                MessageBox.Show("EDI File Processed!");

            }
        }
    }
}
