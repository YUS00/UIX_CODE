using System;
using System.Net;

namespace ConsolaServidorFTP
{
    class Consola
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {

            char sentencia;
            string path;

            FtpWebResponse response;

            DescargarEDI FTPDownload = new DescargarEDI();

            do
            {
                Console.Clear();
                Console.WriteLine("********************************************");
                Console.WriteLine("\tExtracción de archivos EDI");
                Console.WriteLine("********************************************");
                Console.WriteLine("\t");
                Console.WriteLine("\tOPCIONES:");
                Console.WriteLine("\t d-: Descargar");
                Console.WriteLine("\t s-: Salir");
                Console.WriteLine("\t");
                Console.WriteLine("********************************************");
                Console.WriteLine("\t");
                Console.Write("\tSeleccione la opción: ");

                sentencia = Console.ReadKey(true).KeyChar;

                Boolean error_ubicacion;

                Console.WriteLine(sentencia);

                switch (sentencia)
                {
                    case 'd':

                        Console.WriteLine("\t");
                        Console.WriteLine("\tIniciando conexión. Espere porfavor...");
                        Console.WriteLine("\t");

                        try
                        {
                            response = FTPDownload.FTP_Connect();

                            Console.WriteLine("\t");
                            Console.WriteLine("\tConexión establecida con éxito.");
                            Console.WriteLine("\t");

                            do
                            {

                                Console.WriteLine("********************************************");
                                Console.WriteLine("\t");
                                Console.WriteLine("\tPorfavor, seleccione la ubicación donde desee guardar el archivo correspondiente.");
                                Console.WriteLine("\t");
                                Console.WriteLine("\tPara ello, escriba la ubicación donde quiera ubicarlo.");
                                Console.WriteLine("\t");
                                Console.WriteLine("\tEj. : Unidad/directorio_de_ejemplo");


                                Console.WriteLine("\t");
                                Console.WriteLine("\t");
                                Console.Write("\tIntroduzca la ubicación: ");

                                path = Console.ReadLine();

                                error_ubicacion = false;

                                try
                                {
                                    FTPDownload.FTP_Upload(path, response);

                                }
                                catch (Exception error)
                                {
                                    error_ubicacion = true;

                                    Console.WriteLine("\t");
                                    Console.WriteLine("\t");
                                    Console.WriteLine("********************************************");
                                    Console.WriteLine("\tError de ubicación:");
                                    Console.WriteLine("\t");
                                    Console.WriteLine("\tNo se ha podido encontrar esa dirección. Porfavor, revise su ubicación y vuelva a intentarlo.");
                                    Console.WriteLine("\t");
                                    Console.WriteLine("\tCódigo de error:");
                                    Console.WriteLine("\t");
                                    Console.WriteLine(error.ToString() + ".");
                                    Console.WriteLine("\t");
                                }

                            } while (error_ubicacion);



                            Console.WriteLine("\t");
                            Console.WriteLine("\tIniciando descarga, espere porfavor...");
                            Console.WriteLine("\t");

                            Console.WriteLine("********************************************");
                            Console.WriteLine("\t");
                            Console.WriteLine("\tDescarga realizada con éxito!");

                        }

                        catch (Exception error)
                        {
                            Console.WriteLine("\t");
                            Console.WriteLine("\t");
                            Console.WriteLine("********************************************");
                            Console.WriteLine("\tError de descarga:");
                            Console.WriteLine("\t");
                            Console.WriteLine("\tNo se ha podido realizar la descarga del archivo. Revise su conexión y servidor al que quiere acceder.");
                            Console.WriteLine("\t");
                            Console.WriteLine("\tCódigo de error:");
                            Console.WriteLine("\t");
                            Console.WriteLine(error.ToString() + ".");

                        }

                        Console.WriteLine("\t");
                        Console.WriteLine("********************************************");
                        Console.WriteLine("\t");
                        Console.WriteLine("Presione ENTER para volver.");
                        Console.ReadLine();

                        break;
                }
            } while (sentencia != 's');


        }




    }
}
