using System.IO;
using System.Net;

namespace ConsolaServidorFTP
{
    class DescargarEDI
    {

        //private void FTP_File()
        //{

        //    string richfile;
        //    string file = string.Empty;

        //    richfile = FTP_Upload(file);

        //}


        internal string FTP_Upload()

        {

            string result = string.Empty;


            string URL = "ftp://192.168.10.1/";
            string FTPLogin = "g7";
            string FTPPassword = "12345aA";
            string nombre_archivo_local = "RARROrderSample.edi";


            //Iniciar petición hacia el servidor FTP
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(URL + nombre_archivo_local);
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            //Credenciales para la conexion al servidor FTP
            request.Credentials = new NetworkCredential(FTPLogin, FTPPassword);

            //Iniciar la petición de respuesta del FTP
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            //Readers
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            //Transferir el reader a la variable "result"
            result = reader.ReadToEnd();

            using (StreamWriter file = File.CreateText(nombre_archivo_local))
            {
                file.WriteLine(result);
                file.Close();
            }

            reader.Close();

            response.Close();

            return result;
        }



    }




}
