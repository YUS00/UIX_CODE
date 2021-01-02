using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;

namespace G7_EnviarEdi
{
    public partial class EnviarEdi : Form
    {
        public EnviarEdi()
        {
            InitializeComponent();
            lblStatus.Text = @"Uploaded 0%";
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
            MessageBox.Show("Upload Complete!");
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "All Files|*.*" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fi = new FileInfo(ofd.FileName);
                    Username = txtUsername.Text;
                    Password = txtPassword.Text;
                    Server = txtServer.Text;
                    Filename = fi.Name;
                    Fullname = fi.FullName;
                }
            }

            //Start the Background and wait a little to start it.
            Thread.Sleep(1000);
            backgroundWorker.RunWorkerAsync();  //the most important command to start the background worker
            Thread.Sleep(1000);

        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //Upload Method.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(string.Format("{0}/{1}", Server, Filename)));
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(Username, Password);
            Stream ftpstream = request.GetRequestStream();
            FileStream fs = File.OpenRead(Fullname);

            // Method to calculate and show the progress.
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
