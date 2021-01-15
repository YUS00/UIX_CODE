using System;

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

                Console.WriteLine(sentencia);

                switch (sentencia)
                {
                    case 'd':
                        try
                        {
                            Console.WriteLine("\t");
                            Console.WriteLine("\tIniciando descarga, espere porfavor...");
                            Console.WriteLine("\t");
                            Console.WriteLine("\t" + FTPDownload.FTP_Upload());
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
                            Console.WriteLine("No se ha podido realizar la descarga del archivo. Revise su conexión y servidor al que quiere acceder.");
                            Console.WriteLine("Código de error:");
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
