using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace G7_Orders
{
    public partial class InterfazEDI : Libreria_BaseForms.BaseForms
    {
        public InterfazEDI()
        {
            InitializeComponent();
        }

        OpenFileDialog openFile = new OpenFileDialog();
        string line = "";

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if(openFile.ShowDialog() == DialogResult.OK)
            {
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


            }
        }
    }
}
