using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;

namespace G7_EnviarEdi
{
    public partial class EnviarEdi : Libreria_BaseForms.BaseFormVentana
    {
        public EnviarEdi()
        {
            InitializeComponent();
            lblStatus.Text = @"Uploaded 0%";
        }
        
       
        public string Username;
        public string Filename;
        public string Fullname;
        public string Server;
        public string Password;

        

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Text = $"Uploaded {e.ProgressPercentage}%";
            lblStatus.Update();
            progressBar.Value = e.ProgressPercentage;
            progressBar.Update();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblStatus.Text = "Upload Completed!";
            MessageBox.Show("Upload Completed!");
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //Abrir dialogo para seleccionar el archivo
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "EDI Files (*.edi)|*.edi" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(ofd.FileName);
                    Username = txtUsername.Text;
                    Password = txtPassword.Text;
                    Server = txtServer.Text;
                    Filename = fi.Name;
                    Fullname = fi.FullName;

                    backgroundWorker.RunWorkerAsync();  //Importante para que empiece el backgroundWorker.DoWork()
                }
            }

            

        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //Upload file
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(string.Format("{0}/{1}", Server, Filename)));
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(Username, Password);
            Stream ftpstream = request.GetRequestStream();
            FileStream fs = File.OpenRead(Fullname);

            //Progreso de la lectura
            byte[] buffer = new byte[1024];
            double total = (double)fs.Length;
            int byteRead = 0;
            double read = 0;

            do
            {
                byteRead = fs.Read(buffer, 0, 1024);
                ftpstream.Write(buffer, 0, byteRead);
                read += (double)byteRead;
                double percentage = read / total * 100;
                backgroundWorker.ReportProgress((int)percentage);
            }
            while (byteRead != 0);
            fs.Close();
            ftpstream.Close();
        }
    }
}
