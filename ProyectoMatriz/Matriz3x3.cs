using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMatriz
{
    public class Matriz3x3 : Matriz
    {
        //Atributos unicos de la clase
        private double[,] matriz3x3 = new double[3, 3];
        private double[,] matriz3x3Inversa = new double[3, 3];

        //Constructor
        public Matriz3x3(int pTamanoMatriz) : base(pTamanoMatriz) { }

        //Metodos
        public double CalculoDeterminante()
        {
            double Det = +matriz3x3[0, 0] * ((matriz3x3[1, 1] * matriz3x3[2, 2]) - (matriz3x3[1, 2] * matriz3x3[2, 1])) - matriz3x3[0, 1] * ((matriz3x3[1, 0] * matriz3x3[2, 2]) - (matriz3x3[1, 2] * matriz3x3[2, 0])) + matriz3x3[0, 2] * ((matriz3x3[1, 0] * matriz3x3[2, 1]) - (matriz3x3[1, 1] * matriz3x3[2, 0]));
            return Det;
        }

        //Preguntar al usuario si la matriz ingresada por el mismo es la misma que se muestra en pantalla
        public void VerificarMatriz()
        {
            Console.Clear();
            Console.WriteLine("╔═══════════•° Es esta su matriz? °•════════════╗\n");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("  [ " + matriz3x3[i, 0] + "  ,  " + matriz3x3[i, 1] + "  ,  " + matriz3x3[i, 2] + " ]");
            }
        }

        //Se piden los valores de la matriz correspondientes a sus posiciones
        public void PedirMatriz()
        {
            Console.Clear();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Ingrese sus datos en sus respectivas posiciones\n");
                        Console.WriteLine("[1,1] , [1,2] , [1,3]");
                        Console.WriteLine("[2,1] , [2,2] , [2,3]");
                        Console.WriteLine("[3,1] , [3,2] , [3,3] \n");

                        Console.Write($"[{i + 1}, {j + 1}] : ");
                        matriz3x3[i, j] = Convert.ToDouble(Console.ReadLine());
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

        //Este metodo agrega la determinante de la matriz a la clase principal
        public override void AnadirDeterminante(double pDeterminante)
        {
            base.AnadirDeterminante(pDeterminante);
        }

        //Se calcular la adjunta de una matriz, al no tener un patron especifico y facil de implementar, me toco hacerlo manualmente
        public void CalculoAdjunta()
        {
            double[,] MatrizAdjunta = new double[3, 3];
            MatrizAdjunta[0, 0] = +((matriz3x3[1, 1] * matriz3x3[2, 2]) - (matriz3x3[1, 2] * matriz3x3[2, 1]));
            MatrizAdjunta[0, 1] = -((matriz3x3[1, 0] * matriz3x3[2, 2]) - (matriz3x3[1, 2] * matriz3x3[2, 0]));
            MatrizAdjunta[0, 2] = +((matriz3x3[1, 0] * matriz3x3[2, 1]) - (matriz3x3[1, 1] * matriz3x3[2, 0]));

            MatrizAdjunta[1, 0] = -((matriz3x3[0, 1] * matriz3x3[2, 2]) - (matriz3x3[0, 2] * matriz3x3[2, 1]));
            MatrizAdjunta[1, 1] = +((matriz3x3[0, 0] * matriz3x3[2, 2]) - (matriz3x3[0, 2] * matriz3x3[2, 0]));
            MatrizAdjunta[1, 2] = -((matriz3x3[0, 0] * matriz3x3[2, 1]) - (matriz3x3[0, 1] * matriz3x3[2, 0]));

            MatrizAdjunta[2, 0] = +((matriz3x3[0, 1] * matriz3x3[1, 2]) - (matriz3x3[0, 2] * matriz3x3[1, 1]));
            MatrizAdjunta[2, 1] = -((matriz3x3[0, 0] * matriz3x3[1, 2]) - (matriz3x3[0, 2] * matriz3x3[1, 0]));
            MatrizAdjunta[2, 2] = +((matriz3x3[0, 0] * matriz3x3[1, 1]) - (matriz3x3[0, 1] * matriz3x3[1, 0]));

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz3x3[i, j] = MatrizAdjunta[i, j];
                }
            }
        }

        //Este calculo aplica la furmula de multiplicar  1 sobre la determinante por cada elemento de la matriz adjunta
        public void CalculoInversa()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz3x3Inversa[i, j] = (1 / base.Determinante) * (matriz3x3[i, j]);
                }
            }
        }

        //Imprime los datos de la matriz, su determinante, el tamano y la matriz original
        public override void ImprimirMatriz()
        {
            Console.Clear();
            base.ImprimirMatriz();
            Console.WriteLine("\n -------------------------------------------------------------------- ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("  [ " + matriz3x3Inversa[i, 0] + "  ,  " + matriz3x3Inversa[i, 1] + "  ,  " + matriz3x3Inversa[i, 2] + " ]\n");
            }
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════╝");
            Console.ReadKey();
        }
    }
}
