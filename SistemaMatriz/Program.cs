using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MatrizDeInteiros mat = new MatrizDeInteiros(5,5);
            Console.WriteLine(mat.Inserir(2,4,10));

            if (mat.eQuadrada())
            {
                Console.WriteLine("É quadrada!");
            }
            else
            {
                Console.WriteLine("Não é quadrada!");
            }

            Console.WriteLine(mat.Total());
            Console.WriteLine(mat.MostrarNumero(10));
            Console.ReadKey();
        }
    }
}
