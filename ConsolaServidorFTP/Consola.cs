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
            string ExitToMenu_path = "EXIT";

            Boolean ExitToMenu = true; //En caso de querer volvér al menú.

            FtpWebResponse response;

            DescargarEDI FTPDownload = new DescargarEDI();

            do
            {
                Console.Clear();
                Console.WriteLine("|*************************************************************************************************************|");
                Console.WriteLine("\t| Extracción de archivos EDI |");
                Console.WriteLine("|*************************************************************************************************************|");
                Console.WriteLine("\t");
                Console.WriteLine("\tBienvenido/a a la consola de descárga de archivos EDI.");
                Console.WriteLine("\t");
                Console.WriteLine("\tDesde aquí, podra importar sus archivos desde cualquier servidor FTP que se encuentre registrado en la red.");
                Console.WriteLine("\t");
                Console.WriteLine("\t");
                Console.WriteLine("\tUtilize las opciones inferiores para acceder o abandonar esta consola:");
                Console.WriteLine("\t");
                Console.WriteLine("\t---------------------");
                Console.WriteLine("\tOPCIONES:\n" + "\td-: Descargar\n" + "\ts-: Salir");
                Console.WriteLine("\t---------------------");
                Console.WriteLine("\t");
                Console.WriteLine("|*************************************************************************************************************|");
                Console.WriteLine("\t");
                Console.Write("\tSeleccione la opción: ");

                sentencia = Console.ReadKey(true).KeyChar;

                ExitToMenu = false;

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
                                Console.WriteLine("\t");
                                Console.WriteLine("|*************************************************************************************************************|");
                                Console.WriteLine("\t");
                                Console.WriteLine("\tPorfavor, seleccione la ubicación donde desee guardar el archivo correspondiente.");
                                Console.WriteLine("\t");
                                Console.WriteLine("\tPara ello, escriba la ubicación utilizando los símbolos de barra lateral '/' para separar los directorios.");
                                Console.WriteLine("\tPuede utilizar el ejemplo como módo de ayuda.");
                                Console.WriteLine("\t");
                                Console.WriteLine("\tEj. : Unidad/directorio_de_ejemplo");
                                Console.WriteLine("\t");
                                Console.WriteLine("\tEscriba 'EXIT' para volver al menú de opciones.");
                                Console.WriteLine("\t");
                                Console.Write("\tIntroduzca la ubicación: ");

                                path = Console.ReadLine();

                                Console.WriteLine("\t");

                                ExitToMenu = path == ExitToMenu_path; //Comprueba si el usuario desea volver al menú

                                error_ubicacion = false;

                                if (path == string.Empty)
                                {
                                    error_ubicacion = true;
                                }
                                
                                else
                                {
                                    try
                                    {
                                        FTPDownload.FTP_Upload(path, response);
                                    }

                                    catch (Exception error)
                                    {
                                        error_ubicacion = true;

                                        Console.WriteLine("\t");
                                        Console.WriteLine("\t");
                                        Console.WriteLine("|*************************************************************************************************************|");
                                        Console.WriteLine("\t");
                                        Console.WriteLine("\tError de ubicación:");
                                        Console.WriteLine("\t");
                                        Console.WriteLine("\tNo se ha podido encontrar esa dirección. Porfavor, revise su ubicación y vuelva a intentarlo.");
                                        Console.WriteLine("\t");
                                        Console.WriteLine("\tCódigo de error:");
                                        Console.WriteLine("\t");
                                        Console.WriteLine(error.ToString() + ".");
                                        Console.WriteLine("\t");
                                    }

                                    if (error_ubicacion)
                                    {
                                        response = FTPDownload.FTP_Connect();
                                    }
                                }

                            } while (error_ubicacion && !ExitToMenu);

                            if (!error_ubicacion)
                            {
                                Console.WriteLine("\t");
                                Console.WriteLine("\tIniciando descarga, espere porfavor...");
                                Console.WriteLine("\t");

                                Console.WriteLine("|*************************************************************************************************************|");
                                Console.WriteLine("\t");
                                Console.WriteLine("\tDescarga realizada con éxito!");
                            }


                        }


                        catch (Exception error)
                        {
                            Console.WriteLine("\t");
                            Console.WriteLine("\t");
                            Console.WriteLine("|*************************************************************************************************************|");
                            Console.WriteLine("\t");
                            Console.WriteLine("\tError de descarga:");
                            Console.WriteLine("\t");
                            Console.WriteLine("\tNo se ha podido realizar la descarga del archivo. Revise su conexión y servidor al que quiere acceder.");
                            Console.WriteLine("\t");
                            Console.WriteLine("\tCódigo de error:");
                            Console.WriteLine("\t");
                            Console.WriteLine(error.ToString() + ".");

                        }

                        if (!ExitToMenu)
                        {
                            Console.WriteLine("\t");
                            Console.WriteLine("|*************************************************************************************************************|");
                            Console.WriteLine("\t");
                            Console.WriteLine("Presione ENTER para volver.");
                            Console.WriteLine("\t");
                            Console.ReadLine();
                        }

                        break;

                }

                ExitToMenu = true; //Se cambia el booleano para repetir el bucle y volver al menú.

            } while (sentencia != 's' && ExitToMenu);


        }




    }
}
