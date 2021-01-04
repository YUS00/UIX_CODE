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
    public partial class InterfazDescarga : Form
    {
        public InterfazDescarga()
        {
            InitializeComponent();
        }

        private async void processEdiFiles()
        {
            FtpClient ftp = new FtpClient("localhost", new System.Net.NetworkCredential { UserName = "admin", Password = "mrrobot1234" });

            FtpListItem[] listing = await ftp.GetListingAsync();

            foreach (FtpListItem ftpItem in listing)
            {
                if (ftpItem.Type != FtpFileSystemObjectType.File)
                {
                    continue;
                }

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

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            processEdiFiles();
        }
    }
}
