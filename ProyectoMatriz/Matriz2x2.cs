using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMatriz
{
    public class Matriz2x2 : Matriz
    {
        private double[,] matriz2x2= new double[2, 2];
        private double[,] matriz2x2Inversa = new double[2, 2];

        public Matriz2x2(int pTamanoMatriz) : base(pTamanoMatriz) { }

        public double CalcularDeterminante()
        {
            double Det = ((matriz2x2[0, 0] * matriz2x2[1, 1]) - (matriz2x2[0, 1] * matriz2x2[1, 0]));
            return Det;
        }

        public override void ImprimirMatriz()
        {
            Console.Clear();
            base.ImprimirMatriz();
            Console.WriteLine("\n -------------------------------------------------------------------- ");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("  [ " + matriz2x2Inversa[i, 0] + "  ,  " + matriz2x2Inversa[i, 1] + " ]\n");
            }
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════╝");
            Console.ReadKey();
        }

        public void VerificarMatriz()
        {
            Console.Clear();
            Console.WriteLine("╔═══════════•° Es esta su matriz? °•════════════╗\n");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("  [ " + matriz2x2[i, 0] + "  ,  " + matriz2x2[i, 1] + " ]");
            }
        }
        public void CalculoInversa()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matriz2x2Inversa[i, j] = (1 / base.Determinante) * (matriz2x2[i, j]);
                }
            }
        }
        public override void AnadirDeterminante(double pDeterminante)
        {
            base.AnadirDeterminante(pDeterminante);
        }

        public void CalculoAdjunta()
        {
            double[,] matrizCopia = new double[2, 2];
            matrizCopia[0, 0] = matriz2x2[1, 1];
            matrizCopia[1, 1] = matriz2x2[0, 0];
            if (matriz2x2[0, 1] < 0)
            {
                matrizCopia[0, 1] = matriz2x2[0, 1] + (matriz2x2[0, 1] * -2);
            }
            else if (matriz2x2[0, 1] > 0)
            {
                matrizCopia[0, 1] = matriz2x2[0, 1] - (matriz2x2[0, 1] * 2);
            }
            else { }

            if (matriz2x2[1, 0] < 0)
            {
                matrizCopia[1, 0] = matriz2x2[1, 0] + (matriz2x2[1, 0] * -2);
            }
            else if (matriz2x2[1, 0] > 0)
            {
                matrizCopia[1, 0] = matriz2x2[1, 0] - (matriz2x2[1, 0] * 2);
            }
            else { }

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    matriz2x2[i, j] = matrizCopia[i, j];
                }
            }
        }
        public void PedirMatriz()
        {
            Console.Clear();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Ingrese sus datos en sus respectivas posiciones\n");
                        Console.WriteLine("[1,1] , [1,2]");
                        Console.WriteLine("[2,1] , [2,2]\n");

                        Console.Write($"[{i + 1}, {j + 1}] : ");
                        matriz2x2[i, j] = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();


                    }
                    catch (FormatException)
                    {
                        //-1 solo a J ya que el TryCatch esta ocurriendo dentro del segundo for, ergo no puede afectar al primero
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Error! Solo numeros");
                        Console.ReadKey();
                        Console.Clear();
                        j = j - 1;
                    }

                }
            }
        }
    }
}
