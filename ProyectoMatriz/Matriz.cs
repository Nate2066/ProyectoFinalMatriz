using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMatriz
{
    public class Matriz
    {
        protected double Determinante;
        private int TamanoMatriz;

        public Matriz(int pTamanoMatriz)
        {
            TamanoMatriz = pTamanoMatriz;
        }

        public virtual void AnadirDeterminante(double pDeterminante)
        {
            Determinante = pDeterminante;
        }
        //Metodo para mostrar info
        public virtual void ImprimirMatriz()
        {
            Console.WriteLine("╔═════════════════════•° Informacion de matriz °•══════════════════════╗\n");
            Console.WriteLine("                               [" + TamanoMatriz + ", " + TamanoMatriz + "]\n");
            Console.WriteLine(" .Determinante.    →    " + Determinante + "\n");
        }
    }
}
