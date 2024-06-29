using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Salir = false;
            double Determinante;
            Matriz3x3 matriz3 = new Matriz3x3(3);
            Matriz2x2 matriz2 = new Matriz2x2(2);
            do
            {
                try
                {
                    bool Si = false;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n  ██████╗ ██████╗ ███╗   ██╗██╗   ██╗███████╗██████╗ ████████╗ ██████╗ ██████╗ ");
                    Console.WriteLine(" ██╔════╝██╔═══██╗████╗  ██║██║   ██║██╔════╝██╔══██╗╚══██╔══╝██╔═══██╗██╔══██╗  ");
                    Console.WriteLine(" ██║     ██║   ██║██╔██╗ ██║██║   ██║█████╗  ██████╔╝   ██║   ██║   ██║██████╔╝  ");
                    Console.WriteLine(" ██║     ██║   ██║██║╚██╗██║╚██╗ ██╔╝██╔══╝  ██╔══██╗   ██║   ██║   ██║██╔══██╗  ");
                    Console.WriteLine(" ╚██████╗╚██████╔╝██║ ╚████║ ╚████╔╝ ███████╗██║  ██║   ██║   ╚██████╔╝██║  ██║  ");
                    Console.WriteLine("  ╚═════╝ ╚═════╝ ╚═╝  ╚═══╝  ╚═══╝  ╚══════╝╚═╝  ╚═╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝  ");
                    Console.WriteLine("                          ┌┬┐┌─┐┌┬┐┬─┐┬┌─┐┌─┐┌─┐");
                    Console.WriteLine("                          │││├─┤ │ ├┬┘││  ├┤ └─┐");
                    Console.WriteLine("                          ┴ ┴┴ ┴ ┴ ┴└─┴└─┘└─┘└─┘\n");
                    Console.WriteLine("\n                         ♥♥||Elija una opcion||♥♥");
                    Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■\n                                By Nate :p");
                    Console.WriteLine(" _____________________________________________________________________________\n");
                    Console.WriteLine(" ► 1.  -   Matriz [3x3]");
                    Console.WriteLine(" ► 2.  -   Matrix [2x2]");
                    Console.WriteLine(" -----------------------------------------------------------------------------\n");
                    Console.WriteLine(" ► 3.  -   Salir");
                    Console.WriteLine("\n■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                    Console.WriteLine(" >Ingresa una opcion<");
                    int OpcionPrimerMenu = Convert.ToInt16(Console.ReadLine());

                    switch (OpcionPrimerMenu)
                    {
                        case 1:
                            while (!Si)
                            {
                                //Caso de matriz 3x3
                                //Se piden los valores de la matriz 
                                matriz3.PedirMatriz();

                                //Se llama al metodo para calcular la determinante y se guarda su valor en una nueva variable
                                Determinante = matriz3.CalculoDeterminante();
                                matriz3.AnadirDeterminante(Determinante);

                                //Se presenta la matriz ingresada y se ofrecen opciones por si esta es incorrecta
                                matriz3.VerificarMatriz();
                                Console.WriteLine("\n ---------------------------------------------- ");
                                Console.WriteLine("\n  ► 1.  -      Si       ");
                                Console.WriteLine("  ► 2.  -      No       \n");
                                Console.WriteLine("  ► 3.  -      Volver     \n");
                                Console.WriteLine("╚══════════════════════════════════════════════╝");
                                int Opcion1 = Convert.ToInt32(Console.ReadLine());

                                if (Opcion1 == 1)
                                {
                                    if (Determinante == 0)
                                    {
                                        //En caso que el determinante de una matriz resulte 0, la matriz no tendra inversa
                                        Console.Clear();
                                        Console.WriteLine("La determinante resulto 0, por lo tanto, la matriz ingresada no tiene inversa\n");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("\nClick para volver al menu principal!");
                                        Console.ReadKey();
                                        Si = true;
                                    }
                                    else
                                    {
                                        matriz3.CalculoAdjunta();
                                        matriz3.CalculoInversa();
                                        matriz3.ImprimirMatriz();
                                        Si = true;
                                    }

                                }
                                else if (Opcion1 == 2)
                                {
                                    Console.Clear();
                                }
                                else if(Opcion1 == 3)
                                {
                                    Si = true;
                                }
                                else
                                {
                                    MensajeError();
                                }
                            }
                            break;
                        case 2:
                            while (!Si)
                            {
                                matriz2.PedirMatriz();
                                Determinante = matriz2.CalcularDeterminante();
                                matriz2.AnadirDeterminante(Determinante);

                                matriz2.VerificarMatriz();
                                Console.WriteLine("\n ---------------------------------------------- ");
                                Console.WriteLine("\n  ► 1.  -      Si       ");
                                Console.WriteLine("  ► 2.  -      No       \n");
                                Console.WriteLine("  ► 3.  -      Volver     \n");
                                Console.WriteLine("╚══════════════════════════════════════════════╝");
                                int Opcion1 = Convert.ToInt32(Console.ReadLine());

                                if (Opcion1 == 1)
                                {
                                    if (Determinante == 0)
                                    {
                                        //En caso que el determinante de una matriz resulte 0, la matriz no tendra inversa
                                        Console.Clear();
                                        Console.WriteLine("La determinante resulto 0, por lo tanto, la matriz ingresada no tiene inversa\n");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                                        Console.WriteLine("\nClick para volver al menu principal!");
                                        Console.ReadKey();
                                        Si = true;
                                    }
                                    else
                                    {
                                        matriz2.CalculoAdjunta();
                                        matriz2.CalculoInversa();
                                        matriz2.ImprimirMatriz();
                                        Si = true;
                                    }
                                }
                                else if (Opcion1 == 2)
                                {
                                    Console.Clear();
                                }
                                else if (Opcion1 == 3)
                                {
                                    Si = true;
                                }
                                else
                                {
                                    MensajeError();
                                }
                            }
                            break;
                        case 3:
                            Console.Clear();
                            Salir = true;
                            break;
                        default:
                            MensajeError();
                            break;
                    }
                }
                catch (FormatException)
                {
                    MensajeError();
                }
                catch (OverflowException)
                {
                    MensajeError();
                }

            } while (!Salir);
        }

        //Metodo para los mensajes cada que se detecte un error
        static void MensajeError()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Error! Opcion invalida");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.ReadKey();
        }
    }
}
