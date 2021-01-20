using System.IO;
using System.Net;

namespace ConsolaServidorFTP
{
    class DescargarEDI
    {

        //Variable global que contiene el nombre del archivo que queremos descargar
        string nombre_archivo_local = "RARROrderSample.edi";

        internal FtpWebResponse FTP_Connect()

        {

            //string result = string.Empty;

            string URL = "ftp://192.168.10.1/";
            string FTPLogin = "g7";
            string FTPPassword = "12345aA";


            //Iniciar petición hacia el servidor FTP
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(URL + nombre_archivo_local);
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            //Credenciales para la conexion al servidor FTP
            request.Credentials = new NetworkCredential(FTPLogin, FTPPassword);

            //Iniciar la petición de respuesta del FTP
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            return response;

        }


        internal void FTP_Upload(string path, FtpWebResponse response)
        {
            //String vacío que contendrá la información del archivo del servidor FTP
            string result = string.Empty;

            //Readers
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            //Transferir el reader a la variable "result" anteriormente vacía
            result = reader.ReadToEnd();

            using (StreamWriter file = File.CreateText(path + "/" + nombre_archivo_local))
            {
                file.WriteLine(result);
                file.Close();
            }

            reader.Close();

            response.Close();

        }







        //internal void File_location(string file, string path)
        //{

        //    string path;

        //    path = @"D:\test\";
        //    path = path + file;


        //    SaveFileDialog file_dialog = new SaveFileDialog();

        //    file_dialog.Filter = "EDI(*.EDI)|*.edi";

        //    file.

        //    //path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, file);
        //    //FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.Append, System.IO.FileAccess.Write);



        //}



    }




}
