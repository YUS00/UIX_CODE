using System.Net;
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


            string URL = "http://192.168.10.1:10000";
            string FTPLogin = "";
            string FTPPassword = "";
            string nombre_archivo_local = "states.txt";


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
