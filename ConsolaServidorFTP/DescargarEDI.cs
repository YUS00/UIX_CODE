using System.IO;
using System.Net;

namespace ConsolaServidorFTP
{
    public class DescargarEDI
    {

        //Variable global que contiene el nombre del archivo que queremos descargar
        //string nombre_archivo_local = "RARROrderSample.edi";

        //string URL = "ftp://192.168.10.1/";
        //string FTPLogin = "g7";
        //string FTPPassword = "12345aA";

        string nombre_archivo_local = "RARROrderSample.edi";

        string URL = "ftp://127.0.0.1/";
        string FTPLogin = "admin";
        string FTPPassword = "mrrobot1234";


        internal FtpWebResponse FTP_Download()

        {

            //Iniciar petición hacia el servidor FTP
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(URL + nombre_archivo_local);
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            //Credenciales para la conexion al servidor FTP
            request.Credentials = new NetworkCredential(FTPLogin, FTPPassword);

            //Iniciar la petición de respuesta del FTP
            FtpWebResponse download_response = (FtpWebResponse)request.GetResponse();

            return download_response;
        }


        internal void FTP_File(string path, FtpWebResponse download_response)
        {
            //String vacío que contendrá la información del archivo del servidor FTP
            string result = string.Empty;

            //Readers
            Stream responseStream = download_response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            //Transferir el reader a la variable "result" anteriormente vacía
            result = reader.ReadToEnd();

            using (StreamWriter file = File.CreateText(path + "/" + nombre_archivo_local))
            {
                file.WriteLine(result);
                file.Close();
            }

            reader.Close();

            download_response.Close();
        }


        internal void FTP_MoveFile()
        {

            //Iniciar petición hacia el servidor FTP
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(URL + nombre_archivo_local);

            //Credenciales para la conexion al servidor FTP
            request.Credentials = new NetworkCredential(FTPLogin, FTPPassword);

            //
            request.UseBinary = true;
            request.Method = WebRequestMethods.Ftp.Rename;
            request.RenameTo = "Tractats" + "/" + nombre_archivo_local;

            FtpWebResponse back = (FtpWebResponse)request.GetResponse();

            //bool Success = back.StatusCode == FtpStatusCode.CommandOK || back.StatusCode == FtpStatusCode.FileActionOK;
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
