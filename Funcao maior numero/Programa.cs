using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite 3 numeros: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int maior = Comparar(a, b, c);
            MostrarResultado(maior);

            Console.ReadLine();
        }


        static int Comparar(int x, int y, int z)
        {
            int maior;

            if (x > y && x > z)
            {
                maior = x;
            }
            else if (y > z)
            {
                maior = y;
            }
            else
            {
                maior = z;
            }
            return maior;
         }

        static void MostrarResultado(int valor)
        {
            Console.WriteLine("Maior numero = " + valor);
        }


        
    }
}
