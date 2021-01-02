using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace G7_EnviarEdi
{
    public partial class EnviarEdi : Form
    {
        public EnviarEdi()
        {
            InitializeComponent();
        }
        
        //Creamos modelo para guardar config de Ftp
        struct FtpSetting
        {
            public string Server { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string FileName { get; set; }
            public string FullName { get; set; }

        }

        FtpSetting _inputParameter;

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //Guardamos en variables las propiedades del modelo FtpSetting
            string fileName = ((FtpSetting)e.Argument).FileName;
            string fullName = ((FtpSetting)e.Argument).FullName;
            string userName = ((FtpSetting)e.Argument).Username;
            string password = ((FtpSetting)e.Argument).Password;
            string server = ((FtpSetting)e.Argument).Server;
            //Ftpwebrequest enables programatically create FTP connections to FTP Servers and transfer files
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(string.Format("{0}/{1}", server, fileName)));
            //Indicamos que queremos hacer un Upload
            request.Method = WebRequestMethods.Ftp.UploadFile;
            //Introducimos user y password
            request.Credentials = new NetworkCredential(userName, password);

            Stream ftpStream = request.GetRequestStream();
            FileStream fs = File.OpenRead(fullName);

            //Recorrer el archivo
            byte[] buffer = new byte[1024];
            double total = (double)fs.Length;
            int byteRead = 0;
            double read = 0;
            do
            {
                if(!backgroundWorker.CancellationPending)
                {
                    byteRead = fs.Read(buffer, 0, 1024);
                    ftpStream.Write(buffer, 0, byteRead);
                    read = (double)byteRead;
                    double percentage = read / total * 100;
                    backgroundWorker.ReportProgress((int)percentage);
                }
            } while (byteRead != 0);
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Text = $"Uploaded {e.ProgressPercentage} %";
            progressBar.Value = e.ProgressPercentage;
            progressBar.Update();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStatus.Text = "Upload complete!";
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, ValidateNames = true, Filter = "All files|*.*" })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(ofd.FileName);
                    _inputParameter.Username = lblUsername.Text;
                    _inputParameter.Password = lblPassword.Text;
                    _inputParameter.Server = lblServer.Text;
                    _inputParameter.FileName = fi.Name;
                    _inputParameter.FullName = fi.FullName;
                }
            }
        }
    }
}
