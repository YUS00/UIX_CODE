using FluentFTP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DescargarEdi
{
    public partial class InterfazDescarga : Libreria_BaseForms.BaseFormVentana
    {
        public InterfazDescarga()
        {
            InitializeComponent();
        }

        FtpClient ftp = new FtpClient("localhost", new System.Net.NetworkCredential { UserName = "admin", Password = "mrrobot1234" });

        FtpListItem[] listing;

        private async void processEdiFiles()
        {
            



            

            foreach (FtpListItem ftpItem in listing)
            {
                if (ftpItem.Name.ToLower() != txbSelectedFile.Text.ToLower())
                {
                    continue;
                } else
                {
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        await ftp.DownloadAsync(memoryStream, ftpItem.Name);

                        memoryStream.Position = 0;

                        using (StreamReader streamReader = new StreamReader(memoryStream))
                        {
                            string fileContents = await streamReader.ReadToEndAsync();



                            //Procesar el EDI
                        }

                        await ftp.MoveFileAsync(ftpItem.Name, Path.Combine("Tractats", ftpItem.Name));
                        

                    }
                }

                
            }

            dtgFiles.Refresh();
        }

        private async void refresh()
        {
            listing = await ftp.GetListingAsync();
            dtgFiles.DataSource = listing;

            txbSelectedFile.DataBindings.Clear();
            txbSelectedFile.DataBindings.Add("Text", listing, "Name");
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            processEdiFiles();
            MessageBox.Show("File Downloaded!");
        }

        private async void InterfazDescarga_Load(object sender, EventArgs e)
        {
            listing = await ftp.GetListingAsync();
            dtgFiles.DataSource = listing;

            txbSelectedFile.DataBindings.Clear();
            txbSelectedFile.DataBindings.Add("Text", listing, "Name");
        }
    }
}
